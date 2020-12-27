using System;

namespace Matrix1_CSharp {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite a quantidade de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine());
            Console.Write("Agora digite a quantidade de colunas da matriz: ");
            int colunas = int.Parse(Console.ReadLine());

            int[,] mat = new int[linhas, colunas];


            for (int i = 0; i < linhas; i++) {
                Console.Write("\nDigite os números da " + (i+1) + "ª linha separados por espaços ' ': ");
                string[] numeros = Console.ReadLine().Split(" ");
                for (int j = 0; j < colunas; j++) {
                    mat[i, j] = int.Parse(numeros[j]);
                }
            }

            Console.Write("\nDigite um número da matriz: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++) {
                    if (mat[i, j] == num) {
                        Console.WriteLine("Número " + num + " encontrado na posição: " + i + "," + j);
                        if (j > 0) {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < colunas - 1) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < linhas - 1) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}