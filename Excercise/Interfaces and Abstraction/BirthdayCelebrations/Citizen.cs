using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Citizens : IDentible, IBirthDate
    {
        public Citizens(string id, string name, int age, string brithDate)
        {
            Id = id;
            Name = name;
            Age = age;
            BrithDate = brithDate;
        }

        public string Id { get; }

        public string Name { get; }

        public int Age { get; }
        public string BrithDate { get; private set; }

        
    }
}