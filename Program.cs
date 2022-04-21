using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Collections;

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
        
        static void Desafio8()
        {
        /*
        Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que 
        recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do 
        funcionário, com duas casas decimais.
        Entrada
        O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o 
        número, quantidade de horas trabalhadas e o valor que o funcionário recebe por hora trabalhada, 
        respectivamente.
        Saída
        Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço em branco antes 
        e depois da igualdade. No caso do salário, também deve haver um espaço em branco após o $.
        */
        NumberFormatInfo nfi = (NumberFormatInfo)
        CultureInfo.InvariantCulture.NumberFormat.Clone();
        nfi.NumberGroupSeparator = ".";

        int numFuncionario = int.Parse(Console.ReadLine());
        int numHoraTrabalhada = int.Parse(Console.ReadLine());
        double valorHoraTrabalhada = double.Parse(Console.ReadLine());
        double totalSalario = 0;
        
        totalSalario = numHoraTrabalhada * valorHoraTrabalhada;
        
        Console.WriteLine("NUMBER = "+ numFuncionario);
        Console.WriteLine("SALARY = U$ "+ totalSalario.ToString("F2", nfi));
        }
        
        static void Desafio9 ()
        {
        /*
        Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por 
        ele no mês (em dinheiro). Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, 
        informar o total a receber no final do mês, com duas casas decimais.
        Entrada
        O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão (double) 
        com duas casas decimais, representando o salário fixo do vendedor e montante total das vendas efetuadas 
        por este vendedor, respectivamente.
        Saída
        Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.
        */
        NumberFormatInfo nfi = (NumberFormatInfo)
        CultureInfo.InvariantCulture.NumberFormat.Clone();
        nfi.NumberGroupSeparator = ".";
        
        string nomeVendedor = Console.ReadLine();
        double salarioVendedor = double.Parse(Console.ReadLine());
        double totalVendas = double.Parse(Console.ReadLine());
        
        totalVendas = (totalVendas * 15) / 100;
        salarioVendedor = totalVendas + salarioVendedor;
        
        Console.WriteLine("TOTAL = R$ "+ salarioVendedor.ToString("F2", nfi));
        }
        
        static void Desafio11()
        {
            /*
            Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio 
            (R). A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.
            Entrada
            O arquivo de entrada contém um valor de ponto flutuante (dupla precisão), correspondente ao raio 
            da esfera.
            Saída
            A saída deverá ser uma mensagem "VOLUME" conforme o exemplo fornecido abaixo, com um espaço antes 
            e um espaço depois da igualdade. O valor deverá ser apresentado com 3 casas após o ponto.
            */

        NumberFormatInfo nfi = (NumberFormatInfo)
        CultureInfo.InvariantCulture.NumberFormat.Clone();
        nfi.NumberGroupSeparator = ".";
        
        double raio = double.Parse(Console.ReadLine());
        double volume = 0;
        
        raio = Math.Pow(raio, 3);
        volume = (4/3.0) * (3.14159 * raio);

        Console.WriteLine("VOLUME = "+ volume.ToString("F3", nfi));
        }
        
        static void Desafio12()
        {
            /*
            Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em 
            seguida, calcule e mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B.
            Entrada
            O arquivo de entrada contém três valores com um dígito após o ponto decimal.
            Saída
            O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas 
            descritas acima, sempre com mensagem correspondente e um espaço entre os dois pontos e o valor. 
            O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.
            */
            NumberFormatInfo nfi = (NumberFormatInfo)
            CultureInfo.InvariantCulture.NumberFormat.Clone();
            nfi.NumberGroupSeparator = ".";

            string[] entradas = Console.ReadLine().Split(" ");
            double A = double.Parse(entradas[0]), B = double.Parse(entradas[1]), C = double.Parse(entradas[2]);
            double total = 0;
            //área do triângulo retângulo que tem A por base e C por altura.
            total = (A * C) / 2;
            Console.WriteLine("TRIANGULO: "+ total.ToString("F3", nfi));

            //área do círculo de raio C. (pi = 3.14159)
            total = Math.Pow(C , 2);
            total = 3.14159 * total;
            Console.WriteLine("CIRCULO: "+ total.ToString("F3", nfi));

            //área do trapézio que tem A e B por bases e C por altura.
            total = ((A + B) * C) / 2 ;
            Console.WriteLine("TRAPEZIO: "+ total.ToString("F3", nfi));

            //área do quadrado que tem lado B.
            total = B * B;
            Console.WriteLine("QUADRADO: "+ total.ToString("F3", nfi));

            //área do retângulo que tem lados A e B.
            total = A * B;
            Console.WriteLine("RETANGULO: "+ total.ToString("F3", nfi));
        }
        
        static void comoUsarOperador()
        {
            string name1 = Console.ReadLine();
            int points1 = Convert.ToInt32(Console.ReadLine());
            string name2 = Console.ReadLine();
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);

            DancerPoints total = dancer1 + dancer2;
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);

        }
            class DancerPoints
    {
        public string name;
        public int points;
        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        //overload the + operator

        public static DancerPoints operator+(DancerPoints d1, DancerPoints d2)
        {


            
            DancerPoints total = new DancerPoints(d1.name + " & " + d2.name, d1.points + d2.points);
            return total;
        }
        
            
        

    }
        
        static void ExemploComoUsarColecao()
        {
            //Exemplo de uso de Coleção Genérica <T>
            List<int> lista = new List<int>();
            for(var i = 0; i < 60; i++)
            {
                lista.Add(i);
            }
            lista.Remove(50);

            Console.WriteLine("\nList: ");
            for(var x = 0; x < lista.Count; x++)
            {
                Console.WriteLine(lista[x] + " ");
            }
            lista.Sort();
            Console.WriteLine("\nSorted: ");
            for(var z = 0; z < lista.Count; z++)
            {
                Console.WriteLine(lista[z] + " ");
            }
        }
        
        static void ExemploSortedList()
        {
            //Exemplo de SortedList
            SortedList<string, int> exemploSorted = new SortedList<string, int>();
            exemploSorted.Add("A", 1);
            exemploSorted.Add("Solo", 2);
            exemploSorted.Add("C", 3);
            Console.WriteLine("Sorted List: ");
            foreach (string s in exemploSorted.Keys)
            Console.WriteLine(s + ": " + exemploSorted[s]);
            Console.WriteLine("\nCount: " + exemploSorted.Count); 
        }
        
        static void ExemploBitArray(){
            //Exemplo de BitArray
            BitArray ba1 = new BitArray(4);
            BitArray ba2 = new BitArray(4);

            ba1.SetAll(true);
            ba2.SetAll(false);

            ba1.Set(2, false);
            ba2.Set(3, true);

            //PrintBarr nome genérico para o método de imprimir o BitArray
            PrintBarr("ba1", ba1);
            PrintBarr("ba2", ba2);
            Console.WriteLine();

            PrintBarr("ba1 AND ba2", ba1.And(ba2));
            PrintBarr("    NOT ba2", ba2.Not());

            static void PrintBarr(string name, BitArray ba)
        {
            Console.WriteLine(name + " : ");
            for(int i = 0; i < ba.Length; i++)
            {
                Console.WriteLine(ba.Get(i) + " ");
                Console.WriteLine();
            }
        }
        }

        static void ExemploStackGenerica(){
            //Exemplo de Stack Collection || Last in, First Out(LIFO)
            Stack<int> pilha = new Stack<int>();
            
            //Para gerar numeros aleatórios	
            Random randNum = new Random();
            for (int i = 0; i < 10; i++)
                pilha.Push(randNum.Next(100));

            Console.WriteLine("Stack: ");
            foreach (int i in pilha)
                Console.Write(i + " ");
            Console.Write("\nCount: " + pilha.Count); //Contando a quantidade de 10 itens dentro da pilha
            Console.Write("\nTop: " + pilha.Peek()); //Mostrando o item do topo da pilha
            Console.Write("\nPop: " + pilha.Pop()); //Removendo o item do topo da pilha
            Console.Write("\nCount: " + pilha.Count); //Reduzindo a quantidade de item para 9
        }
        
        static void ExemploQueue(){
            //Exemplo de Queue Collection || First in, First Out(FIFO)
            Queue<int> fila = new Queue<int>();

            //Para adicionar itens na fila
            Random randNum = new Random();
            for (int i = 0; i < 5; i++)
                fila.Enqueue(randNum.Next(100));
            Console.Write("Queue: ");
            foreach (int i in fila)
                Console.Write(i + " ");
            Console.Write("\nCount: " + fila.Count); //Contando a quantidade de 5 itens dentro da fila
            Console.Write("\nDequeue: " + fila.Dequeue()); //Removendo o item do topo da fila

            Console.Write("\nQueue: ");
            foreach (int i in fila)
                Console.Write(i + " ");
        }
        static void Main(string[] args)
        {
            

        }
        

        
        
        }
    }
 

