namespace Ejercicio1.VO
{
    partial class Fdatos
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            lbPatentes = new Label();
            label2 = new Label();
            tBpatente = new TextBox();
            tBkilometraje = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(41, 153);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(142, 153);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lbPatentes
            // 
            lbPatentes.AutoSize = true;
            lbPatentes.Location = new Point(41, 40);
            lbPatentes.Name = "lbPatentes";
            lbPatentes.Size = new Size(70, 15);
            lbPatentes.TabIndex = 2;
            lbPatentes.Text = "Nro Patente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 102);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Kilometraje";
            // 
            // tBpatente
            // 
            tBpatente.Location = new Point(117, 37);
            tBpatente.Name = "tBpatente";
            tBpatente.Size = new Size(100, 23);
            tBpatente.TabIndex = 4;
            // 
            // tBkilometraje
            // 
            tBkilometraje.Location = new Point(117, 99);
            tBkilometraje.Name = "tBkilometraje";
            tBkilometraje.Size = new Size(100, 23);
            tBkilometraje.TabIndex = 5;
            // 
            // Fdatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 204);
            Controls.Add(tBkilometraje);
            Controls.Add(tBpatente);
            Controls.Add(label2);
            Controls.Add(lbPatentes);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "Fdatos";
            Text = "Fdatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnAceptar;
        public Button btnCancelar;
        private Label lbPatentes;
        private Label label2;
        public TextBox tBpatente;
        public TextBox tBkilometraje;
        private TextBox textBox2;
    }
}