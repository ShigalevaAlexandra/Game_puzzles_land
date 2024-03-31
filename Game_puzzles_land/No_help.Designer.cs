namespace Game_puzzles_land
{
    partial class No_help
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
            this.pictBox_popugai_bad = new System.Windows.Forms.PictureBox();
            this.pictBox_area_speak = new System.Windows.Forms.PictureBox();
            this.txtBox_no_help = new System.Windows.Forms.TextBox();
            this.rndBtn_ok = new Game_puzzles_land.My_controrls.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_popugai_bad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_area_speak)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBox_popugai_bad
            // 
            this.pictBox_popugai_bad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictBox_popugai_bad.Image = global::Game_puzzles_land.Properties.Resources.popugai_bad;
            this.pictBox_popugai_bad.Location = new System.Drawing.Point(30, 97);
            this.pictBox_popugai_bad.Name = "pictBox_popugai_bad";
            this.pictBox_popugai_bad.Size = new System.Drawing.Size(181, 196);
            this.pictBox_popugai_bad.TabIndex = 0;
            this.pictBox_popugai_bad.TabStop = false;
            // 
            // pictBox_area_speak
            // 
            this.pictBox_area_speak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictBox_area_speak.Image = global::Game_puzzles_land.Properties.Resources.area_speak_popugai;
            this.pictBox_area_speak.Location = new System.Drawing.Point(211, 51);
            this.pictBox_area_speak.Name = "pictBox_area_speak";
            this.pictBox_area_speak.Size = new System.Drawing.Size(268, 148);
            this.pictBox_area_speak.TabIndex = 1;
            this.pictBox_area_speak.TabStop = false;
            // 
            // txtBox_no_help
            // 
            this.txtBox_no_help.BackColor = System.Drawing.Color.White;
            this.txtBox_no_help.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_no_help.Enabled = false;
            this.txtBox_no_help.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_no_help.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(150)))));
            this.txtBox_no_help.Location = new System.Drawing.Point(243, 72);
            this.txtBox_no_help.MinimumSize = new System.Drawing.Size(217, 69);
            this.txtBox_no_help.Multiline = true;
            this.txtBox_no_help.Name = "txtBox_no_help";
            this.txtBox_no_help.ReadOnly = true;
            this.txtBox_no_help.Size = new System.Drawing.Size(217, 83);
            this.txtBox_no_help.TabIndex = 2;
            this.txtBox_no_help.Text = "К сожалению, подсказки закончились((";
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
            this.rndBtn_ok.TabIndex = 12;
            this.rndBtn_ok.Text = "ок";
            this.rndBtn_ok.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(69)))), ((int)(((byte)(127)))));
            this.rndBtn_ok.UseVisualStyleBackColor = false;
            this.rndBtn_ok.Click += new System.EventHandler(this.rndBtn_ok_Click);
            // 
            // No_help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_puzzles_land.Properties.Resources.bcgr_help_0;
            this.ClientSize = new System.Drawing.Size(550, 347);
            this.ControlBox = false;
            this.Controls.Add(this.rndBtn_ok);
            this.Controls.Add(this.txtBox_no_help);
            this.Controls.Add(this.pictBox_area_speak);
            this.Controls.Add(this.pictBox_popugai_bad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 390);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(570, 390);
            this.Name = "No_help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подсказки закончились";
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_popugai_bad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_area_speak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBox_popugai_bad;
        private System.Windows.Forms.PictureBox pictBox_area_speak;
        private System.Windows.Forms.TextBox txtBox_no_help;
        private My_controrls.RoundButton rndBtn_ok;
    }
}