using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MarkoCoboEs1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            var contatto = new string[2];
            try
            {
                StreamReader sr = new StreamReader("rubrica.txt");
                linea = sr.ReadLine();
                contatto = linea.Split(',');
                do
                {
                    Console.WriteLine("NOME: " + contatto[0] + " COGNOME" + contatto[1] +   " NUMERO" + contatto[2]);
                    linea = sr.ReadLine();

                } while (linea != null);

                    sr.Close();
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception" + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block. ");
            }
        }
    }
}
