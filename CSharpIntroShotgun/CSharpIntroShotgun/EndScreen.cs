using System;
using System.Windows.Forms;

namespace Shotgun {
    public partial class EndScreen : Form {
        public EndScreen(string message) {
            InitializeComponent();
            txtResult.Text = message;
        }

        private void cmdPlayAgain_Click(object sender, EventArgs e) {
            Application.Restart();
        }

        private void cmdExitGame_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
