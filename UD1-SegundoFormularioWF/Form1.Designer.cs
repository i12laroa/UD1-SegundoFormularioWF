namespace UD1_SegundoFormularioWF
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFamilia = new System.Windows.Forms.RadioButton();
            this.rbProfes = new System.Windows.Forms.RadioButton();
            this.rbAlumnos = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "EJEMPLO DE VARIOS FORMULARIOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFamilia);
            this.groupBox1.Controls.Add(this.rbProfes);
            this.groupBox1.Controls.Add(this.rbAlumnos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevos Forms";
            // 
            // rbFamilia
            // 
            this.rbFamilia.AutoSize = true;
            this.rbFamilia.Location = new System.Drawing.Point(19, 117);
            this.rbFamilia.Name = "rbFamilia";
            this.rbFamilia.Size = new System.Drawing.Size(72, 20);
            this.rbFamilia.TabIndex = 2;
            this.rbFamilia.TabStop = true;
            this.rbFamilia.Text = "Familia";
            this.rbFamilia.UseVisualStyleBackColor = true;
            // 
            // rbProfes
            // 
            this.rbProfes.AutoSize = true;
            this.rbProfes.Location = new System.Drawing.Point(19, 74);
            this.rbProfes.Name = "rbProfes";
            this.rbProfes.Size = new System.Drawing.Size(94, 20);
            this.rbProfes.TabIndex = 1;
            this.rbProfes.TabStop = true;
            this.rbProfes.Text = "Profesores";
            this.rbProfes.UseVisualStyleBackColor = true;
            // 
            // rbAlumnos
            // 
            this.rbAlumnos.AutoSize = true;
            this.rbAlumnos.Checked = true;
            this.rbAlumnos.Location = new System.Drawing.Point(19, 33);
            this.rbAlumnos.Name = "rbAlumnos";
            this.rbAlumnos.Size = new System.Drawing.Size(80, 20);
            this.rbAlumnos.TabIndex = 0;
            this.rbAlumnos.TabStop = true;
            this.rbAlumnos.Text = "Alumnos";
            this.rbAlumnos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Crear nueva ventana";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 204);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbProfes;
        private System.Windows.Forms.RadioButton rbAlumnos;
        private System.Windows.Forms.RadioButton rbFamilia;
        private System.Windows.Forms.Button button1;
    }
}

