using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.State
{
    public class StateAberto : ICircuitBreakerState
    {
        private readonly CircuitBreaker _circuitBreaker;
        private readonly DateTime _retryTime;

        public StateAberto(CircuitBreaker circuitBreaker)
        {
            _circuitBreaker = circuitBreaker;
            _retryTime = DateTime.UtcNow.Add(_circuitBreaker.ResetTimeout);
        }

        public void DefinirEstado()
        {
            Console.WriteLine("Circuit breaker está no estado aberto. Tentando novamente: " + _retryTime);
        }

        public void HouveFalha()
        {
            if (DateTime.UtcNow >= _retryTime)
            {
                _circuitBreaker.MoveToStateSemiAberto();
            }
        }

        public void HouveSucesso()
        {
            _circuitBreaker.MoveToStateFechado();
        }

        public bool PermitirChamadas()
        {
            return false;
        }
    }
}
