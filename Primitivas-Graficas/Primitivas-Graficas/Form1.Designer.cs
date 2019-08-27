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
            this.rbBresenhan = new System.Windows.Forms.RadioButton();
            this.rbDDA = new System.Windows.Forms.RadioButton();
            this.rbEqReal = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.groupBoxRetas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRetas
            // 
            this.groupBoxRetas.Controls.Add(this.rbBresenhan);
            this.groupBoxRetas.Controls.Add(this.rbDDA);
            this.groupBoxRetas.Controls.Add(this.rbEqReal);
            this.groupBoxRetas.Location = new System.Drawing.Point(25, 19);
            this.groupBoxRetas.Name = "groupBoxRetas";
            this.groupBoxRetas.Size = new System.Drawing.Size(154, 107);
            this.groupBoxRetas.TabIndex = 0;
            this.groupBoxRetas.TabStop = false;
            this.groupBoxRetas.Text = "Retas";
            // 
            // rbBresenhan
            // 
            this.rbBresenhan.AutoSize = true;
            this.rbBresenhan.Location = new System.Drawing.Point(17, 66);
            this.rbBresenhan.Name = "rbBresenhan";
            this.rbBresenhan.Size = new System.Drawing.Size(76, 17);
            this.rbBresenhan.TabIndex = 2;
            this.rbBresenhan.TabStop = true;
            this.rbBresenhan.Text = "Bresenhan";
            this.rbBresenhan.UseVisualStyleBackColor = true;
            this.rbBresenhan.CheckedChanged += new System.EventHandler(this.RbBresenhan_CheckedChanged);
            // 
            // rbDDA
            // 
            this.rbDDA.AutoSize = true;
            this.rbDDA.Location = new System.Drawing.Point(17, 43);
            this.rbDDA.Name = "rbDDA";
            this.rbDDA.Size = new System.Drawing.Size(87, 17);
            this.rbDDA.TabIndex = 1;
            this.rbDDA.TabStop = true;
            this.rbDDA.Text = "Declive DDA";
            this.rbDDA.UseVisualStyleBackColor = true;
            this.rbDDA.CheckedChanged += new System.EventHandler(this.RbDDA_CheckedChanged);
            // 
            // rbEqReal
            // 
            this.rbEqReal.AutoSize = true;
            this.rbEqReal.Location = new System.Drawing.Point(17, 20);
            this.rbEqReal.Name = "rbEqReal";
            this.rbEqReal.Size = new System.Drawing.Size(88, 17);
            this.rbEqReal.TabIndex = 0;
            this.rbEqReal.TabStop = true;
            this.rbEqReal.Text = "Equação real";
            this.rbEqReal.UseVisualStyleBackColor = true;
            this.rbEqReal.CheckedChanged += new System.EventHandler(this.RbEqReal_CheckedChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Location = new System.Drawing.Point(25, 387);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.lbY);
            this.groupBox2.Controls.Add(this.lbX);
            this.groupBox2.Controls.Add(this.groupBoxRetas);
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Location = new System.Drawing.Point(785, -5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 552);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(22, 482);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(20, 13);
            this.lbX.TabIndex = 2;
            this.lbX.Text = "X: ";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(22, 510);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(20, 13);
            this.lbY.TabIndex = 3;
            this.lbY.Text = "Y: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 546);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "CG-Primitivas Gráficas";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.groupBoxRetas.ResumeLayout(false);
            this.groupBoxRetas.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRetas;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.RadioButton rbDDA;
        private System.Windows.Forms.RadioButton rbEqReal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbBresenhan;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label lbX;
    }
}

