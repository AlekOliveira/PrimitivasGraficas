using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitivas_Graficas
{
    class Poligono
    {
            private List<Point> pontos = new List<Point>();
            private int rotulo;
            private bool fechado;
            private int[,] MA = new int[3, 3];

            public Poligono(int rotulo)
            {
                this.rotulo = rotulo;
                this.Fechado = false;

                MA[0, 0] = 1;
                MA[1, 1] = 1;
                MA[2, 2] = 1;
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
                for (int i = 0; i < pontos.Count; i++)
                {
                    Point p = pontos[i];
                    p.X = (p.X * MA[0, 0]) + (p.Y * MA[0, 1]) + MA[0, 2];
                    p.Y = (p.X * MA[1, 0]) + (p.Y * MA[1, 1]) + MA[1, 2];
                    pontos[i] = p;
                }
            }

            private void MultMat(int[,] M)
            {
                int soma = 0;
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

            public void Translada(int Tx, int Ty)
            {
                int[,] M = new int[3, 3];
                M[0, 0] = 1;
                M[0, 2] = Tx;
                M[1, 1] = 1;
                M[1, 2] = Ty;
                M[2, 2] = 1;

                MultMat(M);
            }
        public void Escala(int Sx, int Sy)
        {
            int[,] M = new int[3, 3];
            M[0, 0] = Sx;
            M[1, 1] = Sy;
            M[2, 2] = 1;

            //Chama a transladação p/ origem
            //X e Y médio
            int Mx = 0, My = 0;
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



        }



    }
}
