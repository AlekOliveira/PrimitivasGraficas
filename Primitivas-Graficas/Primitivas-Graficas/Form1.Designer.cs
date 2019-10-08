namespace Primitivas_Graficas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxRetas = new System.Windows.Forms.GroupBox();
            this.RbRetaBresenhan = new System.Windows.Forms.RadioButton();
            this.RbRetaDDA = new System.Windows.Forms.RadioButton();
            this.RbRetaReal = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbY = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RbElipMédio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbCircPtMedio = new System.Windows.Forms.RadioButton();
            this.RbCircTrig = new System.Windows.Forms.RadioButton();
            this.RbCircReal = new System.Windows.Forms.RadioButton();
            this.pbxRetas = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pbxPoligonos = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btCisY = new System.Windows.Forms.Button();
            this.tbCisY = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btCisX = new System.Windows.Forms.Button();
            this.tbCisX = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btRotacao = new System.Windows.Forms.Button();
            this.tbRotacao = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btEscala = new System.Windows.Forms.Button();
            this.tbSY = new System.Windows.Forms.TextBox();
            this.tbSX = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTX = new System.Windows.Forms.TextBox();
            this.tbTY = new System.Windows.Forms.TextBox();
            this.btTransf = new System.Windows.Forms.Button();
            this.BtExcluiPoligno = new System.Windows.Forms.Button();
            this.BtNovoPoligno = new System.Windows.Forms.Button();
            this.dgvPontos = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbPolignos = new System.Windows.Forms.ComboBox();
            this.rbOrigem = new System.Windows.Forms.RadioButton();
            this.rbEixo = new System.Windows.Forms.RadioButton();
            this.btEspX = new System.Windows.Forms.Button();
            this.btEspY = new System.Windows.Forms.Button();
            this.tbVPx = new System.Windows.Forms.TextBox();
            this.tbVPy = new System.Windows.Forms.TextBox();
            this.btViewPort = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.cbFloodFill = new System.Windows.Forms.CheckBox();
            this.groupBoxRetas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRetas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPoligonos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPontos)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRetas
            // 
            this.groupBoxRetas.Controls.Add(this.RbRetaBresenhan);
            this.groupBoxRetas.Controls.Add(this.RbRetaDDA);
            this.groupBoxRetas.Controls.Add(this.RbRetaReal);
            this.groupBoxRetas.Location = new System.Drawing.Point(6, 19);
            this.groupBoxRetas.Name = "groupBoxRetas";
            this.groupBoxRetas.Size = new System.Drawing.Size(155, 89);
            this.groupBoxRetas.TabIndex = 0;
            this.groupBoxRetas.TabStop = false;
            this.groupBoxRetas.Text = "Retas";
            // 
            // RbRetaBresenhan
            // 
            this.RbRetaBresenhan.AutoSize = true;
            this.RbRetaBresenhan.Location = new System.Drawing.Point(17, 66);
            this.RbRetaBresenhan.Name = "RbRetaBresenhan";
            this.RbRetaBresenhan.Size = new System.Drawing.Size(76, 17);
            this.RbRetaBresenhan.TabIndex = 2;
            this.RbRetaBresenhan.TabStop = true;
            this.RbRetaBresenhan.Text = "Bresenhan";
            this.RbRetaBresenhan.UseVisualStyleBackColor = true;
            this.RbRetaBresenhan.CheckedChanged += new System.EventHandler(this.RbBresenhan_CheckedChanged);
            // 
            // RbRetaDDA
            // 
            this.RbRetaDDA.AutoSize = true;
            this.RbRetaDDA.Location = new System.Drawing.Point(18, 43);
            this.RbRetaDDA.Name = "RbRetaDDA";
            this.RbRetaDDA.Size = new System.Drawing.Size(87, 17);
            this.RbRetaDDA.TabIndex = 1;
            this.RbRetaDDA.TabStop = true;
            this.RbRetaDDA.Text = "Declive DDA";
            this.RbRetaDDA.UseVisualStyleBackColor = true;
            this.RbRetaDDA.CheckedChanged += new System.EventHandler(this.RbDDA_CheckedChanged);
            // 
            // RbRetaReal
            // 
            this.RbRetaReal.AutoSize = true;
            this.RbRetaReal.Location = new System.Drawing.Point(17, 20);
            this.RbRetaReal.Name = "RbRetaReal";
            this.RbRetaReal.Size = new System.Drawing.Size(88, 17);
            this.RbRetaReal.TabIndex = 0;
            this.RbRetaReal.TabStop = true;
            this.RbRetaReal.Text = "Equação real";
            this.RbRetaReal.UseVisualStyleBackColor = true;
            this.RbRetaReal.CheckedChanged += new System.EventHandler(this.RbEqReal_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.lbY);
            this.groupBox2.Controls.Add(this.lbX);
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.groupBoxRetas);
            this.groupBox2.Location = new System.Drawing.Point(9, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1510, 115);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(368, 87);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(20, 13);
            this.lbY.TabIndex = 7;
            this.lbY.Text = "Y: ";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(332, 87);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(20, 13);
            this.lbX.TabIndex = 6;
            this.lbX.Text = "X: ";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Location = new System.Drawing.Point(408, 82);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RbElipMédio);
            this.groupBox3.Location = new System.Drawing.Point(328, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 46);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elipse";
            // 
            // RbElipMédio
            // 
            this.RbElipMédio.AutoSize = true;
            this.RbElipMédio.Location = new System.Drawing.Point(17, 20);
            this.RbElipMédio.Name = "RbElipMédio";
            this.RbElipMédio.Size = new System.Drawing.Size(85, 17);
            this.RbElipMédio.TabIndex = 0;
            this.RbElipMédio.TabStop = true;
            this.RbElipMédio.Text = "Ponto Médio";
            this.RbElipMédio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbCircPtMedio);
            this.groupBox1.Controls.Add(this.RbCircTrig);
            this.groupBox1.Controls.Add(this.RbCircReal);
            this.groupBox1.Location = new System.Drawing.Point(167, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 89);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cicunferência";
            // 
            // RbCircPtMedio
            // 
            this.RbCircPtMedio.AutoSize = true;
            this.RbCircPtMedio.Location = new System.Drawing.Point(17, 66);
            this.RbCircPtMedio.Name = "RbCircPtMedio";
            this.RbCircPtMedio.Size = new System.Drawing.Size(85, 17);
            this.RbCircPtMedio.TabIndex = 2;
            this.RbCircPtMedio.TabStop = true;
            this.RbCircPtMedio.Text = "Ponto Médio";
            this.RbCircPtMedio.UseVisualStyleBackColor = true;
            // 
            // RbCircTrig
            // 
            this.RbCircTrig.AutoSize = true;
            this.RbCircTrig.Location = new System.Drawing.Point(18, 43);
            this.RbCircTrig.Name = "RbCircTrig";
            this.RbCircTrig.Size = new System.Drawing.Size(89, 17);
            this.RbCircTrig.TabIndex = 1;
            this.RbCircTrig.TabStop = true;
            this.RbCircTrig.Text = "Trigonometria";
            this.RbCircTrig.UseVisualStyleBackColor = true;
            // 
            // RbCircReal
            // 
            this.RbCircReal.AutoSize = true;
            this.RbCircReal.Location = new System.Drawing.Point(17, 20);
            this.RbCircReal.Name = "RbCircReal";
            this.RbCircReal.Size = new System.Drawing.Size(88, 17);
            this.RbCircReal.TabIndex = 0;
            this.RbCircReal.TabStop = true;
            this.RbCircReal.Text = "Equação real";
            this.RbCircReal.UseVisualStyleBackColor = true;
            // 
            // pbxRetas
            // 
            this.pbxRetas.BackColor = System.Drawing.Color.White;
            this.pbxRetas.Location = new System.Drawing.Point(9, 127);
            this.pbxRetas.Name = "pbxRetas";
            this.pbxRetas.Size = new System.Drawing.Size(980, 622);
            this.pbxRetas.TabIndex = 3;
            this.pbxRetas.TabStop = false;
            this.pbxRetas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PbxRetas_MouseClick);
            this.pbxRetas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbxRetas_MouseMove);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1003, 781);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.pbxRetas);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(995, 755);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Primitivas";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pbxPoligonos);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(995, 755);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Poligonos";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TabPage2_MouseClick);
            // 
            // pbxPoligonos
            // 
            this.pbxPoligonos.Location = new System.Drawing.Point(3, 3);
            this.pbxPoligonos.Name = "pbxPoligonos";
            this.pbxPoligonos.Size = new System.Drawing.Size(752, 746);
            this.pbxPoligonos.TabIndex = 5;
            this.pbxPoligonos.TabStop = false;
            this.pbxPoligonos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PbxPoligonos_MouseClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox4.Controls.Add(this.cbFloodFill);
            this.groupBox4.Controls.Add(this.groupBox11);
            this.groupBox4.Controls.Add(this.groupBox10);
            this.groupBox4.Controls.Add(this.groupBox9);
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.BtExcluiPoligno);
            this.groupBox4.Controls.Add(this.BtNovoPoligno);
            this.groupBox4.Controls.Add(this.dgvPontos);
            this.groupBox4.Controls.Add(this.CbPolignos);
            this.groupBox4.Location = new System.Drawing.Point(761, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(228, 743);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Poligonos";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btCisY);
            this.groupBox9.Controls.Add(this.tbCisY);
            this.groupBox9.Location = new System.Drawing.Point(10, 536);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(200, 58);
            this.groupBox9.TabIndex = 13;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Cisalhamento Y";
            // 
            // btCisY
            // 
            this.btCisY.Location = new System.Drawing.Point(123, 19);
            this.btCisY.Name = "btCisY";
            this.btCisY.Size = new System.Drawing.Size(68, 23);
            this.btCisY.TabIndex = 7;
            this.btCisY.Text = "Aplicar";
            this.btCisY.UseVisualStyleBackColor = true;
            this.btCisY.Click += new System.EventHandler(this.BtCisY_Click);
            // 
            // tbCisY
            // 
            this.tbCisY.Location = new System.Drawing.Point(33, 22);
            this.tbCisY.Name = "tbCisY";
            this.tbCisY.Size = new System.Drawing.Size(30, 20);
            this.tbCisY.TabIndex = 8;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btCisX);
            this.groupBox8.Controls.Add(this.tbCisX);
            this.groupBox8.Location = new System.Drawing.Point(10, 472);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 58);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Cisalhamento X";
            // 
            // btCisX
            // 
            this.btCisX.Location = new System.Drawing.Point(123, 19);
            this.btCisX.Name = "btCisX";
            this.btCisX.Size = new System.Drawing.Size(68, 23);
            this.btCisX.TabIndex = 7;
            this.btCisX.Text = "Aplicar";
            this.btCisX.UseVisualStyleBackColor = true;
            this.btCisX.Click += new System.EventHandler(this.BtCisX_Click);
            // 
            // tbCisX
            // 
            this.tbCisX.Location = new System.Drawing.Point(33, 22);
            this.tbCisX.Name = "tbCisX";
            this.tbCisX.Size = new System.Drawing.Size(30, 20);
            this.tbCisX.TabIndex = 8;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbEixo);
            this.groupBox7.Controls.Add(this.rbOrigem);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.btRotacao);
            this.groupBox7.Controls.Add(this.tbRotacao);
            this.groupBox7.Location = new System.Drawing.Point(10, 365);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 101);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Rotação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ang:";
            // 
            // btRotacao
            // 
            this.btRotacao.Location = new System.Drawing.Point(123, 19);
            this.btRotacao.Name = "btRotacao";
            this.btRotacao.Size = new System.Drawing.Size(68, 23);
            this.btRotacao.TabIndex = 7;
            this.btRotacao.Text = "Aplicar";
            this.btRotacao.UseVisualStyleBackColor = true;
            this.btRotacao.Click += new System.EventHandler(this.BtRotacao_Click);
            // 
            // tbRotacao
            // 
            this.tbRotacao.Location = new System.Drawing.Point(45, 22);
            this.tbRotacao.Name = "tbRotacao";
            this.tbRotacao.Size = new System.Drawing.Size(30, 20);
            this.tbRotacao.TabIndex = 8;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.btEscala);
            this.groupBox6.Controls.Add(this.tbSY);
            this.groupBox6.Controls.Add(this.tbSX);
            this.groupBox6.Location = new System.Drawing.Point(10, 301);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 58);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Escala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "X:";
            // 
            // btEscala
            // 
            this.btEscala.Location = new System.Drawing.Point(123, 19);
            this.btEscala.Name = "btEscala";
            this.btEscala.Size = new System.Drawing.Size(68, 23);
            this.btEscala.TabIndex = 7;
            this.btEscala.Text = "Aplicar";
            this.btEscala.UseVisualStyleBackColor = true;
            this.btEscala.Click += new System.EventHandler(this.BtEscala_Click);
            // 
            // tbSY
            // 
            this.tbSY.Location = new System.Drawing.Point(87, 22);
            this.tbSY.Name = "tbSY";
            this.tbSY.Size = new System.Drawing.Size(30, 20);
            this.tbSY.TabIndex = 9;
            // 
            // tbSX
            // 
            this.tbSX.Location = new System.Drawing.Point(33, 22);
            this.tbSX.Name = "tbSX";
            this.tbSX.Size = new System.Drawing.Size(30, 20);
            this.tbSX.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.tbTX);
            this.groupBox5.Controls.Add(this.tbTY);
            this.groupBox5.Controls.Add(this.btTransf);
            this.groupBox5.Location = new System.Drawing.Point(8, 232);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 63);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Translação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X:";
            // 
            // tbTX
            // 
            this.tbTX.Location = new System.Drawing.Point(35, 29);
            this.tbTX.Name = "tbTX";
            this.tbTX.Size = new System.Drawing.Size(30, 20);
            this.tbTX.TabIndex = 4;
            // 
            // tbTY
            // 
            this.tbTY.Location = new System.Drawing.Point(89, 29);
            this.tbTY.Name = "tbTY";
            this.tbTY.Size = new System.Drawing.Size(30, 20);
            this.tbTY.TabIndex = 5;
            // 
            // btTransf
            // 
            this.btTransf.Location = new System.Drawing.Point(125, 27);
            this.btTransf.Name = "btTransf";
            this.btTransf.Size = new System.Drawing.Size(69, 23);
            this.btTransf.TabIndex = 6;
            this.btTransf.Text = "Aplicar";
            this.btTransf.UseVisualStyleBackColor = true;
            this.btTransf.Click += new System.EventHandler(this.BtTransf_Click);
            // 
            // BtExcluiPoligno
            // 
            this.BtExcluiPoligno.Location = new System.Drawing.Point(117, 105);
            this.BtExcluiPoligno.Name = "BtExcluiPoligno";
            this.BtExcluiPoligno.Size = new System.Drawing.Size(93, 23);
            this.BtExcluiPoligno.TabIndex = 3;
            this.BtExcluiPoligno.Text = "Excluir";
            this.BtExcluiPoligno.UseVisualStyleBackColor = true;
            this.BtExcluiPoligno.Click += new System.EventHandler(this.BtExcluiPoligno_Click);
            // 
            // BtNovoPoligno
            // 
            this.BtNovoPoligno.Location = new System.Drawing.Point(117, 76);
            this.BtNovoPoligno.Name = "BtNovoPoligno";
            this.BtNovoPoligno.Size = new System.Drawing.Size(93, 23);
            this.BtNovoPoligno.TabIndex = 2;
            this.BtNovoPoligno.Text = "Novo";
            this.BtNovoPoligno.UseVisualStyleBackColor = true;
            this.BtNovoPoligno.Click += new System.EventHandler(this.BtNovoPoligno_Click);
            // 
            // dgvPontos
            // 
            this.dgvPontos.AllowUserToAddRows = false;
            this.dgvPontos.AllowUserToDeleteRows = false;
            this.dgvPontos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPontos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dgvPontos.Location = new System.Drawing.Point(8, 49);
            this.dgvPontos.Name = "dgvPontos";
            this.dgvPontos.ReadOnly = true;
            this.dgvPontos.RowHeadersVisible = false;
            this.dgvPontos.Size = new System.Drawing.Size(89, 159);
            this.dgvPontos.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 45;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Width = 45;
            // 
            // CbPolignos
            // 
            this.CbPolignos.FormattingEnabled = true;
            this.CbPolignos.Location = new System.Drawing.Point(117, 49);
            this.CbPolignos.Name = "CbPolignos";
            this.CbPolignos.Size = new System.Drawing.Size(93, 21);
            this.CbPolignos.TabIndex = 0;
            this.CbPolignos.SelectedIndexChanged += new System.EventHandler(this.CbPolignos_SelectedIndexChanged);
            // 
            // rbOrigem
            // 
            this.rbOrigem.AutoSize = true;
            this.rbOrigem.Checked = true;
            this.rbOrigem.Location = new System.Drawing.Point(13, 48);
            this.rbOrigem.Name = "rbOrigem";
            this.rbOrigem.Size = new System.Drawing.Size(58, 17);
            this.rbOrigem.TabIndex = 10;
            this.rbOrigem.TabStop = true;
            this.rbOrigem.Text = "Origem";
            this.rbOrigem.UseVisualStyleBackColor = true;
            // 
            // rbEixo
            // 
            this.rbEixo.AutoSize = true;
            this.rbEixo.Location = new System.Drawing.Point(13, 71);
            this.rbEixo.Name = "rbEixo";
            this.rbEixo.Size = new System.Drawing.Size(45, 17);
            this.rbEixo.TabIndex = 11;
            this.rbEixo.Text = "Eixo";
            this.rbEixo.UseVisualStyleBackColor = true;
            // 
            // btEspX
            // 
            this.btEspX.Location = new System.Drawing.Point(6, 19);
            this.btEspX.Name = "btEspX";
            this.btEspX.Size = new System.Drawing.Size(88, 23);
            this.btEspX.TabIndex = 9;
            this.btEspX.Text = "Espelhar em X";
            this.btEspX.UseVisualStyleBackColor = true;
            this.btEspX.Click += new System.EventHandler(this.BtEspX_Click);
            // 
            // btEspY
            // 
            this.btEspY.Location = new System.Drawing.Point(100, 19);
            this.btEspY.Name = "btEspY";
            this.btEspY.Size = new System.Drawing.Size(88, 23);
            this.btEspY.TabIndex = 14;
            this.btEspY.Text = "Espelhar em Y";
            this.btEspY.UseVisualStyleBackColor = true;
            this.btEspY.Click += new System.EventHandler(this.BtEspY_Click);
            // 
            // tbVPx
            // 
            this.tbVPx.Location = new System.Drawing.Point(6, 19);
            this.tbVPx.Name = "tbVPx";
            this.tbVPx.Size = new System.Drawing.Size(30, 20);
            this.tbVPx.TabIndex = 9;
            // 
            // tbVPy
            // 
            this.tbVPy.Location = new System.Drawing.Point(49, 19);
            this.tbVPy.Name = "tbVPy";
            this.tbVPy.Size = new System.Drawing.Size(30, 20);
            this.tbVPy.TabIndex = 15;
            // 
            // btViewPort
            // 
            this.btViewPort.Location = new System.Drawing.Point(100, 16);
            this.btViewPort.Name = "btViewPort";
            this.btViewPort.Size = new System.Drawing.Size(88, 23);
            this.btViewPort.TabIndex = 16;
            this.btViewPort.Text = "Aplicar";
            this.btViewPort.UseVisualStyleBackColor = true;
            this.btViewPort.Click += new System.EventHandler(this.BtViewPort_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btEspX);
            this.groupBox10.Controls.Add(this.btEspY);
            this.groupBox10.Location = new System.Drawing.Point(10, 600);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 57);
            this.groupBox10.TabIndex = 17;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Espelhamento";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btViewPort);
            this.groupBox11.Controls.Add(this.tbVPx);
            this.groupBox11.Controls.Add(this.tbVPy);
            this.groupBox11.Location = new System.Drawing.Point(10, 663);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(200, 61);
            this.groupBox11.TabIndex = 18;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "ViewPort (Larg, Alt)";
            // 
            // cbFloodFill
            // 
            this.cbFloodFill.AutoSize = true;
            this.cbFloodFill.Location = new System.Drawing.Point(117, 154);
            this.cbFloodFill.Name = "cbFloodFill";
            this.cbFloodFill.Size = new System.Drawing.Size(64, 17);
            this.cbFloodFill.TabIndex = 20;
            this.cbFloodFill.Text = "FloodFill";
            this.cbFloodFill.UseVisualStyleBackColor = true;
            this.cbFloodFill.CheckedChanged += new System.EventHandler(this.CbFloodFill_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1021, 805);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CG-Primitivas Gráficas";
            this.groupBoxRetas.ResumeLayout(false);
            this.groupBoxRetas.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRetas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPoligonos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPontos)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRetas;
        private System.Windows.Forms.RadioButton RbRetaDDA;
        private System.Windows.Forms.RadioButton RbRetaReal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RbRetaBresenhan;
        private System.Windows.Forms.PictureBox pbxRetas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbCircPtMedio;
        private System.Windows.Forms.RadioButton RbCircTrig;
        private System.Windows.Forms.RadioButton RbCircReal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RbElipMédio;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtExcluiPoligno;
        private System.Windows.Forms.Button BtNovoPoligno;
        private System.Windows.Forms.DataGridView dgvPontos;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.ComboBox CbPolignos;
        private System.Windows.Forms.PictureBox pbxPoligonos;
        private System.Windows.Forms.Button btTransf;
        private System.Windows.Forms.TextBox tbTY;
        private System.Windows.Forms.TextBox tbTX;
        private System.Windows.Forms.Button btEscala;
        private System.Windows.Forms.TextBox tbSX;
        private System.Windows.Forms.TextBox tbSY;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btRotacao;
        private System.Windows.Forms.TextBox tbRotacao;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btCisX;
        private System.Windows.Forms.TextBox tbCisX;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btCisY;
        private System.Windows.Forms.TextBox tbCisY;
        private System.Windows.Forms.RadioButton rbEixo;
        private System.Windows.Forms.RadioButton rbOrigem;
        private System.Windows.Forms.Button btEspY;
        private System.Windows.Forms.Button btEspX;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button btViewPort;
        private System.Windows.Forms.TextBox tbVPx;
        private System.Windows.Forms.TextBox tbVPy;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox cbFloodFill;
    }
}

