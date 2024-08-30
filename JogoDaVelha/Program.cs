using System;

class Program
{

    // Criando a Parte Inicial
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao Jogo da Velha!");
        Console.Write("Digite o número de linhas: ");
        int linhas = int.Parse(Console.ReadLine());
        Console.Write("Digite o número de colunas: ");
        int colunas = int.Parse(Console.ReadLine());
        // Os métodos Parse e TryParse nos permitem converter ou tentar converter uma string para um outro tipo. 
        //No caso, todos os tipos built-in do .NET possuem estes métodos.

        var jogo = new JogoDaVelha(linhas, colunas);
        jogo.Iniciar();
    }
}

// Criando o Jogo
class JogoDaVelha
{
    private int linhas;
    private int colunas;
    private char[,] tabuleiro;
    private char jogadorAtual;

    public JogoDaVelha(int linhas, int colunas)
    {
        this.linhas = linhas;
        this.colunas = colunas;
        this.tabuleiro = new char[linhas, colunas];
        this.jogadorAtual = 'X';

        // Inicializar o tabuleiro com espaços vazios
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                tabuleiro[i, j] = ' ';
            }
        }
    }
}