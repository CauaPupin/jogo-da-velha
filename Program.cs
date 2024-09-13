using System;
// Os métodos Parse e TryParse nos permitem converter ou tentar converter uma string para um outro tipo. 
//No caso, todos os tipos built-in do .NET possuem estes métodos.
class Program
{

    // Criando a Parte Inicial
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao Jogo da Velha!");
        Console.Write("Seu jogo será criado no formate 3x3");
        
        var jogo = new JogoDaVelha(3, 3); //Inicializando o jogo com um tabuleiro 3x3
        jogo.Iniciar();
    }
}

// Criando o Jogo
class JogoDaVelha
{
    private char[,] tabuleiro;
    private char jogadorAtual;

    public JogoDaVelha(int linhas, int colunas)
    {
        tabuleiro = new char [linhas, colunas];
        jogadorAtual = 'X' // ---- JOGADOR (X) COMEÇA O JOGO ----

        // ---- INICIALIZAR TABULEIRO VAZIO ----
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                tabuleiro[i, j] = ' ';
            }
        }
    }
    
// ---- MONTANDO O TABULEIRO ----
private void MostrarTab()
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(tabuleiro[i, j]);
            if (j < 2) Console.Write("|");
        }
        Console.WriteLine();
        if (i < 2) Console.WriteLine("-----");
    }
}


}