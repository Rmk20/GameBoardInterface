using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_Game
{
    internal class Highscore : IHighscore
    {
        private static string cs = "Host=tetris-aif31-4751.7tc.cockroachlabs.cloud;Username=Player;Password=HVKu4l8nZjcZeBjnORv1Gg;Database=tetris;Port=26257";
        private string name;
        public string Name { get => name; set => name = value; }
        private int score;
        public int Score { get => score; set => score = value; }

        public Highscore(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public bool highscoreHochladen()
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection(cs);
                con.Open();
                string sql = "INSERT INTO highscore (name, score) VALUES ('" + this.name + "'," + this.score + ")";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Highscore[] highscoreRunterladen()
        {
            try
            {
                List<Highscore> highscores = new List<Highscore>();
                NpgsqlConnection con = new NpgsqlConnection(cs);
                con.Open();
                string sql = "SELECT name, score FROM highscore order by score desc";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    highscores.Add(new Highscore(reader.GetString(0), reader.GetInt32(1)));
                }
                return highscores.ToArray();
            }
            catch
            {
                return new Highscore[] { new Highscore("-", 0)};
            }
        }
    }
}