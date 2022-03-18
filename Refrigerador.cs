using System;
using System.Threading;

namespace EjemplosInterfaces
{
    class Refrigerador:LineaBlanca,IEncender
    {
        public Refrigerador()
        {
            Marca = "Mabe";
            Modelo = "2021";
            Console.WriteLine("Marca: {0} ", Marca);
            Console.WriteLine("Modelo: {0} ", Modelo);
            MostrarEnDisplay();
        }

        public void MostrarEnDisplay()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Refrigerador conectado a la corriente");
        }
    }
}
