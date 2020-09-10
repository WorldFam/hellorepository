using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;

namespace Polymorphism
{
    public class Company
    {
        public List<Employee> Employee;

        public Company()
        {
            Employee = new List<Employee>();
        }
        public double GetMonthlySalaryTotal()
        {
            double sum = 0;
            for (int i = 0;
            i < Employee.Count; i++)
            {
                sum += Employee[i].GetMonthlySalary();
            }
            return sum;
        }

        public void HireNewEmployee(Employee emp)
        {
             Employee.Add(emp);
        }
        
    
    }
}