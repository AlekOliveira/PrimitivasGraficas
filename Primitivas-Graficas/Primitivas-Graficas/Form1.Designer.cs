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
            this.BtExcluiPoligno = new System.Windows.Forms.Button();
            this.BtNovoPoligno = new System.Windows.Forms.Button();
            this.dgvPontos = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbPolignos = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPontos)).BeginInit();
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
            this.groupBox2.Size = new System.Drawing.Size(951, 115);
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
            this.pbxRetas.Location = new System.Drawing.Point(9, 127);
            this.pbxRetas.Name = "pbxRetas";
            this.pbxRetas.Size = new System.Drawing.Size(954, 415);
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
            this.tabControl1.Size = new System.Drawing.Size(974, 574);
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
            this.tabPage1.Size = new System.Drawing.Size(966, 548);
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
            this.tabPage2.Size = new System.Drawing.Size(966, 548);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Poligonos";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TabPage2_MouseClick);
            // 
            // pbxPoligonos
            // 
            this.pbxPoligonos.Location = new System.Drawing.Point(6, 6);
            this.pbxPoligonos.Name = "pbxPoligonos";
            this.pbxPoligonos.Size = new System.Drawing.Size(789, 536);
            this.pbxPoligonos.TabIndex = 5;
            this.pbxPoligonos.TabStop = false;
            this.pbxPoligonos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PbxPoligonos_MouseClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox4.Controls.Add(this.BtExcluiPoligno);
            this.groupBox4.Controls.Add(this.BtNovoPoligno);
            this.groupBox4.Controls.Add(this.dgvPontos);
            this.groupBox4.Controls.Add(this.CbPolignos);
            this.groupBox4.Location = new System.Drawing.Point(801, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(159, 539);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Polignos";
            // 
            // BtExcluiPoligno
            // 
            this.BtExcluiPoligno.Location = new System.Drawing.Point(7, 441);
            this.BtExcluiPoligno.Name = "BtExcluiPoligno";
            this.BtExcluiPoligno.Size = new System.Drawing.Size(145, 23);
            this.BtExcluiPoligno.TabIndex = 3;
            this.BtExcluiPoligno.Text = "Excluir";
            this.BtExcluiPoligno.UseVisualStyleBackColor = true;
            this.BtExcluiPoligno.Click += new System.EventHandler(this.BtExcluiPoligno_Click);
            // 
            // BtNovoPoligno
            // 
            this.BtNovoPoligno.Location = new System.Drawing.Point(7, 412);
            this.BtNovoPoligno.Name = "BtNovoPoligno";
            this.BtNovoPoligno.Size = new System.Drawing.Size(145, 23);
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
            this.dgvPontos.Location = new System.Drawing.Point(6, 121);
            this.dgvPontos.Name = "dgvPontos";
            this.dgvPontos.ReadOnly = true;
            this.dgvPontos.RowHeadersVisible = false;
            this.dgvPontos.Size = new System.Drawing.Size(146, 284);
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
            this.CbPolignos.Location = new System.Drawing.Point(7, 20);
            this.CbPolignos.Name = "CbPolignos";
            this.CbPolignos.Size = new System.Drawing.Size(146, 21);
            this.CbPolignos.TabIndex = 0;
            this.CbPolignos.SelectedIndexChanged += new System.EventHandler(this.CbPolignos_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1003, 597);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPontos)).EndInit();
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
    }
}

