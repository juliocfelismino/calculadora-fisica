namespace Crud
{
    partial class FormAceleracao
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
            txtVelocidade = new TextBox();
            txtTempo = new TextBox();
            buttonCalcular = new Button();
            lblResultado = new Label();
            TEMPO = new Label();
            VELOCIDADE = new Label();
            SuspendLayout();
            // 
            // txtVelocidade
            // 
            txtVelocidade.Location = new Point(237, 189);
            txtVelocidade.Name = "txtVelocidade";
            txtVelocidade.Size = new Size(100, 23);
            txtVelocidade.TabIndex = 11;
            // 
            // txtTempo
            // 
            txtTempo.Location = new Point(343, 189);
            txtTempo.Name = "txtTempo";
            txtTempo.Size = new Size(100, 23);
            txtTempo.TabIndex = 10;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(478, 189);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 9;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(483, 134);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(70, 15);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "RESULTADO";
            // 
            // TEMPO
            // 
            TEMPO.AutoSize = true;
            TEMPO.Location = new Point(366, 134);
            TEMPO.Name = "TEMPO";
            TEMPO.Size = new Size(47, 15);
            TEMPO.TabIndex = 7;
            TEMPO.Text = "TEMPO";
            // 
            // VELOCIDADE
            // 
            VELOCIDADE.AutoSize = true;
            VELOCIDADE.Location = new Point(248, 134);
            VELOCIDADE.Name = "VELOCIDADE";
            VELOCIDADE.Size = new Size(76, 15);
            VELOCIDADE.TabIndex = 6;
            VELOCIDADE.Text = "VELOCIDADE";
            // 
            // FormAceleracao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtVelocidade);
            Controls.Add(txtTempo);
            Controls.Add(buttonCalcular);
            Controls.Add(lblResultado);
            Controls.Add(TEMPO);
            Controls.Add(VELOCIDADE);
            Name = "FormAceleracao";
            Text = "FormAceleracao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVelocidade;
        private TextBox txtTempo;
        private Button buttonCalcular;
        private Label lblResultado;
        private Label TEMPO;
        private Label VELOCIDADE;
    }
}