using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Command
{
    public class SubtracaoCommand : ICommand
    {
        public void Execute()
        {
            double resultado;
            double Numero2;
            double Numero1;
            Console.WriteLine("Insira o primeiro numero para subtracao: ");
            Numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero para subtracao");
            Numero2 = double.Parse(Console.ReadLine());
            resultado = Numero1 - Numero2;
            Console.WriteLine("O resultado da subtracao foi: " + resultado);
        }
    }
}
