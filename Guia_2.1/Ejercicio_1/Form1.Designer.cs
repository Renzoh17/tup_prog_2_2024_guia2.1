namespace Ejercicio_1
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
            this.lbUltimoReg = new System.Windows.Forms.ListBox();
            this.lbListRegistros = new System.Windows.Forms.ListBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnListRegistros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUltimoReg
            // 
            this.lbUltimoReg.FormattingEnabled = true;
            this.lbUltimoReg.Location = new System.Drawing.Point(12, 12);
            this.lbUltimoReg.Name = "lbUltimoReg";
            this.lbUltimoReg.Size = new System.Drawing.Size(385, 82);
            this.lbUltimoReg.TabIndex = 0;
            // 
            // lbListRegistros
            // 
            this.lbListRegistros.FormattingEnabled = true;
            this.lbListRegistros.Location = new System.Drawing.Point(12, 100);
            this.lbListRegistros.Name = "lbListRegistros";
            this.lbListRegistros.Size = new System.Drawing.Size(385, 173);
            this.lbListRegistros.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(403, 12);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(132, 34);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnListRegistros
            // 
            this.btnListRegistros.Location = new System.Drawing.Point(403, 100);
            this.btnListRegistros.Name = "btnListRegistros";
            this.btnListRegistros.Size = new System.Drawing.Size(132, 34);
            this.btnListRegistros.TabIndex = 3;
            this.btnListRegistros.Text = "Listar Registros";
            this.btnListRegistros.UseVisualStyleBackColor = true;
            this.btnListRegistros.Click += new System.EventHandler(this.btnListRegistros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 282);
            this.Controls.Add(this.btnListRegistros);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lbListRegistros);
            this.Controls.Add(this.lbUltimoReg);
            this.Name = "Form1";
            this.Text = "Registro Vehicular";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbUltimoReg;
        private System.Windows.Forms.ListBox lbListRegistros;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnListRegistros;
    }
}

