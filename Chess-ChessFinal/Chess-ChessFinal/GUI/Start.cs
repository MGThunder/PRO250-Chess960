using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess.GUI
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rbtnSandardChess.Checked)
            {
                window ChessGame = new window(true);
                ChessGame.AddEvents();
                ChessGame.Show();
                Hide();
            }
            else if (rbtnChess960.Checked)
            {
                window ChessGame = new window(false);
                ChessGame.AddEvents();
                ChessGame.Show();
                Hide();
            }
        }
    }
}
