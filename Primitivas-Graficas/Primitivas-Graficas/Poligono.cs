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
        private int[][] MA = new int[3][];

        public Poligono(int rotulo)
        {            
            this.rotulo = rotulo;
            this.Fechado = false;
            MA[0] = new int[3];
            MA[1] = new int[3];
            MA[2] = new int[3];

            MA[0][0] = 1;
            MA[0][1] = 0;
            MA[0][2] = 0;
            MA[1][0] = 0;
            MA[1][1] = 1;
            MA[1][2] = 0;
            MA[2][0] = 0;
            MA[2][1] = 0;
            MA[2][2] = 1;
        }
        public Poligono(int rotulo, List<Point> pontos)
        {
            this.pontos = pontos;
            this.rotulo = rotulo;
            this.Fechado = false;
            MA[0] = new int[3];
            MA[1] = new int[3];
            MA[2] = new int[3];

            MA[0][0] = 1;
            MA[0][1] = 0;
            MA[0][2] = 0;
            MA[1][0] = 0;
            MA[1][1] = 1;
            MA[1][2] = 0;
            MA[2][0] = 0;
            MA[2][1] = 0;
            MA[2][2] = 1;
        }
        
        public int Rotulo { get => rotulo; set => rotulo = value; }
        public List<Point> Pontos { get => pontos;}
        public bool Fechado { get => fechado; set => fechado = value; }
        public void AddPonto(Point p)
        {
            this.Pontos.Add(p);
        }

        

        public void Translada(int Tx, int Ty)
        {
            int[][] M = new int[3][];
            M[0] = new int[3];
            M[1] = new int[3];
            M[2] = new int[3];

            M[0][0] = 1;
            M[0][1] = 0;
            M[0][2] = Tx;
            M[1][0] = 0;
            M[1][1] = 1;
            M[1][2] = Ty;
            M[2][0] = 0;
            M[2][1] = 0;
            M[2][2] = 1;


        }
        public void Escala(int Sx, int Sy)
        {   //Chama a transladação

            int[][] M = new int[3][];
            M[0] = new int[3];
            M[1] = new int[3];
            M[2] = new int[3];

            M[0][0] = Sx;
            M[0][1] = 0;
            M[0][2] = 0;
            M[1][0] = 0;
            M[1][1] = Sy;
            M[1][2] = 0;
            M[2][0] = 0;
            M[2][1] = 0;
            M[2][2] = 1;


        }

        
    }
}
