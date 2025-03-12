namespace Componentes_Her
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Navegador = new System.Windows.Forms.Button();
            this.btn_LectorPDF = new System.Windows.Forms.Button();
            this.btn_Reproductor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "En cual deseas ingresar?";
            // 
            // btn_Navegador
            // 
            this.btn_Navegador.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Navegador.Location = new System.Drawing.Point(249, 315);
            this.btn_Navegador.Name = "btn_Navegador";
            this.btn_Navegador.Size = new System.Drawing.Size(287, 53);
            this.btn_Navegador.TabIndex = 6;
            this.btn_Navegador.Text = "Navegador";
            this.btn_Navegador.UseVisualStyleBackColor = true;
            this.btn_Navegador.Click += new System.EventHandler(this.btn_Navegador_Click);
            // 
            // btn_LectorPDF
            // 
            this.btn_LectorPDF.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LectorPDF.Location = new System.Drawing.Point(249, 244);
            this.btn_LectorPDF.Name = "btn_LectorPDF";
            this.btn_LectorPDF.Size = new System.Drawing.Size(287, 50);
            this.btn_LectorPDF.TabIndex = 5;
            this.btn_LectorPDF.Text = "Lector PDF";
            this.btn_LectorPDF.UseVisualStyleBackColor = true;
            this.btn_LectorPDF.Click += new System.EventHandler(this.btn_LectorPDF_Click);
            // 
            // btn_Reproductor
            // 
            this.btn_Reproductor.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reproductor.Location = new System.Drawing.Point(249, 175);
            this.btn_Reproductor.Name = "btn_Reproductor";
            this.btn_Reproductor.Size = new System.Drawing.Size(287, 50);
            this.btn_Reproductor.TabIndex = 4;
            this.btn_Reproductor.Text = "Reproductor de Video";
            this.btn_Reproductor.UseVisualStyleBackColor = true;
            this.btn_Reproductor.Click += new System.EventHandler(this.btn_Reproductor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Navegador);
            this.Controls.Add(this.btn_LectorPDF);
            this.Controls.Add(this.btn_Reproductor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Navegador;
        private System.Windows.Forms.Button btn_LectorPDF;
        private System.Windows.Forms.Button btn_Reproductor;
    }
}

