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
    public partial class Crossword_numberbus : Form
    {
        PrivateFontCollection my_font;

        public Crossword_numberbus()
        {
            InitializeComponent();
            Add_my_font();
            Use_my_font();

            //разрешаем вводить текст в поля кроссворда
            custTxtBox_00.ReadOnly = false;
            custTxtBox_01.ReadOnly = false;
            custTxtBox_02.ReadOnly = false;
            custTxtBox_04.ReadOnly = false;
            custTxtBox_05.ReadOnly = false;
          
            custTxtBox_10.ReadOnly = false;
            custTxtBox_12.ReadOnly = false;
            custTxtBox_14.ReadOnly = false;

            custTxtBox_20.ReadOnly = false;
            custTxtBox_21.ReadOnly = false;
            custTxtBox_22.ReadOnly = false;
            custTxtBox_23.ReadOnly = false;
            custTxtBox_24.ReadOnly = false;
            custTxtBox_25.ReadOnly = false;

            custTxtBox_30.ReadOnly = false;
            custTxtBox_32.ReadOnly = false;
            custTxtBox_34.ReadOnly = false;

            custTxtBox_41.ReadOnly = false;
            custTxtBox_42.ReadOnly = false;
            custTxtBox_43.ReadOnly = false;
            custTxtBox_45.ReadOnly = false;

            custTxtBox_50.ReadOnly = false;
            custTxtBox_51.ReadOnly = false;
            custTxtBox_53.ReadOnly = false;
            custTxtBox_54.ReadOnly = false;
            custTxtBox_55.ReadOnly = false;

            custTxtBox_60.ReadOnly = false;
            custTxtBox_62.ReadOnly = false;
            custTxtBox_65.ReadOnly = false;

            custTxtBox_70.ReadOnly = false;
            custTxtBox_71.ReadOnly = false;
            custTxtBox_72.ReadOnly = false;
            custTxtBox_73.ReadOnly = false;
            custTxtBox_74.ReadOnly = false;

            custTxtBox_80.ReadOnly = false;
            custTxtBox_82.ReadOnly = false;
            custTxtBox_85.ReadOnly = false;

            custTxtBox_90.ReadOnly = false;
            custTxtBox_91.ReadOnly = false;
            custTxtBox_92.ReadOnly = false;
            custTxtBox_94.ReadOnly = false;
            custTxtBox_95.ReadOnly = false;
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
            strLbl_progress.Font = new Font(my_font.Families[0], 18);
            strLbl_record.Font = new Font(my_font.Families[0], 18);
            strLbl_value_progress.Font = new Font(my_font.Families[0], 18);
            strLbl_value_record.Font = new Font(my_font.Families[0], 18);
        }

        //навигация меню "Выбор вида головоломки"
        private void rndBtn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Choice_crosswords choice_Crosswords = new Choice_crosswords();
            choice_Crosswords.Show();
        }

        private void rndBtn_instruction_Click(object sender, EventArgs e)
        {
            Numberbus_instruction numberbus_Instruction = new Numberbus_instruction();
            numberbus_Instruction.Show();
        }
    }
}