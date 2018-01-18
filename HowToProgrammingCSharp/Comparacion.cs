//Fig. 3.26: Comparacion.cs
//Comparacion de enteros mediante el uso de instrucciones if(), operadores de
//igualdad y operadores relacionales
using System;

namespace HowToProgrammingCSharp
{
    public class Comparacion
    {
        //El metodo main comienza la ejecucion de la aplicacion de C#
        public static void Main(string[] args)
        {
            int numero1;//Declara el primer numero a comparar
            int numero2;//Declara el segundo numero a comparar

            //Pide al usuario y lee el primer numero
            Console.Write("Escriba el primer numero");
            numero1 = Convert.ToInt32(Console.ReadLine());

            //pide al usuario y lee el segundo numero
            Console.Write("Escriba el segundo numero");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if(numero1 == numero2)
            {
                Console.WriteLine("{0} == {1}", numero1, numero2);
            }
            if (numero1 != numero2)
            {
                Console.WriteLine("{0} != {1}", numero1, numero2);
            }
            if(numero1 < numero2)
            {
                Console.WriteLine("{0} < {1}", numero1, numero2);
            }
            if (numero1 > numero2)
            {
                Console.WriteLine("{0} > {1}", numero1, numero2);
            }
            if (numero1 <= numero2)
            {
                Console.WriteLine("{0} <= {1}", numero1, numero2);
            }
            if(numero1 >= numero2)
            {
                Console.WriteLine("{0} >= {1}", numero1, numero2);
            }
        }//Fin del metodo main
    }//fin de la clase Comparacion
}
