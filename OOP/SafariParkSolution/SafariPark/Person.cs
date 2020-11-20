﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Person
    {
        private string _firstName;
        private string _lastName;

        public int Age { get; set; }

        public Person(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }

        public Person() { }
        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}";
        }



    }
}
