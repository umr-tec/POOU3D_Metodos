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
            string user1 = "umr", user2, pass1 = "123", pass2;
            Console.WriteLine("Bienvenidos al sistema, si deseseas ingresar da de alta tus credecniales de acceso");
            Console.WriteLine("Ingresa tu usuario");
            user2 = Console.ReadLine();
            Console.WriteLine("Ingresa tu contraseña");
            pass2 = Console.ReadLine();
            if (user2 == user1 && pass2 == pass1)
            {
                objeto1.RFC = "GAH227882";
                objeto1.AgregarEliminarCuenta();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("YA TE EQUIVOCASTE JA JA JA.");

            }

            

            /*
                + Evelin, Karina, Rocio
                - Nahomi, Nahomi, Felix 2,Abraham, 
                 Erick, UMR, Hugo, Hugo, Hugo, Hugo, Hugo, Hugo, Hugo, Hugo, Hugo, Hugo, Hugo
             */
            Console.ReadKey();
        }
    }
}
