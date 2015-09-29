using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person
    {
        
        private int age;

        public Person(String name, int age)
        {
            Name = name; // On emploie toujours la propriété
            Age = age;
        }
        public int Age
        {
            get { return age; }
            set { age = (value > 0) ? value : 1 ;}
        }

        public String Name
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Name + " agée de " + Age + " ans";        }
    }
}
