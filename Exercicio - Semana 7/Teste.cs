using Exercicio.Cadastro;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Exercicio
{

    public static class Teste
    {
        private static List<Cachorro> Cachorros = new List<Cachorro>();
        private static List<Gato> Gatos = new List<Gato>();

        static void Main(string[] args)
        {
            // Adição do cachorro
            Cachorro cachorro = new Cachorro();
            var cadastro = cachorro.AdicionarCachorro(new Cachorro
            {
                Identificacao = 1,
                Nome = "Rex",
                Raca = "Tomba lata",
                Idade = 2,
                CPF = 99999999,
                Email = "edu@gmail.com",
                Endereco = "Rua do Cobre, 768",
                NomeDoDono = "Edu"
            });

            if (cadastro == true)
            {
                Console.WriteLine($"O cadastro do cachorro {c.Nome} foi realizado com sucesso!");
            }

            // Adição do gato
            Gato g = new Gato();
            var msg2 = g.AdicionarGato(new Gato
            {
                Identificacao = 1,
                Nome = "Miau",
                Raca = "Siames",
                Idade = 5,
                CPF = 88888888,
                Email = "carlos@gmail.com",
                Endereco = "Rua da Prata, 55",
                NomeDoDono = "Carlos"
            });

            if (msg2 == "Gato cadastrado com sucesso!")
            {
                Console.WriteLine($"O cadastro do gato {c.Nome} foi realizado com sucesso!");
            }
        }




        public bool AdicionarCachorro(Cachorro cachorro)
        {
            if (cachorro.Nome == string.Empty || cachorro.Idade == 0 || cachorro.Raca == string.Empty)
                return "É obrigatório informar os dados do cachorro.";

            if (cachorro.NomeDoDono == string.Empty || cachorro.Email == string.Empty || cachorro.CPF == 0 || cachorro.Endereco == string.Empty)
                return "É obrigatório informar os dados do dono do cachorro.";

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

            return true;
        }
    }


    public string AdicionarGato(Gato gato)
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
}
