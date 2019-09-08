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
        private int[][] MA = new int[3][];

        public Poligono(int rotulo)
        {            
            this.Rotulo = rotulo;
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

        public void AddPonto(Point p)
        {
            this.pontos.Add(p);
        }
    }
}
