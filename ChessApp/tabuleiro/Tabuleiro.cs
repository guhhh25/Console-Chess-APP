using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.tabuleiro
{
    internal class Tabuleiro
    {
        public int Linha { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas { get; set; }


        public Tabuleiro(int linha, int coluna)
        {
            this.Linha = linha;
            this.Colunas = coluna;
            this.Pecas = new Peca[Linha, Colunas]; //Matriz
        } 

        public Peca peca(int Linha, int Coluna)
        {
            return Pecas[Linha, Coluna];   // Return the X,Y piece position
        }
    
    }

}
