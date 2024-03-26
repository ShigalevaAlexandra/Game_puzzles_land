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
    public partial class Crosswords_classic : Form
    {
        PrivateFontCollection my_font;

        public Crosswords_classic()
        {
            InitializeComponent();
            Add_my_font();
            Use_my_font();

            //разрешаем вводить текст в поля кроссворда
            custTxtBox_10.ReadOnly = false;
            custTxtBox_11.ReadOnly = false;
            custTxtBox_12_60.ReadOnly = false;
            custTxtBox_13.ReadOnly = false;
            custTxtBox_14_90.ReadOnly = false;
            custTxtBox_15.ReadOnly = false;

            custTxtBox_20.ReadOnly = false;
            custTxtBox_21_30.ReadOnly = false;
            custTxtBox_22.ReadOnly = false;
            custTxtBox_23.ReadOnly = false;
            custTxtBox_24_40.ReadOnly = false;
            custTxtBox_25.ReadOnly = false;
            custTxtBox_26.ReadOnly = false;

            custTxtBox_31.ReadOnly = false;
            custTxtBox_64_32.ReadOnly = false;
            custTxtBox_33.ReadOnly = false;

            custTxtBox_41.ReadOnly = false;
            custTxtBox_71_42.ReadOnly = false;
            custTxtBox_43.ReadOnly = false;
            custTxtBox_44.ReadOnly = false;
            custTxtBox_45_111.ReadOnly = false;

            custTxtBox_50.ReadOnly = false;
            custTxtBox_51_62.ReadOnly = false;
            custTxtBox_52.ReadOnly = false;
            custTxtBox_53_92.ReadOnly = false;
            custTxtBox_54_100.ReadOnly = false;

            custTxtBox_61.ReadOnly = false;
            custTxtBox_63.ReadOnly = false;

            custTxtBox_70.ReadOnly = false;
            custTxtBox_72.ReadOnly = false;
            custTxtBox_73_80.ReadOnly = false;

            custTxtBox_81.ReadOnly = false;
            custTxtBox_82.ReadOnly = false;
            custTxtBox_83_113.ReadOnly = false;

            custTxtBox_91.ReadOnly = false;

            custTxtBox_101.ReadOnly = false;
            custTxtBox_102.ReadOnly = false;

            custTxtBox_110.ReadOnly = false;
            custTxtBox_112.ReadOnly = false;
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
            Classic_instruction classic_Instruction = new Classic_instruction();
            classic_Instruction.Show();
        }
    }
}