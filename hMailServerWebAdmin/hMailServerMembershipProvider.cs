using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Configuration.Provider;
using System.Diagnostics;

namespace hMailServerWebAdmin
{
    public sealed class hMailServerMembershipProvider : MembershipProvider
    {


        //
        // Global connection string, generated password length, generic exception message, event log info.
        //

        private int newPasswordLength = 8;
        private string exceptionMessage = "An exception occurred. Please check the Event Log.";

        //
        // System.Configuration.Provider.ProviderBase.Initialize Method
        //

        public override void Initialize(string name, NameValueCollection config)
        {
            //
            // Initialize values from web.config.
            //

            if (config == null)
                throw new ArgumentNullException("config");

            if (name == null || name.Length == 0)
                name = "hMailServerMembershipProvider";

            if (String.IsNullOrEmpty(config["description"]))
            {
                config.Remove("description");
                config.Add("description", "hMailServer Membership provider");
            }

            // Initialize the abstract base class.
            base.Initialize(name, config);

            pApplicationName = GetConfigValue(config["applicationName"], "");
            pMaxInvalidPasswordAttempts = Convert.ToInt32(GetConfigValue(config["maxInvalidPasswordAttempts"], "5"));
            pPasswordAttemptWindow = Convert.ToInt32(GetConfigValue(config["passwordAttemptWindow"], "10"));
            pMinRequiredNonAlphanumericCharacters = Convert.ToInt32(GetConfigValue(config["minRequiredNonAlphanumericCharacters"], "1"));
            pMinRequiredPasswordLength = Convert.ToInt32(GetConfigValue(config["minRequiredPasswordLength"], "7"));
            pPasswordStrengthRegularExpression = Convert.ToString(GetConfigValue(config["passwordStrengthRegularExpression"], ""));
            pEnablePasswordReset = Convert.ToBoolean(GetConfigValue(config["enablePasswordReset"], "true"));
            pEnablePasswordRetrieval = false;
            pRequiresQuestionAndAnswer = false;
            pRequiresUniqueEmail = true;            

            string temp_format = GetConfigValue(config["passwordFormat"], "Hashed");
            switch (temp_format)
            {
                case "Hashed":
                    pPasswordFormat = MembershipPasswordFormat.Hashed;
                    break;
                default:
                    throw new ProviderException("Password format not supported.");
            }

        }


        //
        // A helper function to retrieve config values from the configuration file.
        //

        private string GetConfigValue(string configValue, string defaultValue)
        {
            if (String.IsNullOrEmpty(configValue))
                return defaultValue;

            return configValue;
        }


        //
        // System.Web.Security.MembershipProvider properties.
        //


        private string pApplicationName;
        private bool pEnablePasswordReset;
        private bool pEnablePasswordRetrieval;
        private bool pRequiresQuestionAndAnswer;
        private bool pRequiresUniqueEmail;
        private int pMaxInvalidPasswordAttempts;
        private int pPasswordAttemptWindow;
        private MembershipPasswordFormat pPasswordFormat;

        public override string ApplicationName
        {
            get { return pApplicationName; }
            set { pApplicationName = value; }
        }

        public override bool EnablePasswordReset
        {
            get { return pEnablePasswordReset; }
        }


        public override bool EnablePasswordRetrieval
        {
            get { return pEnablePasswordRetrieval; }
        }


        public override bool RequiresQuestionAndAnswer
        {
            get { return pRequiresQuestionAndAnswer; }
        }


        public override bool RequiresUniqueEmail
        {
            get { return pRequiresUniqueEmail; }
        }


        public override int MaxInvalidPasswordAttempts
        {
            get { return pMaxInvalidPasswordAttempts; }
        }


        public override int PasswordAttemptWindow
        {
            get { return pPasswordAttemptWindow; }
        }


        public override MembershipPasswordFormat PasswordFormat
        {
            get { return pPasswordFormat; }
        }

        private int pMinRequiredNonAlphanumericCharacters;

        public override int MinRequiredNonAlphanumericCharacters
        {
            get { return pMinRequiredNonAlphanumericCharacters; }
        }

        private int pMinRequiredPasswordLength;

        public override int MinRequiredPasswordLength
        {
            get { return pMinRequiredPasswordLength; }
        }

        private string pPasswordStrengthRegularExpression;

        public override string PasswordStrengthRegularExpression
        {
            get { return pPasswordStrengthRegularExpression; }
        }

        //
        // System.Web.Security.MembershipProvider methods.
        //

        //
        // MembershipProvider.ChangePassword
        //

        public override bool ChangePassword(string username, string oldPwd, string newPwd)
        {
            if (!ValidateUser(username, oldPwd))
                return false;

            ValidatePasswordEventArgs args =
              new ValidatePasswordEventArgs(username, newPwd, true);

            OnValidatingPassword(args);

            if (args.Cancel)
                if (args.FailureInformation != null)
                    throw args.FailureInformation;
                else
                    throw new MembershipPasswordException("Change password canceled due to new password validation failure.");

            string[] sp = username.Split(new Char[] { '@' });

            if (sp.Length != 2)
                return false;

            hMailServerNetRemote.Application app = RemoteActivation.GetRemotehMailServerApplication();
            hMailServerNetRemote.Domain domain = app.Domains.ItemByName(sp[1]);
            hMailServerNetRemote.Account account = domain.Accounts[username];
            account.Password = newPwd;
            account.Save();

            return true;
        }



        //
        // MembershipProvider.ChangePasswordQuestionAndAnswer
        //

        public override bool ChangePasswordQuestionAndAnswer(string username,
                      string password,
                      string newPwdQuestion,
                      string newPwdAnswer)
        {
            if (!ValidateUser(username, password))
                return false;

            return false;
        }



        //
        // MembershipProvider.CreateUser
        //

        public override MembershipUser CreateUser(string username,
                 string password,
                 string email,
                 string passwordQuestion,
                 string passwordAnswer,
                 bool isApproved,
                 object providerUserKey,
                 out MembershipCreateStatus status)
        {
            ValidatePasswordEventArgs args =
              new ValidatePasswordEventArgs(username, password, true);

            OnValidatingPassword(args);

            if (args.Cancel)
            {
                status = MembershipCreateStatus.InvalidPassword;
                return null;
            }

            if (RequiresUniqueEmail && GetUserNameByEmail(email) != "")
            {
                status = MembershipCreateStatus.DuplicateEmail;
                return null;
            }

            throw new ProviderException("User creation not allowed.");


        }


        //
        // MembershipProvider.DeleteUser
        //

        public override bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            throw new ProviderException("User deletion not allowed.");
        }


        //
        // MembershipProvider.GetAllUsers
        //

        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            throw new ProviderException("GetAllUsers not implemented.");

        }


        //
        // MembershipProvider.GetNumberOfUsersOnline
        //

        public override int GetNumberOfUsersOnline()
        {
            return 0;
        }


        //
        // MembershipProvider.GetPassword
        //

        public override string GetPassword(string username, string answer)
        {
            if (!EnablePasswordRetrieval)
            {
                throw new ProviderException("Password Retrieval Not Enabled.");
            }

            if (PasswordFormat == MembershipPasswordFormat.Hashed)
            {
                throw new ProviderException("Cannot retrieve Hashed passwords.");
            }

            return "";
        }

        //
        // MembershipProvider.GetUser(string, bool)
        //

        public override MembershipUser GetUser(string username, bool userIsOnline)
        {
            return GetUser((object)username, userIsOnline);
        }

        //
        // MembershipProvider.GetUser(object, bool)
        //

        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            hMailServerNetRemote.Account account = GetAccount((string)providerUserKey);
            if (account == null)
                return null;

            MembershipUser u = GetUserFromAccount(account);

            return u;
        }

        //
        // GetUserFromReader
        //    A helper function that takes the current row from the MySqlDataReader
        // and hydrates a MembershiUser from the values. Called by the 
        // MembershipUser.GetUser implementation.
        //

        private hMailServerNetRemote.Account GetAccount(string email)
        {
            hMailServerNetRemote.Application app = RemoteActivation.GetRemotehMailServerApplication();
            string[] sp = email.Split(new Char[] { '@' });

            if (sp.Length != 2)
                return null;

            hMailServerNetRemote.Domain domain = app.Domains.ItemByName(sp[1]);
            if (domain == null)
                return null;

            hMailServerNetRemote.Account account = domain.Accounts.ItemByAddress(email);
            if (account == null)
                return null;

            return account;
        }

        private MembershipUser GetUserFromAccount(hMailServerNetRemote.Account account)
        {
            string address = account.Address;
            object providerUserKey = address;
            string username = address;
            string email = address;
            string passwordQuestion = "";
            string comment = "";
            bool isApproved = true;
            bool isLockedOut = false;
            DateTime creationDate = DateTime.Now;
            DateTime lastLoginDate = account.LastLogonTime;
            DateTime lastActivityDate = lastLoginDate;
            DateTime lastPasswordChangedDate = DateTime.Now;
            DateTime lastLockedOutDate = DateTime.Now;

            MembershipUser u = new MembershipUser(this.Name,
                                                  username,
                                                  providerUserKey,
                                                  email,
                                                  passwordQuestion,
                                                  comment,
                                                  isApproved,
                                                  isLockedOut,
                                                  creationDate,
                                                  lastLoginDate,
                                                  lastActivityDate,
                                                  lastPasswordChangedDate,
                                                  lastLockedOutDate);

            return u;
        }

        //
        // MembershipProvider.UnlockUser
        //

        public override bool UnlockUser(string username)
        {
            return false;
        }


        //
        // MembershipProvider.GetUserNameByEmail
        //

        public override string GetUserNameByEmail(string email)
        {
            hMailServerNetRemote.Account account = GetAccount(email);
            if (account == null)
                return "";

            return email;
        }


        //
        // MembershipProvider.ResetPassword
        //

        public override string ResetPassword(string username, string answer)
        {
            if (!EnablePasswordReset)
            {
                throw new NotSupportedException("Password reset is not enabled.");
            }

            if (answer == null && RequiresQuestionAndAnswer)
            {
                UpdateFailureCount(username, "passwordAnswer");

                throw new ProviderException("Password answer required for password reset.");
            }

            string newPassword =
              System.Web.Security.Membership.GeneratePassword(newPasswordLength, MinRequiredNonAlphanumericCharacters);

            ValidatePasswordEventArgs args =
              new ValidatePasswordEventArgs(username, newPassword, true);

            OnValidatingPassword(args);

            if (args.Cancel)
                if (args.FailureInformation != null)
                    throw args.FailureInformation;
                else
                    throw new MembershipPasswordException("Reset password canceled due to password validation failure.");

            hMailServerNetRemote.Account account = GetAccount(username);

            if (account == null)
                throw new ProviderException("Can't find user");

            account.Password = newPassword;
            account.Save();

            return newPassword;
        }


        //
        // MembershipProvider.UpdateUser
        //

        public override void UpdateUser(MembershipUser user)
        {
            throw new ProviderException("UpdateUser not implemented");
        }


        //
        // MembershipProvider.ValidateUser
        //

        public override bool ValidateUser(string username, string password)
        {
            bool isValid = false;


            hMailServerNetRemote.Application app = RemoteActivation.GetRemotehMailServerApplication();
            hMailServerNetRemote.Account account = app.Authenticate(username, password);

            if (account != null)
            {
                isValid = true;
            }
            else
            {
                UpdateFailureCount(username, "password");
            }

            return isValid;
        }


        //
        // UpdateFailureCount
        //   A helper method that performs the checks and updates associated with
        // password failure tracking.
        //

        private void UpdateFailureCount(string username, string failureType)
        {
        }


        //
        // MembershipProvider.FindUsersByName
        //

        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            return FindUsersByEmail(usernameToMatch, pageIndex, pageSize, out totalRecords);
        }

        //
        // MembershipProvider.FindUsersByEmail
        //

        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new ProviderException("FindUsersByEmail not implemented.");
        }        
    }

}