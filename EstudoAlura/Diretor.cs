using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoAlura
{
    class Diretor : Funcionario
    {
        public Diretor () : base(3000)
        {

        }

        public override double GetBonificao()
        {
            return 3.0 * base.GetBonificao();
        }

        public override void AumentoSalario()
        {
            Salario = base.Salario;
        }

    }
}
