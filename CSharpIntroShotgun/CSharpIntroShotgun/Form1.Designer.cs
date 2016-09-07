namespace Shotgun {
    partial class Form1 {
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
            this.components = new System.ComponentModel.Container();
            this.cmdFire = new System.Windows.Forms.Button();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.cmdBlock = new System.Windows.Forms.Button();
            this.cmdShotgun = new System.Windows.Forms.Button();
            this.txtPlayerAmmo = new System.Windows.Forms.Label();
            this.txtOpponentAmmo = new System.Windows.Forms.Label();
            this.txtTurnReport = new System.Windows.Forms.Label();
            this.opponentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.opponentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdFire
            // 
            this.cmdFire.Enabled = false;
            this.cmdFire.Location = new System.Drawing.Point(75, 107);
            this.cmdFire.Name = "cmdFire";
            this.cmdFire.Size = new System.Drawing.Size(70, 67);
            this.cmdFire.TabIndex = 0;
            this.cmdFire.Text = "Fire";
            this.cmdFire.UseVisualStyleBackColor = true;
            this.cmdFire.Click += new System.EventHandler(this.cmdAction);
            // 
            // cmdLoad
            // 
            this.cmdLoad.Location = new System.Drawing.Point(151, 107);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(70, 67);
            this.cmdLoad.TabIndex = 1;
            this.cmdLoad.Text = "Load";
            this.cmdLoad.UseVisualStyleBackColor = true;
            this.cmdLoad.Click += new System.EventHandler(this.cmdAction);
            // 
            // cmdBlock
            // 
            this.cmdBlock.Location = new System.Drawing.Point(227, 107);
            this.cmdBlock.Name = "cmdBlock";
            this.cmdBlock.Size = new System.Drawing.Size(70, 67);
            this.cmdBlock.TabIndex = 2;
            this.cmdBlock.Text = "Block";
            this.cmdBlock.UseVisualStyleBackColor = true;
            this.cmdBlock.Click += new System.EventHandler(this.cmdAction);
            // 
            // cmdShotgun
            // 
            this.cmdShotgun.Enabled = false;
            this.cmdShotgun.Location = new System.Drawing.Point(303, 92);
            this.cmdShotgun.Name = "cmdShotgun";
            this.cmdShotgun.Size = new System.Drawing.Size(105, 96);
            this.cmdShotgun.TabIndex = 3;
            this.cmdShotgun.Text = "Shotgun";
            this.cmdShotgun.UseVisualStyleBackColor = true;
            this.cmdShotgun.Click += new System.EventHandler(this.cmdAction);
            // 
            // txtPlayerAmmo
            // 
            this.txtPlayerAmmo.AutoSize = true;
            this.txtPlayerAmmo.Location = new System.Drawing.Point(11, 16);
            this.txtPlayerAmmo.Name = "txtPlayerAmmo";
            this.txtPlayerAmmo.Size = new System.Drawing.Size(111, 13);
            this.txtPlayerAmmo.TabIndex = 4;
            this.txtPlayerAmmo.Text = "Your shotgun is empty";
            // 
            // txtOpponentAmmo
            // 
            this.txtOpponentAmmo.AutoSize = true;
            this.txtOpponentAmmo.Location = new System.Drawing.Point(314, 16);
            this.txtOpponentAmmo.Name = "txtOpponentAmmo";
            this.txtOpponentAmmo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOpponentAmmo.Size = new System.Drawing.Size(106, 13);
            this.txtOpponentAmmo.TabIndex = 5;
            this.txtOpponentAmmo.Text = "Opponent Ammo is Y";
            this.txtOpponentAmmo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTurnReport
            // 
            this.txtTurnReport.AutoSize = true;
            this.txtTurnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurnReport.Location = new System.Drawing.Point(71, 56);
            this.txtTurnReport.Name = "txtTurnReport";
            this.txtTurnReport.Size = new System.Drawing.Size(302, 20);
            this.txtTurnReport.TabIndex = 6;
            this.txtTurnReport.Text = "As the sun sets, a deadly duel commence";
            this.txtTurnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // opponentBindingSource
            // 
            this.opponentBindingSource.DataSource = typeof(Shotgun.Actors.Opponent);
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(Shotgun.Actors.Player);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 206);
            this.Controls.Add(this.txtTurnReport);
            this.Controls.Add(this.txtOpponentAmmo);
            this.Controls.Add(this.txtPlayerAmmo);
            this.Controls.Add(this.cmdShotgun);
            this.Controls.Add(this.cmdBlock);
            this.Controls.Add(this.cmdLoad);
            this.Controls.Add(this.cmdFire);
            this.Name = "Form1";
            this.Text = "Shotgun";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opponentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.BindingSource opponentBindingSource;
        public System.Windows.Forms.Button cmdFire;
        public System.Windows.Forms.Button cmdLoad;
        public System.Windows.Forms.Button cmdBlock;
        public System.Windows.Forms.Button cmdShotgun;
        public System.Windows.Forms.Label txtPlayerAmmo;
        public System.Windows.Forms.Label txtOpponentAmmo;
        public System.Windows.Forms.Label txtTurnReport;
    }
}

