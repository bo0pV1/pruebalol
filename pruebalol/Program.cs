//hola puedo caer asi a la prueba?

using pruebalol;
using System.Runtime.CompilerServices;

provincia prov = new provincia();
ciudad ciudadlol = new ciudad();
List<provincia> provincias = new();
List<ciudad> ciudades = new();

do
{
    Console.WriteLine("ingrese el nombre de la provincia!");
    prov.nombre = Console.ReadLine();
    if (prov.nombre != null)
    {
        carga(prov);
    }
    else
    {
        Console.WriteLine("terminando la carga de provincias........");
        break;
    }

}
while (prov.nombre != null);

Console.WriteLine("aprete para continuar");
Console.ReadKey();
Console.Clear();


void carga(provincia provinciad)
{
    provinciad.nombre = prov.nombre;
    Console.WriteLine("ingrese el nombre del gobernador!");
    provinciad.gobernador = Console.ReadLine();
    Console.WriteLine("ingrese la region!");
    provinciad.region = Console.ReadLine();
    provincias.Add(provinciad);
    do
    {
        Console.WriteLine("ingrese el nombre de la ciudad");
        ciudadlol.nombre = Console.ReadLine();
        if (ciudadlol.nombre != null)
        {
            cargaciudad(ciudadlol);
        }
        else
        {
            Console.WriteLine("terminando la carga de ciudades........");
            break;
        }

    }
    while (ciudadlol.nombre != null);

}



void cargaciudad(ciudad ciud)
{
    ciud.nombre = ciudadlol.nombre;
    Console.WriteLine("ingrese la cantidad de habitantes de la ciudad !");
    ciud.CantHabitantes=int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese la distancia en km de la ciudad!");
    ciud.SuperficieKM =int.Parse(Console.ReadLine());
    ciudades.Add(ciud);

}






//hola, no, desaprobado.