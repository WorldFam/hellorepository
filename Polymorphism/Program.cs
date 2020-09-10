using System;

namespace Polymorphism
{
    class Program
    {
        /*Employee tautvis = new FullTimeEmployee("Peter", 55)
        {
            Name = "Jonas",
            MonthlySalary = 143
        };
        Employee tautvis1 = new PartTimeEmployee("Tautvis", 127, 40)
        {
            Name = "Jonas",
            HourlyWage = 45,
            HoursPerMonth = 236
        };
        Console.WriteLine(tautvis);
        Console.WriteLine(tautvis1);*/
            
        
            
            public static void Main(string[] args)
            {
                Company company = new Company();
                company.HireNewEmployee(new PartTimeEmployee("edva",127,40));
                company.HireNewEmployee(new FullTimeEmployee("edvaV2",5200));
                Console.Out.WriteLine(company.GetMonthlySalaryTotal());
            
            }
        }
    }


