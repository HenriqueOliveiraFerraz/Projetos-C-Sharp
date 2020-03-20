# Projetos-C-Sharp
## Vou colocar projetos que utilizei para estudar C# nesse repositório, desde pequenos até maiores.
## 1.Vetor e Classe.

A dona de um pensionato possui dez quartos para alugar para estudantes,
sendo esses quartos identificados pelos números 0 a 9.
Quando um estudante deseja alugar um quarto, deve-se registrar o nome
e email deste estudante.

Fazer um programa que inicie com todos os dez quartos vazios, e depois
leia uma quantidade N representando o número de estudantes que vão
alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
N estudantes. Para cada registro de aluguel, informar o nome e email do
estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
um relatório de todas ocupações do pensionato, por ordem de quarto,
conforme exemplo.

Exemplo de "output":
```
Quantos quartos serão alugados? 3
Aluguel #1:
Nome: Maria Green
Email: maria@gmail.com
Quarto: 5

Aluguel #2:
Nome: Marco Antonio
Email: marco@gmail.com
Quarto: 1

Aluguel #3:
Nome: Alex Brown
Email: alex@gmail.com
Quarto: 8

Quartos ocupados:
1: Marco Antonio, marco@gmail.com
5: Maria Green, maria@gmail.com
8: Alex Brown, alex@gmail.com
```

```c#
using System;

namespace VetorClasse
{
    class Estudantes
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Estudantes(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
```
```c#
using System;
using System.Globalization;

namespace VetorClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudantes[] vect = new Estudantes[10];

            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudantes(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }


        }
    }
}


```
## 2.Lista e Classe

Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
N funcionários. Não deve haver repetição de id.
Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
conforme exemplos.
Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
aumento por porcentagem dada.

Exemplo de "output":

```
How many employees will be registered? 3
Emplyoee #1:
Id: 333
Name: Maria Brown
Salary: 4000.00
Emplyoee #2:
Id: 536
Name: Alex Grey
Salary: 3000.00
Emplyoee #3:
Id: 772
Name: Bob Green
Salary: 5000.00
Enter the employee id that will have salary increase : 536
Enter the percentage: 10.0
Updated list of employees:
333, Maria Brown, 4000.00
536, Alex Grey, 3300.00
772, Bob Green, 5000.00
```
```
How many employees will be registered? 2
Emplyoee #1:
Id: 333
Name: Maria Brown
Salary: 4000.00
Emplyoee #2:
Id: 536
Name: Alex Grey
Salary: 3000.00
Enter the employee id that will have salary increase: 776
This id does not exist!
Updated list of employees:
333, Maria Brown, 4000.00
536, Alex Grey, 3000.00
```
```c#
using System;
using System.Globalization;


namespace ListaFuncionarios
{
    class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario += (porcentagem*Salario)/100;
        }

        public override string ToString()
        {
            return ID
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

```
```c#
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListaFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());
            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Funcionário  #{i}:");
                Console.WriteLine("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Funcionario(id, nome, salario));
            }

            Console.WriteLine("Insira  o ID do funcionário que ira receber aumento: ");
            int funcionarioID = int.Parse(Console.ReadLine());

            Funcionario temp = lista.Find(x => x.ID == funcionarioID);
            if(temp != null)
            {
                Console.WriteLine("Insira a porcentagem do aumento: ");
                double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                temp.AumentarSalario(aumento);
            }
            else
            {
                Console.WriteLine("Esse ID não existe");
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("Lista atualizada dos funcionários: ");
            foreach(Funcionario obj in lista)
            {
                Console.WriteLine(obj);
            }

        }
    }
}

```
## 3.Matriz Bidimensional

Fazer um programa para ler dois números inteiros M e N, e depois ler
uma matriz de M linhas por N colunas contendo números inteiros,
podendo haver repetições. Em seguida, ler um número inteiro X que
pertence à matriz. Para cada ocorrência de X, mostrar os valores à
esquerda, acima, à direita e abaixo de X, quando houver, conforme
exemplo.

Exemplo de "output":

```
3 4
10 8 15 12
21 11 23 8
14 5 13 19
8
Position 0,1:
Left: 10
Right: 15
Down: 11
Position 1,3:
Left: 23
Up: 12
Down: 19
```

```c#
using System;

namespace MatrizBiDimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linha = Console.ReadLine().Split(' '); 
            int m = int.Parse(linha[0]); //linhas da matriz
            int n = int.Parse(linha[1]); //colunas da matriz

            int[,] matriz = new int[m, n];
            Console.WriteLine();
            for(int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());
            //A variável 'm' representa a quantidade de linhas da matriz
            for (int i = 0; i < m; i++)
            {
                //A variável 'n' representa a quantidade de colunas da matriz
                for (int j = 0; j < n; j++)
                {
                    if(matriz[i,j] == x)
                    {
                        Console.WriteLine("Posição " + i + "," + j + ":");
                        //Se 'j' for maior do que zero, significa que o número 'x' verificado possui outro número a esquerda dele
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[i,j-1]);
                        }
                        //Se 'i' for maior que zero, significa que o número 'x' verificado possui outro número acima dele
                        if (i > 0)
                        {
                            Console.WriteLine("Acima: " + matriz[i-1,j]);
                        }
                        //Se 'j' for menor do que o número de colunas menos um, significa que o número 'x' verificado possui outro número a direita dele
                        if(j < n - 1)
                        {
                            Console.WriteLine("Direita: " + matriz[i,j+1]);
                        }
                        //Se 'i' for menor do que o número de linhas menos um, significa que o número 'x' verificado possui outro número abaixo dele
                        if(i < m - 1)
                        {
                            Console.WriteLine("Abaixo: " + matriz[i+1,j]);
                        }
                    }
                }
                
            }
        }
    }
}

```
