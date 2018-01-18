//Fig. 3.18: Suma.cs
//Muestra la suma de dos numeros que se introducen desde el teclado.
using System;

namespace HowToProgrammingCSharp
{
    public class Suma
    {
        public static void Main(string[] args)
        {
            int numero1;//declara el primer numero a sumar
            int numero2;//declara el segundo numero a sumar
            int suma;//declara la suma de numero1 y numero2

            Console.Write("Escriba el primer entero: "); //mensaje para el usuario
            //lee el primer numero del usuario
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba el segundo entero: ");//mensaje para el usuario
            //lee el segundo numero del usuario
            numero2 = Convert.ToInt32(Console.ReadLine());

            suma = numero1 + numero2; //suma los numeros

            Console.WriteLine("La suma es {0}", suma);//muestra la suma
        }//fin del metodo main
    }//fin de la clase suma
}
