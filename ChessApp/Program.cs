using ChessApp;
using ChessApp.tabuleiro;

internal class Program

{
    private static void Main(string[] args)
    {
        Tabuleiro tab = new Tabuleiro(20, 20);
        Tela.ImprimirTabuleiro(tab);
      
    }
}