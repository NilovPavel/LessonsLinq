using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsLinq
{
    public class Departament
    {
        private static int count;
        public int ID { get; set; }
        public string Name { get; set; }

        public Departament(string name) 
        { 
            this.ID = count;
            count++;
            this.Name = name;
        }
    }
}
