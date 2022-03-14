﻿using System;
using System.Globalization;

namespace BeeCrowd___C_
{
    class Program
    {
        static void Desafio2()
        {
            /*
            A fórmula para calcular a área de uma circunferência é: area = π . raio2. Considerando 
            para este problema que π = 3.14159:
            - Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.
            Entrada
            A entrada contém um valor de ponto flutuante (dupla precisão), no caso, a variável raio.
            Saída
            Apresentar a mensagem "A=" seguido pelo valor da variável area, conforme exemplo abaixo, 
            com 4 casas após o ponto decimal. Utilize variáveis de dupla precisão (double). 
            */

        NumberFormatInfo nfi = (NumberFormatInfo)
        CultureInfo.InvariantCulture.NumberFormat.Clone();
        nfi.NumberGroupSeparator = ".";
         double n = 3.14159;
         double raio = double.Parse(Console.ReadLine());
         double area;
         
         raio = Math.Pow(raio, 2);
         area = n * raio;
        
         Console.WriteLine("A="+ area.ToString("F4", nfi));

        }
        static void Desafio5()
        {
            /*
            Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de 
            um aluno. A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota 
            B tem peso 7.5 (A soma dos pesos portanto é 11). Assuma que cada nota pode ir de 0 até 
            10.0, sempre com uma casa decimal.
            Entrada
            O arquivo de entrada contém 2 valores com uma casa decimal cada um.
            Saída
            Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 5 dígitos após
            o ponto decimal e com um espaço em branco antes e depois da igualdade. Utilize variáveis
            de dupla precisão (double) e como todos os problemas, não esqueça de imprimir o fim de 
            linha após o resultado, caso contrário, você receberá "Presentation Error"
            */
        NumberFormatInfo nfi = (NumberFormatInfo)
        CultureInfo.InvariantCulture.NumberFormat.Clone();
        nfi.NumberGroupSeparator = ".";

        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double MEDIA = 0;
        MEDIA = (A * 3.5) + (B * 7.5);
        MEDIA = MEDIA / 11;
        Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", nfi));
        }
        static void Desafio6()
        {
            /*
            Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. A seguir,
            calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota 
            C tem peso 5. Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
            Entrada
            O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).
            Saída
            Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 1 dígito após
            o ponto decimal e com um espaço em branco antes e depois da igualdade.
            */
        NumberFormatInfo nfi = (NumberFormatInfo)
        CultureInfo.InvariantCulture.NumberFormat.Clone();
        nfi.NumberGroupSeparator = ".";
        
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());
        double MEDIA = 0;
        MEDIA = (A * 2)  + (B * 3) + (C * 5);
        MEDIA = MEDIA / 10;
        Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", nfi));
        }
        
        static void Desafio7()
        {
            /*Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A 
            e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
            Entrada
            O arquivo de entrada contém 4 valores inteiros.
            */
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());
        int diferenca = 0;
        
        diferenca = (A * B) - (C * D);
        Console.WriteLine("DIFERENCA = "+ diferenca);
        }
        static void Main(string[] args)
        {
            
        }
    }
}
