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
