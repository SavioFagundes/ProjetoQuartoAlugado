using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartosAlugados
{
    internal class Informacion
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Informacion(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public override string ToString()
        {
            return Name + "," + Email;
        }
    }
}
