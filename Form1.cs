using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro
{
    public partial class Form1 : Form
    {
        #region Properties
        ManagerChessBoard Chess;
        #endregion
        public Form1()
        {
            InitializeComponent();
            Chess = new ManagerChessBoard(panelCaro,picturePlayer,PlayerName);
            Chess.DrawChessBoard();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PanelBoard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
