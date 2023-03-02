using laboratorio1KatherinMartinez.Entidades;
using laboratorio1KatherinMartinez.Negocio;

persona persona = new persona();
clspersona clspersona = new clspersona();

Console.WriteLine("Ingresa tu nombre");
persona.Nombre = Console.ReadLine();

Console.WriteLine("Ingresa tu edad");
persona.Edad = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa tu sexo");
persona.Sexo = Console.ReadLine();

Console.WriteLine("Ingresa tu peso");
persona.Peso = double.Parse(Console.ReadLine());

Console.WriteLine("Ingresa tu altura");
persona.Altura = double.Parse(Console.ReadLine());

clspersona.calcularIMC(persona);
clspersona.esMayorDeEdad(persona);
