using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoAlura
{
     class  Funcionario
    {
        public string nome { get; set; }
        public double Salario { get; protected set; }

        public static int totalFuncionario { get; private set; }
        public Funcionario (double salario){

            Salario = salario;
            
            totalFuncionario++;

        }
       

        public virtual double GetBonificao()
        {
            return Salario ;
        }

        public virtual void AumentoSalario()
        {
            Salario *= 1.1;
        }

    }
}
