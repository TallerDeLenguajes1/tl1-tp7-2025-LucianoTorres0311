// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;
Calculadora calc1 = new Calculadora();
int opcion;
double num;
int decision;

do
{
    Console.WriteLine("Ingrese una opcion");
    Console.WriteLine("[1] Suma");
    Console.WriteLine("[2] Resta");
    Console.WriteLine("[3] Multiplicacion");
    Console.WriteLine("[4] Division");
    Console.WriteLine("[5] Limpiar");
    Console.WriteLine("[0] Salir");
    int.TryParse(Console.ReadLine(), out opcion);
    switch (opcion)
    {
        case 1:
        do
        {
            Console.WriteLine("Ingrese un numero");
            double.TryParse(Console.ReadLine(), out num);
            calc1.Sumar(num);
            Console.WriteLine("El resultado es:" + calc1.resultado);
            Console.WriteLine("Ingrese 1 si quiere repetir o 0 si quiere salir");
            int.TryParse(Console.ReadLine(), out decision);
        } while (decision != 0);   
        break;
        case 2:
        do
        { 
            Console.WriteLine("Ingrese un numero");
            double.TryParse(Console.ReadLine(), out num);
            calc1.Restar(num);
            Console.WriteLine("El resultado es:" + calc1.resultado);
            Console.WriteLine("Ingrese 1 si quiere repetir o 0 si quiere salir");
            int.TryParse(Console.ReadLine(), out decision);
        }while (decision != 0);
        break;
        case 3:
        do
        { 
            Console.WriteLine("Ingrese un numero");
            double.TryParse(Console.ReadLine(), out num);
            calc1.Multiplicar(num);
            Console.WriteLine("El resultado es:" + calc1.resultado);
            Console.WriteLine("Ingrese 1 si quiere repetir o 0 si quiere salir");
            int.TryParse(Console.ReadLine(), out decision);
        }while (decision != 0);
        break;
        case 4:
        do 
        {

            Console.WriteLine("Ingrese un numero");
            double.TryParse(Console.ReadLine(), out num);
            calc1.Dividir(num);
            Console.WriteLine("El resultado es:" + calc1.resultado);
            Console.WriteLine("Ingrese 1 si quiere repetir o 0 si quiere salir");
            int.TryParse(Console.ReadLine(), out decision);
        }while (decision != 0);
        break;
        case 5:
        do
        {
            calc1.Limpiar();
            Console.WriteLine("El resultado es:" + calc1.resultado);
            Console.WriteLine("Ingrese 1 si quiere repetir o 0 si quiere salir");
            int.TryParse(Console.ReadLine(), out decision);
        } while (decision != 0);
        break;
        
    }
} while (opcion != 0);

