namespace Crud
{
    partial class FormVelocidade
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
            DISTANCIA = new Label();
            TEMPO = new Label();
            lblResultado = new Label();
            buttonCalcular = new Button();
            txtTempo = new TextBox();
            txtDistancia = new TextBox();
            SuspendLayout();
            // 
            // DISTANCIA
            // 
            DISTANCIA.AutoSize = true;
            DISTANCIA.Location = new Point(114, 88);
            DISTANCIA.Name = "DISTANCIA";
            DISTANCIA.Size = new Size(66, 15);
            DISTANCIA.TabIndex = 0;
            DISTANCIA.Text = "DISTANCIA";
            DISTANCIA.Click += label1_Click;
            // 
            // TEMPO
            // 
            TEMPO.AutoSize = true;
            TEMPO.Location = new Point(232, 88);
            TEMPO.Name = "TEMPO";
            TEMPO.Size = new Size(47, 15);
            TEMPO.TabIndex = 1;
            TEMPO.Text = "TEMPO";
            TEMPO.Click += label2_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(349, 88);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(70, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "RESULTADO";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(368, 161);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 3;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // txtTempo
            // 
            txtTempo.Location = new Point(221, 143);
            txtTempo.Name = "txtTempo";
            txtTempo.Size = new Size(100, 23);
            txtTempo.TabIndex = 4;
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(100, 143);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(100, 23);
            txtDistancia.TabIndex = 5;
            // 
            // FormVelocidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDistancia);
            Controls.Add(txtTempo);
            Controls.Add(buttonCalcular);
            Controls.Add(lblResultado);
            Controls.Add(TEMPO);
            Controls.Add(DISTANCIA);
            Name = "FormVelocidade";
            Text = "FormVelocidade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DISTANCIA;
        private Label TEMPO;
        private Label lblResultado;
        private Button buttonCalcular;
        private TextBox txtTempo;
        private TextBox txtDistancia;
    }
}