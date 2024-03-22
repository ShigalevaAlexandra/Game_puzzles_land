using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_puzzles_land.My_controrls
{
    //Класс для создания нового элемента RoundButton со свойствами:
    //1. BorderSize - размер контура кнопки
    //2. BorderRadius - радиус округления углов кнопки
    //3. BorderColor - цвет контура кнопки
    //4. BackgroundColor - цвет заливки кнопки
    //5. TextColor - цвет текста на кнопке
    public class RoundButton : Button
    {
        //начальные значения полей свойств кнопки
        private int border_size = 0;
        private int border_radius = 0;
        private Color border_color = Color.BlueViolet;  //начальный цвет контупа кнопки

        //получение новых свойств кнопки
        public int BorderSize
        {
            get { return border_size; }
            set
            {
                border_size = value;
                this.Invalidate();
            }
        }

        public int BorderRadius
        {
            get { return border_radius; }
            set
            {
                border_radius = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return border_color; }
            set
            {
                border_color = value;
                this.Invalidate();
            }
        }

        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        //начальные свойства для отрисовки кнопки
        public RoundButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        //создание закругленных углов кнопки
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);   //верхний левый угол
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);   //верхний правый угол
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);   //нижний правый угол
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);   //нижний левый угол
            path.CloseFigure();

            return path;
        }

        //редактируем функцию отрисовки элемента Button - OnPaint()
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle rect_area = this.ClientRectangle;
            Rectangle rect_border = Rectangle.Inflate(rect_area, - border_size, - border_size);

            int round_size = 2;

            if (border_size > 0)
                round_size = border_size;

            if (border_radius > 2) //закругленная кнопка
            {
                using (GraphicsPath pathArea = GetFigurePath(rect_area, border_radius))
                using (GraphicsPath pathBorder = GetFigurePath(rect_border, border_radius - border_size))
                using (Pen penArea = new Pen(this.Parent.BackColor, round_size))
                using (Pen penBorder = new Pen(border_color, border_size))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias; 
                    this.Region = new Region(pathArea);

                    //рисуем саму кнопку
                    pevent.Graphics.DrawPath(penArea, pathArea);
                    
                    if (border_size >= 1)
                        //рисуем границы(контур) кнопки
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //обычная кнопка
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                this.Region = new Region(rect_area);
                
                if (border_size >= 1)
                {
                    using (Pen penBorder = new Pen(border_color, border_size))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        //редактируем функцию отрисовки элемента Button - OnHandleCreated()
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (border_radius > this.Height)
                border_radius = this.Height;
        }
    }
}