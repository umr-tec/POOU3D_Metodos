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
            int resultadoMetodo = objeto1.CalcularCosto(2, 150);
            string resultadoMetodo1 = objeto1.CalcularCosto2("Jabón Zote rosa de barra 250 gramos", 5, 15);

            Console.WriteLine(resultadoMetodo);
            Console.WriteLine(resultadoMetodo1);

            //objeto1.AgregarEliminarCuenta();
            /*
                + Evelin, Karina
                - Nahomi, Nahomi, Felix, Abraham, 
            Erick, UMR, Hugo, HugoHugoHugoHugoHugoHugoHugoHugoHugoHugo
             */
            Console.ReadKey();
        }
    }
}
