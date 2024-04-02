using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_puzzles_land
{
    public partial class Crosswords_classic : Form
    {
        PrivateFontCollection my_font;

        const int count_answers = 11;   //кол-во слов в кроссворде
        const int count_cell = 39;  //кол-во ячеек в кроссворде
        int correct_answers = 0;   //кол-во правильно введенных слов в поля кроссворда

        //переменные для определения было проверено поле кроссворда или нет
        bool visible_1 = false, visible_2 = false, visible_3 = false, visible_4 = false, visible_5 = false,
             visible_6 = false, visible_7 = false, visible_8 = false, visible_9 = false, visible_10 = false, visible_11 = false;

        //список для записи открытх ячеек кроссворда при поощи подсказки
        List<int> help_open = new List<int>(count_cell);
        int help_count = 10;   //кол-во подсказок

        string[] answers = new string[count_answers]   //массив слов кроссворда
                {
                    "аврора",
                    "бабочка",
                    "аура",
                    "чабрец",
                    "сдоба",
                    "радар",
                    "абба",
                    "анап",
                    "раб",
                    "абу",
                    "сцеп"
                };

        //переменные для записи введенных слов в кроссворд
        string words_1 = "", words_2 = "", words_3 = "", words_4 = "", words_5 = "",
               words_6 = "", words_7 = "", words_8 = "", words_9 = "", words_10 = "", words_11 = "";

        bool is_winner = false;  //проверка уровня на завершение

        public Crosswords_classic()
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

        //функция проверки введенных ответов пользователем в поля кроссворда
        private void User_answers()
        {
            if (correct_answers < count_answers)
            {
                //получение ответов, введенных пользователем
                words_1 = custTxtBox_10.Texts + custTxtBox_11.Texts + custTxtBox_12_60.Texts + custTxtBox_13.Texts + custTxtBox_14_90.Texts + custTxtBox_15.Texts;
                words_2 = custTxtBox_20.Texts + custTxtBox_21_30.Texts + custTxtBox_22.Texts + custTxtBox_23.Texts + custTxtBox_24_40.Texts + custTxtBox_25.Texts + custTxtBox_26.Texts;
                words_3 = custTxtBox_21_30.Texts + custTxtBox_31.Texts + custTxtBox_64_32.Texts + custTxtBox_33.Texts;
                words_4 = custTxtBox_24_40.Texts + custTxtBox_41.Texts + custTxtBox_71_42.Texts + custTxtBox_43.Texts + custTxtBox_44.Texts + custTxtBox_45_111.Texts;
                words_5 = custTxtBox_50.Texts + custTxtBox_51_62.Texts + custTxtBox_52.Texts + custTxtBox_53_92.Texts + custTxtBox_54_100.Texts;
                words_6 = custTxtBox_12_60.Texts + custTxtBox_61.Texts + custTxtBox_51_62.Texts + custTxtBox_63.Texts + custTxtBox_64_32.Texts;
                words_7 = custTxtBox_70.Texts + custTxtBox_71_42.Texts + custTxtBox_72.Texts + custTxtBox_73_80.Texts;
                words_8 = custTxtBox_73_80.Texts + custTxtBox_81.Texts + custTxtBox_82.Texts + custTxtBox_83_113.Texts;
                words_9 = custTxtBox_14_90.Texts + custTxtBox_91.Texts + custTxtBox_53_92.Texts;
                words_10 = custTxtBox_54_100.Texts + custTxtBox_101.Texts + custTxtBox_102.Texts;
                words_11 = custTxtBox_110.Texts + custTxtBox_45_111.Texts + custTxtBox_112.Texts + custTxtBox_83_113.Texts;

                //просмотр полей кроссворда на правильность введенных ответов
                //проверка первого слова
                if (words_1 == answers[0])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных слов
                    qw_1.BackColor = Color.PapayaWhip;
                    qw_6.BackColor = Color.PapayaWhip;
                    qw_9.BackColor = Color.PapayaWhip;
                    custTxtBox_10.BackColor = Color.PapayaWhip;
                    custTxtBox_11.BackColor = Color.PapayaWhip;
                    custTxtBox_12_60.BackColor = Color.PapayaWhip;
                    custTxtBox_13.BackColor = Color.PapayaWhip;
                    custTxtBox_14_90.BackColor = Color.PapayaWhip;
                    custTxtBox_15.BackColor = Color.PapayaWhip;

                    if (visible_1 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        qw_1.ReadOnly = true;
                        qw_6.ReadOnly = true;
                        qw_9.ReadOnly = true;
                        custTxtBox_10.ReadOnly = true;
                        custTxtBox_11.ReadOnly = true;
                        custTxtBox_12_60.ReadOnly = true;
                        custTxtBox_13.ReadOnly = true;
                        custTxtBox_14_90.ReadOnly = true;
                        custTxtBox_15.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(1); help_open.Add(2); help_open.Add(3); help_open.Add(4); help_open.Add(5); help_open.Add(6);
                    }

                    visible_1 = true;
                }

                //проверка второго слова
                if (words_2 == answers[1])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных слов
                    qw_2.BackColor = Color.PapayaWhip;
                    qw_3.BackColor = Color.PapayaWhip;
                    qw_4.BackColor = Color.PapayaWhip;
                    custTxtBox_20.BackColor = Color.PapayaWhip;
                    custTxtBox_21_30.BackColor = Color.PapayaWhip;
                    custTxtBox_22.BackColor = Color.PapayaWhip;
                    custTxtBox_23.BackColor = Color.PapayaWhip;
                    custTxtBox_24_40.BackColor = Color.PapayaWhip;
                    custTxtBox_25.BackColor = Color.PapayaWhip;
                    custTxtBox_26.BackColor = Color.PapayaWhip;

                    if (visible_2 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        qw_2.ReadOnly = true;
                        qw_3.ReadOnly = true;
                        qw_4.ReadOnly = true;
                        custTxtBox_20.ReadOnly = true;
                        custTxtBox_21_30.ReadOnly = true;
                        custTxtBox_22.ReadOnly = true;
                        custTxtBox_23.ReadOnly = true;
                        custTxtBox_24_40.ReadOnly = true;
                        custTxtBox_25.ReadOnly = true;
                        custTxtBox_26.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(7); help_open.Add(8); help_open.Add(9); help_open.Add(10); help_open.Add(11); help_open.Add(12); help_open.Add(13);
                    }

                    visible_2 = true;
                }

                //проверка третьего слова
                if (words_3 == answers[2])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных слов
                    qw_3.BackColor = Color.PapayaWhip;
                    custTxtBox_21_30.BackColor = Color.PapayaWhip;
                    custTxtBox_31.BackColor = Color.PapayaWhip;
                    custTxtBox_64_32.BackColor = Color.PapayaWhip;
                    custTxtBox_33.BackColor = Color.PapayaWhip;

                    if (visible_3 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        qw_3.ReadOnly = true;
                        custTxtBox_21_30.ReadOnly = true;
                        custTxtBox_31.ReadOnly = true;
                        custTxtBox_64_32.ReadOnly = true;
                        custTxtBox_33.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(8); help_open.Add(14); help_open.Add(15); help_open.Add(16);
                    }

                    visible_3 = true;
                }

                //проверка четвертого слова
                if (words_4 == answers[3])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных слов
                    qw_4.BackColor = Color.PapayaWhip;
                    custTxtBox_24_40.BackColor = Color.PapayaWhip;
                    custTxtBox_41.BackColor = Color.PapayaWhip;
                    custTxtBox_71_42.BackColor = Color.PapayaWhip;
                    custTxtBox_43.BackColor = Color.PapayaWhip;
                    custTxtBox_44.BackColor = Color.PapayaWhip;
                    custTxtBox_45_111.BackColor = Color.PapayaWhip;

                    if (visible_4 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        qw_4.ReadOnly = true;
                        custTxtBox_24_40.ReadOnly = true;
                        custTxtBox_41.ReadOnly = true;
                        custTxtBox_71_42.ReadOnly = true;
                        custTxtBox_43.ReadOnly = true;
                        custTxtBox_44.ReadOnly = true;
                        custTxtBox_45_111.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(11); help_open.Add(17); help_open.Add(18); help_open.Add(19); help_open.Add(20); help_open.Add(21);
                    }

                    visible_4 = true;
                }

                //проверка пятого слова
                if (words_5 == answers[4])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных слов
                    qw_5.BackColor = Color.PapayaWhip;
                    qw_10.BackColor = Color.PapayaWhip;
                    custTxtBox_50.BackColor = Color.PapayaWhip;
                    custTxtBox_51_62.BackColor = Color.PapayaWhip;
                    custTxtBox_52.BackColor = Color.PapayaWhip;
                    custTxtBox_53_92.BackColor = Color.PapayaWhip;
                    custTxtBox_54_100.BackColor = Color.PapayaWhip;

                    if (visible_5 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        qw_5.ReadOnly = true;
                        qw_10.ReadOnly = true;
                        custTxtBox_50.ReadOnly = true;
                        custTxtBox_51_62.ReadOnly = true;
                        custTxtBox_52.ReadOnly = true;
                        custTxtBox_53_92.ReadOnly = true;
                        custTxtBox_54_100.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(22); help_open.Add(23); help_open.Add(24); help_open.Add(25); help_open.Add(26);
                    }

                    visible_5 = true;
                }

                //проверка шестого слова
                if (words_6 == answers[5])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных слов
                    qw_6.BackColor = Color.PapayaWhip;
                    custTxtBox_12_60.BackColor = Color.PapayaWhip;
                    custTxtBox_61.BackColor = Color.PapayaWhip;
                    custTxtBox_51_62.BackColor = Color.PapayaWhip;
                    custTxtBox_63.BackColor = Color.PapayaWhip;
                    custTxtBox_64_32.BackColor = Color.PapayaWhip;

                    if (visible_6 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        qw_6.ReadOnly = true;
                        custTxtBox_12_60.ReadOnly = true;
                        custTxtBox_61.ReadOnly = true;
                        custTxtBox_51_62.ReadOnly = true;
                        custTxtBox_63.ReadOnly = true;
                        custTxtBox_64_32.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(3); help_open.Add(27); help_open.Add(23); help_open.Add(28); help_open.Add(15);
                    }

                    visible_6 = true;
                }

                //проверка седьмого слова
                if (words_7 == answers[6])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных слов
                    qw_7.BackColor = Color.PapayaWhip;
                    qw_8.BackColor = Color.PapayaWhip;
                    custTxtBox_70.BackColor = Color.PapayaWhip;
                    custTxtBox_71_42.BackColor = Color.PapayaWhip;
                    custTxtBox_72.BackColor = Color.PapayaWhip;
                    custTxtBox_73_80.BackColor = Color.PapayaWhip;

                    if (visible_7 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        qw_7.ReadOnly = true;
                        qw_8.ReadOnly = true;
                        custTxtBox_70.ReadOnly = true;
                        custTxtBox_71_42.ReadOnly = true;
                        custTxtBox_72.ReadOnly = true;
                        custTxtBox_73_80.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(29); help_open.Add(18); help_open.Add(30); help_open.Add(31);
                    }

                    visible_7 = true;
                }

                //проверка восьмого слова
                if (words_8 == answers[7])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных слов
                    qw_8.BackColor = Color.PapayaWhip;
                    custTxtBox_73_80.BackColor = Color.PapayaWhip;
                    custTxtBox_81.BackColor = Color.PapayaWhip;
                    custTxtBox_82.BackColor = Color.PapayaWhip;
                    custTxtBox_83_113.BackColor = Color.PapayaWhip;

                    if (visible_8 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        qw_8.ReadOnly = true;
                        custTxtBox_73_80.ReadOnly = true;
                        custTxtBox_81.ReadOnly = true;
                        custTxtBox_82.ReadOnly = true;
                        custTxtBox_83_113.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(31); help_open.Add(32); help_open.Add(33); help_open.Add(34);
                    }

                    visible_8 = true;
                }

                //проверка девятого слова
                if (words_9 == answers[8])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных слов
                    qw_9.BackColor = Color.PapayaWhip;
                    custTxtBox_14_90.BackColor = Color.PapayaWhip;
                    custTxtBox_91.BackColor = Color.PapayaWhip;
                    custTxtBox_53_92.BackColor = Color.PapayaWhip;

                    if (visible_9 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        qw_9.ReadOnly = true;
                        custTxtBox_14_90.ReadOnly = true;
                        custTxtBox_91.ReadOnly = true;
                        custTxtBox_53_92.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(5); help_open.Add(35); help_open.Add(25);
                    }

                    visible_9 = true;
                }

                //проверка десятого слова
                if (words_10 == answers[9])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных слов
                    qw_10.BackColor = Color.PapayaWhip;
                    custTxtBox_54_100.BackColor = Color.PapayaWhip;
                    custTxtBox_101.BackColor = Color.PapayaWhip;
                    custTxtBox_102.BackColor = Color.PapayaWhip;

                    if (visible_10 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        qw_10.ReadOnly = true;
                        custTxtBox_54_100.ReadOnly = true;
                        custTxtBox_101.ReadOnly = true;
                        custTxtBox_102.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(26); help_open.Add(36); help_open.Add(37);
                    }

                    visible_10 = true;
                }

                //проверка одиннадцатого слова
                if (words_11 == answers[10])
                {
                    //смена заднего фона полей кросворда - выделение правильно введенных слов
                    qw_11.BackColor = Color.PapayaWhip;
                    custTxtBox_110.BackColor = Color.PapayaWhip;
                    custTxtBox_45_111.BackColor = Color.PapayaWhip;
                    custTxtBox_112.BackColor = Color.PapayaWhip;
                    custTxtBox_83_113.BackColor = Color.PapayaWhip;

                    if (visible_11 == false)
                    {
                        //повторное начисление прогресса недоступно
                        correct_answers++;

                        //повторное редактирование правильных полей недоступно
                        qw_11.ReadOnly = true;
                        custTxtBox_110.ReadOnly = true;
                        custTxtBox_45_111.ReadOnly = true;
                        custTxtBox_112.ReadOnly = true;
                        custTxtBox_112.ReadOnly = true;
                        custTxtBox_83_113.ReadOnly = true;

                        //фиксирование открытых ячеек игрового поля кроссворда
                        help_open.Add(38); help_open.Add(21); help_open.Add(39); help_open.Add(34);
                    }

                    visible_11 = true;
                }

                strLbl_value_progress.Text = Convert.ToString(Convert.ToInt32((correct_answers * 100) / count_answers)) + " %";
            }
            else
            {
                if(is_winner == false)
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
                int help_words = words.Next(1, 39);

                while (help_open.Contains(help_words)) help_words = words.Next(1, 39);

                switch (help_words)
                {
                    case 1:
                        custTxtBox_10.Texts = "а";
                        qw_1.BackColor = Color.LightCyan;
                        custTxtBox_10.BackColor = Color.LightCyan;
                        custTxtBox_10.ReadOnly = true;

                        help_open.Add(1);
                        break;

                    case 2:
                        custTxtBox_11.Texts = "в";
                        custTxtBox_11.BackColor = Color.LightCyan;
                        custTxtBox_11.ReadOnly = true;

                        help_open.Add(2);
                        break;

                    case 3:
                        custTxtBox_12_60.Texts = "р";
                        qw_6.BackColor = Color.LightCyan;
                        custTxtBox_12_60.BackColor = Color.LightCyan;
                        custTxtBox_12_60.ReadOnly = true;

                        help_open.Add(3);
                        break;

                    case 4:
                        custTxtBox_13.Texts = "о";
                        custTxtBox_13.BackColor = Color.LightCyan;
                        custTxtBox_13.ReadOnly = true;

                        help_open.Add(4);
                        break;

                    case 5:
                        custTxtBox_14_90.Texts = "р";
                        qw_9.BackColor = Color.LightCyan;
                        custTxtBox_14_90.BackColor = Color.LightCyan;
                        custTxtBox_14_90.ReadOnly = true;

                        help_open.Add(5);
                        break;

                    case 6:
                        custTxtBox_15.Texts = "а";
                        custTxtBox_15.BackColor = Color.LightCyan;
                        custTxtBox_15.ReadOnly = true;

                        help_open.Add(6);
                        break;

                    case 7:
                        custTxtBox_20.Texts = "б";
                        custTxtBox_20.BackColor = Color.LightCyan;
                        custTxtBox_20.ReadOnly = true;

                        help_open.Add(7);
                        break;

                    case 8:
                        custTxtBox_21_30.Texts = "а";
                        custTxtBox_21_30.BackColor = Color.LightCyan;
                        custTxtBox_21_30.ReadOnly = true;

                        help_open.Add(8);
                        break;

                    case 9:
                        custTxtBox_22.Texts = "б";
                        custTxtBox_22.BackColor = Color.LightCyan;
                        custTxtBox_22.ReadOnly = true;

                        help_open.Add(9);
                        break;

                    case 10:
                        custTxtBox_23.Texts = "о";
                        custTxtBox_23.BackColor = Color.LightCyan;
                        custTxtBox_23.ReadOnly = true;

                        help_open.Add(10);
                        break;

                    case 11:
                        custTxtBox_24_40.Texts = "ч";
                        custTxtBox_24_40.BackColor = Color.LightCyan;
                        custTxtBox_24_40.ReadOnly = true;

                        help_open.Add(11);
                        break;

                    case 12:
                        custTxtBox_25.Texts = "к";
                        custTxtBox_25.BackColor = Color.LightCyan;
                        custTxtBox_25.ReadOnly = true;

                        help_open.Add(12);
                        break;

                    case 13:
                        custTxtBox_26.Texts = "а";
                        custTxtBox_26.BackColor = Color.LightCyan;
                        custTxtBox_26.ReadOnly = true;

                        help_open.Add(13);
                        break;

                    case 14:
                        custTxtBox_31.Texts = "у";
                        custTxtBox_31.BackColor = Color.LightCyan;
                        custTxtBox_31.ReadOnly = true;

                        help_open.Add(14);
                        break;

                    case 15:
                        custTxtBox_64_32.Texts = "р";
                        custTxtBox_64_32.BackColor = Color.LightCyan;
                        custTxtBox_64_32.ReadOnly = true;

                        help_open.Add(15);
                        break;

                    case 16:
                        custTxtBox_33.Texts = "а";
                        custTxtBox_33.BackColor = Color.LightCyan;
                        custTxtBox_33.ReadOnly = true;

                        help_open.Add(16);
                        break;

                    case 17:
                        custTxtBox_41.Texts = "а";
                        custTxtBox_41.BackColor = Color.LightCyan;
                        custTxtBox_41.ReadOnly = true;

                        help_open.Add(17);
                        break;

                    case 18:
                        custTxtBox_71_42.Texts = "б";
                        custTxtBox_71_42.BackColor = Color.LightCyan;
                        custTxtBox_71_42.ReadOnly = true;

                        help_open.Add(18);
                        break;

                    case 19:
                        custTxtBox_43.Texts = "р";
                        custTxtBox_43.BackColor = Color.LightCyan;
                        custTxtBox_43.ReadOnly = true;

                        help_open.Add(19);
                        break;

                    case 20:
                        custTxtBox_44.Texts = "е";
                        custTxtBox_44.BackColor = Color.LightCyan;
                        custTxtBox_44.ReadOnly = true;

                        help_open.Add(20);
                        break;

                    case 21:
                        custTxtBox_45_111.Texts = "ц";
                        custTxtBox_45_111.BackColor = Color.LightCyan;
                        custTxtBox_45_111.ReadOnly = true;

                        help_open.Add(21);
                        break;

                    case 22:
                        custTxtBox_50.Texts = "с";
                        custTxtBox_50.BackColor = Color.LightCyan;
                        custTxtBox_50.ReadOnly = true;

                        help_open.Add(22);
                        break;

                    case 23:
                        custTxtBox_51_62.Texts = "д";
                        custTxtBox_51_62.BackColor = Color.LightCyan;
                        custTxtBox_51_62.ReadOnly = true;

                        help_open.Add(23);
                        break;

                    case 24:
                        custTxtBox_52.Texts = "о";
                        custTxtBox_52.BackColor = Color.LightCyan;
                        custTxtBox_52.ReadOnly = true;

                        help_open.Add(24);
                        break;

                    case 25:
                        custTxtBox_53_92.Texts = "б";
                        custTxtBox_53_92.BackColor = Color.LightCyan;
                        custTxtBox_53_92.ReadOnly = true;

                        help_open.Add(25);
                        break;

                    case 26:
                        custTxtBox_54_100.Texts = "а";
                        custTxtBox_54_100.BackColor = Color.LightCyan;
                        custTxtBox_54_100.ReadOnly = true;

                        help_open.Add(26);
                        break;

                    case 27:
                        custTxtBox_61.Texts = "а";
                        custTxtBox_61.BackColor = Color.LightCyan;
                        custTxtBox_61.ReadOnly = true;

                        help_open.Add(27);
                        break;

                    case 28:
                        custTxtBox_63.Texts = "а";
                        custTxtBox_63.BackColor = Color.LightCyan;
                        custTxtBox_63.ReadOnly = true;

                        help_open.Add(28);
                        break;

                    case 29:
                        custTxtBox_70.Texts = "а";
                        custTxtBox_70.BackColor = Color.LightCyan;
                        custTxtBox_70.ReadOnly = true;

                        help_open.Add(29);
                        break;

                    case 30:
                        custTxtBox_72.Texts = "б";
                        custTxtBox_72.BackColor = Color.LightCyan;
                        custTxtBox_72.ReadOnly = true;

                        help_open.Add(30);
                        break;

                    case 31:
                        custTxtBox_73_80.Texts = "а";
                        custTxtBox_73_80.BackColor = Color.LightCyan;
                        custTxtBox_73_80.ReadOnly = true;

                        help_open.Add(31);
                        break;

                    case 32:
                        custTxtBox_81.Texts = "н";
                        custTxtBox_81.BackColor = Color.LightCyan;
                        custTxtBox_81.ReadOnly = true;

                        help_open.Add(32);
                        break;

                    case 33:
                        custTxtBox_82.Texts = "а";
                        custTxtBox_82.BackColor = Color.LightCyan;
                        custTxtBox_82.ReadOnly = true;

                        help_open.Add(33);
                        break;

                    case 34:
                        custTxtBox_83_113.Texts = "п";
                        custTxtBox_83_113.BackColor = Color.LightCyan;
                        custTxtBox_83_113.ReadOnly = true;

                        help_open.Add(34);
                        break;

                    case 35:
                        custTxtBox_91.Texts = "а";
                        custTxtBox_91.BackColor = Color.LightCyan;
                        custTxtBox_91.ReadOnly = true;

                        help_open.Add(35);
                        break;

                    case 36:
                        custTxtBox_101.Texts = "б";
                        custTxtBox_101.BackColor = Color.LightCyan;
                        custTxtBox_101.ReadOnly = true;

                        help_open.Add(36);
                        break;

                    case 37:
                        custTxtBox_102.Texts = "у";
                        custTxtBox_102.BackColor = Color.LightCyan;
                        custTxtBox_102.ReadOnly = true;

                        help_open.Add(37);
                        break;

                    case 38:
                        custTxtBox_110.Texts = "с";
                        custTxtBox_110.BackColor = Color.LightCyan;
                        custTxtBox_110.ReadOnly = true;

                        help_open.Add(38);
                        break;

                    case 39:
                        custTxtBox_112.Texts = "е";
                        custTxtBox_112.BackColor = Color.LightCyan;
                        custTxtBox_112.ReadOnly = true;

                        help_open.Add(39);
                        break;
                }
            }

            help_count--;

            if (help_count <= 0) strLabel_help_count.Text = "0";
            else strLabel_help_count.Text = help_count.ToString();
        }

        //навигация меню уровень "Классический"
        private void Crosswords_classic_MouseHover(object sender, EventArgs e)
        {
            User_answers();
        }

        private void pctBox_crossword_area_MouseHover(object sender, EventArgs e)
        {
            User_answers();
        }

        private void rndBtn_help_Click(object sender, EventArgs e)
        {
            Help_answer();
        }

        private void symbol_success_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ограничение вводимых символов (можно вводить только символы Аа-Яя)
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]").Success)
            {
                e.Handled = true;
            }
        }

        private void VisibleTrue_MouseMove(object sender, MouseEventArgs e)
        {
            //показ вопроса к выбранному полю кроссворда
            Area_qw_1.Visible = true;
        }
        private void VisibleFalse_MouseLeave(object sender, EventArgs e)
        {
            //скрытие вопроса к выбранному полю кроссворда
            Area_qw_1.Visible = false;
        }

        private void custTxtBox_20_MouseMove(object sender, MouseEventArgs e)
        {
            //показ вопроса к выбранному полю кроссворда
            Area_qw_2.Visible = true;
        }
        private void custTxtBox_20_MouseLeave(object sender, EventArgs e)
        {
            //скрытие вопроса к выбранному полю кроссворда
            Area_qw_2.Visible = false;
        }

        private void custTxtBox_21_30_MouseLeave(object sender, EventArgs e)
        {
            //скрытие вопроса к выбранному полю кроссворда
            Area_qw_3.Visible = false;
        }
        private void custTxtBox_21_30_MouseMove(object sender, MouseEventArgs e)
        {
            //показ вопроса к выбранному полю кроссворда
            Area_qw_3.Visible = true;
        }

        private void custTxtBox_24_40_MouseLeave(object sender, EventArgs e)
        {
            //скрытие вопроса к выбранному полю кроссворда
            Area_qw_4.Visible = false;
        }
        private void custTxtBox_24_40_MouseMove(object sender, MouseEventArgs e)
        {
            //показ вопроса к выбранному полю кроссворда
            Area_qw_4.Visible = true;
        }

        private void custTxtBox_50_MouseLeave(object sender, EventArgs e)
        {
            //скрытие вопроса к выбранному полю кроссворда
            Area_qw_5.Visible = false;
        }
        private void custTxtBox_50_MouseMove(object sender, MouseEventArgs e)
        {
            //показ вопроса к выбранному полю кроссворда
            Area_qw_5.Visible = true;
        }

        private void custTxtBox_12_60_MouseLeave(object sender, EventArgs e)
        {
            //скрытие вопроса к выбранному полю кроссворда
            Area_qw_6.Visible = false;
        }
        private void custTxtBox_12_60_MouseMove(object sender, MouseEventArgs e)
        {
            //показ вопроса к выбранному полю кроссворда
            Area_qw_6.Visible = true;
        }

        private void custTxtBox_70_MouseMove(object sender, MouseEventArgs e)
        {
            //показ вопроса к выбранному полю кроссворда
            Area_qw_7.Visible = true;
        }
        private void custTxtBox_70_MouseLeave(object sender, EventArgs e)
        {
            //скрытие вопроса к выбранному полю кроссворда
            Area_qw_7.Visible = false;
        }

        private void custTxtBox_73_80_MouseMove(object sender, MouseEventArgs e)
        {
            //показ вопроса к выбранному полю кроссворда
            Area_qw_8.Visible = true;
        }
        private void custTxtBox_73_80_MouseLeave(object sender, EventArgs e)
        {
            //скрытие вопроса к выбранному полю кроссворда
            Area_qw_8.Visible = false;
        }

        private void custTxtBox_14_90_MouseMove(object sender, MouseEventArgs e)
        {
            //показ вопроса к выбранному полю кроссворда
            Area_qw_9.Visible = true;
        }
        private void custTxtBox_14_90_MouseLeave(object sender, EventArgs e)
        {
            //скрытие вопроса к выбранному полю кроссворда
            Area_qw_9.Visible = false;
        }

        private void custTxtBox_54_100_MouseMove(object sender, MouseEventArgs e)
        {
            //показ вопроса к выбранному полю кроссворда
            Area_qw_10.Visible = true;
        }
        private void custTxtBox_54_100_MouseLeave(object sender, EventArgs e)
        {
            //скрытие вопроса к выбранному полю кроссворда
            Area_qw_10.Visible = false;
        }


        private void custTxtBox_110_MouseMove(object sender, MouseEventArgs e)
        {
            //показ вопроса к выбранному полю кроссворда
            Area_qw_11.Visible = true;
        }
        private void custTxtBox_110_MouseLeave(object sender, EventArgs e)
        {
            //скрытие вопроса к выбранному полю кроссворда
            Area_qw_11.Visible = false;
        }

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