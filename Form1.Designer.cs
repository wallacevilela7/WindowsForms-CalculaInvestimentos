namespace CalculaJuros
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalcular = new Button();
            txtPeriodo = new TextBox();
            txtTaxaJuros = new TextBox();
            txtValorAplicado = new TextBox();
            txtResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(68, 236);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(281, 32);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // txtPeriodo
            // 
            txtPeriodo.Location = new Point(68, 62);
            txtPeriodo.Name = "txtPeriodo";
            txtPeriodo.Size = new Size(281, 23);
            txtPeriodo.TabIndex = 1;
            // 
            // txtTaxaJuros
            // 
            txtTaxaJuros.Location = new Point(68, 128);
            txtTaxaJuros.Name = "txtTaxaJuros";
            txtTaxaJuros.Size = new Size(279, 23);
            txtTaxaJuros.TabIndex = 2;
            // 
            // txtValorAplicado
            // 
            txtValorAplicado.Location = new Point(68, 190);
            txtValorAplicado.Name = "txtValorAplicado";
            txtValorAplicado.Size = new Size(279, 23);
            txtValorAplicado.TabIndex = 3;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(68, 379);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(279, 23);
            txtResult.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 44);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 6;
            label1.Text = "Período (anos)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 110);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 7;
            label2.Text = "Taxa Juros Mensais  (%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 172);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 8;
            label3.Text = "Valor Aplicado (R$)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 361);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 10;
            label5.Text = "Ganhos (R$)";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(68, 292);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(279, 31);
            btnLimpar.TabIndex = 11;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(434, 469);
            Controls.Add(btnLimpar);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResult);
            Controls.Add(txtValorAplicado);
            Controls.Add(txtTaxaJuros);
            Controls.Add(txtPeriodo);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Calculadora de Investimentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtPeriodo;
        private TextBox txtTaxaJuros;
        private TextBox txtValorAplicado;
        private TextBox txtResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button btnLimpar;
    }
}