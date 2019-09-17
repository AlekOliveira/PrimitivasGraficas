using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primitivas_Graficas
{
    class Primitivas
    {
        public static void EQgeral(Point p1, Point p2, PictureBox pbx)
        {
            Bitmap b = new Bitmap(pbx.Image);

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
                        b.SetPixel(x, (int)y, Color.CadetBlue);
                    }
                }
                else //2º Octante
                {
                    double x;
                    for (int y = p1.Y; y <= p2.Y; y++)
                    {
                        x = p1.X + (y - p1.Y) / m;
                        x = Math.Round(x);
                        b.SetPixel((int)x, y, Color.CadetBlue);
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
                        b.SetPixel(x, (int)y, Color.CadetBlue);
                    }

                }
                else //3º Octante
                {
                    double x;
                    for (int y = p1.Y; y <= p2.Y; y++)
                    {
                        x = p1.X - (y - p1.Y) / m;
                        x = Math.Round(x);
                        b.SetPixel((int)x, y, Color.CadetBlue);
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
                        b.SetPixel(x, (int)y, Color.CadetBlue);
                    }
                }
                else //6º Octante
                {
                    double x;
                    for (int y = p1.Y; y >= p2.Y; y--)
                    {
                        x = p1.X + (y - p1.Y) / m;
                        x = Math.Round(x);
                        b.SetPixel((int)x, y, Color.CadetBlue);
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
                        b.SetPixel(x, (int)y, Color.CadetBlue);
                    }
                }
                else //7º Octante
                {
                    double x;
                    for (int y = p1.Y; y >= p2.Y; y--)
                    {
                        x = p1.X - (y - p1.Y) / m;
                        x = Math.Round(x);
                        b.SetPixel((int)x, y, Color.CadetBlue);
                    }
                }
            }
            else
            {
                if (p1.X == p2.X) // corre X
                {
                    for (int Y = p1.Y; Y <= p2.Y; Y++)
                        b.SetPixel((int)p1.X, (int)Y, Color.CadetBlue);
                    for (int Y = p1.Y; Y >= p2.Y; Y--)
                        b.SetPixel((int)p1.X, (int)Y, Color.CadetBlue);
                }
                else
                {
                    if (p1.Y == p2.Y) // Corre Y
                    {
                        for (int Y = p1.Y; Y <= p2.Y; Y++)
                            b.SetPixel((int)p1.X, (int)Y, Color.CadetBlue);
                        for (int Y = p1.Y; Y >= p2.Y; Y--)
                            b.SetPixel((int)p1.X, (int)Y, Color.CadetBlue);
                    }
                }

            }
            pbx.Image = b;
        }

        public static void Bresenhan(Point p1, Point p2, PictureBox pbx)
        {
            Bitmap b = new Bitmap(pbx.Image);
            int declive;
            int dx, dy, incNE, incE, d, x, y;
            dx = p2.X - p1.X;
            dy = p2.Y - p1.Y;
            if (Math.Abs(dx) >= Math.Abs(dy))
            {
                if (p2.X < p1.X)
                    Bresenhan(p2, p1, pbx);
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
                    for (x = p1.X; x <= p2.X; x++)
                    {
                        b.SetPixel(x, y, Color.Coral);
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
                    Bresenhan(p2, p1, pbx);
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
                    for (y = p1.Y; y <= p2.Y; y++)
                    {
                        b.SetPixel(x, y, Color.Coral);
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
            pbx.Image = b;

        }

        public static void DecliveDDA(Point p1, Point p2, PictureBox pbx)
        {
            Bitmap b = new Bitmap(pbx.Image);
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
                    b.SetPixel((int)p1.X, (int)Y, Color.Black);
                for (Y = p1.Y; Y >= p2.Y; Y--)
                    b.SetPixel((int)p1.X, (int)Y, Color.Black);
            }
            else
            {
                Xinc = (double)(p2.X - p1.X) / Length;
                Yinc = (double)(p2.Y - p1.Y) / Length;
                X = p1.X; Y = p1.Y;
                while (X < p2.X)
                {
                    b.SetPixel((int)Math.Round(X), (int)Math.Round(Y), Color.Black);
                    X = X + Xinc;
                    Y = Y + Yinc;
                }
            }
            pbx.Image = b;
        }


        public static void CircGeral(Point p1, PictureBox pbx, double raio)
        {
            Bitmap b = new Bitmap(pbx.Image);
            double x, y = raio;
            double limite = raio / Math.Sqrt(2);
            for (x = 0; x <= limite; x++)
            {
                Simetria8(b,p1.X, p1.Y, (int)x, (int)y);
                y = Math.Sqrt(Math.Pow(raio, 2) - Math.Pow(x, 2));
            }

            pbx.Image = b;
        }


        private static void desenha(Bitmap b, int x, int y)
        {
            b.SetPixel((int)x, (int)y, Color.Black);
        }

        private static void Simetria8(Bitmap data, int cx, int cy, int dx, int dy)
        {
            if (Tamanho(data, cx + dy, cy - dx)) // 1o Octante
                desenha(data, cx + dy, cy - dx);
            if (Tamanho(data, cx + dx, cy - dy)) // 2o Octante
                desenha(data, cx + dx, cy - dy);
            if (Tamanho(data, cx - dx, cy - dy)) // 3o Octante
                desenha(data, cx - dx, cy - dy);
            if (Tamanho(data, cx - dy, cy - dx)) // 4o Octante
                desenha(data, cx - dy, cy - dx);
            if (Tamanho(data, cx - dy, cy + dx)) // 5o Octante
                desenha(data, cx - dy, cy + dx);
            if (Tamanho(data, cx - dx, cy + dy)) // 6o Octante
                desenha(data, cx - dx, cy + dy);
            if (Tamanho(data, cx + dx, cy + dy)) // 7o Octante
                desenha(data, cx + dx, cy + dy);
            if (Tamanho(data, cx + dy, cy + dx)) // 8o Octante
                desenha(data, cx + dy, cy + dx);
        }

        private static bool Tamanho(Bitmap bmp, int x, int y)
        {
            return x >= 0 && x < bmp.Width && y >= 0 && y < bmp.Height;
        }

        public static void CircTrig(Point p1, PictureBox pbx, double raio)
        {
            Bitmap b = new Bitmap(pbx.Image);
            double x, y;
            for (double ang = 90; ang >= 45; --ang)
            {
                x = raio * Math.Cos(ang * 180 / Math.PI);
                y = raio * Math.Sin(ang * 180 / Math.PI);
                Simetria8(b, p1.X, p1.Y, (int)x, (int)y);
            }
            pbx.Image = b;
        }

        public static void PontoMedio(Point p1, PictureBox pbx, double raio)
        {
            Bitmap b = new Bitmap(pbx.Image);
            double x = 0, y = raio;
            double d = 1 - raio;
            Simetria8(b, p1.X, p1.Y, (int)x, (int)y);
            while (y > x)
            {
                if (d < 0) /* escolhe E */
                    d += 2 * x + 3;
                else
                {  /* escolhe SE */
 	                d += 2 * (x - y) +5;
                    y--;
                }
                x++;
                Simetria8(b, p1.X, p1.Y, (int)x, (int)y); //função de simetria
            } /* while*/
            pbx.Image = b;
        } /*pontomedio*/


        public static void Elipse(Point p1, PictureBox pbx, double raio)
        {
            double x = 0, y = raio, d = 1 - raio;
            //double deltaE = 3, in
        }

    }


    //Bresenhan Tulio
    /*private void BresenhamTulio(int x1, int x2, int y1, int y2, Bitmap bmp) /// NAO FUNCIONA AINDA
    {
        int dx, dy, incE, incNE, declive, d, x, y;

        dx = (int)(x2 - x1);
        dy = (int)(y2 - y1);
        declive = 1;

        if (Math.Abs(dx) > Math.Abs(dy)) // FOR EM RELAÇÃO A X
        {
            if (x1 > x2)
            {
                // INVERTE OS PONTOS E REFAZ AS PERGUNTAS
                BresenhamTulio(x2, x1, y2, y1, bmp);
            }
            else
            {
                if (dy < 0)
                {
                    // X, -Y
                    declive = -1;
                    dy = -dy;
                }

                incE = 2 * dy;
                incNE = 2 * dy - 2 * dx;
                d = incE - dx;

                y = (int)y1;

                for (x = (int)x1; x <= x2; x++)
                {
                    bmp.SetPixel(x, y, Color.Black);

                    if (d < 0)
                        d += incE;
                    else
                    {
                        d += incNE;
                        y += declive;
                    }
                }
            }
        }
        else // FOR EM RELAÇÃO A Y
        {
            if (y1 > y2)
            {
                BresenhamTulio(x2, x1, y2, y1, bmp);
            }
            else
            {
                if (dx < 0)
                {
                    declive = -1;
                    dx = -dx;
                }

                incE = 2 * dx;
                incNE = 2 * dx - 2 * dy;
                d = incE - dy;

                x = (int)x1;
                for (y = (int)y1; y <= y2; ++y)
                {
                    bmp.SetPixel(x, y, Color.Black);
                    if (d < 0) // escolhe incE
                        d += incE;
                    else
                    {   // escolhe incNE
                        d += incNE;
                        x += declive;
                    }
                }
            }
        }

    }*/
}
