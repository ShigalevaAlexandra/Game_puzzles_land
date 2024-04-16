namespace Game_puzzles_land
{
    partial class Table_record
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
            this.rndBtn_back = new Game_puzzles_land.My_controrls.RoundButton();
            this.strLbl_record_list = new Game_puzzles_land.My_controrls.StrokeLabel();
            this.lbl_title_pazzles = new System.Windows.Forms.Label();
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_crossword_classic = new System.Windows.Forms.Label();
            this.lbl_crossword_numberbus = new System.Windows.Forms.Label();
            this.lbl_crossword_classic_number = new System.Windows.Forms.Label();
            this.lbl_crossword_numberbus_number = new System.Windows.Forms.Label();
            this.lbl_crossword_classic_result = new System.Windows.Forms.Label();
            this.lbl_crossword_numberbus_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rndBtn_back
            // 
            this.rndBtn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(69)))), ((int)(((byte)(127)))));
            this.rndBtn_back.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(69)))), ((int)(((byte)(127)))));
            this.rndBtn_back.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(9)))), ((int)(((byte)(98)))));
            this.rndBtn_back.BorderRadius = 34;
            this.rndBtn_back.BorderSize = 5;
            this.rndBtn_back.FlatAppearance.BorderSize = 0;
            this.rndBtn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rndBtn_back.Font = new System.Drawing.Font("Microsoft YaHei", 24.75F, System.Drawing.FontStyle.Bold);
            this.rndBtn_back.ForeColor = System.Drawing.Color.White;
            this.rndBtn_back.Location = new System.Drawing.Point(68, 68);
            this.rndBtn_back.Name = "rndBtn_back";
            this.rndBtn_back.Size = new System.Drawing.Size(121, 68);
            this.rndBtn_back.TabIndex = 2;
            this.rndBtn_back.Text = "<<";
            this.rndBtn_back.TextColor = System.Drawing.Color.White;
            this.rndBtn_back.UseVisualStyleBackColor = false;
            this.rndBtn_back.Click += new System.EventHandler(this.rndBtn_back_Click);
            // 
            // strLbl_record_list
            // 
            this.strLbl_record_list.AutoSize = true;
            this.strLbl_record_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.strLbl_record_list.Font = new System.Drawing.Font("Microsoft YaHei", 24.75F, System.Drawing.FontStyle.Bold);
            this.strLbl_record_list.ForeColor = System.Drawing.Color.White;
            this.strLbl_record_list.Location = new System.Drawing.Point(470, 229);
            this.strLbl_record_list.MaximumSize = new System.Drawing.Size(599, 89);
            this.strLbl_record_list.MinimumSize = new System.Drawing.Size(599, 89);
            this.strLbl_record_list.Name = "strLbl_record_list";
            this.strLbl_record_list.OutlineForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(9)))), ((int)(((byte)(98)))));
            this.strLbl_record_list.OutlineWidth = 5F;
            this.strLbl_record_list.Size = new System.Drawing.Size(599, 89);
            this.strLbl_record_list.TabIndex = 3;
            this.strLbl_record_list.Text = "ДОСТИЖЕНИЯ";
            this.strLbl_record_list.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_title_pazzles
            // 
            this.lbl_title_pazzles.AutoSize = true;
            this.lbl_title_pazzles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_title_pazzles.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_title_pazzles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lbl_title_pazzles.Location = new System.Drawing.Point(206, 349);
            this.lbl_title_pazzles.Name = "lbl_title_pazzles";
            this.lbl_title_pazzles.Size = new System.Drawing.Size(173, 19);
            this.lbl_title_pazzles.TabIndex = 4;
            this.lbl_title_pazzles.Text = "название головоломки";
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_number.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(132)))), ((int)(((byte)(52)))));
            this.lbl_number.Location = new System.Drawing.Point(643, 349);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(120, 19);
            this.lbl_number.TabIndex = 5;
            this.lbl_number.Text = "номер попытки";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_result.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(52)))), ((int)(((byte)(119)))));
            this.lbl_result.Location = new System.Drawing.Point(969, 349);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(76, 19);
            this.lbl_result.TabIndex = 6;
            this.lbl_result.Text = "результат";
            // 
            // lbl_crossword_classic
            // 
            this.lbl_crossword_classic.AutoSize = true;
            this.lbl_crossword_classic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_crossword_classic.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_crossword_classic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lbl_crossword_classic.Location = new System.Drawing.Point(206, 408);
            this.lbl_crossword_classic.Name = "lbl_crossword_classic";
            this.lbl_crossword_classic.Size = new System.Drawing.Size(106, 19);
            this.lbl_crossword_classic.TabIndex = 7;
            this.lbl_crossword_classic.Text = "Классический";
            // 
            // lbl_crossword_numberbus
            // 
            this.lbl_crossword_numberbus.AutoSize = true;
            this.lbl_crossword_numberbus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_crossword_numberbus.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_crossword_numberbus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lbl_crossword_numberbus.Location = new System.Drawing.Point(206, 456);
            this.lbl_crossword_numberbus.Name = "lbl_crossword_numberbus";
            this.lbl_crossword_numberbus.Size = new System.Drawing.Size(75, 19);
            this.lbl_crossword_numberbus.TabIndex = 8;
            this.lbl_crossword_numberbus.Text = "Числобус";
            // 
            // lbl_crossword_classic_number
            // 
            this.lbl_crossword_classic_number.AutoSize = true;
            this.lbl_crossword_classic_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_crossword_classic_number.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_crossword_classic_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lbl_crossword_classic_number.Location = new System.Drawing.Point(751, 408);
            this.lbl_crossword_classic_number.Name = "lbl_crossword_classic_number";
            this.lbl_crossword_classic_number.Size = new System.Drawing.Size(17, 19);
            this.lbl_crossword_classic_number.TabIndex = 9;
            this.lbl_crossword_classic_number.Text = "0";
            // 
            // lbl_crossword_numberbus_number
            // 
            this.lbl_crossword_numberbus_number.AutoSize = true;
            this.lbl_crossword_numberbus_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_crossword_numberbus_number.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_crossword_numberbus_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lbl_crossword_numberbus_number.Location = new System.Drawing.Point(749, 456);
            this.lbl_crossword_numberbus_number.Name = "lbl_crossword_numberbus_number";
            this.lbl_crossword_numberbus_number.Size = new System.Drawing.Size(17, 19);
            this.lbl_crossword_numberbus_number.TabIndex = 10;
            this.lbl_crossword_numberbus_number.Text = "0";
            // 
            // lbl_crossword_classic_result
            // 
            this.lbl_crossword_classic_result.AutoSize = true;
            this.lbl_crossword_classic_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_crossword_classic_result.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_crossword_classic_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lbl_crossword_classic_result.Location = new System.Drawing.Point(1033, 408);
            this.lbl_crossword_classic_result.Name = "lbl_crossword_classic_result";
            this.lbl_crossword_classic_result.Size = new System.Drawing.Size(17, 19);
            this.lbl_crossword_classic_result.TabIndex = 11;
            this.lbl_crossword_classic_result.Text = "0";
            // 
            // lbl_crossword_numberbus_result
            // 
            this.lbl_crossword_numberbus_result.AutoSize = true;
            this.lbl_crossword_numberbus_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_crossword_numberbus_result.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_crossword_numberbus_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lbl_crossword_numberbus_result.Location = new System.Drawing.Point(1033, 456);
            this.lbl_crossword_numberbus_result.Name = "lbl_crossword_numberbus_result";
            this.lbl_crossword_numberbus_result.Size = new System.Drawing.Size(17, 19);
            this.lbl_crossword_numberbus_result.TabIndex = 12;
            this.lbl_crossword_numberbus_result.Text = "0";
            // 
            // Table_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_puzzles_land.Properties.Resources.bcgr_table_record;
            this.ClientSize = new System.Drawing.Size(1329, 886);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_crossword_numberbus_result);
            this.Controls.Add(this.lbl_crossword_classic_result);
            this.Controls.Add(this.lbl_crossword_numberbus_number);
            this.Controls.Add(this.lbl_crossword_classic_number);
            this.Controls.Add(this.lbl_crossword_numberbus);
            this.Controls.Add(this.lbl_crossword_classic);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_number);
            this.Controls.Add(this.lbl_title_pazzles);
            this.Controls.Add(this.strLbl_record_list);
            this.Controls.Add(this.rndBtn_back);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1345, 925);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1345, 925);
            this.Name = "Table_record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лучшие результаты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private My_controrls.RoundButton rndBtn_back;
        private My_controrls.StrokeLabel strLbl_record_list;
        private System.Windows.Forms.Label lbl_title_pazzles;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_crossword_classic;
        private System.Windows.Forms.Label lbl_crossword_numberbus;
        private System.Windows.Forms.Label lbl_crossword_classic_number;
        private System.Windows.Forms.Label lbl_crossword_numberbus_number;
        private System.Windows.Forms.Label lbl_crossword_classic_result;
        private System.Windows.Forms.Label lbl_crossword_numberbus_result;
    }
}