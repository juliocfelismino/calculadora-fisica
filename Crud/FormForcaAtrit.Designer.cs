namespace Crud
{
    partial class FormForcaAtrit
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
            txtCoeficiente = new TextBox();
            txtNormal = new TextBox();
            buttonCalcular = new Button();
            lblResultado = new Label();
            FROCANORMAL = new Label();
            COEFICIENTE = new Label();
            SuspendLayout();
            // 
            // txtCoeficiente
            // 
            txtCoeficiente.Location = new Point(207, 241);
            txtCoeficiente.Name = "txtCoeficiente";
            txtCoeficiente.Size = new Size(100, 23);
            txtCoeficiente.TabIndex = 23;
            // 
            // txtNormal
            // 
            txtNormal.Location = new Point(348, 241);
            txtNormal.Name = "txtNormal";
            txtNormal.Size = new Size(100, 23);
            txtNormal.TabIndex = 22;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(483, 241);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 21;
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
            lblResultado.TabIndex = 20;
            lblResultado.Text = "RESULTADO";
            // 
            // FROCANORMAL
            // 
            FROCANORMAL.AutoSize = true;
            FROCANORMAL.Location = new Point(371, 186);
            FROCANORMAL.Name = "FROCANORMAL";
            FROCANORMAL.Size = new Size(79, 15);
            FROCANORMAL.TabIndex = 19;
            FROCANORMAL.Text = "Força Normal";
            // 
            // COEFICIENTE
            // 
            COEFICIENTE.AutoSize = true;
            COEFICIENTE.Location = new Point(207, 186);
            COEFICIENTE.Name = "COEFICIENTE";
            COEFICIENTE.Size = new Size(116, 15);
            COEFICIENTE.TabIndex = 18;
            COEFICIENTE.Text = "Coeficiente de Atrito";
            // 
            // FormForcaAtrit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCoeficiente);
            Controls.Add(txtNormal);
            Controls.Add(buttonCalcular);
            Controls.Add(lblResultado);
            Controls.Add(FROCANORMAL);
            Controls.Add(COEFICIENTE);
            Name = "FormForcaAtrit";
            Text = "FormForcaAtrit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCoeficiente;
        private TextBox txtNormal;
        private Button buttonCalcular;
        private Label lblResultado;
        private Label FROCANORMAL;
        private Label COEFICIENTE;
    }
}