using System;
using System.Collections.Generic;
using System.Text;

namespace Project4
{
    internal class Employee1
    {

        // Private data members
        private int emp_code;
        private string emp_name;
        private string designation;
        private double basicPay;

        public Employee1(int emp_code, string emp_name, string designation, double basicPay)
        {
            this.emp_code = emp_code;
            this.emp_name = emp_name;
            this.designation = designation;
            this.basicPay = basicPay;
        }

        public void CalculateSalary()
        {
            double hra = 0.10 * basicPay; // HRA is 10% of basic pay
            double da = 0.45 * basicPay;  // DA is 20% of basic pay
            double netSalary = basicPay + hra + da;

            Console.WriteLine($"Employee Code:" + emp_code);
            Console.WriteLine($"Employee Name:" + emp_name);
            Console.WriteLine($"Designation:" + designation);
            Console.WriteLine($"Basic Pay:" + basicPay);
            Console.WriteLine($"Gross Salary: " + netSalary);
        }
    }

    class P1
    {
        public static void Main()
        {
            // Create multiple Employee objects
            Employee1 e1 = new Employee1(101, "Dhara", "Manager", 50000);
            e1.CalculateSalary();


            Employee1 e2 = new Employee1(102, "Aesh", "Backend Developer", 40000);
            e2.CalculateSalary();

            Employee1 e3 = new Employee1(103, "Mital", "fronted developer", 40000);
            e3.CalculateSalary();


            Console.WriteLine("=========================");
            Console.WriteLine("Name: Aesh Domadiya");
            Console.WriteLine("Enrollment no.: 24SOECE11008");

            Console.ReadLine();
        }
    }
}