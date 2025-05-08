//hola puedo caer asi a la prueba?

using pruebalol;
using System.Runtime.CompilerServices;
List<provincia> provincias = new();
List<ciudad> ciudades = new();

carga();

Console.WriteLine("aprete para continuar");
Console.ReadKey();
Console.Clear();

muestralol();
Console.ReadKey();



void muestralol()
{

    Console.WriteLine("-------------------------muestra lolazaaa---------------------------");
    foreach (provincia provo in provincias)
    {
        Console.WriteLine($"--provincia--");
        Console.WriteLine($"    Nombre: {provo.nombre} ");
        Console.WriteLine($"    Gobernador: {provo.gobernador} ");
        Console.WriteLine($"    Region: {provo.region} ");
        foreach (ciudad ciu in ciudades)
        {
            Console.WriteLine($"     ---Ciudades---");
            Console.WriteLine($"           Nombre: {ciu.nombre} ");
            Console.WriteLine($"           Cantidad Habitantes: {ciu.CantHabitantes} ");
            Console.WriteLine($"           Nombre: {ciu.SuperficieKM}km² ");
        }

    }

    Console.WriteLine("aprete cualquier tecla para salir!");
}
void carga()
{
    string nombre = "hola ";
    do
    {
        provincia prov = new provincia();

        Console.WriteLine("ingrese el nombre de la provincia!");
        prov.nombre = Console.ReadLine();
      
        if (!string.IsNullOrEmpty(prov.nombre))
        {
 
            Console.WriteLine("ingrese el nombre del gobernador!");
            prov.gobernador = Console.ReadLine();
            Console.WriteLine("ingrese la region!");
            prov.region = Console.ReadLine();
            provincias.Add(prov);

            string ciuda = " hola";
            do
            {
                ciudad ciudadlol22 = new ciudad();
                Console.WriteLine("ingrese el nombre de la ciudad");
                ciudadlol22.nombre = Console.ReadLine();

                if (!string.IsNullOrEmpty(ciudadlol22.nombre))
                {


                    Console.WriteLine("ingrese la cantidad de habitantes de la ciudad !");
                    ciudadlol22.CantHabitantes = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la distancia en km de la ciudad!");
                    ciudadlol22.SuperficieKM = int.Parse(Console.ReadLine());
                    ciudades.Add(ciudadlol22);
                    
                    
                }
                else
                {
                    Console.WriteLine("terminando la carga de ciudades........");
                    ciuda = null;
                }

            }
            while (!string.IsNullOrEmpty(ciuda));




        }
        else
        {
            Console.WriteLine("terminando la carga de provincias........");
            nombre = null;
        }

    } while (!string.IsNullOrEmpty(nombre));


}







//hola, no, desaprobado.