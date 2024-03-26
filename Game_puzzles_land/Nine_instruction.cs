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
    public partial class Nine_instruction : Form
    {
        PrivateFontCollection my_font;

        public Nine_instruction()
        {
            InitializeComponent();
            Add_my_font();
            Use_my_font();

            //установка текста в компонентах
            txtBox_instruction.Text = "Этот филворд схож с\nсудоку, ведь в \nкаждом малом \nквадрате находится \nровно 9 букв.\r\nВ ячейке филворда \nрасположено только \nодно слово";
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
            txtBox_instruction.Font = new Font(my_font.Families[0], 13);
            lbl_title_level.Font = new Font(my_font.Families[0], 15);
            rndBtn_ok.Font = new Font(my_font.Families[0], 13);
        }

        //навигация меню "Выбор вида головоломки"
        private void rndBtn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
