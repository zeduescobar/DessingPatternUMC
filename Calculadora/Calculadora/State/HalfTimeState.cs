using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.State
{
    public class StateSemiAberto : ICircuitBreakerState
    {
        private readonly CircuitBreaker _circuitBreaker;

        public StateSemiAberto(CircuitBreaker circuitBreaker)
        {
            _circuitBreaker = circuitBreaker;
        }

        public void DefinirEstado()
        {
            Console.WriteLine("Circuit breaker está no estado semi-aberto.");
        }

        public void HouveFalha()
        {
            _circuitBreaker.MoveToStateAberto();
        }

        public void HouveSucesso()
        {
            _circuitBreaker.MoveToStateFechado();
        }

        public bool PermitirChamadas()
        {
            return true;
        }
    }
}
