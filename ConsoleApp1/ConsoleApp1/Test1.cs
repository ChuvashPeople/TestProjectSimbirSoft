using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Test1
    {
        public string name;
        public int age;

        public Test1(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Test1(string name) : this(name, 12)
        {

        }
        public Test1():this("name")
        {

        }

    }
}
