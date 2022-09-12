using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
   public class Person
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private int age;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            
            LastName = lastName;
           
            Age = age;

            Salary = salary;
           
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public decimal IncreaseSalary(decimal percentage)
        {
          
            if (Age < 30)
            {
                percentage /= 2;
                percentage /= 100;
                return Salary = (Salary * percentage) + Salary;
            }
            else
            {
                percentage /= 100;
                return Salary = (Salary * percentage ) + Salary;
            }
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }

    }
}
