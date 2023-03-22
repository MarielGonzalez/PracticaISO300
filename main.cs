using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al programa para determinar el tipo de triángulo en función de sus lados ");
        Console.WriteLine("Por favor introduzca el lado 1");
        int lado1;
        lado1 = int.Parse(System.Console.ReadLine());
        Console.WriteLine("Por favor introduzca el lado 2");
        int lado2;
        lado2 = int.Parse(System.Console.ReadLine());
        Console.WriteLine("Por favor introduzca el lado 3");
        int lado3;
        lado3 = int.Parse(System.Console.ReadLine());
        Console.WriteLine("Los lados son {0},{1} y {2}", lado1, lado2, lado3);

        try
        {
            if (lado1 == lado2 ^ lado1 == lado2 ^ lado2 == lado3) //Manejo de Errores usando Try-catch 
            {
                Console.WriteLine("El triángulo es equilatero");
            }
            else if ((lado1 != lado2) ^ (lado1 != lado3) ^ (lado2 != lado3))
            {
                Console.WriteLine("El triángulo es escaleno");
            }
            else
            {
                Console.WriteLine("El triángulo es isósceles");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("El programa ha terminado");
        }

        Environment.Exit(0);   //Esto se usa para manipular la plataforma actual que corre el codigo, salgo para liberar la memoria

    }
}


