using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Perro : Animal
    {
        public override void Sonido()
        {
            Console.WriteLine("GUA GUA GUA");
        }

        public override void Moverse()
        {
            Console.WriteLine(Nombre + " Esta corriendo");
        }
    }
}
