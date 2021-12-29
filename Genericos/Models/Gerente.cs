using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos.Models {
    public class Gerente : Pessoa {
        public string Funcao { get; set; }
        public decimal Salario { get; set; }

        public string DizFuncao() => $"Minha função é {Funcao}";
    }
}
