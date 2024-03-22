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
    public partial class Classic_instruction : Form
    {
        PrivateFontCollection my_font;

        public Classic_instruction()
        {
            InitializeComponent();
            Add_my_font();
            Use_my_font();

            //установка текста в компонентах
            txtBox_instruction.Text = "Для разгадывания \nэтого кроссворда \nнеобходимо \nправильно \nподобрать ответы \nна поставленные \nвопросы.\r\n\r\nВопросы появятся \nполсе наведения \nкурсора на \nнумерованную \nячейку кроссворда";
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
