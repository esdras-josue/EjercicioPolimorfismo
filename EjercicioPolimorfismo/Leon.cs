
namespace EjercicioPolimorfismo
{
    public class Leon : Animal
    {
        public override void Sonido()
        {
            Console.WriteLine("GUAAAAR");
        }

        public override void Moverse()
        {
            Console.WriteLine(Nombre + " Esta cazando.");
        }
    }
}
