using ConsoleApp7.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Models
{
    internal class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if(value > 0)
                {
                    _age = value;
                }
                else
                {
                    throw new AgeException("Age value must be greater than 0!");
                }
            }
        }
        public Human(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
