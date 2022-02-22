using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLibrary;
//******************************************************************
//Author: JEEVITHA
//Purpose: To Create Employee Management Application by using BLL
//******************************************************************
namespace BusinessLogicLibrary
{
    public class EmployeeBLL
    {
        public static bool AddEmployee(int empId, string empName, int empSalary, int empAge)
        {
            
            // if all validations are succeccful then call DAL
            var result = EmployeeDAL.AddEmployee(empId, empName, empSalary, empAge);
            return result;
        }
        public static List<string> GetEmployeeById(int Id)
        {
            var result= EmployeeDAL.GetEmployeeById(Id);
            return result;
        }
        public static List<string> GetEmployeeByName(string Name)
        {
            var result = EmployeeDAL.GetEmployeeByName(Name);
            return result;
        }
        public static string[] GetAllEmployees()
        {
            var result = EmployeeDAL.GetAllEmployees();
            return result;
        }
    }
}
