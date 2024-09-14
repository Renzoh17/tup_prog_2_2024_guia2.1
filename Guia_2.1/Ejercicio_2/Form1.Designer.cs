namespace Ejercicio_2
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
            this.btnRegistrarE = new System.Windows.Forms.Button();
            this.btnGenerarL = new System.Windows.Forms.Button();
            this.btnMostrarL = new System.Windows.Forms.Button();
            this.tbMostrarL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegistrarE
            // 
            this.btnRegistrarE.Location = new System.Drawing.Point(12, 12);
            this.btnRegistrarE.Name = "btnRegistrarE";
            this.btnRegistrarE.Size = new System.Drawing.Size(118, 38);
            this.btnRegistrarE.TabIndex = 0;
            this.btnRegistrarE.Text = "Registrar Empleado";
            this.btnRegistrarE.UseVisualStyleBackColor = true;
            this.btnRegistrarE.Click += new System.EventHandler(this.btnRegistrarE_Click);
            // 
            // btnGenerarL
            // 
            this.btnGenerarL.Location = new System.Drawing.Point(261, 12);
            this.btnGenerarL.Name = "btnGenerarL";
            this.btnGenerarL.Size = new System.Drawing.Size(131, 38);
            this.btnGenerarL.TabIndex = 1;
            this.btnGenerarL.Text = "Generar Liquidaciones";
            this.btnGenerarL.UseVisualStyleBackColor = true;
            this.btnGenerarL.Click += new System.EventHandler(this.btnGenerarL_Click);
            // 
            // btnMostrarL
            // 
            this.btnMostrarL.Location = new System.Drawing.Point(522, 12);
            this.btnMostrarL.Name = "btnMostrarL";
            this.btnMostrarL.Size = new System.Drawing.Size(127, 38);
            this.btnMostrarL.TabIndex = 2;
            this.btnMostrarL.Text = "Mostrar Liquidaciones";
            this.btnMostrarL.UseVisualStyleBackColor = true;
            this.btnMostrarL.Click += new System.EventHandler(this.btnMostrarL_Click);
            // 
            // tbMostrarL
            // 
            this.tbMostrarL.Location = new System.Drawing.Point(12, 70);
            this.tbMostrarL.Multiline = true;
            this.tbMostrarL.Name = "tbMostrarL";
            this.tbMostrarL.ReadOnly = true;
            this.tbMostrarL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMostrarL.Size = new System.Drawing.Size(637, 368);
            this.tbMostrarL.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.tbMostrarL);
            this.Controls.Add(this.btnMostrarL);
            this.Controls.Add(this.btnGenerarL);
            this.Controls.Add(this.btnRegistrarE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarE;
        private System.Windows.Forms.Button btnGenerarL;
        private System.Windows.Forms.Button btnMostrarL;
        private System.Windows.Forms.TextBox tbMostrarL;
    }
}

