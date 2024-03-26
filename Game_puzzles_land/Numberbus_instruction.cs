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
    public partial class Numberbus_instruction : Form
    {
        PrivateFontCollection my_font;

        public Numberbus_instruction()
        {
            InitializeComponent();
            Add_my_font();
            Use_my_font();

            //установка текста в компонентах
            txtBox_instruction.Text = "В этот кроссворд \nнужно вписать не \nслова, а числа. Вы \nнайдете их в левой \nчасти игрового окна, \nрасположенные по \nвозрастанию.\r\n\r\nВаша задача - найти \nместо в числобусе \nдля каждого из них";
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
