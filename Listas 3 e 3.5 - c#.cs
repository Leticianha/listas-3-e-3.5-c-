using System;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace Entrada
{
    class Projeto
    {
        static void Main(string[] args)
        {
            /*string nome;
            Console.WriteLine("Qual seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é " + nome);*/

            /*int idade;
            Console.WriteLine("Qual sua idade?");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine(idade);*/

            /*float altura;
            double salario;
            Console.WriteLine("Qual sua altura?");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual seu salário");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Sua altura é: " + altura + " e você ganha " +  salario);*/

            /*double n1 = double.Parse(Console.ReadLine());
            double n2;
            n2 = double.Parse(Console.ReadLine());
            double div = n1 / n2;
            double soma = n1 + n2;
            double mult = n1 * n2;
            double sub = n1 - n2;
            Console.WriteLine(div.ToString("F3"));
            Console.WriteLine(soma);
            Console.WriteLine(mult);
            Console.WriteLine(sub); */

            /*Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0 && numero < 100) {
                Console.WriteLine("O número é maior que 0 e menor que 100");
            }*/

            /*LISTA 3*/

            /*ATIVIDADE 1*/

            /*1 – Faça um programa que leia o número de um funcionário, seu
            número de horas trabalhadas, o valor que recebe por hora e calcule o
            salário desse funcionário.A seguir, mostre o número e o salário do
            funcionário.*/

            /*Console.WriteLine("ATIVIDA 1");
            int nFuncionario;
            Console.WriteLine("Insira o número do funcionário");
            nFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor que recebe por hora");
            int valorHoras = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o salário");
            float salario = float.Parse(Console.ReadLine());
            double salarioTotal = valorHoras * salario;
            Console.WriteLine("N funcionário: " + nFuncionario);
            Console.WriteLine("Salário: " + salarioTotal);*/

            /*ATIVIDADE 2*/

            /*2 - Fazer um programa para ler o código de uma peça 1, o número de
            peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o
            número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre
            o valor a ser pago.*/

            /*Console.WriteLine("ATIVIDADE 2");
            Console.WriteLine("Insira o código da peça 1");
            int pecaUm = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o preço unitário da peça 1");
            float precoPecaUm = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de peças 1 irá pegar");
            int quantPecaUm = int.Parse(Console.ReadLine());
            double totalPecaUm = quantPecaUm * precoPecaUm;
            Console.WriteLine("Valor a pagar: " + totalPecaUm);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Insira o código da peça 2");
            int pecaDois = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o preço unitário da peça 1");
            float precoPecaDois = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de peças 1 irá pegar");
            int quantPecaDois = int.Parse(Console.ReadLine());
            double totalPecaDois = quantPecaDois * precoPecaDois;
            Console.WriteLine("Valor a pagar: " + totalPecaDois);*/

            /*ATIVIDADE 3*/

            /*3 – Fazer um programa que leia três valores: A, B e C.Em seguida,
            calcule e mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            Fórmula: A* C / 2.0
            b) a área do círculo de raio C. (pi = 3.14159)
            Fórmula: 3.14159 * C * C
            c) a área do trapézio que tem A e B por bases e C por altura.
            Fórmula: (A + B) / 2.0 * C
            d) a área do quadrado que tem lado B.
            Fórmula: B* B
            e) a área do retângulo que tem lado A e altura B.
            Fórmula: A* B*/

            /*Console.WriteLine("ATIVIDADE 3");
            Console.WriteLine("Insira valor A");
            float valorA = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira valor B");
            float valorB = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira valor C");
            float valorC = float.Parse(Console.ReadLine());

            Console.WriteLine("-------- fórmula a --------");
            double formulaA = valorA * valorC / 2.0;
            Console.WriteLine("A área do triângulo retângulo que tem A por base e C por altura: " +  formulaA);
            Console.WriteLine("-------- fórmula b --------");
            double formulaB = 3.14159 * valorC * valorC;
            Console.WriteLine("A área do círculo de raio C (pi = 3.14159: " + formulaB);
            Console.WriteLine("-------- fórmula c --------");
            double formulaC = (valorA + valorB) / 2.0 * valorC;
            Console.WriteLine("A área do trapézio que tem A e B por bases e C por altura: " + formulaC);
            Console.WriteLine("-------- fórmula d --------");
            double formulaD = valorB * valorB;
            Console.WriteLine("A área do quadrado que tem lado B: " + formulaD);
            Console.WriteLine("-------- fórmula d --------");
            double formulaE = valorA * valorB;
            Console.WriteLine("A área do retângulo que tem lado A e altura B: " + formulaE);*/

            /*LISTA 3,5*/

            /*ATIVIDADE 1*/

            /*1 – Peça para o usuário informar um login e uma senha e verifique:
            -Se o login for igual a “admin” e a senha igual a “1234”, escreva, “Pode
            acessar”
            -Senão, escreva, “Login ou senha incorreto”*/

            /*Console.WriteLine("ATIVIDADE 1");
            Console.WriteLine("Login:");
            string login = Console.ReadLine();
            Console.WriteLine("Senha:");
            int senha = int.Parse(Console.ReadLine());
            if (login == "admin" && senha == 1234) {
                Console.WriteLine("Pode acessar");
            } else
            {
                Console.WriteLine("Login ou senha incorreto");
            };*/

            /*ATIVIDADE 2*/

            /*2 - Uma loja solicitou um sistema para verificar as blusas do estoque.
            - Se a quantidade for maior que 40, escreva, “ESTOQUE OK”
            -Se a quantidade for maior que 20 e menor ou igual a 40, escreva,
            “ATENÇÃO AO ESTOQUE”
            -Senão, escreva “ESTOQUE CRITICO”*/

            /*Console.WriteLine("ATIVIDADE 2");
            Console.WriteLine("Insira a quantidade");
            int quantidade = int.Parse(Console.ReadLine());
            if (quantidade < 20) {
                Console.WriteLine("ESTOQUE CRITICO");
            } else if ((quantidade >= 20) && (quantidade <= 40))
            {
                Console.WriteLine("ATENÇÃO AO ESTOQUE");
            } else
            {
                Console.WriteLine("ESTOQUE OK");
            }*/

            /*ATIVIDADE 3*/

            /*3 – Para conseguir o visto de outro país é solicitado informações sobre
            o usuário, como idade e salário, se a idade for maior ou igual a 18 e o
            salário for maior que R$2000, escreva, “PODE VIAJAR”, senão, escreva,
            “NÃO PODE VIAJAR”*/

            /*Console.WriteLine("ATIVIDADE 3");
            Console.WriteLine("Idade:");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Salário:");
            float salario = float.Parse(Console.ReadLine());
            if ((idade >= 18) && (salario > 2000))
            {
                Console.WriteLine("PODE VIAJAR");
            } else
            {
                Console.WriteLine("Não pode viajar");
            }*/

            /*ATIVIDADE 4*/

            /*4 – Os alunos de uma escola podem escolher uma aula diferente todo
            mês, para decidirem isso, é feito uma enquete.
            - Quem digitou o número 1 ou 2, optou pela aula de desenho e pintura,
            então, escreva “DESENHO E PINTURA”.
            -Quem digitou o número 3 ou 4, optou pela aula de discurso e debate,
            então, escreva “DISCURSO E DEBATE”.
            -Quem digitou outro número irá fazer aula de dança, então, escreva,
            “DANÇA”*/

            /*Console.WriteLine("ATIVIDADE 4");
            Console.WriteLine("Escolhe um número de [1 ou 2 para desenho e pintura], [3 ou 4 para discurso e debate] ou [outro número para dança]");
            int numero = int.Parse(Console.ReadLine());
            if ((numero == 1) || (numero == 2))
            {
                Console.WriteLine("DESENHO E PINTURA");
            } else if ((numero == 3) || (numero == 4))
            {
                Console.WriteLine("DISCURSO E DEBATE");
            } else
            {
                Console.WriteLine("DANÇA");
            }*/

            /*ATIVIDADE 5*/

            /*5 – O usuário irá digitar um número, verifique se:
            -Se o número digitado é positivo(maior que zero) e maior que 100 ao
            mesmo tempo, se sim, escreva “número especial”
            -Senão, escreva “fora do intervalo”*/

            /*Console.WriteLine("ATIVIDADE 5");
            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());
            if ((numero > 0) && (numero > 100))
            {
                Console.WriteLine("Número especial");
            }
            else
            {
                Console.WriteLine("Fora do intervalo");
            }*/
        }
    }
}
