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
    public partial class Fillwords_nine : Form
    {
        PrivateFontCollection my_font;

        const int count_answers = 6;   //кол-во слов в филворде
        const int count_start_cell = 6;  //кол-во начальных букв
        int correct_answers = 0;   //кол-во правильно найденных слов в филлворде

        //список для записи открытых начальных букв при помощи подсказки
        List<int> help_open = new List<int>(count_start_cell);
        int help_count = 5;   //кол-во подсказок

        string[] answers = new string[count_answers]   //массив слов филлворда
              {
                    "циферблат",
                    "император",
                    "украшение",
                    "жаворонок",
                    "закорючка",
                    "перламутр",
              };

        //переменная для записи найденных слов в филлворде
        string word = "";

        public Fillwords_nine()
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
            Nine_instruction nine_Instruction = new Nine_instruction();
            nine_Instruction.Show();
        }

        private void custTxtBox_000_MouseDown(object sender, MouseEventArgs e)
        {
            word += custTxtBox_000.Text;
            custTxtBox_000.BackColor = Color.NavajoWhite;
            rndBtn_back.Focus();
        }
        private void custTxtBox_010_MouseDown(object sender, MouseEventArgs e)
        {
            word += custTxtBox_010.Text;
            custTxtBox_010.BackColor = Color.NavajoWhite;
            rndBtn_back.Focus();
        }

        private void custTxtBox_020_MouseDown(object sender, MouseEventArgs e)
        {
            word += custTxtBox_020.Text;
            custTxtBox_020.BackColor = Color.NavajoWhite;
            rndBtn_back.Focus();
        }

        private void custTxtBox_001_MouseDown(object sender, MouseEventArgs e)
        {
            word += custTxtBox_001.Text;
            custTxtBox_001.BackColor = Color.NavajoWhite;
            rndBtn_back.Focus();
        }

        private void custTxtBox_011_MouseDown(object sender, MouseEventArgs e)
        {
            word += custTxtBox_011.Text;
            custTxtBox_011.BackColor = Color.NavajoWhite;
            rndBtn_back.Focus();
        }

        private void custTxtBox_021_MouseDown(object sender, MouseEventArgs e)
        {
            word += custTxtBox_021.Text;
            custTxtBox_021.BackColor = Color.NavajoWhite;
            rndBtn_back.Focus();
        }

        private void custTxtBox_002_MouseDown(object sender, MouseEventArgs e)
        {
            word += custTxtBox_002.Text;
            custTxtBox_002.BackColor = Color.NavajoWhite;
            rndBtn_back.Focus();
        }

        private void custTxtBox_012_MouseDown(object sender, MouseEventArgs e)
        {
            word += custTxtBox_012.Text;
            custTxtBox_012.BackColor = Color.NavajoWhite;
            rndBtn_back.Focus();
        }

        private void custTxtBox_022_MouseDown(object sender, MouseEventArgs e)
        {
            word += custTxtBox_022.Text;
            custTxtBox_022.BackColor = Color.NavajoWhite;
            rndBtn_back.Focus();
        }

        private void custTxtBox_000_MouseUp(object sender, MouseEventArgs e)
        {
            word += custTxtBox_000.Text;
            custTxtBox_000.BackColor = Color.NavajoWhite;
            rndBtn_back.Focus();
        }

        private void custTxtBox_010_MouseUp(object sender, MouseEventArgs e)
        {
            word += custTxtBox_010.Text;
            custTxtBox_010.BackColor = Color.NavajoWhite;
            rndBtn_back.Focus();
        }

        private void custTxtBox_020_MouseUp(object sender, MouseEventArgs e)
        {
            word += custTxtBox_020.Text;
            custTxtBox_020.BackColor = Color.NavajoWhite;
            rndBtn_back.Focus();
        }

        private void custTxtBox_001_MouseUp(object sender, MouseEventArgs e)
        {
            word += custTxtBox_001.Text;
            custTxtBox_001.BackColor = Color.NavajoWhite;
            rndBtn_back.Focus();
        }

        private void custTxtBox_011_MouseUp(object sender, MouseEventArgs e)
        {
            word += custTxtBox_011.Text;
            custTxtBox_011.BackColor = Color.NavajoWhite;
            rndBtn_back.Focus();
        }

        private void custTxtBox_021_MouseUp(object sender, MouseEventArgs e)
        {
            word += custTxtBox_021.Text;
            custTxtBox_021.BackColor = Color.NavajoWhite;
            rndBtn_back.Focus();
        }

        private void custTxtBox_002_MouseUp(object sender, MouseEventArgs e)
        {
            word += custTxtBox_002.Text;
            custTxtBox_002.BackColor = Color.NavajoWhite;
            rndBtn_back.Focus();
        }

        private void custTxtBox_012_MouseUp(object sender, MouseEventArgs e)
        {
            word += custTxtBox_012.Text;
            custTxtBox_012.BackColor = Color.NavajoWhite;
            rndBtn_back.Focus();
        }

        private void custTxtBox_022_MouseUp(object sender, MouseEventArgs e)
        {
            word += custTxtBox_022.Text;
            custTxtBox_022.BackColor = Color.NavajoWhite;
            rndBtn_back.Focus();
        }

        private void custTxtBox_010_MouseHover(object sender, EventArgs e)
        {
            word += custTxtBox_010.Text;
            custTxtBox_010.BackColor = Color.NavajoWhite;
            rndBtn_back.Focus();
        }

        private void custTxtBox_010_MouseEnter(object sender, EventArgs e)
        {
            word += custTxtBox_010.Text;
            custTxtBox_010.BackColor = Color.NavajoWhite;
            rndBtn_back.Focus();
        }
    }
}