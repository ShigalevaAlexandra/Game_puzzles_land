using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_puzzles_land
{
    public partial class Choice_fillwords : Form
    {
        PrivateFontCollection my_font;

        public Choice_fillwords()
        {
            InitializeComponent();
            Add_my_font();
            Use_my_font();

            //установка текста в компонентах
            strLbl_choice_fillwords.Text = "РАЗНОВИДНОСТИ\n        ФИЛВОРДОВ";
        }

        //функция для загрузки шрифтов в приложение
        private void Add_my_font()
        {
            this.my_font = new PrivateFontCollection();
            this.my_font.AddFontFile("../../fonts/seymour-one.ttf");
        }

        //функция применения шрифтов
        private void Use_my_font()
        {
            //seymour-one.ttf
            rndBtn_back.Font = new Font(my_font.Families[0], 24);
            strLbl_choice_fillwords.Font = new Font(my_font.Families[0], 26);
            rndBtn_angle.Font = new Font(my_font.Families[0], 24);
            rndBtn_nine.Font = new Font(my_font.Families[0], 24);
        }

        //навигация меню "Выбор вида головоломки"
        private void rndBtn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Choice_puzzle choice_Puzzle = new Choice_puzzle();
            choice_Puzzle.Show();
        }

        private void rndBtn_angle_Click(object sender, EventArgs e)
        {
            this.Close();
            Fillwords_angle fillwords_Angle = new Fillwords_angle();
            fillwords_Angle.Show();
        }

        private void rndBtn_nine_Click(object sender, EventArgs e)
        {
            this.Close();
            Fillwords_nine fillwords_Nine = new Fillwords_nine();
            fillwords_Nine.Show();
        }
    }
}