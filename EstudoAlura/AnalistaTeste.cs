using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoAlura
{
    class AnalistaTeste : Funcionario
    {
        public AnalistaTeste() : base(4000){


        }

        public override double GetBonificao()
        {
            return 1.0 * base.GetBonificao();
        }
    }
}
