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
    public partial class Choice_puzzle : Form
    {
        PrivateFontCollection my_font;

        public Choice_puzzle()
        {
            InitializeComponent();
            Add_my_font();
            Use_my_font();

            //установка текста в компонентах
            strLbl_choice_puzzles.Text = "                ВЫБЕРИТЕ\nВИД ГОЛОВОЛОМКИ";
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
            strLbl_choice_puzzles.Font = new Font(my_font.Families[0], 26);
            rndBtn_fillwords.Font = new Font(my_font.Families[0], 24);
            rndBtn_crosswords.Font = new Font(my_font.Families[0], 24);
        }

        //навигация меню "Выбор вида головоломки"
        private void rndBtn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_menu main_Menu = new Main_menu();
            main_Menu.Show();
        }

        private void rndBtn_fillwords_Click(object sender, EventArgs e)
        {
            this.Close();
            Choice_fillwords choice_Fillwords = new Choice_fillwords();
            choice_Fillwords.Show();
        }

        private void rndBtn_crosswords_Click(object sender, EventArgs e)
        {
            this.Close();
            Choice_crosswords choice_Crosswords = new Choice_crosswords();
            choice_Crosswords.Show();
        }
    }
}