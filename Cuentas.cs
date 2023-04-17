using System;

namespace POOU3D_Ejemplo1
{
    class Cuentas
    {
        //Campos - banco - cuenta - persona
        string nombreCliente, primerApellidoCliente, segundoApellidoCliente;
        string curpCliente, rfcCLiente, numeroCelularCliente, emailCliente;
        string numeroCuenta;
        DateTime fechaRegistroCliente;
        double saldoActual, saldoAnterior;
        const string nombreBanco = "ChucanflurBank";

        public Cuentas(string nombreCliente, string primerApellidoCliente, string segundoApellidoCliente, string rfcCLiente, string numeroCelularCliente, string emailCliente)
        {
            this.nombreCliente = nombreCliente;
            this.primerApellidoCliente = primerApellidoCliente;
            this.segundoApellidoCliente = segundoApellidoCliente;
            this.rfcCLiente = rfcCLiente;
            this.numeroCelularCliente = numeroCelularCliente;
            this.emailCliente = emailCliente;
        }

        public Cuentas()
        {
            Console.Title = nombreBanco;
        }

        //Metodo para crear o eliminar una cuenta 
        public bool AgregarEliminarCuenta() {
            //Variable de pulsacion de teclado
            ConsoleKeyInfo seleccionTecla;
            Console.WriteLine("Adminiatración de cuentas.");

            if (string.IsNullOrEmpty(rfcCLiente))//""
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Debes ingresar un RFC para dar de alta una cuenta.");
            }
            else
            {
                Console.WriteLine("Se va a agregar o eliminar una cuenta para el cliente con RFC: {0}.", rfcCLiente);
                Console.WriteLine("\n Selecciona la opción que desees ejecutar:");
                Console.WriteLine("\t Presiona 1: Si deseas agregar una cuenta al cliente");
                Console.WriteLine("\t Presiona 2: Si deseas Eliminar la cuenta al cliente");
                seleccionTecla = Console.ReadKey();

                if (seleccionTecla.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Presionastye el número 1");
                }
                if (seleccionTecla.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("Presionastye el número 2");
                }
            }                           
            return false;
        }


        //Miembro de tipo metodo
        public int CalcularCosto( int cantidadArticulos, int costoArticulos ) {
            return cantidadArticulos*costoArticulos;
        }
        public string CalcularCosto2(string nombreArticulo, int cantidadArticulos, int costoArticulos) {
            int resultado = cantidadArticulos * costoArticulos;
            return nombreArticulo +" Total: $"+ resultado.ToString();
        }
        public void CalcularCosto1() {
            Console.WriteLine("0");
        }



    }
}
