namespace GUI
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_formMatricula = new System.Windows.Forms.Button();
            this.btn_formConsultas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEMO SISTEMA MATRICULA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_formMatricula
            // 
            this.btn_formMatricula.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_formMatricula.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_formMatricula.ForeColor = System.Drawing.Color.White;
            this.btn_formMatricula.Location = new System.Drawing.Point(12, 75);
            this.btn_formMatricula.Name = "btn_formMatricula";
            this.btn_formMatricula.Size = new System.Drawing.Size(443, 150);
            this.btn_formMatricula.TabIndex = 1;
            this.btn_formMatricula.Text = "MATRÍCULA";
            this.btn_formMatricula.UseVisualStyleBackColor = false;
            this.btn_formMatricula.Click += new System.EventHandler(this.btn_formMatricula_Click);
            // 
            // btn_formConsultas
            // 
            this.btn_formConsultas.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_formConsultas.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_formConsultas.ForeColor = System.Drawing.Color.Transparent;
            this.btn_formConsultas.Location = new System.Drawing.Point(12, 231);
            this.btn_formConsultas.Name = "btn_formConsultas";
            this.btn_formConsultas.Size = new System.Drawing.Size(443, 150);
            this.btn_formConsultas.TabIndex = 2;
            this.btn_formConsultas.Text = "CONSULTAS";
            this.btn_formConsultas.UseVisualStyleBackColor = false;
            this.btn_formConsultas.Click += new System.EventHandler(this.btn_formConsultas_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(467, 405);
            this.Controls.Add(this.btn_formConsultas);
            this.Controls.Add(this.btn_formMatricula);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_formMatricula;
        private System.Windows.Forms.Button btn_formConsultas;
    }
}