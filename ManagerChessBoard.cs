using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro
{
    public class ManagerChessBoard
    {
        #region Properties
        private TextBox namePlayer;
        private PictureBox picturePlayer;
        private List<Player> players;
        private Panel chessBoard;
        private List<List<Button>> matrix;
        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }

        public List<Player> Players { get => players; set => players = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public PictureBox PicturePlayer { get => picturePlayer; set => picturePlayer = value; }
        public TextBox NamePlayer { get => namePlayer; set => namePlayer = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

        //  public TextBox NamePlayer { get => NamePlayer; set => NamePlayer = value; }

        private int currentPlayer;
        #endregion
    
        #region Initialize
       
        public ManagerChessBoard(Panel chessboard,PictureBox PicturePlayer,TextBox NamePlayer)
        {
            this.ChessBoard = chessboard;
            this.PicturePlayer = PicturePlayer;
            this.NamePlayer = NamePlayer;
            this.Players = new List<Player>()
            {
                new Player("Hung",Image.FromFile(Application.StartupPath+"\\Resources\\c51cda89a29626ea7b655bd7f703218c.png")),
                new Player("Tony",Image.FromFile(Application.StartupPath+"\\Resources\\download.png"))
            };
            this.CurrentPlayer = 0;
            ChangePlayer();
      
        }
        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            Matrix = new List<List<Button>>();//4 
            Button oldbutton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Const.Chess_Size; i++)
            {
                Matrix.Add(new List<Button>());//4
                for (int j = 0; j < Const.Chess_Size; j++)
                {
                    Button button = new Button()
                    {
                        Width = Const.Chess_withd,
                        Height = Const.Chess_height,
                        Location = new Point(oldbutton.Location.X + oldbutton.Width, oldbutton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()//4

                    };
                    button.Click += Button_Click;
                    Matrix[i].Add(button); //Phan Luu Button Vao Ma Tran//4
                    oldbutton = button;
                    ChessBoard.Controls.Add(oldbutton);
                }
                oldbutton.Location = new Point(0, oldbutton.Location.Y + Const.Chess_height);
                oldbutton.Width = 0;
                oldbutton.Height = 0;
            }
        }


        private void EndGame()
        {
            MessageBox.Show("END");
        }
        private bool IsendGame(Button button)
        {
            return IsendHozri(button)||IsendSub(button)||IsendVetical(button)||IsendCheo(button);
        }

        private Point GetchessPoint(Button button)
        {
            int vertical = Convert.ToInt32(button.Tag);
            int horizontal = Matrix[vertical].IndexOf(button);
            Point point = new Point(horizontal,vertical);
            return point;
        }

        private bool IsendHozri(Button button)
        {
            Point point = GetchessPoint(button);
            int countLeft = 0;
            int countRight = 0;
            for(int i = point.X; i >= 0; i--)
            {
                if (i + 1 > Const.Chess_Size) break;
                if (Matrix[point.Y][i].BackgroundImage == button.BackgroundImage&&Matrix[point.Y][i].BackgroundImage==Matrix[point.Y][i+1].BackgroundImage)
                {
                    countLeft++;
                }
            }
            
            for(int i = point.X; i < Const.Chess_Size; i++)
            {
                if (i - 1 < 0) break;
                if (Matrix[point.Y][i].BackgroundImage == button.BackgroundImage&& Matrix[point.Y][i].BackgroundImage == Matrix[point.Y][i - 1].BackgroundImage)
                {
                    countRight++;
                }
            }
            return countLeft + countRight ==5;

            
        }
        private bool IsendVetical(Button button)
        {
            Point point = GetchessPoint(button);
            int countTop = 0;
            int countBottom = 0;
            for(int i = point.Y; i >= 0; i--)
            {
                if (matrix[i][point.X].BackgroundImage == button.BackgroundImage) { countTop++; }
            }
            for (int i = point.Y + 1; i < Const.Chess_Size; i++)
            {
                if (matrix[i][point.X].BackgroundImage == button.BackgroundImage) {
                    countBottom++;
                }
            }
            return countBottom + countTop == 5;
        }
        private bool IsendCheo(Button button)
        {
            Point point = GetchessPoint(button);
            int countTopCheo = 0;
            int countBottomCheo = 0;
            for (int i = 0; i <=point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0) break;
                if (matrix[point.Y - i][point.X - i].BackgroundImage == button.BackgroundImage)
                {
                    countTopCheo++;
                }
                else break;
            }
            for (int i = 1; i <= Const.Chess_Size-point.X; i++)
            {
                if (point.X + i >= Const.Chess_Size || point.Y + i >= Const.Chess_Size) break;
                if (matrix[point.Y + i][point.X + i].BackgroundImage == button.BackgroundImage)
                {
                    countBottomCheo++;
                }
                else break;
            }
            return countBottomCheo + countTopCheo == 5;
        }
        private bool IsendSub(Button button)
        {
            Point point = GetchessPoint(button);
            int countTopCheo2 = 0;
            int countBottomCheo2 = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > Const.Chess_Size || point.Y - i < 0) break;
                if (matrix[point.Y - i][point.X + i].BackgroundImage == button.BackgroundImage)
                {
                    countTopCheo2++;
                }
                else break;
            }
            for (int i = 1; i <= Const.Chess_Size - point.X; i++)
            {
                if (point.X - i <0 || point.Y + i > Const.Chess_Size) break;
                if (matrix[point.Y + i][point.X - i].BackgroundImage == button.BackgroundImage)
                {
                    countBottomCheo2++;
                }
                else break;
            }
            return countBottomCheo2 + countTopCheo2 == 5;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            if (btn.BackgroundImage != null)
                return;
            //btn.BackgroundImage = Players[CurrentPlayer].Mark;
            Mark(btn);
            ChangePlayer();
            if (IsendGame(btn))
            {
                EndGame();
            }

        }
        private void ChangePlayer()
        {
            NamePlayer.Text = Players[CurrentPlayer].Name;
            PicturePlayer.Image = Players[CurrentPlayer].Mark;
        }
        private void Mark(Button btn)
        {
            btn.BackgroundImage = Players[CurrentPlayer].Mark;
            CurrentPlayer = CurrentPlayer == 0 ? 1 : 0;
        }
        #endregion
    }
}
