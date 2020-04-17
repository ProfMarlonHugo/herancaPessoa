using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca_pessoa
{
    class Pessoa
    {
        private string nome;

        /*get set*/
        public virtual string Nome
        {
            get { return nome; }
            set { nome = value;  }
        }

        public string mostrarNaTela()
        {
            return "Nome :" + Nome;
        }
    }
}
