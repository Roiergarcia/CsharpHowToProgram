//Fig. 4.2: PruebaLibroCalificaciones.cs
//crea un objeto LibroCalificaciones y llama a su metodo MostrarMensaje
using System;

namespace HowToProgrammingCSharp
{
    class PruebaLibroCalificaciones
    {
        public static void Main(string[] args) 
        { 
            //Crea un objeto LibroCalificaciones y lo asigna a miLibroCalificaciones
            LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones();

            //llama al metodo MostrarMensaje de miLibroCalificaciones
            miLibroCalificaciones.MostrarMensaje();
        }//fin del main
    }//fin de la clase PruebaLibroCalificaciones
}
