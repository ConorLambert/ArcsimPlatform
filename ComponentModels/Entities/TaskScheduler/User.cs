using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace ArcsimPlatform.ComponentModels.Entities.TaskScheduler
{
    [Serializable]
    public class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Team { get; set; }

        public string GetFullUserName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

        public WindowsIdentity OriginalIdentity { get; set; }

        #region IIdentity Members

        public string AuthenticationType
        {
            get { return "Windows"; }
        }

        public bool IsAuthenticated
        {
            get { return true; }
        }

        #endregion
    }

    public class UserComplexClass
    {
        public int HedgingUserId { get; set; }
        public String UserName { get; set; }
        public String ActiveUser { get; set; }
        public String FirstName { get; set; }
        public String Surname { get; set; }
    }
}
