using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    using System;
    public class Person
    {
        private const int MinNameLength = 3;
        private const int MinAge = 0;
        private const decimal MinSalary = 650m;

        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            private set
            {
                if (value.Length < MinNameLength)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            private set
            {
                if (value.Length < MinNameLength)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                if (value < MinAge)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                age = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }
            private set
            {
                if (value < MinSalary)
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }
                salary = value;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age < 30)
            {
                this.Salary += this.Salary * (percentage / 200);
            }
            else
            {
                this.Salary += this.Salary * (percentage / 100);
            }
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }
    }
}


