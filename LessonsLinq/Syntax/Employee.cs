using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsLinq
{
    public class Employee
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Departament Departament { get; set; }

        public override string ToString()
        {
            return Name + "\t" + Age + "\t" + Departament.Name;
        }
    }
}
