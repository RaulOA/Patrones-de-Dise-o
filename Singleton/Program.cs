using System;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.Instance.mensaje);
            Singleton.Instance.mensaje = "Hola Luna";
            Console.WriteLine(Singleton.Instance.mensaje);
        }
    }
}
