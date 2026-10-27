namespace Crud
{
    partial class FormMenu
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
            buttonVelocidade = new Button();
            buttonAceleracao = new Button();
            buttonForca = new Button();
            buttonForcaAtrito = new Button();
            buttonPeso = new Button();
            buttonLeiOhon = new Button();
            SuspendLayout();
            // 
            // buttonVelocidade
            // 
            buttonVelocidade.Location = new Point(75, 95);
            buttonVelocidade.Name = "buttonVelocidade";
            buttonVelocidade.Size = new Size(90, 72);
            buttonVelocidade.TabIndex = 0;
            buttonVelocidade.Text = "Velocidade Media";
            buttonVelocidade.UseVisualStyleBackColor = true;
            buttonVelocidade.Click += button1_Click;
            // 
            // buttonAceleracao
            // 
            buttonAceleracao.Location = new Point(300, 95);
            buttonAceleracao.Name = "buttonAceleracao";
            buttonAceleracao.Size = new Size(90, 72);
            buttonAceleracao.TabIndex = 1;
            buttonAceleracao.Text = "Aceleracao";
            buttonAceleracao.UseVisualStyleBackColor = true;
            buttonAceleracao.Click += buttonAceleracao_Click;
            // 
            // buttonForca
            // 
            buttonForca.Location = new Point(511, 95);
            buttonForca.Name = "buttonForca";
            buttonForca.Size = new Size(90, 72);
            buttonForca.TabIndex = 2;
            buttonForca.Text = "Forca";
            buttonForca.UseVisualStyleBackColor = true;
            buttonForca.Click += buttonForca_Click;
            // 
            // buttonForcaAtrito
            // 
            buttonForcaAtrito.Location = new Point(75, 241);
            buttonForcaAtrito.Name = "buttonForcaAtrito";
            buttonForcaAtrito.Size = new Size(90, 72);
            buttonForcaAtrito.TabIndex = 3;
            buttonForcaAtrito.Text = "Forca de Atrito";
            buttonForcaAtrito.UseVisualStyleBackColor = true;
            buttonForcaAtrito.Click += buttonForcaAtrito_Click;
            // 
            // buttonPeso
            // 
            buttonPeso.Location = new Point(300, 241);
            buttonPeso.Name = "buttonPeso";
            buttonPeso.Size = new Size(90, 72);
            buttonPeso.TabIndex = 4;
            buttonPeso.Text = "Peso";
            buttonPeso.UseVisualStyleBackColor = true;
            buttonPeso.Click += buttonPeso_Click;
            // 
            // buttonLeiOhon
            // 
            buttonLeiOhon.Location = new Point(511, 241);
            buttonLeiOhon.Name = "buttonLeiOhon";
            buttonLeiOhon.Size = new Size(90, 72);
            buttonLeiOhon.TabIndex = 5;
            buttonLeiOhon.Text = "Lei de Ohon";
            buttonLeiOhon.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLeiOhon);
            Controls.Add(buttonPeso);
            Controls.Add(buttonForcaAtrito);
            Controls.Add(buttonForca);
            Controls.Add(buttonAceleracao);
            Controls.Add(buttonVelocidade);
            Name = "FormMenu";
            Text = "FormMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonVelocidade;
        private Button buttonAceleracao;
        private Button buttonForca;
        private Button buttonForcaAtrito;
        private Button buttonPeso;
        private Button buttonLeiOhon;
    }
}
