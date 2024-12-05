namespace EDDemo.Busqueda_y_Ordenamineto.Ordenamiento.forms
{
    partial class MNatural
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
            this.lstNatural = new System.Windows.Forms.ListBox();
            this.btnOrdenarN = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNatural
            // 
            this.lstNatural.FormattingEnabled = true;
            this.lstNatural.ItemHeight = 16;
            this.lstNatural.Location = new System.Drawing.Point(32, 110);
            this.lstNatural.Name = "lstNatural";
            this.lstNatural.Size = new System.Drawing.Size(120, 164);
            this.lstNatural.TabIndex = 0;
            // 
            // btnOrdenarN
            // 
            this.btnOrdenarN.Location = new System.Drawing.Point(220, 135);
            this.btnOrdenarN.Name = "btnOrdenarN";
            this.btnOrdenarN.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenarN.TabIndex = 1;
            this.btnOrdenarN.Text = "Ordenar";
            this.btnOrdenarN.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(220, 222);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // MNatural
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 403);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOrdenarN);
            this.Controls.Add(this.lstNatural);
            this.Name = "MNatural";
            this.Text = "MNatural";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstNatural;
        private System.Windows.Forms.Button btnOrdenarN;
        private System.Windows.Forms.Button btnLimpiar;
    }
}