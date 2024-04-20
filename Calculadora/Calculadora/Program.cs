using Calculadora.Command;
using Calculadora.State;
using System.Windows.Input;
using ICommand = Calculadora.Command.ICommand;



    class Program
    {
        static void Main(string[] args)
        {
            // Criar um circuit breaker com um limite de falha de 3 e um tempo de reset de 1 minuto
            CircuitBreaker circuitBreaker = new CircuitBreaker(failureThreshold: 3, resetTimeout: TimeSpan.FromMinutes(1));

            // Realizar uma série de chamadas simuladas
            for (int i = 1; i <= 10; i++)
            {
                try
                {
                    // Chamar a lógica que pode falhar usando o circuit breaker
                    circuitBreaker.Execute(() =>
                    {
                        Console.WriteLine($"Chamada {i}: Bem-sucedida");
                    });
                }
                catch (Exception)
                {
                    Console.WriteLine($"Chamada {i}: Falhou");
                }
            }
        }
    }

