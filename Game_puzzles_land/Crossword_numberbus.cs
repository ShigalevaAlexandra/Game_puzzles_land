using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_puzzles_land
{
    public partial class Crossword_numberbus : Form
    {
        PrivateFontCollection my_font;

        const int count_answers = 18;   //кол-во чисел в кроссворде
        const int count_cell = 42;  //кол-во ячеек в кроссворде
        int correct_answers = 0;   //кол-во правильно введенных слов в поля кроссворда

        //переменные для определения было проверено поле кроссворда или нет
        bool visible_1 = false, visible_2 = false, visible_3 = false, visible_4 = false, visible_5 = false, visible_6 = false,
             visible_7 = false, visible_8 = false, visible_9 = false, visible_10 = false, visible_11 = false, visible_12 = false,
             visible_13 = false, visible_14 = false, visible_15 = false, visible_16 = false, visible_17 = false, visible_18 = false;

        //список для записи открытх ячеек кроссворда при поощи подсказки
        List<int> help_open = new List<int>(count_cell);
        int help_count = 10;   //кол-во подсказок

        string[] answers = new string[count_answers]   //массив чисел кроссворда
               {
                    "10", "25", "45", "68", "81", "98",
                    "151", "219", "638", "765", "913",
                    "1264", "3693", "7283",
                    "27605", "50513", "96289",
                    "875464"
               };

        //переменные для записи введенных чисел в кроссворд
        string number_1 = "", number_2 = "", number_3 = "", number_4 = "", number_5 = "", number_6 = "",
               number_7 = "", number_8 = "", number_9 = "", number_10 = "", number_11 = "", number_12 = "",
               number_13 = "", number_14 = "", number_15 = "", number_16 = "", number_17 = "", number_18 = "";

        bool is_winner = false;  //проверка уровня на завершение

        public Crossword_numberbus()
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
            strLbl_progress.Font = new Font(my_font.Families[0], 18);
            strLbl_record.Font = new Font(my_font.Families[0], 18);
            strLbl_value_progress.Font = new Font(my_font.Families[0], 18);
            strLbl_value_record.Font = new Font(my_font.Families[0], 18);
            strLabel_help.Font = new Font(my_font.Families[0], 18);
            strLabel_help_count.Font = new Font(my_font.Families[0], 18);
        }

        private void symbol_success_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ограничение вводимых символов (можно вводить только символы Аа-Яя)
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[0-9]").Success)
            {
                e.Handled = true;
            }
        }

        //функция проверки введенных ответов пользователем в поля кроссворда
        private void User_answers()
        {
            if (correct_answers < count_answers)
            {
                //получение ответов, введенных пользователем
                number_1 = custTxtBox_04.Texts + custTxtBox_05.Texts;
                number_2 = custTxtBox_85.Texts + custTxtBox_95.Texts;
                number_3 = custTxtBox_94.Texts + custTxtBox_95.Texts;
                number_4 = custTxtBox_41.Texts + custTxtBox_51.Texts;
                number_5 = custTxtBox_43.Texts + custTxtBox_53.Texts;
                number_6 = custTxtBox_50.Texts + custTxtBox_51.Texts;

                number_7 = custTxtBox_53.Texts + custTxtBox_54.Texts + custTxtBox_55.Texts;
                number_8 = custTxtBox_45.Texts + custTxtBox_55.Texts + custTxtBox_65.Texts;
                number_9 = custTxtBox_41.Texts + custTxtBox_42.Texts + custTxtBox_43.Texts;
                number_10 = custTxtBox_00.Texts + custTxtBox_01.Texts + custTxtBox_02.Texts;
                number_11 = custTxtBox_90.Texts + custTxtBox_91.Texts + custTxtBox_92.Texts;

                number_12 = custTxtBox_04.Texts + custTxtBox_14.Texts + custTxtBox_24.Texts + custTxtBox_34.Texts;
                number_13 = custTxtBox_62.Texts + custTxtBox_72.Texts + custTxtBox_82.Texts + custTxtBox_92.Texts;
                number_14 = custTxtBox_00.Texts + custTxtBox_10.Texts + custTxtBox_20.Texts + custTxtBox_30.Texts;

                number_15 = custTxtBox_70.Texts + custTxtBox_71.Texts + custTxtBox_72.Texts + custTxtBox_73.Texts + custTxtBox_74.Texts;
                number_16 = custTxtBox_02.Texts + custTxtBox_12.Texts + custTxtBox_22.Texts + custTxtBox_32.Texts + custTxtBox_42.Texts;
                number_17 = custTxtBox_50.Texts + custTxtBox_60.Texts + custTxtBox_70.Texts + custTxtBox_80.Texts + custTxtBox_90.Texts;

                number_18 = custTxtBox_20.Texts + custTxtBox_21.Texts + custTxtBox_22.Texts + custTxtBox_23.Texts + custTxtBox_24.Texts + custTxtBox_25.Texts;

                //просмотр полей кроссворда на правильность введенных ответов
                //проверка первого числа
                if (number_1 == answers[0])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных чисел
                    custTxtBox_04.BackColor = Color.LightCyan;
                    custTxtBox_05.BackColor = Color.LightCyan;

                    //правильно подставленное число не показывать в списке
                    lbl_10.Visible = false;

                    if (visible_1 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        custTxtBox_04.ReadOnly = true;
                        custTxtBox_05.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(4); help_open.Add(5);
                    }

                    visible_1 = true;
                }

                //проверка второго числа
                if (number_2 == answers[1])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных чисел
                    custTxtBox_85.BackColor = Color.LightCyan;
                    custTxtBox_95.BackColor = Color.LightCyan;

                    //правильно подставленное число не показывать в списке
                    lbl_25.Visible = false;

                    if (visible_2 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        custTxtBox_85.ReadOnly = true;
                        custTxtBox_95.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(37); help_open.Add(42); 
                    }

                    visible_2 = true;
                }

                //проверка третьего числа
                if (number_3 == answers[2])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных чисел
                    custTxtBox_94.BackColor = Color.LightCyan;
                    custTxtBox_95.BackColor = Color.LightCyan;

                    //правильно подставленное число не показывать в списке
                    lbl_45.Visible = false;

                    if (visible_3 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        custTxtBox_94.ReadOnly = true;
                        custTxtBox_95.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(41); help_open.Add(42);
                    }

                    visible_3 = true;
                }

                //проверка четвертого числа
                if (number_4 == answers[3])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных чисел
                    custTxtBox_41.BackColor = Color.LightCyan;
                    custTxtBox_51.BackColor = Color.LightCyan;

                    //правильно подставленное число не показывать в списке
                    lbl_68.Visible = false;

                    if (visible_4 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        custTxtBox_41.ReadOnly = true;
                        custTxtBox_51.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(18); help_open.Add(23); 
                    }

                    visible_4 = true;
                }

                //проверка пятого числа
                if (number_5 == answers[4])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных чисел
                    custTxtBox_43.BackColor = Color.LightCyan;
                    custTxtBox_53.BackColor = Color.LightCyan;

                    //правильно подставленное число не показывать в списке
                    lbl_81.Visible = false;

                    if (visible_5 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        custTxtBox_43.ReadOnly = true;
                        custTxtBox_53.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(20); help_open.Add(24);
                    }

                    visible_5 = true;
                }

                //проверка шестого числа
                if (number_6 == answers[5])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных чисел
                    custTxtBox_50.BackColor = Color.LightCyan;
                    custTxtBox_51.BackColor = Color.LightCyan;

                    //правильно подставленное число не показывать в списке
                    lbl_98.Visible = false;

                    if (visible_6 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        custTxtBox_50.ReadOnly = true;
                        custTxtBox_51.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(22); help_open.Add(23);
                    }

                    visible_6 = true;
                }

                //проверка седьмого числа
                if (number_7 == answers[6])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных чисел
                    custTxtBox_53.BackColor = Color.LightCyan;
                    custTxtBox_54.BackColor = Color.LightCyan;
                    custTxtBox_55.BackColor = Color.LightCyan;

                    //правильно подставленное число не показывать в списке
                    lbl_151.Visible = false;

                    if (visible_7 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        custTxtBox_53.ReadOnly = true;
                        custTxtBox_54.ReadOnly = true;
                        custTxtBox_55.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(24); help_open.Add(25); help_open.Add(26);
                    }

                    visible_7 = true;
                }

                //проверка восьмого числа
                if (number_8 == answers[7])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных чисел
                    custTxtBox_45.BackColor = Color.LightCyan;
                    custTxtBox_55.BackColor = Color.LightCyan;
                    custTxtBox_65.BackColor = Color.LightCyan;

                    //правильно подставленное число не показывать в списке
                    lbl_219.Visible = false;

                    if (visible_8 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        custTxtBox_45.ReadOnly = true;
                        custTxtBox_55.ReadOnly = true;
                        custTxtBox_65.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(21); help_open.Add(26); help_open.Add(29);
                    }

                    visible_8 = true;
                }

                //проверка девятого числа
                if (number_9 == answers[8])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных чисел
                    custTxtBox_41.BackColor = Color.LightCyan;
                    custTxtBox_42.BackColor = Color.LightCyan;
                    custTxtBox_43.BackColor = Color.LightCyan;

                    //правильно подставленное число не показывать в списке
                    lbl_638.Visible = false;

                    if (visible_9 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        custTxtBox_41.ReadOnly = true;
                        custTxtBox_42.ReadOnly = true;
                        custTxtBox_43.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(18); help_open.Add(19); help_open.Add(20);
                    }

                    visible_9 = true;
                }

                //проверка десятого числа
                if (number_10 == answers[9])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных чисел
                    custTxtBox_00.BackColor = Color.LightCyan;
                    custTxtBox_01.BackColor = Color.LightCyan;
                    custTxtBox_02.BackColor = Color.LightCyan;

                    //правильно подставленное число не показывать в списке
                    lbl_765.Visible = false;

                    if (visible_10 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        custTxtBox_00.ReadOnly = true;
                        custTxtBox_01.ReadOnly = true;
                        custTxtBox_02.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(1); help_open.Add(2); help_open.Add(3);
                    }

                    visible_10 = true;
                }

                //проверка одиннадцатого числа
                if (number_11 == answers[10])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных чисел
                    custTxtBox_90.BackColor = Color.LightCyan;
                    custTxtBox_91.BackColor = Color.LightCyan;
                    custTxtBox_92.BackColor = Color.LightCyan;

                    //правильно подставленное число не показывать в списке
                    lbl_913.Visible = false;

                    if (visible_11 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        custTxtBox_90.ReadOnly = true;
                        custTxtBox_91.ReadOnly = true;
                        custTxtBox_92.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(38); help_open.Add(39); help_open.Add(40);
                    }

                    visible_11 = true;
                }

                //проверка двенадцатого числа
                if (number_12 == answers[11])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных чисел
                    custTxtBox_04.BackColor = Color.LightCyan;
                    custTxtBox_14.BackColor = Color.LightCyan;
                    custTxtBox_24.BackColor = Color.LightCyan;
                    custTxtBox_34.BackColor = Color.LightCyan;

                    //правильно подставленное число не показывать в списке
                    lbl_1264.Visible = false;

                    if (visible_12 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        custTxtBox_04.ReadOnly = true;
                        custTxtBox_14.ReadOnly = true;
                        custTxtBox_24.ReadOnly = true;
                        custTxtBox_34.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(4); help_open.Add(8); help_open.Add(13); help_open.Add(17);
                    }

                    visible_12 = true;
                }

                //проверка тринадцатого числа
                if (number_13 == answers[12])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных чисел
                    custTxtBox_62.BackColor = Color.LightCyan;
                    custTxtBox_72.BackColor = Color.LightCyan;
                    custTxtBox_82.BackColor = Color.LightCyan;
                    custTxtBox_92.BackColor = Color.LightCyan;

                    //правильно подставленное число не показывать в списке
                    lbl_3693.Visible = false;

                    if (visible_13 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        custTxtBox_62.ReadOnly = true;
                        custTxtBox_72.ReadOnly = true;
                        custTxtBox_82.ReadOnly = true;
                        custTxtBox_92.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(28); help_open.Add(32); help_open.Add(36); help_open.Add(40);
                    }

                    visible_13 = true;
                }

                //проверка четырнадцатого числа
                if (number_14 == answers[13])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных чисел
                    custTxtBox_00.BackColor = Color.LightCyan;
                    custTxtBox_10.BackColor = Color.LightCyan;
                    custTxtBox_20.BackColor = Color.LightCyan;
                    custTxtBox_30.BackColor = Color.LightCyan;

                    //правильно подставленное число не показывать в списке
                    lbl_7283.Visible = false;

                    if (visible_14 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        custTxtBox_00.ReadOnly = true;
                        custTxtBox_10.ReadOnly = true;
                        custTxtBox_20.ReadOnly = true;
                        custTxtBox_30.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(1); help_open.Add(6); help_open.Add(9); help_open.Add(15);
                    }

                    visible_14 = true;
                }

                //проверка пятнадцатого числа
                if (number_15 == answers[14])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных чисел
                    custTxtBox_70.BackColor = Color.LightCyan;
                    custTxtBox_71.BackColor = Color.LightCyan;
                    custTxtBox_72.BackColor = Color.LightCyan;
                    custTxtBox_73.BackColor = Color.LightCyan;
                    custTxtBox_74.BackColor = Color.LightCyan;

                    //правильно подставленное число не показывать в списке
                    lbl_27605.Visible = false;

                    if (visible_15 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        custTxtBox_70.ReadOnly = true;
                        custTxtBox_71.ReadOnly = true;
                        custTxtBox_72.ReadOnly = true;
                        custTxtBox_73.ReadOnly = true;
                        custTxtBox_74.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(30); help_open.Add(31); help_open.Add(32); help_open.Add(33); help_open.Add(34);
                    }

                    visible_15 = true;
                }

                //проверка шестнадцатого числа
                if (number_16 == answers[15])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных чисел
                    custTxtBox_02.BackColor = Color.LightCyan;
                    custTxtBox_12.BackColor = Color.LightCyan;
                    custTxtBox_22.BackColor = Color.LightCyan;
                    custTxtBox_32.BackColor = Color.LightCyan;
                    custTxtBox_42.BackColor = Color.LightCyan;

                    //правильно подставленное число не показывать в списке
                    lbl_50513.Visible = false;

                    if (visible_16 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        custTxtBox_02.ReadOnly = true;
                        custTxtBox_12.ReadOnly = true;
                        custTxtBox_22.ReadOnly = true;
                        custTxtBox_32.ReadOnly = true;
                        custTxtBox_42.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(3); help_open.Add(7); help_open.Add(11); help_open.Add(16); help_open.Add(19);
                    }

                    visible_16 = true;
                }

                //проверка семнадцатого числа
                if (number_17 == answers[16])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных чисел
                    custTxtBox_50.BackColor = Color.LightCyan;
                    custTxtBox_60.BackColor = Color.LightCyan;
                    custTxtBox_70.BackColor = Color.LightCyan;
                    custTxtBox_80.BackColor = Color.LightCyan;
                    custTxtBox_90.BackColor = Color.LightCyan;

                    //правильно подставленное число не показывать в списке
                    lbl_96289.Visible = false;

                    if (visible_17 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        custTxtBox_50.ReadOnly = true;
                        custTxtBox_60.ReadOnly = true;
                        custTxtBox_70.ReadOnly = true;
                        custTxtBox_80.ReadOnly = true;
                        custTxtBox_90.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(22); help_open.Add(27); help_open.Add(30); help_open.Add(35); help_open.Add(38);
                    }

                    visible_17 = true;
                }

                //проверка восемнадцатого числа
                if (number_18 == answers[17])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных чисел
                    custTxtBox_20.BackColor = Color.LightCyan;
                    custTxtBox_21.BackColor = Color.LightCyan;
                    custTxtBox_22.BackColor = Color.LightCyan;
                    custTxtBox_23.BackColor = Color.LightCyan;
                    custTxtBox_24.BackColor = Color.LightCyan;
                    custTxtBox_25.BackColor = Color.LightCyan;

                    //правильно подставленное число не показывать в списке
                    lbl_875464.Visible = false;

                    if (visible_18 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        custTxtBox_20.ReadOnly = true;
                        custTxtBox_21.ReadOnly = true;
                        custTxtBox_22.ReadOnly = true;
                        custTxtBox_23.ReadOnly = true;
                        custTxtBox_24.ReadOnly = true;
                        custTxtBox_25.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(9); help_open.Add(10); help_open.Add(11); help_open.Add(12); help_open.Add(13); help_open.Add(14);
                    }

                    visible_18 = true;
                }

                strLbl_value_progress.Text = Convert.ToString(Convert.ToInt32((correct_answers * 100) / count_answers)) + " %";
            }
            else
            {
                if (is_winner == false)
                {
                    strLbl_value_progress.Text = Convert.ToString(Convert.ToInt32((correct_answers * 100) / count_answers)) + " %";
                    rndBtn_help.Enabled = false;

                    Winner winner = new Winner();
                    winner.Show();

                    is_winner = true;
                }
            }
        }

        //функция вызова подсказки
        private void Help_answer()
        {
            //если использованы все подсказки
            if (help_count <= 0)
            {
                rndBtn_help.Enabled = false;

                No_help no_Help = new No_help();
                no_Help.Show();
            }
            else
            {
                Random words = new Random();
                int help_words = words.Next(1, 42);

                while (help_open.Contains(help_words)) help_words = words.Next(1, 42);

                switch (help_words)
                {
                    case 1:
                        custTxtBox_00.Texts = "7";
                        custTxtBox_00.BackColor = Color.MistyRose;
                        custTxtBox_00.ReadOnly = true;

                        help_open.Add(1);
                        break;

                    case 2:
                        custTxtBox_01.Texts = "6";
                        custTxtBox_01.BackColor = Color.MistyRose;
                        custTxtBox_01.ReadOnly = true;

                        help_open.Add(2);
                        break;

                    case 3:
                        custTxtBox_02.Texts = "5";
                        custTxtBox_02.BackColor = Color.MistyRose;
                        custTxtBox_02.ReadOnly = true;

                        help_open.Add(3);
                        break;

                    case 4:
                        custTxtBox_04.Texts = "1";
                        custTxtBox_04.BackColor = Color.MistyRose;
                        custTxtBox_04.ReadOnly = true;

                        help_open.Add(4);
                        break;

                    case 5:
                        custTxtBox_05.Texts = "0";
                        custTxtBox_05.BackColor = Color.MistyRose;
                        custTxtBox_05.ReadOnly = true;

                        help_open.Add(5);
                        break;

                    case 6:
                        custTxtBox_10.Texts = "2";
                        custTxtBox_10.BackColor = Color.MistyRose;
                        custTxtBox_10.ReadOnly = true;

                        help_open.Add(6);
                        break;

                    case 7:
                        custTxtBox_12.Texts = "0";
                        custTxtBox_12.BackColor = Color.MistyRose;
                        custTxtBox_12.ReadOnly = true;

                        help_open.Add(7);
                        break;

                    case 8:
                        custTxtBox_14.Texts = "2";
                        custTxtBox_14.BackColor = Color.MistyRose;
                        custTxtBox_14.ReadOnly = true;

                        help_open.Add(8);
                        break;

                    case 9:
                        custTxtBox_20.Texts = "8";
                        custTxtBox_20.BackColor = Color.MistyRose;
                        custTxtBox_20.ReadOnly = true;

                        help_open.Add(9);
                        break;

                    case 10:
                        custTxtBox_21.Texts = "7";
                        custTxtBox_21.BackColor = Color.MistyRose;
                        custTxtBox_21.ReadOnly = true;

                        help_open.Add(10);
                        break;

                    case 11:
                        custTxtBox_22.Texts = "5";
                        custTxtBox_22.BackColor = Color.MistyRose;
                        custTxtBox_22.ReadOnly = true;

                        help_open.Add(11);
                        break;

                    case 12:
                        custTxtBox_23.Texts = "4";
                        custTxtBox_23.BackColor = Color.MistyRose;
                        custTxtBox_23.ReadOnly = true;

                        help_open.Add(12);
                        break;

                    case 13:
                        custTxtBox_24.Texts = "6";
                        custTxtBox_24.BackColor = Color.MistyRose;
                        custTxtBox_24.ReadOnly = true;

                        help_open.Add(13);
                        break;

                    case 14:
                        custTxtBox_24.Texts = "4";
                        custTxtBox_24.BackColor = Color.MistyRose;
                        custTxtBox_24.ReadOnly = true;

                        help_open.Add(14);
                        break;

                    case 15:
                        custTxtBox_30.Texts = "3";
                        custTxtBox_30.BackColor = Color.MistyRose;
                        custTxtBox_30.ReadOnly = true;

                        help_open.Add(15);
                        break;

                    case 16:
                        custTxtBox_32.Texts = "1";
                        custTxtBox_32.BackColor = Color.MistyRose;
                        custTxtBox_32.ReadOnly = true;

                        help_open.Add(16);
                        break;

                    case 17:
                        custTxtBox_34.Texts = "4";
                        custTxtBox_34.BackColor = Color.MistyRose;
                        custTxtBox_34.ReadOnly = true;

                        help_open.Add(17);
                        break;

                    case 18:
                        custTxtBox_41.Texts = "6";
                        custTxtBox_41.BackColor = Color.MistyRose;
                        custTxtBox_41.ReadOnly = true;

                        help_open.Add(18);
                        break;

                    case 19:
                        custTxtBox_42.Texts = "3";
                        custTxtBox_42.BackColor = Color.MistyRose;
                        custTxtBox_42.ReadOnly = true;

                        help_open.Add(19);
                        break;

                    case 20:
                        custTxtBox_43.Texts = "8";
                        custTxtBox_43.BackColor = Color.MistyRose;
                        custTxtBox_43.ReadOnly = true;

                        help_open.Add(20);
                        break;

                    case 21:
                        custTxtBox_45.Texts = "2";
                        custTxtBox_45.BackColor = Color.MistyRose;
                        custTxtBox_45.ReadOnly = true;

                        help_open.Add(21);
                        break;

                    case 22:
                        custTxtBox_50.Texts = "9";
                        custTxtBox_50.BackColor = Color.MistyRose;
                        custTxtBox_50.ReadOnly = true;

                        help_open.Add(22);
                        break;

                    case 23:
                        custTxtBox_51.Texts = "8";
                        custTxtBox_51.BackColor = Color.MistyRose;
                        custTxtBox_51.ReadOnly = true;

                        help_open.Add(23);
                        break;

                    case 24:
                        custTxtBox_53.Texts = "1";
                        custTxtBox_53.BackColor = Color.MistyRose;
                        custTxtBox_53.ReadOnly = true;

                        help_open.Add(24);
                        break;

                    case 25:
                        custTxtBox_54.Texts = "5";
                        custTxtBox_54.BackColor = Color.MistyRose;
                        custTxtBox_54.ReadOnly = true;

                        help_open.Add(25);
                        break;

                    case 26:
                        custTxtBox_55.Texts = "1";
                        custTxtBox_55.BackColor = Color.MistyRose;
                        custTxtBox_55.ReadOnly = true;

                        help_open.Add(26);
                        break;

                    case 27:
                        custTxtBox_60.Texts = "6";
                        custTxtBox_60.BackColor = Color.MistyRose;
                        custTxtBox_60.ReadOnly = true;

                        help_open.Add(27);
                        break;

                    case 28:
                        custTxtBox_62.Texts = "3";
                        custTxtBox_62.BackColor = Color.MistyRose;
                        custTxtBox_62.ReadOnly = true;

                        help_open.Add(28);
                        break;

                    case 29:
                        custTxtBox_65.Texts = "9";
                        custTxtBox_65.BackColor = Color.MistyRose;
                        custTxtBox_65.ReadOnly = true;

                        help_open.Add(29);
                        break;

                    case 30:
                        custTxtBox_70.Texts = "2";
                        custTxtBox_70.BackColor = Color.MistyRose;
                        custTxtBox_70.ReadOnly = true;

                        help_open.Add(30);
                        break;

                    case 31:
                        custTxtBox_71.Texts = "7";
                        custTxtBox_71.BackColor = Color.MistyRose;
                        custTxtBox_71.ReadOnly = true;

                        help_open.Add(31);
                        break;

                    case 32:
                        custTxtBox_72.Texts = "6";
                        custTxtBox_72.BackColor = Color.MistyRose;
                        custTxtBox_72.ReadOnly = true;

                        help_open.Add(32);
                        break;

                    case 33:
                        custTxtBox_73.Texts = "0";
                        custTxtBox_73.BackColor = Color.MistyRose;
                        custTxtBox_73.ReadOnly = true;

                        help_open.Add(33);
                        break;

                    case 34:
                        custTxtBox_74.Texts = "5";
                        custTxtBox_74.BackColor = Color.MistyRose;
                        custTxtBox_74.ReadOnly = true;

                        help_open.Add(34);
                        break;

                    case 35:
                        custTxtBox_80.Texts = "8";
                        custTxtBox_80.BackColor = Color.MistyRose;
                        custTxtBox_80.ReadOnly = true;

                        help_open.Add(35);
                        break;

                    case 36:
                        custTxtBox_82.Texts = "9";
                        custTxtBox_82.BackColor = Color.MistyRose;
                        custTxtBox_82.ReadOnly = true;

                        help_open.Add(36);
                        break;

                    case 37:
                        custTxtBox_85.Texts = "2";
                        custTxtBox_85.BackColor = Color.MistyRose;
                        custTxtBox_85.ReadOnly = true;

                        help_open.Add(37);
                        break;

                    case 38:
                        custTxtBox_90.Texts = "9";
                        custTxtBox_90.BackColor = Color.MistyRose;
                        custTxtBox_90.ReadOnly = true;

                        help_open.Add(38);
                        break;

                    case 39:
                        custTxtBox_91.Texts = "1";
                        custTxtBox_91.BackColor = Color.MistyRose;
                        custTxtBox_91.ReadOnly = true;

                        help_open.Add(39);
                        break;

                    case 40:
                        custTxtBox_92.Texts = "3";
                        custTxtBox_92.BackColor = Color.MistyRose;
                        custTxtBox_92.ReadOnly = true;

                        help_open.Add(40);
                        break;

                    case 41:
                        custTxtBox_94.Texts = "4";
                        custTxtBox_94.BackColor = Color.MistyRose;
                        custTxtBox_94.ReadOnly = true;

                        help_open.Add(41);
                        break;

                    case 42:
                        custTxtBox_95.Texts = "5";
                        custTxtBox_95.BackColor = Color.MistyRose;
                        custTxtBox_95.ReadOnly = true;

                        help_open.Add(42);
                        break;
                }
            }

            help_count--;

            if (help_count <= 0) strLabel_help_count.Text = "0";
            else strLabel_help_count.Text = help_count.ToString();
        }

        //навигация меню "Выбор вида головоломки"
        private void pctBox_crossword_area_MouseMove(object sender, MouseEventArgs e)
        {
            User_answers();
        }

        private void Crossword_numberbus_MouseMove(object sender, MouseEventArgs e)
        {
            User_answers();
        }

        private void rndBtn_help_Click(object sender, EventArgs e)
        {
            Help_answer();
        }

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