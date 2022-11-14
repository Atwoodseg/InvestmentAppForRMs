using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RM_APP
{
    internal class LoginBE
    {
        public String login(String username)
        {
            //validate the username and the password
            //check the format

            //the object is not created but returned by DBConn
            //DBConnectionClass.getInstanceOfDBConnection().

            return username + "000000";
        }

        
       
    }
}
