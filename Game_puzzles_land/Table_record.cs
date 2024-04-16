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
    public partial class Table_record : Form
    {
        PrivateFontCollection my_font;

        public Table_record()
        {
            InitializeComponent();
            Add_my_font();
            Use_my_font();

            //вывод сохраненных парамеров приложения
            lbl_crossword_classic_result.Text = Convert.ToString(Properties.Settings.Default.CrosswordClassicRecord) + "%";  //рекод в классическом
            lbl_crossword_numberbus_result.Text = Convert.ToString(Properties.Settings.Default.CrosswordNumberbusRecord) + "%";  //рекорд в числобусе
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
            strLbl_record_list.Font = new Font(my_font.Families[0], 26);
            lbl_title_pazzles.Font = new Font(my_font.Families[0], 15);
            lbl_number.Font = new Font(my_font.Families[0], 15);
            lbl_result.Font = new Font(my_font.Families[0], 15);
            lbl_crossword_classic.Font = new Font(my_font.Families[0], 15);
            lbl_crossword_numberbus.Font = new Font(my_font.Families[0], 15);
            lbl_crossword_classic_number.Font = new Font(my_font.Families[0], 15);
            lbl_crossword_numberbus_number.Font = new Font(my_font.Families[0], 15);
            lbl_crossword_classic_result.Font = new Font(my_font.Families[0], 15);
            lbl_crossword_numberbus_result.Font = new Font(my_font.Families[0], 15);
        }

        private void rndBtn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
