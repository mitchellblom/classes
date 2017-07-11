using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. In the `Main` method, create a company, and three employees, and then assign the employees to the company.

            Company newCompany = new Company("Nalgene", DateTime.Now);
            
            Employee newEmp1 = new Employee("Bob", "Director of Direction", DateTime.Now);
            Employee newEmp2 = new Employee("Fred", "Manager of Leadership", DateTime.Now);
            Employee newEmp3 = new Employee("Suzy", "Assistance Assistant", DateTime.Now);

            // 1. Consider the concept of [aggregation](../08_RELATIONSHIPS.md#aggregation), and modify the `Company` class so that you assign employees to a company. 

            newCompany.addEmployee(newEmp1);
            newCompany.addEmployee(newEmp2);
            newCompany.addEmployee(newEmp3);

            // 1. Update the `Company` class to write the name of each employee to the console. Consider a method named `ListEmployees()`.

            newCompany.ListEmployees();

        }
    }

    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        public List<Employee> employeeList = new List<Employee>();
        // Create a method that allows external code to add an employee
        public void addEmployee(Employee addMe) {
            employeeList.Add(addMe);
        }
        // Create a method that allows external code to remove an employee
        public void removeEmployee(Employee deleteMe) {
            employeeList.Remove(deleteMe);
        }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string nameInput, DateTime dateInput)
        {
            Name = nameInput;
            CreatedOn = dateInput;
        }
        public void ListEmployees() {
            foreach (Employee each in this.employeeList) {
                Console.WriteLine($"{each.employeeName}: {each.jobTitle}");
            }
        }

    }

    public class Employee 
    {
        // 1. Create a class that contains information about employees of a company and define methods to get/set employee name, job title, and start date.

        public string employeeName {get; set;}
        public string jobTitle {get; set;}
        public DateTime startDate {get; set;}

        public Employee(string name, string title, DateTime date) {
            employeeName = name;
            jobTitle = title;
            startDate = date;
        }

    }

}