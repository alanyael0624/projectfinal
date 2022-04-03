using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace projectfinal
{
    internal class Program
    {
        private static double a;

        private static void Main(string[] args, string contraseña)
         }

    static void Main(string[] args, string contraseña, double Clabeinter,)
    {
        double Clabeinterbancaria = 0, ; string Nombre = 0;
        int transfer = 0; int op = 0; int retsintarjet;
        double Disponible = 52000, cantidadtr = 0;
        string usuario;
        string contra;

        Transferencia Bancamovil = new Appmobile();
        Bancamovil.bancoreceptor();
        Bancamovil.Clabeinter();
        Bancamovil.nombrereceptor();
        Console.WriteLine("Bienvenido a tu banca movil");
        Console.ReadLine();

        string Usuario = null;
        while (Usuario != "usuario" || contraseña != "contraseña")
            Console.Clear();
        Console.WriteLine("------ BUENAS-TARDES -------");

        Console.Write("ingrese su usuario");
        usuario = Console.ReadLine();
        Console.Write("ingrese su contraseña");
        contraseña = Console.ReadLine();
        try
        {
            if (usuario.Equals("usuario") && contraseña.Equals("contraseña"))
            {
                Console.WriteLine("----BIENVENIDO----");
            }
            else
            {
                throw new ExcepcionBanca("Datos incorrectos");

            }

        }
        catch (Exception Ex)
        {
            Console.WriteLine("Mensaje excepcion: {0}", Ex.Message);
            Console.WriteLine("Enciende la ubicacion de su dispositivo ");
            Console.WriteLine("Permitir permisos de ubicacion y datos");
            Console.WriteLine("NO PERMITIR");
            return;
        }
        do
        {
            do
            {
                Console.WriteLine(" Hola Juan, Buenas Tardes");
                Console.WriteLine("\nSu saldo actual es : S/{0}", Disponible);
                Console.WriteLine("0.- Transferir a cuentas HEY");
                Console.WriteLine("1.- Transfeir a otros bancos");
                Console.WriteLine("2.-Retiro sin tarjeta");
                Console.WriteLine("3.-pagar servicios");
                Console.WriteLine(("4.-Pagar TDC"));
                Console.WriteLine("5.- Ofertas");
                Console.WriteLine("6.- Salir");


                Console.Write("Ingrese su operacion : ");
                op = int.Parse(Console.ReadLine());
                try
                {
                    if (op < 0 || op > 6) ;
                    switch (op)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("----TRANSFERENCIA A OTROS BANCOS-----")

                                ; Console.Write("");
                            Clabeinter = Console.ReadLine();
                            Console.Write("");
                            cantidadtr = int.Parse(Console.ReadLine());
                            double a = (Disponible - cantidadtr);
                            try
                            {
                                if ()
                                {
                                    Console.WriteLine("Transferenica exitosa: S/.{0}", cantidadtr);
                                    Disponible = (Disponible - cantidadtr);
                                    StreamWriter Comprobante;
                                    string nombreFichero = "C:\\Users\\Alan\\Documents\\ficheros\\Comprobantetransfer.txt;";
                                    Comprobante = File.AppendText(nombreFichero);
                                    Comprobante.WriteLine("Transferencia exitosa:" + cantidadtr);
                                    Comprobante.WriteLine(" A: " + Clabeinter);
                                    Comprobante.WriteLine("Regresar");
                                    Comprobante.Close();


                                }
                                else
                                {
                                    Console.WriteLine("---------------------");
                                    throw new ExcepcionBanca("No se puede realizar la operacion, ya que excede a la cantidad de dinero disponible en su cuenta *********0405");

                                }

                            }
                            catch (Exception Ex)
                            {
                                Console.WriteLine("Mensaje excepcion: {0}");
                            }
                            string message = Ex.Message; ;
                    }
                    Console.WriteLine("\n\n Su saldo actual es S/ {0} ", Disponible);
                    try
                    {
                        if (retsintarjet > 0 && retsintarjet <= 8500)
                        {
                            Console.WriteLine("su retiro sin tarjeta de 8500 MXN se realizo con exito");
                            Console.WriteLine("su clave e retiro es: 1111 5555 8787 9495");
                            Disponible = (Disponible - retsintarjet);
                            StreamWriter Comprobante;
                            string nombreFichero = "C:\\Users\\Alan\\Documents\\ficheros\\ComprobanteRetiro.txt";
                            Comprobante = File.AppendText(nombreFichero);
                            Comprobante.WriteLine("Se retiro con exito 8500 MXN de la cuenta : ***********0405 ");
                            Comprobante.Close();


                        }
                    
                    if (op == 1)
                    {
                  
                fin:

                final:

                    Console.Write("Gracias por usar el app, hasta luego");
                    Console.ReadLine();






                }
                }}

            









        

    
    


    
    