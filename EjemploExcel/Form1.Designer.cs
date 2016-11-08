namespace EjemploExcel
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonExaminar = new System.Windows.Forms.Button();
            this.textBoxRutaArchivo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonEscribir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSeleccionarCSV = new System.Windows.Forms.Button();
            this.textBoxCSV = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonEscribirCSV = new System.Windows.Forms.Button();
            this.openFileDialogCSV = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(237, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nuevo archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NuevoArchivo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Al oprimir el botón se creará un nuevo archivo .xlsx con datos de prueba.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo archivo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonExaminar);
            this.groupBox2.Controls.Add(this.textBoxRutaArchivo);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.buttonEscribir);
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(15, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 166);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usar Plantilla";
            // 
            // buttonExaminar
            // 
            this.buttonExaminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExaminar.Location = new System.Drawing.Point(281, 82);
            this.buttonExaminar.Name = "buttonExaminar";
            this.buttonExaminar.Size = new System.Drawing.Size(75, 23);
            this.buttonExaminar.TabIndex = 3;
            this.buttonExaminar.Text = "Examinar";
            this.buttonExaminar.UseVisualStyleBackColor = true;
            this.buttonExaminar.Click += new System.EventHandler(this.SeleccionarPlantilla);
            // 
            // textBoxRutaArchivo
            // 
            this.textBoxRutaArchivo.Location = new System.Drawing.Point(9, 84);
            this.textBoxRutaArchivo.Name = "textBoxRutaArchivo";
            this.textBoxRutaArchivo.ReadOnly = true;
            this.textBoxRutaArchivo.Size = new System.Drawing.Size(254, 20);
            this.textBoxRutaArchivo.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(9, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(347, 33);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Se escriben datos en la segunda hoja de un archivo existente. El archivo debe ten" +
    "er una hoja llamada \"Resultados Técnicos\"";
            // 
            // buttonEscribir
            // 
            this.buttonEscribir.Enabled = false;
            this.buttonEscribir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEscribir.Location = new System.Drawing.Point(137, 128);
            this.buttonEscribir.Name = "buttonEscribir";
            this.buttonEscribir.Size = new System.Drawing.Size(91, 23);
            this.buttonEscribir.TabIndex = 0;
            this.buttonEscribir.Text = "Escribir";
            this.buttonEscribir.UseVisualStyleBackColor = true;
            this.buttonEscribir.Click += new System.EventHandler(this.EscribirEnPantilla);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.buttonSeleccionarCSV);
            this.groupBox3.Controls.Add(this.textBoxCSV);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.buttonEscribirCSV);
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(15, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 185);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usar Plantilla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datos";
            // 
            // buttonSeleccionarCSV
            // 
            this.buttonSeleccionarCSV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSeleccionarCSV.Location = new System.Drawing.Point(281, 57);
            this.buttonSeleccionarCSV.Name = "buttonSeleccionarCSV";
            this.buttonSeleccionarCSV.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccionarCSV.TabIndex = 5;
            this.buttonSeleccionarCSV.Text = "Examinar";
            this.buttonSeleccionarCSV.UseVisualStyleBackColor = true;
            this.buttonSeleccionarCSV.Click += new System.EventHandler(this.SeleccionarCSV);
            // 
            // textBoxCSV
            // 
            this.textBoxCSV.Location = new System.Drawing.Point(70, 59);
            this.textBoxCSV.Name = "textBoxCSV";
            this.textBoxCSV.ReadOnly = true;
            this.textBoxCSV.Size = new System.Drawing.Size(193, 20);
            this.textBoxCSV.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(9, 29);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(347, 24);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Se leen los datos desde un .csv y se ponen en un nuevo libro";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // buttonEscribirCSV
            // 
            this.buttonEscribirCSV.Enabled = false;
            this.buttonEscribirCSV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEscribirCSV.Location = new System.Drawing.Point(137, 94);
            this.buttonEscribirCSV.Name = "buttonEscribirCSV";
            this.buttonEscribirCSV.Size = new System.Drawing.Size(91, 23);
            this.buttonEscribirCSV.TabIndex = 0;
            this.buttonEscribirCSV.Text = "Escribir";
            this.buttonEscribirCSV.UseVisualStyleBackColor = true;
            this.buttonEscribirCSV.Click += new System.EventHandler(this.EscribirDesdeCSV);
            // 
            // openFileDialogCSV
            // 
            this.openFileDialogCSV.FileName = "openFileDialog2";
            this.openFileDialogCSV.Filter = "Coma Veparated Values Files (*.csv)|*.csv|All files (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 443);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Prueba excel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonEscribir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonExaminar;
        private System.Windows.Forms.TextBox textBoxRutaArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSeleccionarCSV;
        private System.Windows.Forms.TextBox textBoxCSV;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonEscribirCSV;
        private System.Windows.Forms.OpenFileDialog openFileDialogCSV;
    }
}

