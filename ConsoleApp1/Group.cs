using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Group
    {
        public string Name { get; set; }
        public List<Student> studens;
        public Group()
        {

        }
        public Group(string name) : this()
        {
            Name = name;
            studens = new List<Student>();
        }
    }
}
