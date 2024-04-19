// See https://aka.ms/new-console-template for more information
using Calculadora.Command;

class Program
{
    static void Main(string[] args)
    {

        ICommand Adicao = new AdicaoCommand();
        Adicao.Execute();

    }
}
