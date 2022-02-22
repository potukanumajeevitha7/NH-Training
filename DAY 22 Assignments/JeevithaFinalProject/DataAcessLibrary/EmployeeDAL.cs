using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//******************************************************************
//Author: JEEVITHA
//Purpose: To create Employee Management Application using DAL
//******************************************************************

namespace DataAcessLibrary
{
    public static class EmployeeDAL
    {
        public static string filePath = "F:\\EmployeeData\\Employees.txt";
        public static bool AddEmployee(int empId, string empName, int empSalary, int empAge)
        {
            try
            {
                string textContent = string.Concat(empId, ",", empName, ",", empSalary, ",", empAge);
                File.AppendAllText(filePath, textContent + Environment.NewLine);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static List<string> GetEmployeeById(int Id)
        {
          var allEmployees = File.ReadAllLines(filePath);
          bool isFound = false;
          List<string> employeeFound = new List<string>();
          foreach (string employee in allEmployees)
          {
            var empDetails = employee.Split(',');
               if (Convert.ToInt32(empDetails[0]) == Id)
               {
                    isFound = true;
                    employeeFound.Add(employee);
                    break;
               }
          }
            return employeeFound;
        }
        public static List<string> GetEmployeeByName(string Name)
        {
            var allEmployees = File.ReadAllLines(filePath);
            bool isFound = false;
            List<string> employeeFound = new List<string>();
            foreach (string employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if (empDetails[1].Contains(Name))
                {
                    employeeFound.Add(employee);
                }
            }
            return employeeFound;
        }
        public static string [] GetAllEmployees()
        {
            var allEmployees=File.ReadAllLines(filePath);
            return allEmployees;
        }
    }
}
