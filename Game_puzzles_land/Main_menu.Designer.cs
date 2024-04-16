namespace Game_puzzles_land
{
    partial class Main_menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rndBtn_start = new Game_puzzles_land.My_controrls.RoundButton();
            this.lbl_game_title = new System.Windows.Forms.Label();
            this.rndBtn_record = new Game_puzzles_land.My_controrls.RoundButton();
            this.rndBtn_exit = new Game_puzzles_land.My_controrls.RoundButton();
            this.SuspendLayout();
            // 
            // rndBtn_start
            // 
            this.rndBtn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(248)))));
            this.rndBtn_start.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(248)))));
            this.rndBtn_start.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(248)))));
            this.rndBtn_start.BorderRadius = 45;
            this.rndBtn_start.BorderSize = 0;
            this.rndBtn_start.FlatAppearance.BorderSize = 0;
            this.rndBtn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rndBtn_start.Font = new System.Drawing.Font("Microsoft YaHei", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rndBtn_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(9)))), ((int)(((byte)(98)))));
            this.rndBtn_start.Location = new System.Drawing.Point(633, 374);
            this.rndBtn_start.Name = "rndBtn_start";
            this.rndBtn_start.Size = new System.Drawing.Size(491, 83);
            this.rndBtn_start.TabIndex = 1;
            this.rndBtn_start.Text = "Старт";
            this.rndBtn_start.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(9)))), ((int)(((byte)(98)))));
            this.rndBtn_start.UseVisualStyleBackColor = false;
            this.rndBtn_start.Click += new System.EventHandler(this.rndBtn_start_Click);
            // 
            // lbl_game_title
            // 
            this.lbl_game_title.AutoSize = true;
            this.lbl_game_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_game_title.Image = global::Game_puzzles_land.Properties.Resources.title_game;
            this.lbl_game_title.Location = new System.Drawing.Point(620, 205);
            this.lbl_game_title.MaximumSize = new System.Drawing.Size(518, 114);
            this.lbl_game_title.MinimumSize = new System.Drawing.Size(518, 114);
            this.lbl_game_title.Name = "lbl_game_title";
            this.lbl_game_title.Size = new System.Drawing.Size(518, 114);
            this.lbl_game_title.TabIndex = 2;
            // 
            // rndBtn_record
            // 
            this.rndBtn_record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(229)))), ((int)(((byte)(215)))));
            this.rndBtn_record.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(229)))), ((int)(((byte)(215)))));
            this.rndBtn_record.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(229)))), ((int)(((byte)(215)))));
            this.rndBtn_record.BorderRadius = 45;
            this.rndBtn_record.BorderSize = 0;
            this.rndBtn_record.FlatAppearance.BorderSize = 0;
            this.rndBtn_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rndBtn_record.Font = new System.Drawing.Font("Microsoft YaHei", 24.75F, System.Drawing.FontStyle.Bold);
            this.rndBtn_record.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(153)))), ((int)(((byte)(95)))));
            this.rndBtn_record.Location = new System.Drawing.Point(633, 486);
            this.rndBtn_record.Name = "rndBtn_record";
            this.rndBtn_record.Size = new System.Drawing.Size(491, 83);
            this.rndBtn_record.TabIndex = 3;
            this.rndBtn_record.Text = "Достижения";
            this.rndBtn_record.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(153)))), ((int)(((byte)(95)))));
            this.rndBtn_record.UseVisualStyleBackColor = false;
            this.rndBtn_record.Click += new System.EventHandler(this.rndBtn_record_Click);
            // 
            // rndBtn_exit
            // 
            this.rndBtn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(69)))), ((int)(((byte)(127)))));
            this.rndBtn_exit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(69)))), ((int)(((byte)(127)))));
            this.rndBtn_exit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(69)))), ((int)(((byte)(127)))));
            this.rndBtn_exit.BorderRadius = 45;
            this.rndBtn_exit.BorderSize = 0;
            this.rndBtn_exit.FlatAppearance.BorderSize = 0;
            this.rndBtn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rndBtn_exit.Font = new System.Drawing.Font("Microsoft YaHei", 24.75F, System.Drawing.FontStyle.Bold);
            this.rndBtn_exit.ForeColor = System.Drawing.Color.White;
            this.rndBtn_exit.Location = new System.Drawing.Point(633, 600);
            this.rndBtn_exit.Name = "rndBtn_exit";
            this.rndBtn_exit.Size = new System.Drawing.Size(491, 83);
            this.rndBtn_exit.TabIndex = 4;
            this.rndBtn_exit.Text = "Выход";
            this.rndBtn_exit.TextColor = System.Drawing.Color.White;
            this.rndBtn_exit.UseVisualStyleBackColor = false;
            this.rndBtn_exit.Click += new System.EventHandler(this.rndBtn_exit_Click);
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_puzzles_land.Properties.Resources.bcgr_main_menu;
            this.ClientSize = new System.Drawing.Size(1325, 882);
            this.Controls.Add(this.rndBtn_exit);
            this.Controls.Add(this.rndBtn_record);
            this.Controls.Add(this.lbl_game_title);
            this.Controls.Add(this.rndBtn_start);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1345, 925);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1345, 925);
            this.Name = "Main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private My_controrls.RoundButton rndBtn_start;
        private System.Windows.Forms.Label lbl_game_title;
        private My_controrls.RoundButton rndBtn_record;
        private My_controrls.RoundButton rndBtn_exit;
    }
}

