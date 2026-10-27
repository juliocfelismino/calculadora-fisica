namespace Crud
{
    partial class FormfORCA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMassa = new TextBox();
            txtAceleracao = new TextBox();
            buttonCalcular = new Button();
            lblResultado = new Label();
            ACELERACAO = new Label();
            MASSA = new Label();
            SuspendLayout();
            // 
            // txtMassa
            // 
            txtMassa.Location = new Point(242, 241);
            txtMassa.Name = "txtMassa";
            txtMassa.Size = new Size(100, 23);
            txtMassa.TabIndex = 17;
            // 
            // txtAceleracao
            // 
            txtAceleracao.Location = new Point(348, 241);
            txtAceleracao.Name = "txtAceleracao";
            txtAceleracao.Size = new Size(100, 23);
            txtAceleracao.TabIndex = 16;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(483, 241);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 15;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(488, 186);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(70, 15);
            lblResultado.TabIndex = 14;
            lblResultado.Text = "RESULTADO";
            // 
            // ACELERACAO
            // 
            ACELERACAO.AutoSize = true;
            ACELERACAO.Location = new Point(371, 186);
            ACELERACAO.Name = "ACELERACAO";
            ACELERACAO.Size = new Size(81, 15);
            ACELERACAO.TabIndex = 13;
            ACELERACAO.Text = "ACELERACAO";
            // 
            // MASSA
            // 
            MASSA.AutoSize = true;
            MASSA.Location = new Point(253, 186);
            MASSA.Name = "MASSA";
            MASSA.Size = new Size(46, 15);
            MASSA.TabIndex = 12;
            MASSA.Text = "MASSA";
            // 
            // FormfORCA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMassa);
            Controls.Add(txtAceleracao);
            Controls.Add(buttonCalcular);
            Controls.Add(lblResultado);
            Controls.Add(ACELERACAO);
            Controls.Add(MASSA);
            Name = "FormfORCA";
            Text = "FormfORCA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMassa;
        private TextBox txtAceleracao;
        private Button buttonCalcular;
        private Label lblResultado;
        private Label ACELERACAO;
        private Label MASSA;
    }
}