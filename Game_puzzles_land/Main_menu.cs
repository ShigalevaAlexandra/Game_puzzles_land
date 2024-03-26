using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_puzzles_land
{
    public partial class Main_menu : Form
    {
        PrivateFontCollection my_font;

        public Main_menu()
        {
            InitializeComponent();
            Add_my_font();
            Use_my_font();
        }

        //функция для загрузки шрифтов в приложение
        private void Add_my_font()
        {
            this.my_font = new PrivateFontCollection();
            this.my_font.AddFontFile("../../seymour-one.ttf");
        }

        //функция применения шрифтов
        private void Use_my_font()
        {
            //seymour-one.ttf
            rndBtn_start.Font = new Font(my_font.Families[0], 24);
            rndBtn_record.Font = new Font(my_font.Families[0], 24);
            rndBtn_exit.Font = new Font(my_font.Families[0], 24);
        }

        //навигация главного меню

        private void rndBtn_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Choice_puzzle choice_Puzzle = new Choice_puzzle();
            choice_Puzzle.Show();
        }

        private void rndBtn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}