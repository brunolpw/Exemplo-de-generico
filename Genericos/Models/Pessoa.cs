using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos.Models {
    public class Pessoa {
        public int Id { get; set; } 
        public string Nome { get; set; }

        public string DizNome(string nome) => $"Meu nome é {nome ?? Nome}";

        public bool ComparaNome(string nome, StringComparison comparison) => 
            string.Equals(nome, Nome, comparison);
    }
}
