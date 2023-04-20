using System;

namespace Singleton
{
    public class Singleton
    {
        // Declara una variable estática privada de tipo Singleton llamada
        // "instance" e inicializa su valor en "null". 
        // Esta variable almacena la única instancia del objeto Singleton.

        private static Singleton instance = null;

        // Declara una variable pública de tipo string llamada "mensaje". 
        // Esta variable se utiliza para almacenar un mensaje que se asigna
        // al crear una nueva instancia del objeto Singleton.

        public string mensaje = "";

        // Define un constructor protegido para la clase Singleton.
        // Este constructor se utiliza para inicializar la variable
        // "mensaje" con el valor "Hola Mundo" al crear una nueva instancia de la clase.

        protected Singleton()
        {
            mensaje = "Hola Mundo";
        }

        // Define una propiedad pública estática llamada "Instance" que devuelve la única instancia del objeto Singleton.

        public static Singleton Instance
        {
            get
            {
                // Si la variable "instance" es nula se le asigna una nueva instancia de la clase Singleton
                if (instance == null)
                    instance = new Singleton();
                // Devuelve la instancia actual del objeto Singleton
                return instance;
            }
        }
    }
}