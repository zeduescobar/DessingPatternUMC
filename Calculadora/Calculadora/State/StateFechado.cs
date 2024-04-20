using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.State
{
    
    public class StateFechado : ICircuitBreakerState
    {
        private readonly CircuitBreaker _circuitBreaker;

        public StateFechado(CircuitBreaker circuitBreaker)
        {
            _circuitBreaker = circuitBreaker;
        }

        public void DefinirEstado()
        {
            Console.WriteLine("Circuit breaker está no state fechado.");
        }

        public void HouveFalha()
        {
            _circuitBreaker.GuardarFalhas();
            if (_circuitBreaker.ConsecutiveFailures >= _circuitBreaker.FailureThreshold)
            {
                _circuitBreaker.MoveToStateAberto();
            }
        }

        public void HouveSucesso()
        {
            _circuitBreaker.Reset();
        }

        public bool PermitirChamadas()
        {
            return true;
        }
    }
}
