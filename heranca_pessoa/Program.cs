using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca_pessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Fisica p1 = new Fisica();
            p1.Nome = "Marlon";
            p1.CPF = "093.221.645-91";

            Juridica j1 = new Juridica();
            j1.Nome = "Apple";
            j1.CNPJ = "09.12312.123/0001-3";

            System.Console.WriteLine(p1.mostrarNaTela() +"-"+ p1.CPF);
            System.Console.WriteLine(j1.mostrarNaTela() + "-" + j1.CNPJ);

            Console.ReadKey();
        }
    }
}
