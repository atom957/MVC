using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolkoiKrzyzyk
{
    class Controller
    {
        public void uruchom()
        {
            View view = new View();
            Board board = new Board();
            Coordinates coordinates = new Coordinates(view.getCoordinate(), view.getCoordinate());
            board.wykonajRuch(coordinates);
            view.wypisz(board.getBoard());
        }
    }
}
