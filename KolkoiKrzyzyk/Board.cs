using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolkoiKrzyzyk
{
    public class Board
    {
        public char[,] board = new char[3, 3];

        public void wykonajRuch(Coordinates c)
        {
            board[c.x, c.y] = 'x';// c.k;
        }

        public char[,] getBoard()
        {
            return board;
        }
    }
}
