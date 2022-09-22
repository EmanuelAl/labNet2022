using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opt = 0;
            do
            {
                
                try
                {
                
                    Console.WriteLine("Eliga una opcion:");
                    Console.WriteLine("1- Ejercicio 1");
                    Console.WriteLine("2- Ejercicio 2");
                    Console.WriteLine("3- Ejercicio 3");
                    Console.WriteLine("4- Ejercicio 4");
                    Console.WriteLine("5- salir");

                     opt = Convert.ToInt32(Console.ReadLine());

                    switch (opt)
                    {
                        case 1:
                            //OPCION 1 
                            try
                            {
                                Calculadora.Dividir(5);
                            }
                            catch
                            {
                                Console.WriteLine("error");
                            }

                            Console.WriteLine("fin del programa, operacion terminada");

                            //FIN ------ OPCION 1
                            break;
                        case 2:
                            //OPCION 2

                            try
                            {
                                //Calculadora.Dividir(5,0);
                                Calculadora.Dividir();
                            }
                            catch
                            {
                                Console.WriteLine("error");
                            }

                            Console.WriteLine("fin del programa, operacion terminada");
                            //FIN--------------OPCION 2

                            break;
                        case 3:
                            //OPCION 3

                            try
                            {
                                Logic.Metodo();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                //Console.WriteLine(ex.StackTrace);
                                Console.WriteLine(ex.ToString());
                                //Console.WriteLine(ex.InnerException);
                            }
                            Console.WriteLine("fin del programa, operacion terminada");
                            //FIN--------------OPCION 3
                            break;
                        case 4:
                            //OPCION 4
                            try
                            {
                                Logic.MetodoConCustomException();
                            }
                            catch (CustomException ex)
                            {
                                Console.WriteLine($"se captura: {ex.Message}");

                            }
                            finally
                            {
                                Console.WriteLine("fin del programa, operacion terminada");
                            }
                            //FIN--------------OPCION 4
                            break;
                        case 5:
                            Console.WriteLine("Cerrando programa");
                            break;
                        default:
                            Console.WriteLine("opcion incorrecta");
                            break;
                    }
                    Console.ReadKey();
                 }

                 catch (FormatException ex)
                 {

                     Console.WriteLine("Debe colocar un numero, NO una letra o nada!");
                 }
                 Console.Clear();
                 
            } while (opt != 5);


        }
    }
}
