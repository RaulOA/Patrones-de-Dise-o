using System;

namespace Prototype_Shallow
{
    // la interfaz "ICloneable" y el patrón Prototype están relacionados
    // en el sentido de que la interfaz "ICloneable" es una forma de permitir
    // la clonación de objetos, que es la base del patrón Prototype.
    // La clonación superficial que se realiza mediante la interfaz "ICloneable"
    // se asemeja a la implementación del patrón Prototype Shallow.

    //La clonación es un proceso en el que se crea una copia de un objeto existente.
    //La clonación puede ser profunda o superficial. La clonación profunda implica
    //la creación de una copia completa del objeto, incluyendo cualquier objeto al
    //que se haga referencia en el objeto original. La clonación superficial implica
    //la creación de una copia del objeto, pero no de los objetos a los que hace referencia.
    public class Animal : ICloneable
    {
        public string Nombre { get; set; }
        public int Patas { get; set; }
        public object Clone()
        {
            //Devuelve una copia superficial del objeto actual de la clase Animal
            //utilizando el método "MemberwiseClone" de la clase Object.
            //Una copia superficial copia los valores de los campos,
            //pero no las referencias de los objetos contenidos en los campos.
            return this.MemberwiseClone();
        }
    }
}