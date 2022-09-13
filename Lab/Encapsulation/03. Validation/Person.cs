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
            set {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                firstName = value;
            }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                lastName = value; 
            }
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
            set {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                age = value;
            }
        }
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set {
                if (value < 650)
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }
                salary = value; 
            }
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
