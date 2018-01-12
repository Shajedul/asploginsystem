using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
     public class Auhtenciation
    {
        public bool login_permission(string username, string password)
        {
            Credential cred = new Credential();
            if(cred.isgranted(username,password))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
