using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class Calculadora
    {
        public static void Dividir(int num = 1 )//OPCION 1
        {
			try
			{
				int result = 0;
                Console.WriteLine("A continuacion ingrese un numero");// <--------------
                num = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Esto va a romper");
                result = num / 0;
				
			}
			catch (Exception ex)
			{
				//throw ex;
                Console.WriteLine("mensaje de la excepcion: "+ ex.Message);
            }
			finally
			{
				Console.WriteLine("Paso por el finally");
			}
        }

		public static void Dividir() //OPCION 2
		{

            try
            {
                int result = 0;
                int num1 = 0;
                int num2 = 0;

                Console.WriteLine("A continuacion ingrese el valor del primer numero");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A continuacion ingrese el valor del segundo numero");
                num2 = Convert.ToInt32(Console.ReadLine());

                result = num1 / num2;

                Console.WriteLine("el resultado es "+ result);

                //Console.WriteLine("Esto va a romper");


            }
            catch (System.FormatException)
            {
                Console.WriteLine("Seguro Ingreso una letra o no ingreso nada!!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Valor fuera de rango!");
            }
            catch (DivideByZeroException ex) 
            {

                Console.WriteLine("Solo Chuck Norris divide por cero!");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("mensaje de la excepcion: " + ex.Message);
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("mensaje de la excepcion: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Paso por el finally");
            }

        }
    }
}
