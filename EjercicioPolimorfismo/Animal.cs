using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Animal
    {
        public string Nombre {  get; set; }

        public virtual void Sonido()
        {
            Console.WriteLine("Hace sonido");
        }

        public virtual void Moverse()
        {
            Console.WriteLine("El animal se esta moviendo");
        }

       


    }
}
