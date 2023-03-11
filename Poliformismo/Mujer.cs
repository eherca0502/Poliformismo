using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformismo
{
    class Mujer : Persona
    {
        public override void Saludar()
        {
            Console.WriteLine("Hello, nice to meet you, my name is" + this.nombre);
        }
    }
}
