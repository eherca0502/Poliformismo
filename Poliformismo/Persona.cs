using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformismo
{
    abstract class Persona
    {
        // variables internas 
        private string _nombre, _direccion, _telefono;

        //propiedad
        public string telefono { get; set; }

        //metodos
        public virtual void Saludar()
        {
            Console.WriteLine("Hola, es un gusto saludarte, mi nombre es :" +this.nombre);
        }
        
       
 
        public string direccion
        {
            set
            {
                this._direccion = value;
            }
            get
            {
                return this._direccion;
            }
        }
        public string nombre
        {
            set // asignar un valor
            {
                this._nombre = value;
            }
            get //mostrar el valor
            {
               return  this._nombre;
            }
        }
    }
}
