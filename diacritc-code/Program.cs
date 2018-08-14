using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diacritc_code
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuário = new Usuário { Nome = "João da Silva", Endereço = "São Paulo - SP" };
            Console.Write($"Nome: {usuário.Nome}, Endereço: {usuário.Endereço}");
            Console.ReadKey();
        }

        public class Usuário
        {
            public string Nome { get; set; }
            public string Endereço { get; set; }
        }
    }
}
