namespace EDDemo.Busqueda_y_Ordenamineto.Ordenamiento.forms
{
    partial class MDirecta
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
            this.lstDirecta = new System.Windows.Forms.ListBox();
            this.bntOrdenarD = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDirecta
            // 
            this.lstDirecta.FormattingEnabled = true;
            this.lstDirecta.ItemHeight = 16;
            this.lstDirecta.Location = new System.Drawing.Point(34, 81);
            this.lstDirecta.Name = "lstDirecta";
            this.lstDirecta.Size = new System.Drawing.Size(120, 164);
            this.lstDirecta.TabIndex = 0;
            // 
            // bntOrdenarD
            // 
            this.bntOrdenarD.Location = new System.Drawing.Point(215, 92);
            this.bntOrdenarD.Name = "bntOrdenarD";
            this.bntOrdenarD.Size = new System.Drawing.Size(75, 23);
            this.bntOrdenarD.TabIndex = 1;
            this.bntOrdenarD.Text = "Ordenar";
            this.bntOrdenarD.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(215, 196);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 28);
            this.btnlimpiar.TabIndex = 2;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // MDirecta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 327);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.bntOrdenarD);
            this.Controls.Add(this.lstDirecta);
            this.Name = "MDirecta";
            this.Text = "MDirecta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDirecta;
        private System.Windows.Forms.Button bntOrdenarD;
        private System.Windows.Forms.Button btnlimpiar;
    }
}