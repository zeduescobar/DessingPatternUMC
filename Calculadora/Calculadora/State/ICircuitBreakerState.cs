using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.State
{
    using System;

    
    public interface ICircuitBreakerState
    {
        void DefinirEstado();
        void HouveFalha();
        void HouveSucesso();
        bool PermitirChamadas();
    }
}
