using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class Logic
    {


        public static void Metodo()
        {
			try
			{
				int num = 10;
				int num2 = 0;
				int result = num / num2;
			}
			catch (Exception ex)
			{

				throw ex;

			}
			
        }

		public static void MetodoConCustomException()
		{
			throw new CustomException();
		}
    }
}
