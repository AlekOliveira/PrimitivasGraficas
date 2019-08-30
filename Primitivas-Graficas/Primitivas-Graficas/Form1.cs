using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primitivas_Graficas
{
    public partial class Form1 : Form
    {
        List<Point> pontos = new List<Point>();
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void LimpaForm()
        {
            Graphics g = CreateGraphics();
            g.FillRectangle(Brushes.White, 0, 0, this.Width, this.Height);
        }
        
        private void EQgeral(Point p1, Point p2)
        {
            Graphics g = CreateGraphics();
            Pen p = new Pen(Brushes.Black);

            double dy = p2.Y - p1.Y;
            double dx = p2.X - p1.X;
            dy = Math.Abs(dy); //Valor modular
            dx = Math.Abs(dx); //Valor modular
            double m = dy / dx;


            if (p2.X > p1.X && p2.Y > p1.Y) //1º Quadrante
            {
                if (dx > dy) //1º Octante
                {
                    double y;
                    for (int x = p1.X; x <= p2.X; x++)
                    {
                        y = (double)(p1.Y + m * (x - p1.X));
                        y = Math.Round(y);
                        g.FillRectangle(Brushes.Black, x, (int)y, 2, 2);
                    }
                }
                else //2º Octante
                {
                    double x;
                    for (int y = p1.Y; y <= p2.Y; y++)
                    {
                        x = p1.X + (y - p1.Y) / m;
                        x = Math.Round(x);
                        g.FillRectangle(Brushes.Black, (int)x, y, 2, 2);
                    }
                }
            }
            else if (p1.X > p2.X && p2.Y > p1.Y) //2º Quadrante
            {
                if (dx > dy) //4º Octante
                {
                    double y;
                    for (int x = p1.X; x >= p2.X; x--)
                    {
                        y = (double)(p1.Y - m * (x - p1.X));
                        y = Math.Round(y);
                        g.FillRectangle(Brushes.Black, x, (int)y, 2, 2);
                    }

                }
                else //3º Octante
                {
                    double x;
                    for (int y = p1.Y; y <= p2.Y; y++)
                    {
                        x = p1.X - (y - p1.Y) / m;
                        x = Math.Round(x);
                        g.FillRectangle(Brushes.Black, (int)x, y, 2, 2);
                    }
                }
            }
            else if (p1.X > p2.X && p1.Y > p2.Y) //3º Quadrante
            {
                if (dx > dy) //5º Octante
                {
                    double y;
                    for (int x = p1.X; x >= p2.X; x--)
                    {
                        y = (double)(p1.Y + m * (x - p1.X));
                        y = Math.Round(y);
                        g.FillRectangle(Brushes.Black, x, (int)y, 2, 2);
                    }
                }
                else //6º Octante
                {
                    double x;
                    for (int y = p1.Y; y >= p2.Y; y--)
                    {
                        x = p1.X + (y - p1.Y) / m;
                        x = Math.Round(x);
                        g.FillRectangle(Brushes.Black, (int)x, y, 2, 2);
                    }
                }
            }
            else if (p2.X > p1.X && p1.Y > p2.Y)
            {
                if (dx > dy) //8º Octante
                {
                    double y;
                    for (int x = p1.X; x <= p2.X; x++)
                    {
                        y = (double)(p1.Y - m * (x - p1.X));
                        y = Math.Round(y);
                        g.FillRectangle(Brushes.Black, x, (int)y, 2, 2);
                    }
                }
                else //7º Octante
                {
                    double x;
                    for (int y = p1.Y; y >= p2.Y; y--)
                    {
                        x = p1.X - (y - p1.Y) / m;
                        x = Math.Round(x);
                        g.FillRectangle(Brushes.Black, (int)x, y, 2, 2);
                    }
                }
            }
        }
        
        private void DecliveDDA(Point p1, Point p2)
        {
            int Length;
            double X, Y, Xinc, Yinc;
            Graphics g = CreateGraphics();
            


            //Guardando a maior largura
            Length = Math.Max((Math.Abs(p2.X - p1.X)),(Math.Abs(p2.Y - p1.Y)));

            Xinc = (double)(p2.X - p1.X) / Length;
            Yinc = (double)(p2.Y - p1.Y) / Length;

            X = p1.X; Y = p1.Y;
            while(X < p2.X)
            {
                g.FillRectangle(Brushes.Black, (int)Math.Round(X), (int)Math.Round(Y), 1, 1);
                X = X + Xinc;
                Y = Y + Yinc;
            }

            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                g.FillRectangle(Brushes.Red, e.X, e.Y, 8, 8);
                pontos.Add(new Point(e.X, e.Y));
                if (pontos.Count == 2)
                {
                    if (rbEqReal.Checked)
                        this.EQgeral(pontos[0], pontos[1]);
                    else if (rbDDA.Checked)
                        this.DecliveDDA(pontos[0], pontos[1]);
                      
                    pontos.Clear();
                }
            }   
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaForm();
        }

        private void RbEqReal_CheckedChanged(object sender, EventArgs e)
        {
            btnLimpar.PerformClick();
        }

        private void RbDDA_CheckedChanged(object sender, EventArgs e)
        {
            btnLimpar.PerformClick();
        }

        private void RbBresenhan_CheckedChanged(object sender, EventArgs e)
        {
            btnLimpar.PerformClick();
        }
    }
}
