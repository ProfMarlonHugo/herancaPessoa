using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca_pessoa
{
    class Fisica : Pessoa
    {
        private string cpf;

        /*novos metodos*/
        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        /*sobreposicao*/
        public override string Nome
        {
            get { return Nome;  }
            set { Nome = value;  }
        }
    }
}
