namespace Ejercicio1
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
            btnRegistrar = new Button();
            btnCargarViaje = new Button();
            btnResumenFinal = new Button();
            button4 = new Button();
            listBoxPatentes = new ListBox();
            label1 = new Label();
            labelCantViajes = new Label();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(32, 37);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(82, 46);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCargarViaje
            // 
            btnCargarViaje.Enabled = false;
            btnCargarViaje.Location = new Point(32, 89);
            btnCargarViaje.Name = "btnCargarViaje";
            btnCargarViaje.Size = new Size(82, 46);
            btnCargarViaje.TabIndex = 1;
            btnCargarViaje.Text = "Cargar Viaje";
            btnCargarViaje.UseVisualStyleBackColor = true;
            btnCargarViaje.Click += btnCargarViaje_Click;
            // 
            // btnResumenFinal
            // 
            btnResumenFinal.Enabled = false;
            btnResumenFinal.Location = new Point(32, 141);
            btnResumenFinal.Name = "btnResumenFinal";
            btnResumenFinal.Size = new Size(82, 46);
            btnResumenFinal.TabIndex = 2;
            btnResumenFinal.Text = "Resumen Final";
            btnResumenFinal.UseVisualStyleBackColor = true;
            btnResumenFinal.Click += btnResumenFinal_Click;
            // 
            // button4
            // 
            button4.Location = new Point(32, 193);
            button4.Name = "btnSalir";
            button4.Size = new Size(82, 46);
            button4.TabIndex = 3;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnSalir_Click;
            // 
            // listBoxPatentes
            // 
            listBoxPatentes.FormattingEnabled = true;
            listBoxPatentes.ItemHeight = 15;
            listBoxPatentes.Location = new Point(175, 37);
            listBoxPatentes.Name = "listBoxPatentes";
            listBoxPatentes.Size = new Size(318, 154);
            listBoxPatentes.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 209);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Viajes:";
            // 
            // labelCantViajes
            // 
            labelCantViajes.AutoSize = true;
            labelCantViajes.Location = new Point(234, 209);
            labelCantViajes.Name = "labelCantViajes";
            labelCantViajes.Size = new Size(12, 15);
            labelCantViajes.TabIndex = 6;
            labelCantViajes.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 274);
            Controls.Add(labelCantViajes);
            Controls.Add(label1);
            Controls.Add(listBoxPatentes);
            Controls.Add(button4);
            Controls.Add(btnResumenFinal);
            Controls.Add(btnCargarViaje);
            Controls.Add(btnRegistrar);
            Name = "Form1";
            Text = "Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnCargarViaje;
        private Button btnResumenFinal;
        private Button button4;
        private Label label1;
        public ListBox listBoxPatentes;
        public Label labelCantViajes;
    }
}
