using System;

public class DivisaoCommand : ICommand
{
    public void Execute()
    {
        double resultado;
        double Numero2;
        double Numero1;
        Console.WriteLine("Insira o primeiro numero para divisão: ");
        Numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira o segundo numero para divisão");
        Numero2 = double.Parse(Console.ReadLine());
        resultado = Numero1 / Numero2;
        Console.WriteLine("O resultado da divisão foi: " + resultado);
    }
}
}
