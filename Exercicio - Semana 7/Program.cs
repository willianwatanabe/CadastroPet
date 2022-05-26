using Exercicio.Cadastro;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Exercicio
{

    public static class Program
    {
        private static List<Cachorro> Cachorros = new List<Cachorro>();
        private static List<Gato> Gatos = new List<Gato>();

        static void Main(string[] args)
        {
            // Adição do cachorro
            Cachorro c = new Cachorro();
            var msg1 = c.AdicionarCachorro(new Cachorro
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

            if (msg1 == "Cachorro cadastrado com sucesso!")
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
    }

}
