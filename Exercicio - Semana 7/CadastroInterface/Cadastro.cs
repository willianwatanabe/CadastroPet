using Exercicio.CadastroModel;
using Exercicio.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.CadastroInterface
{
    public class Cadastro : ICadastro
    {
        private static List<Cachorro> Cachorros = new List<Cachorro>();
        private static List<Gato> Gatos = new List<Gato>();
        public string AdicionarCachorro(Cachorro cachorro, Dono dono)
        {
            Validacao valida = new Validacao();
            if (Validacao.ValidaDados(cachorro, dono) == false)
                 Console.WriteLine($"Preencha todos os dados para seguir com o cadastro.");


                // Adição do cachorro
                Cachorros.Add(cachorro);





                // Envio do e-mail
                var mail = new MailMessage("comunicacao@petstore.com", Email);
                var client = new SmtpClient
                {
                    Port = 25,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.google.com"
                };

                mail.Subject = "Bem vindo a Pet Store";
                mail.Body = $"Parabéns! Seu Pet {cachorro.Nome} foi cadastrado com sucesso!";
                client.Send(mail);

                return "Cachorro cadastrado com sucesso!";
            
        
        }


        public string AdicionarGato(Gato gato, Dono dono)
        {
            if (gato.Nome == string.Empty || gato.Idade == 0 || gato.Raca == string.Empty)
                return "É obrigatório informar os dados do gato.";

            if (gato.NomeDoDono == string.Empty || gato.Email == string.Empty || gato.CPF == 0 || gato.Endereco == string.Empty)
                return "É obrigatório informar os dados do dono do gato.";

            // Adição do gato
            Gatos.Add(gato);

            // Envio de e-mail
            var mail = new MailMessage("comunicacao@petstore.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Bem vindo a Pet Store";
            mail.Body = $"Parabéns! Seu Pet {gato.Nome} foi cadastrado com sucesso!";
            client.Send(mail);

            return "Gato cadastrado com sucesso!";
        }
    }
}
