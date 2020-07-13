namespace Palito
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
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonretirar = new System.Windows.Forms.Button();
            this.buttonjogar = new System.Windows.Forms.Button();
            this.nupdquantidade = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupdquantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Quantidade de palitos  deseja retirar:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(570, 67);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox1.Mask = "0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(89, 22);
            this.maskedTextBox1.TabIndex = 11;
            this.maskedTextBox1.ValidatingType = typeof(int);
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.maskedTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyDown);
            // 
            // buttonretirar
            // 
            this.buttonretirar.Location = new System.Drawing.Point(677, 61);
            this.buttonretirar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonretirar.Name = "buttonretirar";
            this.buttonretirar.Size = new System.Drawing.Size(100, 28);
            this.buttonretirar.TabIndex = 10;
            this.buttonretirar.Text = "Retirar";
            this.buttonretirar.UseVisualStyleBackColor = true;
            this.buttonretirar.Click += new System.EventHandler(this.buttonretirar_Click);
            // 
            // buttonjogar
            // 
            this.buttonjogar.Location = new System.Drawing.Point(677, 22);
            this.buttonjogar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonjogar.Name = "buttonjogar";
            this.buttonjogar.Size = new System.Drawing.Size(100, 28);
            this.buttonjogar.TabIndex = 9;
            this.buttonjogar.Text = "Jogar";
            this.buttonjogar.UseVisualStyleBackColor = true;
            this.buttonjogar.Click += new System.EventHandler(this.buttonjogar_Click);
            this.buttonjogar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonjogar_KeyDown);
            // 
            // nupdquantidade
            // 
            this.nupdquantidade.Location = new System.Drawing.Point(570, 28);
            this.nupdquantidade.Margin = new System.Windows.Forms.Padding(4);
            this.nupdquantidade.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nupdquantidade.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nupdquantidade.Name = "nupdquantidade";
            this.nupdquantidade.Size = new System.Drawing.Size(89, 22);
            this.nupdquantidade.TabIndex = 8;
            this.nupdquantidade.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nupdquantidade.ValueChanged += new System.EventHandler(this.nupdquantidade_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Escolha a quantidade de Palitos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 107);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1033, 445);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 578);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.buttonretirar);
            this.Controls.Add(this.buttonjogar);
            this.Controls.Add(this.nupdquantidade);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupdquantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button buttonretirar;
        private System.Windows.Forms.Button buttonjogar;
        private System.Windows.Forms.NumericUpDown nupdquantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

