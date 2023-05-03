using System;
using System.Threading;
using System.Speech.Synthesis;
using System.Drawing;

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

        }

        //Propiedad para cargar RFC
        public string RFC {
            set { rfcCLiente = value; }
        }

        //Metodo para crear o eliminar una cuenta 
        public bool AgregarEliminarCuenta() {
            //Variable de pulsacion de teclado
            bool resultado;
            ConsoleKeyInfo seleccionTecla;
            Console.WriteLine("Adminiatración de cuentas.");

            if (string.IsNullOrEmpty(rfcCLiente))//""
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Debes ingresar un RFC para dar de alta una cuenta.");
                resultado = false;
            }
            else
            {
                Console.WriteLine("Se va a agregar o eliminar una cuenta para el cliente con RFC: {0}.", rfcCLiente);
                Console.WriteLine("\n Selecciona la opción que desees ejecutar:");
                Console.WriteLine("\t Presiona 1: Sí deseas Agregar una cuenta al cliente");
                Console.WriteLine("\t Presiona 2: Sí deseas Eliminar la cuenta al cliente");
                seleccionTecla = Console.ReadKey();

                if (seleccionTecla.Key == ConsoleKey.D1 || seleccionTecla.Key == ConsoleKey.NumPad1)
                {
                    Console.WriteLine("\n Se va a agregar una cuenta:");
                    Console.WriteLine("\n \t Ingresa el número de cuenta.");
                    numeroCuenta = Console.ReadLine();
                    Console.WriteLine("\n \t ¿La cuenta tendrá algún saldo?.");
                    saldoActual = Convert.ToDouble( Console.ReadLine());
                }
                if (seleccionTecla.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("\n Se eliminará la cuenta del cliente que tiene el RFC: {0}",rfcCLiente);
                    numeroCuenta = string.Empty;                    
                }
                resultado = true;
            }
            return resultado;
        }

        //Método para login
        public bool LogIn() {
            string user1 = "umr", user2, pass1 = "123", pass2;
            bool resultado;

            Console.WriteLine("Bienvenidos al sistema, sí deseseas ingresar, da de alta tus credecniales de acceso.");
            Console.WriteLine("Ingresa tu usuario");
            user2 = Console.ReadLine();
            Console.WriteLine("Ingresa tu contraseña");
            pass2 = Console.ReadLine();
            if (user2 == user1 && pass2 == pass1)
            {
                Console.WriteLine("Accediendo al sistema.");
                Thread.Sleep(1000);
                Console.WriteLine("Accediendo al sistema..");
                Thread.Sleep(1000);
                Console.WriteLine("Accediendo al sistema...");
                Thread.Sleep(1000);
                Console.WriteLine("Accediendo al sistema....");

                SpeechSynthesizer speech = new SpeechSynthesizer();
                speech.Volume = 100;                
                speech.Speak("Ingresaste al sistema.");
                speech.Rate = 10;
                //varieble de retorno ↓
                resultado = true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("YA TE EQUIVOCASTE JA JA JA.");
                resultado = false;
            }
            return resultado;
        }

        //Metodo de menu de opciones
        public void Opciones() {
            //Variables para las opciones
            string opcion, sesion = "activo";
            Console.Clear();
            while (sesion == "activo")
            {                
                Console.WriteLine("Menú de inicio.");
                Console.WriteLine("Teclea la opción deseada:");
                Console.WriteLine("1. Ver información del cliente.");
                Console.WriteLine("2. Ver información cuenta del cliente.");
                Console.WriteLine("3. Agregar o eliminar cuenta.");
                Console.WriteLine("4. Salir.");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1"://mandar llamar un metodo de infomacion del cliente
                        Console.Clear();
                        Console.WriteLine("Información del cliente");
                        InformacionCliente();
                        break;
                    case "2":
                        //mandar llamar un metodo de infomacion de cuenta
                        Console.Clear();
                        InformacionCuenta();
                        break;
                    case "3":
                        Console.Clear();
                        AgregarEliminarCuenta();
                        break;
                    case "4":
                        Console.Clear();
                        sesion = Salir();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Error, selecciona una opción válida");
                        break;
                }
            }            
        }

        //metodo para ver informacion del cliente
        private void InformacionCliente() {
            Console.WriteLine("Bienvenido al módulo de información de cleintes. del banco {0}.", nombreBanco);
            Console.WriteLine("RFC del cliente: {0}.", rfcCLiente);
            Console.WriteLine("Nombre del cliente: {0} {1} {2}", nombreCliente, primerApellidoCliente, segundoApellidoCliente);
            Console.WriteLine("Datos de contacto del cliente: \n\t Teléfono Celular: {0}. \n\t Correo Electrónico: {1}.", numeroCelularCliente, emailCliente);
        }

        //metodo para ver informacion de LA CUENTA 
        private void InformacionCuenta() {
            Console.WriteLine("Bienvenido al módulo de información de cuentas bamcarias, del banco {0}.", nombreBanco);
            //Saber si hay una cuenta cargada o no lo hay
            if (string.IsNullOrEmpty(numeroCuenta))
            {
                //que no hay cuenta asignada
                Console.WriteLine("Debes dar de alta una cuenta bancaria.");
            }
            else
            {
                //si hay una cuenta que mostrar
                Console.WriteLine("El cliente con RFC: {0}, " +
                    "tiene una cuenta con número: {1} y " +
                    "tiene un saldo de: ${2}", rfcCLiente,numeroCuenta,saldoActual);
            }
        }

        //metodo para Salir
        private string Salir() {
            ConsoleKeyInfo keyInfo;
            string resultado = "activo";
            Console.WriteLine("¿Estás seguro que deseas salir del sistema?");
            Console.WriteLine("Presiona s si deseas salir. Presiona n si deseas continuar en el sistema");
            keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.S)
            {
                resultado = "nactivo";
            }
            if (keyInfo.Key == ConsoleKey.N)
            {
                resultado = "activo";
            }
            return resultado;
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

        public void Personalizar() {
            Console.Title = nombreBanco;            
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BufferHeight = 30;
            Console.BufferWidth = 1000;
            Console.WindowHeight = 10;
            Console.WindowWidth = 85;            
            Console.Clear();
        }


    }
}
