namespace Shotgun {
    partial class EndScreen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cmdPlayAgain = new System.Windows.Forms.Button();
            this.cmdExitGame = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdPlayAgain
            // 
            this.cmdPlayAgain.Location = new System.Drawing.Point(50, 80);
            this.cmdPlayAgain.Name = "cmdPlayAgain";
            this.cmdPlayAgain.Size = new System.Drawing.Size(142, 37);
            this.cmdPlayAgain.TabIndex = 0;
            this.cmdPlayAgain.Text = "Play Again";
            this.cmdPlayAgain.UseVisualStyleBackColor = true;
            this.cmdPlayAgain.Click += new System.EventHandler(this.cmdPlayAgain_Click);
            // 
            // cmdExitGame
            // 
            this.cmdExitGame.Location = new System.Drawing.Point(198, 80);
            this.cmdExitGame.Name = "cmdExitGame";
            this.cmdExitGame.Size = new System.Drawing.Size(147, 37);
            this.cmdExitGame.TabIndex = 1;
            this.cmdExitGame.Text = "Exit Game";
            this.cmdExitGame.UseVisualStyleBackColor = true;
            this.cmdExitGame.Click += new System.EventHandler(this.cmdExitGame_Click);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResult.AutoSize = true;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(22, 25);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(201, 31);
            this.txtResult.TabIndex = 2;
            this.txtResult.Text = "Victory / Defeat";
            this.txtResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 133);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.cmdExitGame);
            this.Controls.Add(this.cmdPlayAgain);
            this.Name = "EndScreen";
            this.Text = "EndScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdPlayAgain;
        private System.Windows.Forms.Button cmdExitGame;
        private System.Windows.Forms.Label txtResult;
    }
}