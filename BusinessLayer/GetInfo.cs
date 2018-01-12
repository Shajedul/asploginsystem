using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class GetInfo
    {
        public bool login(string username, string password)
        {
            DataAccess.Auhtenciation authenciate = new DataAccess.Auhtenciation();

            return authenciate.login_permission(username, password);

        }
    }
}
