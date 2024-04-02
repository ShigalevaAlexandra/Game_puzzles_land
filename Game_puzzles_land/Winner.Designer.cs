namespace Game_puzzles_land
{
    partial class Winner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctBox_popugai_happy = new System.Windows.Forms.PictureBox();
            this.strLabel_winner = new Game_puzzles_land.My_controrls.StrokeLabel();
            this.rndBtn_ok = new Game_puzzles_land.My_controrls.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_popugai_happy)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBox_popugai_happy
            // 
            this.pctBox_popugai_happy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pctBox_popugai_happy.Image = global::Game_puzzles_land.Properties.Resources.popugai_happy;
            this.pctBox_popugai_happy.Location = new System.Drawing.Point(187, 121);
            this.pctBox_popugai_happy.Name = "pctBox_popugai_happy";
            this.pctBox_popugai_happy.Size = new System.Drawing.Size(175, 175);
            this.pctBox_popugai_happy.TabIndex = 0;
            this.pctBox_popugai_happy.TabStop = false;
            // 
            // strLabel_winner
            // 
            this.strLabel_winner.AutoSize = true;
            this.strLabel_winner.BackColor = System.Drawing.Color.White;
            this.strLabel_winner.Font = new System.Drawing.Font("Microsoft YaHei", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strLabel_winner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(2)))));
            this.strLabel_winner.Location = new System.Drawing.Point(109, 49);
            this.strLabel_winner.Name = "strLabel_winner";
            this.strLabel_winner.OutlineForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(69)))), ((int)(((byte)(127)))));
            this.strLabel_winner.OutlineWidth = 5F;
            this.strLabel_winner.Size = new System.Drawing.Size(253, 62);
            this.strLabel_winner.TabIndex = 1;
            this.strLabel_winner.Text = "ПОБЕДА!";
            // 
            // rndBtn_ok
            // 
            this.rndBtn_ok.BackColor = System.Drawing.Color.White;
            this.rndBtn_ok.BackgroundColor = System.Drawing.Color.White;
            this.rndBtn_ok.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(9)))), ((int)(((byte)(98)))));
            this.rndBtn_ok.BorderRadius = 20;
            this.rndBtn_ok.BorderSize = 5;
            this.rndBtn_ok.FlatAppearance.BorderSize = 0;
            this.rndBtn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rndBtn_ok.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rndBtn_ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(69)))), ((int)(((byte)(127)))));
            this.rndBtn_ok.Location = new System.Drawing.Point(417, 267);
            this.rndBtn_ok.Name = "rndBtn_ok";
            this.rndBtn_ok.Size = new System.Drawing.Size(95, 41);
            this.rndBtn_ok.TabIndex = 13;
            this.rndBtn_ok.Text = "ок";
            this.rndBtn_ok.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(69)))), ((int)(((byte)(127)))));
            this.rndBtn_ok.UseVisualStyleBackColor = false;
            this.rndBtn_ok.Click += new System.EventHandler(this.rndBtn_ok_Click);
            // 
            // Winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_puzzles_land.Properties.Resources.bcgr_winner1;
            this.ClientSize = new System.Drawing.Size(554, 351);
            this.Controls.Add(this.rndBtn_ok);
            this.Controls.Add(this.strLabel_winner);
            this.Controls.Add(this.pctBox_popugai_happy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Winner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Уровень пройден";
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_popugai_happy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBox_popugai_happy;
        private My_controrls.StrokeLabel strLabel_winner;
        private My_controrls.RoundButton rndBtn_ok;
    }
}