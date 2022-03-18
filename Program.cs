using System;

namespace EjemplosInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Forma Explícita de una interfaz
            */
            Estufa miEstufa = new Estufa(); //Instancia de la clase
            IEncender iencender = miEstufa; // Conectar  la estufa  con un tubo flexible a una fuente de gas
            iencender.MostrarEnDisplay(); //Abrir la llave del gas


            Refrigerador refrigerador = new Refrigerador();


            Console.ReadLine();


        }
    }
}
