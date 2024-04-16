using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastoMorador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resp;
            double valor = 0;
            double total = 0;

            do
            {
                Console.WriteLine("Despesa: ");
                string despesa = Console.ReadLine();

                Console.WriteLine("Informe o valor da despesa: ");
                valor = double.Parse(Console.ReadLine());

                Console.WriteLine("Deseja inserir uma nova despesa? ");
                resp = Console.ReadLine().ToUpper();

                _ = valor;
                _ = total;
                total = total + valor;

            }
            while (resp == "S");

            Console.Clear();

            Console.WriteLine("Valor do gasto total: " + total);

            Console.WriteLine("Informe o número de moradores da casa: ");
            double moradores = double.Parse(Console.ReadLine());

            double media = total / moradores;

            Console.WriteLine("Valor gasto médio por morador: " + media);

            Console.ReadKey();
        }
    }
}
