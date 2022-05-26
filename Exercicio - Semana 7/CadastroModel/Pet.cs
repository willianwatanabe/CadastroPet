using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.CadastroModel
{
    public abstract class Pet
    {
        public int Identificacao { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Raca { get; set; }
        public Dono Dono { get; set; }
    }
}



