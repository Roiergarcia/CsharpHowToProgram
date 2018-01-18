//Fig. 4.7: LibroCalificaciones2.cs
//Clase LibroCalificaciones2 que contiene una variable de instancia cursoNombre
//y una propiedad para obtener (get) y establecer (set) su valor
using System;

namespace HowToProgrammingCSharp
{
    class LibroCalificaciones2
    {
        private string nombreCurso; //nombre del curso para este libro de calificaciones

        //propiedad para obtener (get) y establecer (set) el nombre del curso
        public string NombreCurso
        {
            get
            {
                return nombreCurso;
            }//fin de get
            set
            {
                nombreCurso = value;
            }//fin de set
        }

        //muestra un mensaje de bienvenida para el usuario de LibroCalificaciones2
        public void MostrarMensaje()
        { 
            //usa la propiedad NombreCurso para obtener el
            //nombre del curso que representa este LibroCalificaciones2
            Console.WriteLine("¡Bienvenido al Libro de Calificaciones para\n{0}!",
                NombreCurso);//Muestra la propiedad NombreCurso
        }//fin del metodo mostrar mensaje
    }//fin de la clase LibroCalificaciones
}
