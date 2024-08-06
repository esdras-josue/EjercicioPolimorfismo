using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Gato : Animal
    {
        public override void Sonido()
        {
            Console.WriteLine("Miau, Miau, Miau");
        }

        public override void Moverse()
        {
            Console.WriteLine(Nombre + " esta caminando en el techo");
        }
    }
}
