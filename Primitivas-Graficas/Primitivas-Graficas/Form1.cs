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


        public Form1()
        {
            InitializeComponent();
            pbxRetas.Image = new Bitmap(pbxRetas.Size.Width, pbxRetas.Size.Height);
        }
        private void TabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            pontos.Clear();
        }
        private void TabPage2_MouseClick(object sender, MouseEventArgs e)
        {
            pontos.Clear();
        }


        //INTERFACE PRIMITIVAS GRÁFICAS
        private void PbxRetas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pontos.Add(new Point(e.X, e.Y));
                if (pontos.Count == 2)
                {
                    if (RbRetaReal.Checked)
                        Primitivas.EQgeral(pontos[0], pontos[1], pbxRetas);
                    else if (RbRetaDDA.Checked)
                        Primitivas.DecliveDDA(pontos[0], pontos[1], pbxRetas);
                    else if (RbRetaBresenhan.Checked)
                        Primitivas.Bresenhan(pontos[0], pontos[1], pbxRetas);

                    pontos.Clear();
                }
            }
        }
        private void PbxRetas_MouseMove(object sender, MouseEventArgs e)
        {
            lbX.Text = "X: " + e.X;
            lbY.Text = "Y: " + e.Y;
        }
        private void RbBresenhan_CheckedChanged(object sender, EventArgs e)
        {
            btnLimpar.PerformClick();
        }
        private void RbEqReal_CheckedChanged(object sender, EventArgs e)
        {
            btnLimpar.PerformClick();
        }
        private void RbDDA_CheckedChanged(object sender, EventArgs e)
        {
            btnLimpar.PerformClick();
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            pbxRetas.Image = new Bitmap(pbxRetas.Size.Width, pbxRetas.Size.Height);
        }

        private void PbxPoligonos_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {

            }
            else if(e.Button == MouseButtons.Right) //FECHA O POLIGONO
            {
                
            }
        }

       


        //INTERFACE POLIGONOS
    }
}
