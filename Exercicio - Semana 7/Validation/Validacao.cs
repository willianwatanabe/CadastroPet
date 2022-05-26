using Exercicio.CadastroModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Validation
{
    public class Validacao
    {
        public static bool ValidaDados(Pet pet, Dono dono)
        {
            bool result = true;

            if (String.IsNullOrWhiteSpace(pet.Nome) || pet.Idade == 0 || String.IsNullOrWhiteSpace(pet.Raca) ||
                String.IsNullOrWhiteSpace(dono.NomeDoDono) || String.IsNullOrWhiteSpace(dono.Email) ||
                dono.CPF == 0 || String.IsNullOrWhiteSpace(dono.Endereco))
                result = false;

            return result;

        }
    }
}
