using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tetris_Game
{
    internal class Block : IBlock
    {
        private int[] blockMidCords;
        public int[] BlockMidCords { get => blockMidCords; set => blockMidCords = value; }

        private int[,] relativeBlockCords;
        public int[,] RelativeBlockCords { get => relativeBlockCords; set => relativeBlockCords = value; }

        private Color blockColor;
        public Color BlockColor { get => blockColor; set => blockColor = value; }


        public Block()
        {
            this.blockMidCords = new int[] { 5 , 20 };
            (this.relativeBlockCords, this.blockColor) = getRandomBlock();
        }

        private (int[,], Color) getRandomBlock()
        {
            int[][,] blocks = new int[][,]
            {
                new int[,] { { 0, 1 }, { 1, 1 }, { 1, 0 },{ 0, 0} },    // Square
                new int[,] { { 0, 0 }, { 1, 0 }, { 2, 0 }, { -1, 0 } }, // -------
                new int[,] { { 0, 1 }, { -1, 1 }, { 1, 1 }, { -1, 0} }, // L
                new int[,] { { 0, 1 }, { -1, 1 } , { 1, 1 }, { 1, 0} }, // Reverse L
                new int[,] { { 0, 1 }, { -1, 1 }, { 0, 0 },{ 1, 0 } },  // Z
                new int[,] { { 0, 1 }, { 0, 0 }, { 1, 1 },{ -1, 0 } },  // Reverse Z
                new int[,] { { 0, 1 }, { 1, 1 }, { -1, 1 },{ 0, 0 } }   // T
            };
            Color[] color = new Color[]
            {
                Color.FromArgb(104, 205, 255),      // Square
                Color.FromArgb(255, 5, 0 ),     // -------
                Color.FromArgb(254, 102, 3 ),    // L
                Color.FromArgb(205, 4, 255 ),    // Reverse L
                Color.FromArgb(6, 1, 255 ),    // Z
                Color.FromArgb(162, 255, 255 ),    // Reverse Z
                Color.FromArgb(14, 255, 10 )      // T
            };
            Random random = new Random();
            int randomNum = random.Next(blocks.Length);
            return (blocks[randomNum], color[randomNum]);
        }

        public bool nachUnten(GameBoard gameBoard)
        {
            int[] newBlockMidCords = new int[] { blockMidCords[0], blockMidCords[1] - 1 };
            if (isAlowed(relativeBlockCords, newBlockMidCords, gameBoard))
            {
                this.blockMidCords = newBlockMidCords;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool nachLinks(GameBoard gameBoard)
        {
            int[] newBlockMidCords = new int[] {blockMidCords[0] - 1, blockMidCords[1]};
            if (isAlowed(relativeBlockCords, newBlockMidCords, gameBoard))
            {
                this.blockMidCords = newBlockMidCords;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool nachRechts(GameBoard gameBoard)
        {
            int[] newBlockMidCords = new int[] {blockMidCords[0] + 1, blockMidCords[1]};
            if (isAlowed(relativeBlockCords, newBlockMidCords, gameBoard))
            {
                this.blockMidCords = newBlockMidCords;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool nachLinksDrehen(GameBoard gameBoard)
        {
            int[,] newRelativeBlockCords = turnRelativeCordsLeft();
            if (isAlowed(newRelativeBlockCords, this.blockMidCords, gameBoard))
            {
                this.relativeBlockCords = newRelativeBlockCords;
                return true;
            }
            else
            {
                return false;
            }
        }
        private int[,] turnRelativeCordsLeft()
        {
            int[,] newRelativeCords = new int[this.relativeBlockCords.GetLength(0), 2];
            for (int i = 0; i < this.relativeBlockCords.GetLength(0); i++)
            {
                newRelativeCords[i, 0] = -this.relativeBlockCords[i, 1];
                newRelativeCords[i, 1] = this.relativeBlockCords[i, 0];
            }
            return newRelativeCords;
        }
        public bool nachRechtsDrehen(GameBoard gameBoard)
        {
            int[,] newRelativeBlockCords = turnRelativeCordsRight();
            if (isAlowed(newRelativeBlockCords, this.blockMidCords, gameBoard))
            {
                this.relativeBlockCords = newRelativeBlockCords;
                return true;
            }
            else
            {
                return false;
            }
        }
        private int[,] turnRelativeCordsRight()
        {
            int[,] newRelativeCords = new int[this.relativeBlockCords.GetLength(0),2];
            for(int i = 0; i < this.relativeBlockCords.GetLength(0); i++)
            {
                newRelativeCords[i,0] = this.relativeBlockCords[i,1];
                newRelativeCords[i,1] = -this.relativeBlockCords[i,0];
            }
            return newRelativeCords;
        }
        private bool isAlowed(int[,] newRelativeBlockCords, int[] newBlockMidCords, GameBoard board)
        {
            int[,] newAbsoluteBlockCords = getAbsoluteBlockCords(newRelativeBlockCords, newBlockMidCords);
            for(int i = 0; i < newAbsoluteBlockCords.GetLength(0); i++)
            {
                if (newAbsoluteBlockCords[i,0] < 0 || newAbsoluteBlockCords[i,0] > 9)
                {
                    return false;
                }
                if (newAbsoluteBlockCords[i,1] < 0 || newAbsoluteBlockCords[i,1] > 25)
                {
                    return false;
                }
                if (newAbsoluteBlockCords[i, 1] < 20 && board.GameTileFarbe[newAbsoluteBlockCords[i,0], newAbsoluteBlockCords[i, 1]] != GameBoard.defaultColor)
                {
                    return false;
                }
            }
            return true;
        }
        private int[,] getAbsoluteBlockCords(int[,] newRelativeBlockCords, int[] newBlockMidCords)
        {
            int[,] blockCords = new int[newRelativeBlockCords.GetLength(0),2];
            for(int i = 0; i < newRelativeBlockCords.GetLength(0); i++)
            {
                blockCords[i,0] = newBlockMidCords[0] + newRelativeBlockCords[i,0];
                blockCords[i,1] = newBlockMidCords[1] + newRelativeBlockCords[i,1];
            }
            return blockCords;
        }
        public int[,] getAbsoluteBlockCords()
        {
            int[,] blockCords = new int[relativeBlockCords.GetLength(0), 2];
            for (int i = 0; i < relativeBlockCords.GetLength(0); i++)
            {
                blockCords[i, 0] = blockMidCords[0] + relativeBlockCords[i, 0];
                blockCords[i, 1] = blockMidCords[1] + relativeBlockCords[i, 1];
            }
            return blockCords;
        }

    }
}
