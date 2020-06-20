using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.Controller
{
    class EmployeeController
    {
        private static EmployeeController ec;
        private UnderTheSeaEntities en;
        private EmployeeController()
        {
            en = UnderTheSeaEntities.getInstance();
        }
        public static EmployeeController getInstance()
        {
            if(ec==null)
            {
                ec = new EmployeeController();
            }
            return ec;
        }
        public void deleteEmployee(Employee em)
        {
            Employee temp = en.Employees.Where(x => x.EmployeeId == em.EmployeeId).FirstOrDefault();
            temp.EmployeeStatus = "Discharged";
            en.SaveChanges();
        }
        public void updateEmployee(Employee oldEm, Employee newEm)
        {
            Employee temp = en.Employees.Where(x => x.EmployeeId == oldEm.EmployeeId).FirstOrDefault();
            temp.EmployeeAddress = newEm.EmployeeAddress;
            temp.EmployeePosition = newEm.EmployeePosition;
            temp.EmployeeSalary = newEm.EmployeeSalary;
            temp.EmployeeStatus = newEm.EmployeeStatus;
            en.SaveChanges();
        }
        public void addEmployee(string name, string address, string gender, int salary, string position, string password)
        {
            Employee newEmployee = en.Employees.Create();
            newEmployee.EmployeeStatus = "Active";
            newEmployee.EmployeeName = name;
            newEmployee.EmployeeAddress = address;
            newEmployee.EmployeeGender = gender;
            newEmployee.EmployeeSalary = salary;
            newEmployee.EmployeePosition = position;
            newEmployee.EmployeePassword = password;
            en.Employees.Add(newEmployee);
            en.SaveChanges();
        }
        public List<Employee> getAllEmployee()
        {
            return en.Employees.ToList();
        }
        public int getEmployeeLastId()
        {
            int t = en.Employees.Count();
            return t;
        }

    }
}
