using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.State
{
    public class CircuitBreaker
    {
        private ICircuitBreakerState _state;
        public int ConsecutiveFailures { get; private set; }
        public int FailureThreshold { get; }
        public TimeSpan ResetTimeout { get; }

        public CircuitBreaker(int failureThreshold, TimeSpan resetTimeout)
        {
            FailureThreshold = failureThreshold;
            ResetTimeout = resetTimeout;
            _state = new StateFechado(this);
        }

        public void GuardarFalhas()
        {
            ConsecutiveFailures++;
            _state.HouveFalha();
        }

        public void Reset()
        {
            ConsecutiveFailures = 0;
        }

        public void MoveToStateAberto()
        {
            _state = new StateAberto(this);
            _state.DefinirEstado();
        }

        public void MoveToStateSemiAberto()
        {
            _state = new StateSemiAberto(this);
            _state.DefinirEstado();
        }

        public void MoveToStateFechado()
        {
            _state = new StateFechado(this);
            _state.DefinirEstado();
        }

        public void Execute(Action action)
        {
            if (_state.PermitirChamadas())
            {
                try
                {
                    // Gerar um número aleatório entre 0 e 1
                    Random random = new Random();
                    double randomNumber = random.NextDouble();

                    // Verificar se a chamada foi bem-sucedida com base no limite
                    bool callSucceeded = randomNumber < 0.8; // Supondo que 0.8 seja o limite de sucesso

                    if (callSucceeded)
                    {
                        action();
                        _state.HouveSucesso();
                    }
                    else
                    {
                        throw new Exception("Falha simulada");
                    }
                }
                catch (Exception)
                {
                    _state.HouveFalha();
                    throw;
                }
            }
            else
            {
                Console.WriteLine("Circuit breaker está aberto. Solicitação negada.");
            }
        }
    }



}
