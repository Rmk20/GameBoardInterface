using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Tetris_Game
{
    internal class ControlerGameBoard: IControlerGameBoard
    {
        public EventHandler GameBoardChanged;
        public EventHandler GameOver;
        private GameBoard board;
        private Block activeBlock;
        private Timer timer;
        private int baseGameSpeed = 800;
        private double gameSpeedMultiplicatorIncrease = 0.9;
        public ControlerGameBoard(int difficulty)
        {
            board = new GameBoard();
            board.GameSpeedIncrease += increaseGameSpeed;
            activeBlock = new Block();
            timer = new Timer();
            timer.Tick += new EventHandler(autoDrop);
            baseGameSpeed = baseGameSpeed - ((difficulty - 1) * 300);
            timer.Interval = baseGameSpeed;
            timer.Start();
        }
        private void autoDrop(object sender, EventArgs e)
        {
            nachUnten();
        }
        public void callRender()
        {
            GameBoardChanged.Invoke(this, EventArgs.Empty);
        }
        public void nachLinks()
        {
            if (activeBlock.nachLinks(board))
            {
                GameBoardChanged.Invoke(this, EventArgs.Empty);
            }
        }
        public void nachRechts()
        {
            if (activeBlock.nachRechts(board)) {
                GameBoardChanged.Invoke(this, EventArgs.Empty);
            }
            }
        public void nachLinksDrehen()
        {
            if(activeBlock.nachLinksDrehen(board)){
                GameBoardChanged.Invoke(this, EventArgs.Empty);
            }
        }
        public void nachRechtsDrehen()
        {
            if(activeBlock.nachRechtsDrehen(board)){
                GameBoardChanged.Invoke(this, EventArgs.Empty);
            }
        }
        public void nachUnten()
        {
            if(!activeBlock.nachUnten(board)){
                int[,] activeBlockCords = activeBlock.getAbsoluteBlockCords();
                for (int i = 0; i < activeBlockCords.GetLength(0); i++)
                {
                    if (isInBounds(activeBlockCords[i, 0], activeBlockCords[i, 1]))
                    {
                        board.GameTileFarbe[activeBlockCords[i, 0], activeBlockCords[i, 1]] = activeBlock.BlockColor;
                    }
                    else
                    {
                        
                        timer.Stop();
                        GameOver.Invoke(this, EventArgs.Empty);
                        return;
                    }
                }
                board.deleteFullRows();
                activeBlock = new Block();
            }
            GameBoardChanged.Invoke(this, EventArgs.Empty);
        }
        public GameBoard GetGameBoardWithActiveBlock()
        {
            GameBoard gameBoardWithActiveBlock = new GameBoard();

            gameBoardWithActiveBlock.Score = board.Score;
            Array.Copy(board.GameTileFarbe, gameBoardWithActiveBlock.GameTileFarbe, board.GameTileFarbe.Length);

            int[,] activeBlockCords = activeBlock.getAbsoluteBlockCords();

            for (int i = 0; i < activeBlockCords.GetLength(0); i++)
            {
                if (isInBounds(activeBlockCords[i,0],activeBlockCords[i,1]))
                {
                    gameBoardWithActiveBlock.GameTileFarbe[activeBlockCords[i, 0], activeBlockCords[i, 1]] = activeBlock.BlockColor;
                }
            }

            return gameBoardWithActiveBlock;
        }
        private bool isInBounds(int blockX, int blockY)
        {
            if (blockX >= 0 && blockX < board.GameTileFarbe.GetLength(0) && blockY >= 0 && blockY < board.GameTileFarbe.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void increaseGameSpeed(object sender, EventArgs args)
        {
            timer.Interval = Convert.ToInt32(baseGameSpeed * (Math.Pow(gameSpeedMultiplicatorIncrease, (board.Score / 10))));
        }
        public int GetScore()
        {
            return board.Score;
        }
        public void StopTimer()
        {
            this.timer.Stop();
        }
    }
}
