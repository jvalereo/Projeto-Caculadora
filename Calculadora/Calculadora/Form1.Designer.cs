namespace Calculadora
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.BtnSomar = new System.Windows.Forms.Button();
            this.BtnSubtrair = new System.Windows.Forms.Button();
            this.BtnMultiplicação = new System.Windows.Forms.Button();
            this.BtnDivisão = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(98, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(171, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CALCULADORA";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.BackColor = System.Drawing.Color.Transparent;
            this.lblNum1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(34, 85);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(131, 18);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "Digite 1º Número:";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.BackColor = System.Drawing.Color.Transparent;
            this.lblNum2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(34, 139);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(131, 18);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "Digite 2º Numero:";
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(171, 83);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(123, 20);
            this.textNum1.TabIndex = 3;
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(171, 137);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(123, 20);
            this.textNum2.TabIndex = 4;
            // 
            // BtnSomar
            // 
            this.BtnSomar.BackColor = System.Drawing.Color.Aqua;
            this.BtnSomar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSomar.Location = new System.Drawing.Point(101, 181);
            this.BtnSomar.Name = "BtnSomar";
            this.BtnSomar.Size = new System.Drawing.Size(75, 38);
            this.BtnSomar.TabIndex = 5;
            this.BtnSomar.Text = "+";
            this.BtnSomar.UseVisualStyleBackColor = false;
            this.BtnSomar.Click += new System.EventHandler(this.BtnSomar_Click);
            // 
            // BtnSubtrair
            // 
            this.BtnSubtrair.BackColor = System.Drawing.Color.Aqua;
            this.BtnSubtrair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtrair.Location = new System.Drawing.Point(191, 181);
            this.BtnSubtrair.Name = "BtnSubtrair";
            this.BtnSubtrair.Size = new System.Drawing.Size(79, 38);
            this.BtnSubtrair.TabIndex = 6;
            this.BtnSubtrair.Text = "-";
            this.BtnSubtrair.UseVisualStyleBackColor = false;
            this.BtnSubtrair.Click += new System.EventHandler(this.BtnSubtrair_Click);
            // 
            // BtnMultiplicação
            // 
            this.BtnMultiplicação.BackColor = System.Drawing.Color.Aqua;
            this.BtnMultiplicação.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiplicação.Location = new System.Drawing.Point(101, 237);
            this.BtnMultiplicação.Name = "BtnMultiplicação";
            this.BtnMultiplicação.Size = new System.Drawing.Size(75, 38);
            this.BtnMultiplicação.TabIndex = 7;
            this.BtnMultiplicação.Text = "*";
            this.BtnMultiplicação.UseVisualStyleBackColor = false;
            this.BtnMultiplicação.Click += new System.EventHandler(this.BtnMultiplicação_Click);
            // 
            // BtnDivisão
            // 
            this.BtnDivisão.BackColor = System.Drawing.Color.Aqua;
            this.BtnDivisão.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivisão.Location = new System.Drawing.Point(193, 239);
            this.BtnDivisão.Name = "BtnDivisão";
            this.BtnDivisão.Size = new System.Drawing.Size(75, 35);
            this.BtnDivisão.TabIndex = 8;
            this.BtnDivisão.Text = "/";
            this.BtnDivisão.UseVisualStyleBackColor = false;
            this.BtnDivisão.Click += new System.EventHandler(this.BtnDivisão_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(83, 300);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 18);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado:";
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(171, 298);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(100, 20);
            this.textResultado.TabIndex = 10;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(101, 349);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 36);
            this.BtnLimpar.TabIndex = 11;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(191, 349);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(77, 36);
            this.BtnSair.TabIndex = 12;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(351, 407);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.BtnDivisão);
            this.Controls.Add(this.BtnMultiplicação);
            this.Controls.Add(this.BtnSubtrair);
            this.Controls.Add(this.BtnSomar);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.Button BtnSomar;
        private System.Windows.Forms.Button BtnSubtrair;
        private System.Windows.Forms.Button BtnMultiplicação;
        private System.Windows.Forms.Button BtnDivisão;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
    }
}

