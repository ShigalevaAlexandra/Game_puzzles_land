namespace Game_puzzles_land
{
    partial class Numberbus_instruction
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
            this.lbl_title_level = new System.Windows.Forms.Label();
            this.txtBox_instruction = new System.Windows.Forms.TextBox();
            this.pctBox_img_instruction = new System.Windows.Forms.PictureBox();
            this.rndBtn_ok = new Game_puzzles_land.My_controrls.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_img_instruction)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title_level
            // 
            this.lbl_title_level.AutoSize = true;
            this.lbl_title_level.BackColor = System.Drawing.Color.White;
            this.lbl_title_level.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_title_level.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(21)))), ((int)(((byte)(155)))));
            this.lbl_title_level.Location = new System.Drawing.Point(96, 96);
            this.lbl_title_level.MinimumSize = new System.Drawing.Size(260, 35);
            this.lbl_title_level.Name = "lbl_title_level";
            this.lbl_title_level.Size = new System.Drawing.Size(260, 36);
            this.lbl_title_level.TabIndex = 3;
            this.lbl_title_level.Text = "ЧИСЛОБУС";
            // 
            // txtBox_instruction
            // 
            this.txtBox_instruction.BackColor = System.Drawing.Color.White;
            this.txtBox_instruction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_instruction.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_instruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(131)))), ((int)(((byte)(164)))));
            this.txtBox_instruction.Location = new System.Drawing.Point(379, 151);
            this.txtBox_instruction.MinimumSize = new System.Drawing.Size(276, 298);
            this.txtBox_instruction.Multiline = true;
            this.txtBox_instruction.Name = "txtBox_instruction";
            this.txtBox_instruction.ReadOnly = true;
            this.txtBox_instruction.Size = new System.Drawing.Size(276, 346);
            this.txtBox_instruction.TabIndex = 4;
            this.txtBox_instruction.TabStop = false;
            this.txtBox_instruction.Text = "В этот кроссворд нужно вписать не слова, а числа. Вы найдете их в левой части игр" +
    "ового окна, расположенные по возрастанию.\n\nВаша задача - найти место в числобусе" +
    " для каждого из них";
            // 
            // pctBox_img_instruction
            // 
            this.pctBox_img_instruction.BackColor = System.Drawing.Color.White;
            this.pctBox_img_instruction.BackgroundImage = global::Game_puzzles_land.Properties.Resources.primer_area_numberbus;
            this.pctBox_img_instruction.Location = new System.Drawing.Point(96, 151);
            this.pctBox_img_instruction.MinimumSize = new System.Drawing.Size(220, 220);
            this.pctBox_img_instruction.Name = "pctBox_img_instruction";
            this.pctBox_img_instruction.Size = new System.Drawing.Size(220, 220);
            this.pctBox_img_instruction.TabIndex = 13;
            this.pctBox_img_instruction.TabStop = false;
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
            this.rndBtn_ok.Location = new System.Drawing.Point(607, 467);
            this.rndBtn_ok.Name = "rndBtn_ok";
            this.rndBtn_ok.Size = new System.Drawing.Size(95, 41);
            this.rndBtn_ok.TabIndex = 14;
            this.rndBtn_ok.Text = "ок";
            this.rndBtn_ok.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(69)))), ((int)(((byte)(127)))));
            this.rndBtn_ok.UseVisualStyleBackColor = false;
            this.rndBtn_ok.Click += new System.EventHandler(this.rndBtn_ok_Click);
            // 
            // Numberbus_instruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_puzzles_land.Properties.Resources.bcgr_instruction_numberbus;
            this.ClientSize = new System.Drawing.Size(760, 563);
            this.ControlBox = false;
            this.Controls.Add(this.rndBtn_ok);
            this.Controls.Add(this.pctBox_img_instruction);
            this.Controls.Add(this.txtBox_instruction);
            this.Controls.Add(this.lbl_title_level);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Numberbus_instruction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numberbus_instruction";
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_img_instruction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title_level;
        private System.Windows.Forms.TextBox txtBox_instruction;
        private System.Windows.Forms.PictureBox pctBox_img_instruction;
        private My_controrls.RoundButton rndBtn_ok;
    }
}