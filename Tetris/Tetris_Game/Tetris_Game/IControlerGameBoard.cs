using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_Game
{
    internal interface IControlerGameBoard
    {
        void callRender();
        void nachLinks();
        void nachRechts();
        void nachLinksDrehen();
        void nachRechtsDrehen();
        void nachUnten();
        GameBoard GetGameBoardWithActiveBlock();
        int GetScore();
        void StopTimer();
    }
}
