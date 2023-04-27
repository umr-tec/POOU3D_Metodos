﻿using System;
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
                        break;
                    case "2":
                        //mandar llamar un metodo de infomacion de cuenta
                        Console.Clear();
                        Console.WriteLine("Información de la cuenta");
                        break;
                    case "3":
                        Console.Clear();
                        AgregarEliminarCuenta();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Error, selecciona una opción válida");
                        break;
                }
            }            
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
