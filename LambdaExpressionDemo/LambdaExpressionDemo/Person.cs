﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionDemo
{
    internal class Person
    {
        public int Id;
        public string Name;
        public string Address;
        public int Age;
        public Person(int id, string name, string address, int age)
        {
            Id=id;
            Name=name;
            Address=address;
            Age=age;
        }
    }
}
