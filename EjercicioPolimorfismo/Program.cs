using EjercicioPolimorfismo;
;

/*
 * En dicho proyecto, aplicar polimorfismo según lo visto en clase, debe agregar mínimo 2 métodos y 3 clases, 
 * usted definirá como aplicar polimorfismo en esas 3 clases y mostrar la información en la consola.
 */

Perro perro = new Perro();
Gato gato = new Gato();
Leon leon = new Leon();

perro.Nombre = "Terry";
Console.WriteLine(perro.Nombre + " esta ladrando");
perro.Sonido();
perro.Moverse();
Console.WriteLine();

gato.Nombre = "Capipepo";
Console.WriteLine(gato.Nombre + " esta mauyando");
gato.Sonido();
gato.Moverse();
Console.WriteLine();

leon.Nombre = "Alex";
Console.WriteLine(leon.Nombre + " esta rugiendo ");
leon.Sonido();
leon.Moverse();

Console.ReadKey();