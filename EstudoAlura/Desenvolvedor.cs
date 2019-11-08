using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoAlura
{
    class Desenvolvedor : Funcionario
    {
        public Desenvolvedor() : base(5000)
        {

        }

        public override double GetBonificao()
        {
            return 2.0 * base.GetBonificao();
        }
    }
}
