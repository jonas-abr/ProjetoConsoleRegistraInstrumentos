using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    //public class Pessoa
    //{
    //    public string Nome { get; set; }
    //    public string Sobrenome { get; set; }
    //    public int Idade { get; set; }
    //    public string Profissao { get; set; }
    //}
    public class Program
    {
        static void Main(string[] args)
        {
            //List<Pessoa> pessoas = new List<Pessoa>();
            //Pessoa pessoa = new Pessoa();

            //pessoa.Nome = "Jonas";
            //pessoa.Sobrenome = "Abreu";
            //pessoa.Idade = 21;
            //pessoa.Profissao = "Desenvolvedor de sistemas";
            //pessoas.Add(pessoa);

            //pessoa = new Pessoa();
            //pessoa.Nome = "Victor";
            //pessoa.Sobrenome = "Abreu";
            //pessoa.Idade= 22;
            //pessoa.Profissao = "Dev Back End";
            //pessoas.Add(pessoa);


            //var consultaPessoa = from pe in pessoas
            //                      select new {pe.Nome, pe.Sobrenome, pe.Idade, pe.Profissao };

            //foreach (var p in consultaPessoa)
            //{
            //    Console.WriteLine("nome={0}, sobrenome={1}, idade={2}, profissao={3} ", p.Nome, p.Sobrenome, p.Idade, p.Profissao);
            //}

            //List<string> Nomes = new List<string>();

            // Métodos de Strings: 

            // Entradas -> instrumentos musicais
            // Definir naipes de instrumentos
            // Processamento:
            // Passo 1 -> calcular a quantidade de cada naipe
            // Saída -> mostrar ao usuário as informações. 

            string opcao;

            do
            {
                Console.WriteLine(MostraCabecalho());
                Console.WriteLine(MostraMenu());
                opcao = LeOpcaoMenu();
                ProcessaOpcaoMenu(opcao);
                PressionaTecla();
                Console.Clear();
            }
            while (opcao != "6");
        }

        private static void PressionaTecla()
        {
            throw new NotImplementedException();
        }

        public static void ProcessaOpcaoMenu(string opcao)
        {
            switch(opcao)
            {
                case "1":
                    RegistrarCordas();
                    break;
                case "2":
                    RegistrarSaidaInstrumento();
                    break;
                case"3":
                    RegistrarMetais();
                    break;
                case"4":
                    Console.WriteLine("Obrigado por utilizar o programa");
                    break;
                default:
                    Console.WriteLine("opção de menu inválida");
                    break;
            }
        }

        private static void RegistrarMetais()
        {
            throw new NotImplementedException();
        }

        private static void RegistrarSaidaInstrumento()
        {
            throw new NotImplementedException();
        }

        public static void RegistrarInstrumento()
        {
            Console.Clear();
            Console.WriteLine("Registro de instrumentos");
            Console.WriteLine("Tipo do instrumento (1 - cordas; 2 - madeiras; 3 - metais; )");
            string tipo = Console.ReadLine();

            switch (tipo)
            {
                case "1":
                    RegistrarCordas();
                    break;
                case "2":
                    RegistrarMadeiras();
                    break;
                case "3":
                    RegistrarMetais();
                    break;
                default:
                    Console.WriteLine("tipo de instrumento inválido");
                    PressionaTecla();
                    break;
            }
        }

        private static void RegistrarMadeiras()
        {
            throw new NotImplementedException();
        }

        public static void RegistrarCordas()
        {
            Console.WriteLine("Dados de corda");
        }

        public static string LeOpcaoMenu()
        {
            string opcao;
            Console.Write("opção desejada: ");
            opcao = Console.ReadLine();
            return opcao;
        }

        public static string MostraMenu()
        {
            string menu = "Escolha uma opção:\n" +
            "1 - Registrar instrumentos\n" +
            "2 - Registrar saídas de instrumentos\n" +
            "3 - Mostrar instrumentos\n" + 
            "4 - Sair do programa\n";
            return menu;
        }

        public static string MostraCabecalho()
        {
            return "Controle de instrumentos musicais";
        }
    }
}
