using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Command
{


    public class AdicaoCommand : ICommand
    {
        public void Execute()
        {
            double resultado;
            double Numero2;
            double Numero1;
            Console.WriteLine("Insira o primeiro numero para soma: ");
            Numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero para soma");
            Numero2 = double.Parse(Console.ReadLine());
            resultado = Numero1 + Numero2;
            Console.WriteLine("O resultado da soma foi: " + resultado);
        }
    }
}


