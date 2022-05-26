using Exercicio.CadastroModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.CadastroInterface
{
    public interface ICadastro
    {
        public string AdicionarGato(Gato gato, Dono dono);

        public string AdicionarCachorro(Cachorro cachorro, Dono dono);

    }
}
