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
    public partial class Fillwords_angle : Form
    {
        PrivateFontCollection my_font;

        public Fillwords_angle()
        {
            InitializeComponent();
            Add_my_font();
            Use_my_font();
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
            rndBtn_help.Font = new Font(my_font.Families[0], 18);
            rndBtn_instruction.Font = new Font(my_font.Families[0], 18);
            strLbl_level_title.Font = new Font(my_font.Families[0], 26);
            strLbl_timer.Font = new Font(my_font.Families[0], 18);
            strLbl_record.Font = new Font(my_font.Families[0], 18);
            strLbl_value_timer.Font = new Font(my_font.Families[0], 18);
            strLbl_value_record.Font = new Font(my_font.Families[0], 18);
        }

        //навигация меню "Выбор вида головоломки"
        private void rndBtn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Choice_fillwords choice_Fillwords = new Choice_fillwords();
            choice_Fillwords.Show();
        }

        private void rndBtn_instruction_Click(object sender, EventArgs e)
        {
            Angle_instruction angle_instruction = new Angle_instruction();
            angle_instruction.Show();
        }
    }
}