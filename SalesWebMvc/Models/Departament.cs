using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Departament
    {
        public int id { get; set; }
        public string  name { get; set; }

        public Departament(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Departament()
        {
        }


    }
}
