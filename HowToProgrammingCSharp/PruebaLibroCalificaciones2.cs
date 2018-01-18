//Fig. 4.8: PruebaLibroCalificaciones.cs
//Creacion y Manipulacion de un objeto LibroCalificaciones2
using System;

namespace HowToProgrammingCSharp
{
    class PruebaLibroCalificaciones2
    {
        //El metodo main comienza la ejecucion del programa
        public static void Main(string[] args)
        { 
            //Crea un objeto LibroCalificaciones2 y lo asigna a miLibroCalificaciones
            LibroCalificaciones2 miLibroCalificaciones = new LibroCalificaciones2();

            //muestra el valor inicial de NombreCurso
            Console.WriteLine("El nombre inicial del curso es: '{0}'",
                miLibroCalificaciones.NombreCurso);

            //pide y lee el nombre del curso
            Console.WriteLine("Porfavor escriba el nombre del curso");
            string elNombre = Console.ReadLine();// Lee una linea de texto
            miLibroCalificaciones.NombreCurso = elNombre;//establece el nombre usando una propiedad
            Console.WriteLine();//imprime en pantalla una linea en blanco
            
            //muestra el mensaje de bienvenida después de especificar el nombre del curso
            miLibroCalificaciones.MostrarMensaje();
        }//fin del main
    }//fin de la clase PruebaLibroCalificaciones2
}
