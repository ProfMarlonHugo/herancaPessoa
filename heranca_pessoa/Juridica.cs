using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca_pessoa
{
    class Juridica : Pessoa
    {
        private string cnpj;

        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public override string Nome
        {
            get { return base.Nome; }
            set { base.Nome = value; }
        }

    }
}
