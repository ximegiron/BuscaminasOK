using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas
{
    class Game <T> where T : ICell, new()
    {
        protected int tiempo;
        protected int numMines;

        protected int width;
        protected int height;

        protected int minesLeft;
        protected int flagsCount;

        protected T[,] celdas;

        public Game(int w, int h, int minas)  
        {
            this.width = w;
            this.height = h;
            this.numMines = minas;

            this.celdas = new T[w, h];
            for (uint i = 0; i < this.width; i++)
            {
                for (uint j = 0; j < this.height; j++)
                {
                    this.celdas[i, j] = new T();
                }
            }
            
        }
    }
}
