using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoAlura
{
    class GerenciadorBonificacao
    {
        public double totalBonficacao;

        public void somaBonificacao(Funcionario funcionario)
        {
            totalBonficacao += funcionario.GetBonificao();
        }

        public double GetTotalBonificao()
        {
            return totalBonficacao;
        }


    }
}
