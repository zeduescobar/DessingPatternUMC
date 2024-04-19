using System;
public class MultiplicacaoCommand : ICommand
{
    public void Execute()
    {
        double resultado;
        double Numero2;
        double Numero1;
        Console.WriteLine("Insira o primeiro numero para multiplicação: ");
        Numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira o segundo numero para multiplicação");
        Numero2 = double.Parse(Console.ReadLine());
        resultado = Numero1 * Numero2;
        Console.WriteLine("O resultado da multiplicação foi: " + resultado);
    }
}
}
