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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listBoxPatentes = new ListBox();
            label1 = new Label();
            labelCantViajes = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(32, 37);
            button1.Name = "button1";
            button1.Size = new Size(82, 46);
            button1.TabIndex = 0;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(32, 89);
            button2.Name = "button2";
            button2.Size = new Size(82, 46);
            button2.TabIndex = 1;
            button2.Text = "Cargar Viaje";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(32, 141);
            button3.Name = "button3";
            button3.Size = new Size(82, 46);
            button3.TabIndex = 2;
            button3.Text = "Resumen Final";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(32, 193);
            button4.Name = "button4";
            button4.Size = new Size(82, 46);
            button4.TabIndex = 3;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
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
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        public ListBox listBoxPatentes;
        public Label labelCantViajes;
    }
}
