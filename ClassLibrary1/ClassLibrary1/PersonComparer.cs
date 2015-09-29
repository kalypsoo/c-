
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PersonComparer : IEqualityComparer<Person>
    {
        public Boolean Equals(Person p1, Person p2)
        {
            if (p1 == p2 || p1.Name == p2.Name)
                return true;
            return false;

        }

        public int GetHashCode(Person p)
        { 
            return (int)Math.Pow(p.Name.GetHashCode(),p.Age);
        }
    }
}
