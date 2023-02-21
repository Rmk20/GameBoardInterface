using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tetris_Game
{
    internal class GameBoard : IGameBoard
    {
        public EventHandler GameSpeedIncrease;

        public static Color defaultColor = Color.White;
        private Color[,] gameTileFarbe;
        public Color[,] GameTileFarbe { get => gameTileFarbe; set => gameTileFarbe = value; }       
        private int score;
        public int Score { get => score; set => score = value; }

        public GameBoard()
        {
            gameTileFarbe = new Color[10,20];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    gameTileFarbe[i, j] = GameBoard.defaultColor;
                }
            }
            score = 0;
        }
        public void deleteFullRows()
        {
            for (int i = gameTileFarbe.GetLength(1)-1 ; i >= 0; i--)
            {
                bool hasEmptyTile = false;
                for (int j = 0; j < gameTileFarbe.GetLength(0); j++)
                {
                    if (gameTileFarbe[ j , i ] == GameBoard.defaultColor)
                    {
                        hasEmptyTile = true;
                    }
                }
                if (!hasEmptyTile)
                {
                    deleteFullRow(i);
                }
            }
        }
        private void deleteFullRow(int row) 
        {
            for (int i = row; i < gameTileFarbe.GetLength(1) - 1; i++)
            {
                for (int j = 0; j < gameTileFarbe.GetLength (0); j++)
                {
                    gameTileFarbe[j,i] = gameTileFarbe[j,i + 1];
                }
            }
            for (int j = 0; j < gameTileFarbe.GetLength(0); j++)
            {
                gameTileFarbe[j, 19] = GameBoard.defaultColor;
            }
            score += 10;
            GameSpeedIncrease.Invoke(this, EventArgs.Empty);
        }
    }
}
