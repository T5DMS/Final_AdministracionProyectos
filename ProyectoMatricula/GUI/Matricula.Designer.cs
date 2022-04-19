namespace GUI
{
    partial class Matricula
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
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.cmbDescripcionCurso = new System.Windows.Forms.ComboBox();
            this.cmbNombreCarrera = new System.Windows.Forms.ComboBox();
            this.cmbCarnetEstudiante = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "MATRICULA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Insertar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insertar.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insertar.ForeColor = System.Drawing.Color.White;
            this.btn_Insertar.Location = new System.Drawing.Point(19, 318);
            this.btn_Insertar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(449, 62);
            this.btn_Insertar.TabIndex = 42;
            this.btn_Insertar.Text = "Matricular";
            this.btn_Insertar.UseVisualStyleBackColor = false;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.BackColor = System.Drawing.Color.White;
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(19, 276);
            this.cmbPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(449, 31);
            this.cmbPeriodo.TabIndex = 43;
            // 
            // cmbDescripcionCurso
            // 
            this.cmbDescripcionCurso.BackColor = System.Drawing.Color.White;
            this.cmbDescripcionCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDescripcionCurso.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDescripcionCurso.FormattingEnabled = true;
            this.cmbDescripcionCurso.Location = new System.Drawing.Point(17, 213);
            this.cmbDescripcionCurso.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDescripcionCurso.Name = "cmbDescripcionCurso";
            this.cmbDescripcionCurso.Size = new System.Drawing.Size(449, 31);
            this.cmbDescripcionCurso.TabIndex = 42;
            // 
            // cmbNombreCarrera
            // 
            this.cmbNombreCarrera.BackColor = System.Drawing.Color.White;
            this.cmbNombreCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreCarrera.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombreCarrera.FormattingEnabled = true;
            this.cmbNombreCarrera.Location = new System.Drawing.Point(17, 150);
            this.cmbNombreCarrera.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNombreCarrera.Name = "cmbNombreCarrera";
            this.cmbNombreCarrera.Size = new System.Drawing.Size(449, 31);
            this.cmbNombreCarrera.TabIndex = 41;
            this.cmbNombreCarrera.SelectedIndexChanged += new System.EventHandler(this.cmbNombreCarrera_SelectedIndexChanged);
            // 
            // cmbCarnetEstudiante
            // 
            this.cmbCarnetEstudiante.BackColor = System.Drawing.Color.White;
            this.cmbCarnetEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarnetEstudiante.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarnetEstudiante.FormattingEnabled = true;
            this.cmbCarnetEstudiante.Location = new System.Drawing.Point(17, 87);
            this.cmbCarnetEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCarnetEstudiante.Name = "cmbCarnetEstudiante";
            this.cmbCarnetEstudiante.Size = new System.Drawing.Size(449, 31);
            this.cmbCarnetEstudiante.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(13, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Curso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(13, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 39;
            this.label7.Text = "Estudiante:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(13, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Carrera:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(15, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Periodo:";
            // 
            // Matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(492, 404);
            this.Controls.Add(this.btn_Insertar);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDescripcionCurso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbNombreCarrera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCarnetEstudiante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Matricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matricula";
            this.Load += new System.EventHandler(this.Matricula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.ComboBox cmbDescripcionCurso;
        private System.Windows.Forms.ComboBox cmbNombreCarrera;
        private System.Windows.Forms.ComboBox cmbCarnetEstudiante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}