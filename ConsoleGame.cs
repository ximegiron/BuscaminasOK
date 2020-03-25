﻿//ximena
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas
{
    class ConsoleGame<T>: Game<T> where T : ICell, new()
    {
        private char hiddenSymbol;
        private char mineCell;
        private char flagSymbol;

        public ConsoleGame(int w, int h, int minas): base( w, h, minas) 
        {
            this.hiddenSymbol = (char)9632;
            this.mineCell = '*'; 
            this.flagSymbol = '°';
            ShowGrid();
        }

        public void ShowGrid()
        {
            Console.Write("".PadRight(4));
            for (int i = 0; i < this.width; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write((char)(65+i)+ " ");
             }
            Console.WriteLine();
            string printingValue;

            for (uint i = 0; i < this.height; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(((i+1) + " ").PadLeft(4));
                Console.ForegroundColor = ConsoleColor.White;
                for (uint j = 0; j < this.width; j++)
                {
                    switch (this.celdas[j, i].cell.GetStatus())
                    {
                        case Celda.Status.SHOWN:
                            if (this.celdas[j, i].cell is Mine) //Comprobar tipo de dato
                            {
                                printingValue = this.mineCell.ToString();
                            }
                            else 
                            {
                                printingValue = "" + this.celdas[j, i].cell.GetValue();
                            }
                          break;
                        case Celda.Status.FLAG:
                            printingValue = "" + this.flagSymbol;
                            break;
                        default:
                            printingValue = "" + this.hiddenSymbol;
                            break;
                    }
                    Console.Write(printingValue + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
