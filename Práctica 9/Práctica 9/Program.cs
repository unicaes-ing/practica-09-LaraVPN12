using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Práctica_9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Frutas = new List<string>();
            int menu = 0,contador=0,posicion;;
            string nombre_fruta;
            do
            {
                Console.WriteLine("1) Agregar a la lista\n2) Mostrar Lista\n3) Insertar en la Lista\n4) Eliminar de la Lista\n5) Buscar en la Lista\n6) Vaciar Lista\n7) Salir");
                menu = Convert.ToInt32(Console.ReadLine());
                
           

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Ingrese el nombre de la fruta");
                    nombre_fruta = Console.ReadLine();
                    Frutas.Add(nombre_fruta);
                    break;

                case 2:
                    foreach (string nombre in Frutas)
                    {
                        Console.WriteLine(nombre);
                        
                    }
                    Console.ReadKey();
                    break;

                case 3:
                    do
                    {
                        Console.WriteLine("Ingrese la posición en que la desea colocar(entre 0 y {0})", Frutas.Count);
                        posicion = Convert.ToInt32(Console.ReadLine());
                    } while (posicion < 0 || posicion > Frutas.Count);
                    Console.WriteLine("Ingrese el nombre de la fruta");
                    nombre_fruta = Console.ReadLine();
                    Frutas.Insert(posicion, nombre_fruta);
                   
                    break;
                case 4:
                    Console.WriteLine("Ingrese el nombre de la fruta que desea eliminar");
                    nombre_fruta = Console.ReadLine();
                    if (Frutas.Contains(nombre_fruta))
                    {
                        posicion=Frutas.IndexOf(nombre_fruta);
                        Frutas.RemoveAt(posicion);
                    }
                
                    break;
                case 5:
                    Console.WriteLine("Ingrese el nombre de la fruta que desea buscar");
                    nombre_fruta = Console.ReadLine();
                    if (Frutas.Contains(nombre_fruta))
                    {
                        posicion = Frutas.IndexOf(nombre_fruta);
                        Console.WriteLine("El elemento {0} ha sido encontrado",nombre_fruta);
                    }
                    break;
                case 6:
                    Frutas.Clear();
                    break;
                case 7:
                    break;
            }
            Console.Clear();
            } while (menu !=-1);
            

        }
    }
}
