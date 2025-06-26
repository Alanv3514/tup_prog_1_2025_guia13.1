namespace Ejercicio1.VIC
{
    partial class Fresumen
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
            listBoxResumen = new ListBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // listBoxResumen
            // 
            listBoxResumen.FormattingEnabled = true;
            listBoxResumen.ItemHeight = 15;
            listBoxResumen.Location = new Point(12, 12);
            listBoxResumen.Name = "listBoxResumen";
            listBoxResumen.Size = new Size(272, 184);
            listBoxResumen.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.DialogResult = DialogResult.OK;
            btnSalir.Location = new Point(102, 202);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // Fresumen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 233);
            Controls.Add(btnSalir);
            Controls.Add(listBoxResumen);
            Name = "Fresumen";
            Text = "Fresumen";
            ResumeLayout(false);
        }

        #endregion
        private Button btnSalir;
        public ListBox listBoxResumen;
    }
}