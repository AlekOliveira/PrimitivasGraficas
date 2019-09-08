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
        private List<Point> pontos = new List<Point>();
        private Bitmap bmp;


        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pbx.Size.Width, pbx.Size.Height);
            pbx.Image = bmp;
        }

        private void EQgeral(Point p1, Point p2)
        {
            Bitmap bmp1 = new Bitmap(pbx.Image);

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
                        bmp1.SetPixel(x, (int)y, Color.CadetBlue);
                    }
                }
                else //2º Octante
                {
                    double x;
                    for (int y = p1.Y; y <= p2.Y; y++)
                    {
                        x = p1.X + (y - p1.Y) / m;
                        x = Math.Round(x);
                        bmp1.SetPixel((int)x, y, Color.CadetBlue);
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
                        bmp1.SetPixel(x, (int)y, Color.CadetBlue);
                    }

                }
                else //3º Octante
                {
                    double x;
                    for (int y = p1.Y; y <= p2.Y; y++)
                    {
                        x = p1.X - (y - p1.Y) / m;
                        x = Math.Round(x);
                        bmp1.SetPixel((int)x, y, Color.CadetBlue);
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
                        bmp1.SetPixel(x, (int)y, Color.CadetBlue);
                    }
                }
                else //6º Octante
                {
                    double x;
                    for (int y = p1.Y; y >= p2.Y; y--)
                    {
                        x = p1.X + (y - p1.Y) / m;
                        x = Math.Round(x);
                        bmp1.SetPixel((int)x, y, Color.CadetBlue);
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
                        bmp1.SetPixel(x, (int)y, Color.CadetBlue);
                    }
                }
                else //7º Octante
                {
                    double x;
                    for (int y = p1.Y; y >= p2.Y; y--)
                    {
                        x = p1.X - (y - p1.Y) / m;
                        x = Math.Round(x);
                        bmp1.SetPixel((int)x, y, Color.CadetBlue);
                    }
                }
            }
            else
            {
                if (p1.X == p2.X) // corre X
                {
                    for (int Y = p1.Y; Y <= p2.Y; Y++)
                        bmp1.SetPixel((int)p1.X, (int)Y, Color.CadetBlue);
                    for (int Y = p1.Y; Y >= p2.Y; Y--)
                        bmp1.SetPixel((int)p1.X, (int)Y, Color.CadetBlue);
                }
                else
                {
                    if (p1.Y == p2.Y) // Corre Y
                    {
                        for (int Y = p1.Y; Y <= p2.Y; Y++)
                            bmp1.SetPixel((int)p1.X, (int)Y, Color.CadetBlue);
                        for (int Y = p1.Y; Y >= p2.Y; Y--)
                            bmp1.SetPixel((int)p1.X, (int)Y, Color.CadetBlue);
                    }
                }

            }
            pbx.Image = bmp1;
        }

        private void DecliveDDA(Point p1, Point p2) //ook
        {
            Bitmap bmp1 = new Bitmap(pbx.Image);
            if (p1.X > p2.X)
            {
                Point aux = p1;
                p1 = p2;
                p2 = aux;
            }
            int Length, I;
            double X, Y, Xinc, Yinc;

            //Guardando a maior largura
            Length = Math.Max((Math.Abs(p2.X - p1.X)), (Math.Abs(p2.Y - p1.Y)));

            if (p1.X == p2.X)
            {
                for (Y = p1.Y; Y <= p2.Y; Y++)
                    bmp1.SetPixel((int)p1.X, (int)Y, Color.Black);
                for (Y = p1.Y; Y >= p2.Y; Y--)
                    bmp1.SetPixel((int)p1.X, (int)Y, Color.Black);
            }
            else
            {
                Xinc = (double)(p2.X - p1.X) / Length;
                Yinc = (double)(p2.Y - p1.Y) / Length;
                X = p1.X; Y = p1.Y;
                while (X < p2.X)
                {
                    bmp1.SetPixel((int)Math.Round(X), (int)Math.Round(Y), Color.Black);
                    X = X + Xinc;
                    Y = Y + Yinc;
                }
            }
            pbx.Image = bmp1;
        }

        private void Bresenhan(Point p1, Point p2)
        {
            Bitmap bmp1 = new Bitmap(pbx.Image);
            int declive;
            int dx, dy, incNE, incE, d, x, y;
            dx = p2.X - p1.X;
            dy = p2.Y - p1.Y;
            if(Math.Abs(dx) >= Math.Abs(dy))
            {
                if (p2.X < p1.X)
                    Bresenhan(p2, p1);
                else
                {
                    if (dy <= 0)
                    {
                        declive = -1;
                        dy = -dy;
                    }
                    else
                        declive = 1;
                    incE = 2 * dy;
                    incNE = 2 * dy - 2 * dx; ;
                    d = 2 * dy - dx;
                    y = p1.Y;
                    for(x = p1.X; x <= p2.X; x++)
                    {
                        bmp1.SetPixel(x, y, Color.Coral);
                        if (d <= 0)
                            d += incE;
                        else
                        {
                            d += incNE;
                            y += declive;
                        }
                    }

                }
            }
            else
            {
                if (p2.Y < p1.Y)
                    Bresenhan(p2, p1);
                else
                {
                    if (dx < 0)
                    {
                        declive = -1;
                        dx = -dy;
                    }
                    else
                        declive = 1;
                    incE = 2 * dx;
                    incNE = 2 * dx - 2 * dy;
                    d = 2 * dx - dy;
                    x = p1.X;
                    for(y=p1.Y; y<= p2.Y; y++)
                    {
                        bmp1.SetPixel(x, y, Color.Coral);
                        if (d <= 0)
                            d += incE;
                        else
                        {
                            d += incNE;
                            x += declive;
                        }
                    }

                }
                

            }
            pbx.Image = bmp1;

        }

        private void pbx_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {   
                pontos.Add(new Point(e.X, e.Y));
                if (pontos.Count == 2)
                {
                    if (RbRetaReal.Checked)
                        this.EQgeral(pontos[0], pontos[1]);
                    else if (RbRetaDDA.Checked)
                        this.DecliveDDA(pontos[0], pontos[1]);
                    else if (RbRetaBresenhan.Checked)
                        this.Bresenhan(pontos[0], pontos[1]);

                    pontos.Clear();
                }
            }
        }
        private void pbx_MouseMove(object sender, MouseEventArgs e)
        {
            lbX.Text = "X: " + e.X;
            lbY.Text = "Y: " + e.Y;
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

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pbx.Size.Width, pbx.Size.Height);
            pbx.Image = bmp;
        }
    }
}
