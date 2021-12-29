using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos.Models {
    public class Cliente : Pessoa {
        public string Funcao { get; set; }

        public string DizFuncao() => $"Minha função é {Funcao}";
    }
}
