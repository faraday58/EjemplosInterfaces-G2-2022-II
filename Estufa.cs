using System;
using System.Threading;
namespace EjemplosInterfaces
{
    class Estufa:LineaBlanca,IEncender
    {
        public Estufa()
        {
            Marca = "";
            Modelo = "";

            Console.WriteLine("Marca: {0} ", Marca);
            Console.WriteLine("Modelo: {0} ", Modelo);            
        }

        void IEncender.MostrarEnDisplay()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Encendiendo quemadores");            
        }
    }
}
