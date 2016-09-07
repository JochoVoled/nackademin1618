using System;
using System.Windows.Forms;

namespace Shotgun {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void cmdAction(object sender, EventArgs e) {
            // Read input
            GameManager.player.action = (sender as Button).Text.ToLower();
            GameManager.GameLoop();
            // Output
            GameManager.RenderGui(this);
        }

        private void Form1_Load(object sender, EventArgs e) {
            GameManager.RenderGui(this);
        }
    }
}
