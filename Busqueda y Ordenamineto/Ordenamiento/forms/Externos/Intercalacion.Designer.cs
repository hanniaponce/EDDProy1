namespace EDDemo.Busqueda_y_Ordenamineto.Ordenamiento.forms
{
    partial class Intercalacion
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
            this.lstInter = new System.Windows.Forms.ListBox();
            this.btnInter = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstInter
            // 
            this.lstInter.FormattingEnabled = true;
            this.lstInter.ItemHeight = 16;
            this.lstInter.Location = new System.Drawing.Point(40, 83);
            this.lstInter.Name = "lstInter";
            this.lstInter.Size = new System.Drawing.Size(111, 164);
            this.lstInter.TabIndex = 0;
            // 
            // btnInter
            // 
            this.btnInter.Location = new System.Drawing.Point(217, 104);
            this.btnInter.Name = "btnInter";
            this.btnInter.Size = new System.Drawing.Size(100, 35);
            this.btnInter.TabIndex = 1;
            this.btnInter.Text = "Intercalar";
            this.btnInter.UseVisualStyleBackColor = true;
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(217, 192);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(100, 35);
            this.Limpiar.TabIndex = 2;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            // 
            // Intercalacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 379);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.btnInter);
            this.Controls.Add(this.lstInter);
            this.Name = "Intercalacion";
            this.Text = "Intercalacion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstInter;
        private System.Windows.Forms.Button btnInter;
        private System.Windows.Forms.Button Limpiar;
    }
}