using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Game_puzzles_land.My_controrls
{
    //Класс для создания нового элемента StrokeLabel со свойствами:
    //1. OutlineForeColor - цвет контура текста
    //2. OutlineWidth - размер контура текста
    public class StrokeLabel : Label
    {
        //установка стилей
        public StrokeLabel()
        {
            SetStyle(ControlStyles.Selectable, false);
        }

        public Color OutlineForeColor { get; set; }  //получение цвета контура
        public float OutlineWidth { get; set; }  //получение размера контура

        //редактируем функцию отрисовки элемента Label - OnPaint()
        protected override void OnPaint(PaintEventArgs e)
        {
            PrivateFontCollection my_font = new PrivateFontCollection();
            //настройки кисти
            e.Graphics.FillRectangle(new SolidBrush(Color.Transparent), ClientRectangle);
            using (GraphicsPath graphicsPath = new GraphicsPath())
            using (Pen outline = new Pen(OutlineForeColor, OutlineWidth) { LineJoin = LineJoin.Round })
            using (StringFormat stringFormat = new StringFormat())

            //отрисовка контура текста с использованием настроеннной кисти
            using (Brush foreBrush = new SolidBrush(ForeColor))
            {
                graphicsPath.AddString(Text, Font.FontFamily, (int)Font.Style, Font.Size, ClientRectangle, stringFormat);
                e.Graphics.ScaleTransform(1.3f, 1.35f);
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.DrawPath(outline, graphicsPath);
                e.Graphics.FillPath(foreBrush, graphicsPath);
            }
        }
    }
}