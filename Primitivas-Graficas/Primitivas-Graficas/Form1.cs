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
        private int CountPoli = 0;
        private List<Point> pontos = new List<Point>();
        private List<Poligono> Lpoli = new List<Poligono>();

        public Form1()
        {
            InitializeComponent();
            pbxRetas.Image = new Bitmap(pbxRetas.Size.Width, pbxRetas.Size.Height);
            pbxPoligonos.Image = new Bitmap(pbxPoligonos.Size.Width, pbxPoligonos.Size.Height);
            
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

                    else if (RbCircReal.Checked)
                    {
                        double raio = Math.Sqrt(Math.Pow(pontos[1].X - pontos[0].X, 2) + Math.Pow(pontos[1].Y - pontos[0].Y, 2));
                        Primitivas.CircGeral(pontos[0], pbxRetas, raio);
                    }
                    else if (RbCircTrig.Checked)
                    {
                        double raio = Math.Sqrt(Math.Pow(pontos[1].X - pontos[0].X, 2) + Math.Pow(pontos[1].Y - pontos[0].Y, 2));
                        Primitivas.CircTrig(pontos[0], pbxRetas, raio);
                    }
                    else if (RbCircPtMedio.Checked)
                    {
                        double raio = Math.Sqrt(Math.Pow(pontos[1].X - pontos[0].X, 2) + Math.Pow(pontos[1].Y - pontos[0].Y, 2));
                        Primitivas.PontoMedio(pontos[0], pbxRetas, raio);
                    }
                    else if (RbElipMédio.Checked)
                    {
                        Primitivas.Elipse(pontos[0], pontos[1], pbxRetas);
                    }
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



        //INTERFACE POLIGONOS        
        private void PbxPoligonos_MouseClick(object sender, MouseEventArgs e)
        {
            if (CbPolignos.SelectedIndex > -1 && ((Poligono)CbPolignos.SelectedItem).Fechado == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pontos.Add(e.Location);

                    int pos = Lpoli.FindIndex(x => x.Rotulo == ((Poligono)CbPolignos.SelectedItem).Rotulo); //Busca a posição do poli selecionado na lista de polis
                    Lpoli[pos].AddPonto(e.Location); //add o ponto dentro do obj poligono
                    dgvPontos.Rows.Add(e.X.ToString());
                    dgvPontos.Rows[dgvPontos.Rows.Count - 1].Cells[0].Value = e.X.ToString();
                    dgvPontos.Rows[dgvPontos.Rows.Count - 1].Cells[1].Value = e.Y.ToString();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    pontos.Add(e.Location);

                    int pos = Lpoli.FindIndex(x => x.Rotulo == ((Poligono)CbPolignos.SelectedItem).Rotulo); //Busca a posição do poli selecionado na lista de polis
                    Lpoli[pos].AddPonto(e.Location); //add o ponto dentro do obj poligono
                    dgvPontos.Rows.Add(e.X.ToString());
                    dgvPontos.Rows[dgvPontos.Rows.Count - 1].Cells[0].Value = e.X.ToString();
                    dgvPontos.Rows[dgvPontos.Rows.Count - 1].Cells[1].Value = e.Y.ToString();

                    Primitivas.DecliveDDA(e.Location, Lpoli[pos].Pontos[0], pbxPoligonos);
                    ((Poligono)CbPolignos.SelectedItem).Fechado = true;
                    ((Poligono)CbPolignos.SelectedItem).pontosAtuais = ((Poligono)CbPolignos.SelectedItem).pontos;
                }

                if (pontos.Count == 2)
                {
                    Primitivas.DecliveDDA(pontos[0], pontos[1], pbxPoligonos);
                    pontos[0] = pontos[1]; //O ultimo ponto se transforma em um novo inicial
                    pontos.RemoveAt(1);
                }
            }

            if(cbFloodFill.Checked && e.Button == MouseButtons.Left )
            {
                ((Poligono)CbPolignos.SelectedItem).floodFill(pbxPoligonos,e.X, e.Y);
            }
        }
        private void ClearTelaPoligono()
        {
            dgvPontos.DataSource = null;
            dgvPontos.Rows.Clear();
            dgvPontos.Refresh();
            pbxPoligonos.Image = new Bitmap(pbxPoligonos.Size.Width, pbxPoligonos.Size.Height); // limpa a tela
        }
        private void BtNovoPoligno_Click(object sender, EventArgs e)
        {
            pontos.Clear();
            Poligono p = new Poligono(CountPoli++);
            Lpoli.Add(p);
            CbPolignos.Items.Add(p);
            CbPolignos.SelectedIndex = CbPolignos.Items.Count - 1;
            ClearTelaPoligono();
        }
        private void BtExcluiPoligno_Click(object sender, EventArgs e)
        {
            if (CbPolignos.SelectedIndex > -1 && Lpoli.Count > 0)
            {
                Lpoli.RemoveAt((int)CbPolignos.SelectedIndex);
                CbPolignos.Items.Remove(CbPolignos.SelectedItem);
                CbPolignos.Text = "";
                ClearTelaPoligono();
            }
        }
        private void ReexibePoligono()
        {
            pontos.Clear();
            ClearTelaPoligono();
            Poligono poli = Lpoli.Find(x => x.Rotulo == ((Poligono)CbPolignos.SelectedItem).Rotulo);
            foreach (Point p in poli.pontosAtuais)
            {
                dgvPontos.Rows.Add(p.X.ToString());
                dgvPontos.Rows[dgvPontos.Rows.Count - 1].Cells[0].Value = p.X.ToString();
                dgvPontos.Rows[dgvPontos.Rows.Count - 1].Cells[1].Value = p.Y.ToString();

                pontos.Add(p);
                if (pontos.Count == 2)
                {
                    Primitivas.DecliveDDA(pontos[0], pontos[1], pbxPoligonos);
                    pontos[0] = pontos[1];
                    pontos.RemoveAt(1);
                }
            }
            if (poli.Fechado == true) //Se o poligono estiver completo, a ligação do Pi com Pf é feita
                Primitivas.DecliveDDA(poli.pontosAtuais[0], poli.pontosAtuais[poli.pontosAtuais.Count-1], pbxPoligonos);

        }
        private void CbPolignos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReexibePoligono();
        }

        private void BtTransf_Click(object sender, EventArgs e)
        {
            ((Poligono)CbPolignos.SelectedItem).Translada(double.Parse(tbTX.Text), double.Parse(tbTY.Text));            
            ReexibePoligono();
        }

        private void BtEscala_Click(object sender, EventArgs e)
        {
            ((Poligono)CbPolignos.SelectedItem).Escala(double.Parse(tbSX.Text), double.Parse(tbSY.Text));            
            ReexibePoligono();
        }

        private void BtRotacao_Click(object sender, EventArgs e)
        {
            if(rbOrigem.Checked)
                ((Poligono)CbPolignos.SelectedItem).Rotacao(double.Parse(tbRotacao.Text), new Point(0, 0), 'o');
            else
            {
                Poligono pTemp = ((Poligono)CbPolignos.SelectedItem);
                double Mx = 0, My = 0;
                for (int i = 0; i < pTemp.pontos.Count; i++)
                {
                    Mx += pTemp.pontos[i].X;
                    My += pTemp.pontos[i].Y;
                }
                Mx = Mx / pTemp.pontos.Count;
                My = My / pTemp.pontos.Count;
                ((Poligono)CbPolignos.SelectedItem).Rotacao(double.Parse(tbRotacao.Text), new Point((int)Mx, (int)My), 'e');
            }
            ReexibePoligono();
        }

        private void BtCisX_Click(object sender, EventArgs e)
        {
            ((Poligono)CbPolignos.SelectedItem).cisalhamentoX(double.Parse(tbCisX.Text));
            ReexibePoligono();
            
        }

        private void BtCisY_Click(object sender, EventArgs e)
        {
            ((Poligono)CbPolignos.SelectedItem).cisalhamentoY(double.Parse(tbCisY.Text));
            ReexibePoligono();
        }

        private void BtEspX_Click(object sender, EventArgs e)
        {
            Poligono pTemp = ((Poligono)CbPolignos.SelectedItem);
            double Mx = 0, My = 0;
            for (int i = 0; i < pTemp.pontos.Count; i++)
            {
                Mx += pTemp.pontos[i].X;
                My += pTemp.pontos[i].Y;
            }
            Mx = Mx / pTemp.pontos.Count;
            My = My / pTemp.pontos.Count;
            ((Poligono)CbPolignos.SelectedItem).espelhamentoX(new Point((int)Mx, (int)My));
            ReexibePoligono();
        }

        private void BtEspY_Click(object sender, EventArgs e)
        {
            Poligono pTemp = ((Poligono)CbPolignos.SelectedItem);
            double Mx = 0, My = 0;
            for (int i = 0; i < pTemp.pontos.Count; i++)
            {
                Mx += pTemp.pontos[i].X;
                My += pTemp.pontos[i].Y;
            }
            Mx = Mx / pTemp.pontos.Count;
            My = My / pTemp.pontos.Count;
            ((Poligono)CbPolignos.SelectedItem).espelhamentoY(new Point((int)Mx, (int)My));
            ReexibePoligono();
        }

        

        private void BtViewPort_Click(object sender, EventArgs e)
        {

        }

        

        private void CbFloodFill_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
