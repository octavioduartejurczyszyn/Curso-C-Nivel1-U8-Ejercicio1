using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto
            //  de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y 
            //  muestre por pantalla el monto total a pagar. Usar la función.
            int art, canVen, resultado;
            Console.WriteLine("Escriba el precio del artículo:");
            art = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la cantidad vendida:");
            canVen = int.Parse(Console.ReadLine());
            resultado = producto(art, canVen);
            Console.WriteLine("Monto total a pagar es: " + resultado);

        }
        static int producto(int a, int b){
            int r;
            r = a * b;
            return r;
        }
    }   
}
