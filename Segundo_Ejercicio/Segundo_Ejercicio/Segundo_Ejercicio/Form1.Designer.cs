
namespace Segundo_Ejercicio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.celsius = new System.Windows.Forms.RadioButton();
            this.fahre = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.grados = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.celsius);
            this.groupBox1.Controls.Add(this.fahre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.grados);
            this.groupBox1.Location = new System.Drawing.Point(169, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(484, 347);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // celsius
            // 
            this.celsius.AutoSize = true;
            this.celsius.Location = new System.Drawing.Point(154, 188);
            this.celsius.Margin = new System.Windows.Forms.Padding(4);
            this.celsius.Name = "celsius";
            this.celsius.Size = new System.Drawing.Size(162, 21);
            this.celsius.TabIndex = 10;
            this.celsius.TabStop = true;
            this.celsius.Text = "Fahrenheit to Celsius";
            this.celsius.UseVisualStyleBackColor = true;
            // 
            // fahre
            // 
            this.fahre.AutoSize = true;
            this.fahre.Location = new System.Drawing.Point(154, 143);
            this.fahre.Margin = new System.Windows.Forms.Padding(4);
            this.fahre.Name = "fahre";
            this.fahre.Size = new System.Drawing.Size(162, 21);
            this.fahre.TabIndex = 9;
            this.fahre.TabStop = true;
            this.fahre.Text = "Celsius to Fahrenheit";
            this.fahre.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grados";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 260);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grados
            // 
            this.grados.Location = new System.Drawing.Point(182, 100);
            this.grados.Margin = new System.Windows.Forms.Padding(4);
            this.grados.Name = "grados";
            this.grados.Size = new System.Drawing.Size(113, 22);
            this.grados.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 533);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox grados;
        private System.Windows.Forms.RadioButton celsius;
        private System.Windows.Forms.RadioButton fahre;
    }
}

