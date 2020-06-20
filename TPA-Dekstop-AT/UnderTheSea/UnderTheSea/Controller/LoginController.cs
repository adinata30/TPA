using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.Controller
{
    class LoginController
    {
        private static LoginController lc;
        private LoginController()
        {

        }
        public static LoginController getInstance()
        {
            if(lc == null)
            {
                lc = new LoginController();
            }
            return lc;
        }
        public Employee doLogin(int id, string pw)
        {
            UnderTheSeaEntities entity = UnderTheSeaEntities.getInstance();
            return entity.Employees.Where(x => x.EmployeeId == id && x.EmployeePassword == pw).FirstOrDefault();
        }
    }
}
