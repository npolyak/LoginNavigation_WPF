﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mac_project.Models.Diagnostic
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsFictitious { get; set; }

        public Person(string firstName, string lastName, bool isFictitious)
        {
            FirstName = firstName;
            LastName = lastName;
            IsFictitious = isFictitious;
        }
    }
}
