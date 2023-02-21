using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_Game
{
    internal interface IBlock
    {
        bool nachUnten(GameBoard gameBoard);
        bool nachLinks(GameBoard gameBoard);
        bool nachRechts(GameBoard gameBoard);
        bool nachLinksDrehen(GameBoard gameBoard);
        bool nachRechtsDrehen(GameBoard gameBoard);
        int[,] getAbsoluteBlockCords();
    }
}
