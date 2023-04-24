using System;

namespace POOU3D_Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear la instancia
            Cuentas objeto1 = new Cuentas();
            objeto1.Personalizar();
            //Mandar llamar los métodos
            //int resultadoMetodo = objeto1.CalcularCosto(2, 150);
            //string resultadoMetodo1 = objeto1.CalcularCosto2("Jabón Zote rosa de barra 250 gramos", 5, 15);
            //Console.WriteLine(resultadoMetodo);
            //Console.WriteLine(resultadoMetodo1);

            bool resultadoMetodo = objeto1.LogIn();
            if (resultadoMetodo == true)
            {
                objeto1.AgregarEliminarCuenta();
            }
            /*
                + Evelin, Karina, Rocio
                - Nahomi, Nahomi, Felix 3,Abraham, 
                 Erick, UMR, Hugo, Hugo, Hugo, Hugo, Hugo, Hugo, Hugo, Hugo, Hugo, Hugo, Hugo
                - Taniz
             */
            Console.ReadKey();
        }
    }
}
