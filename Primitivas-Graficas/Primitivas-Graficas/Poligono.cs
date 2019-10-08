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
    class Poligono
    {
        public List<Point> pontos = new List<Point>();
        public List<Point> pontosAtuais = new List<Point>();
        private int rotulo;
        private bool fechado;
        private double[,] MA = new double[3, 3];

        public Poligono(int rotulo)
        {
            this.rotulo = rotulo;
            this.Fechado = false;

            MA[0, 0] = 1;
            MA[1, 1] = 1;
            MA[2, 2] = 1;
        }

        private double[,] NovaMatriz()
        {
            double[,] M = new double[3, 3];
            M[0, 0] = M[1, 1] = M[2, 2] = 1;
            return M;
        }

        public int Rotulo { get => rotulo; set => rotulo = value; }
        public List<Point> Pontos { get => pontos; }
        public bool Fechado { get => fechado; set => fechado = value; }
        public void AddPonto(Point p)
        {
            this.Pontos.Add(p);
        }

        public void AtualizaPontos()
        {
            List<Point> L = new List<Point>();
            Point p = new Point();
            Point newP = new Point();

            for (int i = 0; i < pontos.Count; i++)
            {
                p = pontos[i];
                newP.X = (int)((p.X * MA[0, 0]) + (p.Y * MA[0, 1]) + MA[0, 2]);
                newP.Y = (int)((p.X * MA[1, 0]) + (p.Y * MA[1, 1]) + MA[1, 2]);
                L.Add(newP);
            }
            this.pontosAtuais = L;
        }

        private void MultMat(double[,] M)
        {
            double soma = 0;
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    soma = 0;
                    for (int k = 0; k < 3; k++)
                        soma += MA[l,k] * M[k,c];
                    this.MA[l, c] = soma;
                }
            }
        }              

        public void Translada(double Tx, double Ty)
        {
            double[,] M = NovaMatriz();
            M[0, 2] = Tx;
            M[1, 2] = Ty;

            MultMat(M);
            AtualizaPontos();
        }
        public void Escala(double Sx, double Sy)
        {
            double[,] M = NovaMatriz();
            M[0, 0] = Sx;
            M[1, 1] = Sy;
           
            //X e Y médio
            double Mx = 0, My = 0;
            for (int i = 0; i < pontos.Count; i++)
            {
                Mx += pontos[i].X;
                My += pontos[i].Y;
            }
            Mx = Mx / pontos.Count;
            My = My / pontos.Count;

            Translada(Mx, My);
            MultMat(M);
            Translada(-Mx, -My);
            AtualizaPontos();
        }       
        
        public void Rotacao(double ang, Point p, char op)
        {
            double rad = ang * Math.PI / 180;
            double[,] M = NovaMatriz();
            M[0, 0] = Math.Cos(rad);
            M[0, 1] = -Math.Sin(rad);
            M[1, 0] = Math.Sin(rad);
            M[1, 1] = Math.Cos(rad);

            if(op == 'e')
                Translada(-p.X, -p.Y);
            MultMat(M);
            if (op == 'e')
                Translada(p.X, p.Y);
            AtualizaPontos();
        }

        public void cisalhamentoY(double v)
        {
            double[,] M = NovaMatriz();
            M[0, 1] = v;

            double Mx = 0, My = 0;
            for (int i = 0; i < pontos.Count; i++)
            {
                Mx += pontos[i].X;
                My += pontos[i].Y;
            }
            Mx = Mx / pontos.Count;
            My = My / pontos.Count;

            Translada(Mx, My);
            MultMat(M);
            Translada(-Mx, -My); 
            AtualizaPontos();
        }

        public void cisalhamentoX(double v)
        {
            double[,] M = NovaMatriz();
            M[1, 0] = v;            

            double Mx = 0, My = 0;
            for (int i = 0; i < pontos.Count; i++)
            {
                Mx += pontos[i].X;
                My += pontos[i].Y;
            }
            Mx = Mx / pontos.Count;
            My = My / pontos.Count;

            Translada(Mx, My);            
            MultMat(M);
            Translada(-Mx, -My);
            AtualizaPontos();
        }

        public void espelhamentoX(Point p)
        {
            double[,] M = NovaMatriz();
            M[0, 0] = M[2, 2] = 1;
            M[1, 1] = -1;            
            
            Translada(p.X, p.Y);
            MultMat(M);
            Translada(-p.X, -p.Y);
            AtualizaPontos();
        }

        public void espelhamentoY(Point p)
        {
            double[,] M = NovaMatriz();
            M[1, 1] = M[2, 2] = 1;
            M[0, 0] = -1;

            Translada(p.X, p.Y);
            MultMat(M);
            Translada(-p.X, -p.Y);
            AtualizaPontos();
        }

        public static bool Tamanho(BitmapData bmp, int x, int y)
        {
            return x >= 0 && x < bmp.Width && y >= 0 && y < bmp.Height;
        }

        /* public void floodFill(PictureBox pbx, int x, int y, Color cor)
         {
             Stack<int> pilha = new Stack<int>();
             // lock data
             Bitmap bmp = new Bitmap(pbx.Image);
             BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                 ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
             unsafe
             {
                 byte* aux = gotoxy(data, x, y);
                 int fundoB = *aux, fundoG = *(aux + 1), fundoR = *(aux + 2);
                 int[] dx = { -1, 0, 0, 1 };
                 int[] dy = { 0, -1, 1, 0 };
                 int i;
                 pilha.Push(x);
                 pilha.Push(y);
                 while (pilha.Count > 0)
                 {
                     y = pilha.Pop();
                     x = pilha.Pop();
                     aux = gotoxy(data, x, y);
                     *(aux++) = cor.B; // melhor forma, inc 1
                     *(aux++) = cor.G;
                     *aux = cor.R;
                     for (i = 0; i < 4; ++i)
                     {
                         if (Tamanho(data, x + dx[i], y + dy[i]))
                         {
                             aux = gotoxy(data, x + dx[i], y + dy[i]);
                             if (*aux == fundoB && *(aux + 1) == fundoG && *(aux + 2) == fundoR)
                             {
                                 pilha.Push(x + dx[i]);
                                 pilha.Push(y + dy[i]);
                             }
                         }
                     }
                 }
             }
             // unlock
             bmp.UnlockBits(data);
             pbx.Image = bmp;

         }

         public static unsafe byte* gotoxy(BitmapData bmp, int x, int y)
         {
             byte* aux = (byte*)bmp.Scan0.ToPointer();
             aux += y * bmp.Stride; // linha
             aux += 3 * x; // coluna
             return aux;
         }//*/

        public void floodFill(PictureBox pbx, int x, int y)
        {
            Bitmap bmp = new Bitmap(pbx.Image);
            Color cor = Color.FromArgb(bmp.GetPixel(x, y).R, bmp.GetPixel(x, y).G, bmp.GetPixel(x, y).B);
            Color c_atual;

            Stack<Point> pilha = new Stack<Point>();

            Point p = new Point(x, y);

            pilha.Push(p);

            while (pilha.Count > 0)
            {
                p = pilha.Pop();
                x = p.X;
                y = p.Y;

                c_atual = Color.FromArgb(bmp.GetPixel(p.X, p.Y).R, bmp.GetPixel(p.X, p.Y).G, bmp.GetPixel(p.X, p.Y).B);

                if (c_atual == cor)
                {
                    bmp.SetPixel(x, y, Color.Yellow);

                    if (x - 1 >= 0 && !bmp.GetPixel(x - 1, y).Equals(cor))
                        pilha.Push(new Point(x - 1, y));
                    if (y - 1 >= 0 && !bmp.GetPixel(x, y - 1).Equals(cor))
                        pilha.Push(new Point(x, y - 1));

                    if (x + 1 < pbx.Width && !bmp.GetPixel(x + 1, y).Equals(cor))
                        pilha.Push(new Point(x + 1, y));
                    if (y + 1 < pbx.Height && !bmp.GetPixel(x, y + 1).Equals(cor))
                        pilha.Push(new Point(x, y + 1));
                }

            }
            pbx.Image = bmp;

        }

    }
}
