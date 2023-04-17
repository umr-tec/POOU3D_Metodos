using System;

namespace POOU3D_Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear la instancia
            Cuentas objeto1 = new Cuentas();
            //Mandar llamar los métodos
            Console.WriteLine(objeto1.CalcularCosto2("Marcador TOP", 9, 10));
            Console.WriteLine( objeto1.CalcularCosto(2,900));
            objeto1.CalcularCosto1();

            objeto1.AgregarEliminarCuenta();            
            /*
                +
                - Nahomi
             */
            Console.ReadKey();
        }
    }
}
