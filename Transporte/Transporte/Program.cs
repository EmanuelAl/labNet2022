using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<TransportePublico> lista = new List<TransportePublico>();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"indique la cantidad de pasajeros para el omnibus {i}");
                lista.Add(new Omnibus(Convert.ToInt32(Console.ReadLine())));
            }
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"indique la cantidad de pasajeros para el taxi {i}");
                lista.Add(new Taxi(Convert.ToInt32(Console.ReadLine())));
            }   
            
            for (int i = 0; i < lista.Count; i++)
            {
                
                if (i >= 0 && i <= 4)
                { 
                
                    Console.WriteLine($"Omnibus {i+1}: " + lista[i].MostrarPasajeros());
                }
                if (i > 4)
                {
                    
                    Console.WriteLine($"Taxi {i-4}: " + lista[i].MostrarPasajeros());
                    
                } 
            }
            
            Console.ReadKey();

        }
    }
}
