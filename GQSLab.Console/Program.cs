using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GQSLab.Console;

namespace GQSLab.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Programa iniciado...\n");

            Depuracao.ExecutaExemploDebug();

            Depuracao.ExecutaExemploExcecoes();

            System.Console.WriteLine("\nPrograma em execução...");
            System.Console.ReadKey();
        }
    }
}
