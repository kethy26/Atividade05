using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5
{
    class Program
    {
        static void Main(string[] args)
        {
            string sim;
            string endereco;
            string bairro;
            string cidade;
            string estado;
            string nome_cliente;
            string sobrenome;
            int viagens, quantidade;
            double soma;
            string cupom;
            string promoções;


            Console.WriteLine("Olá!!! Somos da agência Keithy turismo ");
            Console.WriteLine("Digite o seu nome");
            nome_cliente = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome");
            sobrenome = Console.ReadLine();

            Console.WriteLine($"Olá, Sr.{nome_cliente}, Vamos prosseguir com o seu cadastro?...Digite sim! ");
            sim = Console.ReadLine();

            Console.WriteLine("Queremos conhecer um pouco mais sobre você. Me fale seu endereço!");
            endereco = Console.ReadLine();

            Console.WriteLine(" Qual seu Estado?");
            estado = Console.ReadLine();

            Console.WriteLine("Sua cidade?");
            cidade = Console.ReadLine();

            Console.WriteLine("E agora por gentileza, seu bairro?");
            bairro = Console.ReadLine();

            Console.WriteLine($"O Sr.{sobrenome}, mora na cidade de {cidade} - {estado}, no endereço {endereco}, localizado no bairro {bairro}");

            Console.WriteLine($"Queremos saber quantas viagens o Sr.{nome_cliente} realizou ano passado?");
            viagens = (int)double.Parse(s: Console.ReadLine());

            Console.WriteLine("Você planejou quantas viagens para esse ano?");
            quantidade = (int)double.Parse(s: Console.ReadLine());

            soma = viagens + quantidade;


            Console.WriteLine($"Vemos aqui no sistema que o Sr.{nome_cliente} realizou no ano passado {viagens} viagens e no ano atual pretende viajar {quantidade} vezes, somando as viagens do ano anterior e o ano atual equivalem a {soma}");

            Console.WriteLine("\n\n");

            Console.WriteLine($"Dessa forma, faltam {soma - 10 } para completar 10 viagens no total ");

            Console.WriteLine($"A sua média de viagens é de {24 / soma}");



            Console.WriteLine($"No intervalo de meses de {12 / quantidade}");


            Console.WriteLine($"Digite seu cupom de desconto:");
            cupom = Console.ReadLine();

            if (cupom == "keithy10") 
            {

                Console.WriteLine("Parabéns você recebeu 10% de desconto na sua próxima viagem");

            }
            else
            {
                Console.WriteLine("cupom inválido");
            }

            
            Console.WriteLine("Você gostaria de receber promoções no seu e-mail?");
            promoções = Console.ReadLine();
             
            if (promoções == "sim")
            {

            Console.WriteLine($"Obrigada {nome_cliente} por se registrar, você receberá novos e-mails em breve);");

            }
            else
            {
            Console.WriteLine(" Se não ok,você não receberá e-mails de promoções.");
                
            }


            Console.WriteLine("Obrigado, e volte sempre!");

            

                Console.ReadKey();









            Console.ReadKey();



            
            





            







        }
    }
}
