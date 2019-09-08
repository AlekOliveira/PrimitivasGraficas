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
            this.pbx = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbCircPtMedio = new System.Windows.Forms.RadioButton();
            this.RbCircTrig = new System.Windows.Forms.RadioButton();
            this.RbCircReal = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RbElipMédio = new System.Windows.Forms.RadioButton();
            this.lbY = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CbPolignos = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtNovoPoligno = new System.Windows.Forms.Button();
            this.BtExcluiPoligno = new System.Windows.Forms.Button();
            this.groupBoxRetas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(964, 115);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // pbx
            // 
            this.pbx.Location = new System.Drawing.Point(12, 133);
            this.pbx.Name = "pbx";
            this.pbx.Size = new System.Drawing.Size(964, 363);
            this.pbx.TabIndex = 3;
            this.pbx.TabStop = false;
            this.pbx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbx_MouseClick);
            this.pbx.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbx_MouseMove);
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
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox4.Controls.Add(this.BtExcluiPoligno);
            this.groupBox4.Controls.Add(this.BtNovoPoligno);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.CbPolignos);
            this.groupBox4.Location = new System.Drawing.Point(982, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(159, 484);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Polignos";
            // 
            // CbPolignos
            // 
            this.CbPolignos.FormattingEnabled = true;
            this.CbPolignos.Location = new System.Drawing.Point(7, 20);
            this.CbPolignos.Name = "CbPolignos";
            this.CbPolignos.Size = new System.Drawing.Size(146, 21);
            this.CbPolignos.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridView1.Location = new System.Drawing.Point(6, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(146, 284);
            this.dataGridView1.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 45;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.Width = 45;
            // 
            // BtNovoPoligno
            // 
            this.BtNovoPoligno.Location = new System.Drawing.Point(7, 412);
            this.BtNovoPoligno.Name = "BtNovoPoligno";
            this.BtNovoPoligno.Size = new System.Drawing.Size(145, 23);
            this.BtNovoPoligno.TabIndex = 2;
            this.BtNovoPoligno.Text = "Novo";
            this.BtNovoPoligno.UseVisualStyleBackColor = true;
            // 
            // BtExcluiPoligno
            // 
            this.BtExcluiPoligno.Location = new System.Drawing.Point(7, 441);
            this.BtExcluiPoligno.Name = "BtExcluiPoligno";
            this.BtExcluiPoligno.Size = new System.Drawing.Size(145, 23);
            this.BtExcluiPoligno.TabIndex = 3;
            this.BtExcluiPoligno.Text = "Excluir";
            this.BtExcluiPoligno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 507);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pbx);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "CG-Primitivas Gráficas";
            this.groupBoxRetas.ResumeLayout(false);
            this.groupBoxRetas.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRetas;
        private System.Windows.Forms.RadioButton RbRetaDDA;
        private System.Windows.Forms.RadioButton RbRetaReal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RbRetaBresenhan;
        private System.Windows.Forms.PictureBox pbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbCircPtMedio;
        private System.Windows.Forms.RadioButton RbCircTrig;
        private System.Windows.Forms.RadioButton RbCircReal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RbElipMédio;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtExcluiPoligno;
        private System.Windows.Forms.Button BtNovoPoligno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.ComboBox CbPolignos;
    }
}

