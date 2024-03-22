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
    public partial class Choice_crosswords : Form
    {
        PrivateFontCollection my_font;

        public Choice_crosswords()
        {
            InitializeComponent();
            Add_my_font();
            Use_my_font();

            //установка текста в компонентах
            strLbl_choice_crosswords.Text = "РАЗНОВИДНОСТИ\n    КРОССВОРДОВ";
        }

        //функция для загрузки шрифтов в приложение
        private void Add_my_font()
        {
            this.my_font = new PrivateFontCollection();
            this.my_font.AddFontFile("fonts/seymour-one.ttf");
        }

        //функция применения шрифтов
        private void Use_my_font()
        {
            //seymour-one.ttf
            rndBtn_back.Font = new Font(my_font.Families[0], 24);
            strLbl_choice_crosswords.Font = new Font(my_font.Families[0], 26);
            rndBtn_classic.Font = new Font(my_font.Families[0], 24);
            rndBtn_numberbus.Font = new Font(my_font.Families[0], 24);
        }

        //навигация меню "Выбор вида головоломки"
        private void rndBtn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Choice_puzzle choice_Puzzle = new Choice_puzzle();
            choice_Puzzle.Show();
        }

        private void rndBtn_classic_Click(object sender, EventArgs e)
        {
            this.Close(); 
            Crosswords_classic crosswords_Classic = new Crosswords_classic();
            crosswords_Classic.Show();
        }

        private void rndBtn_numberbus_Click(object sender, EventArgs e)
        {
            this.Close();
            Crossword_numberbus crossword_Numberbus = new Crossword_numberbus();
            crossword_Numberbus.Show();
        }
    }
}