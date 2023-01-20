namespace WindowsEFEscuela
{
    partial class frmAlumno
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridAlumno = new System.Windows.Forms.DataGridView();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textIdProfesor = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleName = "btnBuscar";
            this.button1.Location = new System.Drawing.Point(505, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "btnInsertar";
            this.button2.Location = new System.Drawing.Point(505, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Insertar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // button3
            // 
            this.button3.AccessibleName = "btnEliminar";
            this.button3.Location = new System.Drawing.Point(513, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 77);
            this.button3.TabIndex = 2;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button4
            // 
            this.button4.AccessibleName = "btnModificar";
            this.button4.Location = new System.Drawing.Point(527, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 68);
            this.button4.TabIndex = 3;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // textNombre
            // 
            this.textNombre.AccessibleName = "textNombre";
            this.textNombre.Location = new System.Drawing.Point(23, 37);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(161, 20);
            this.textNombre.TabIndex = 5;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AccessibleName = "LabelNombre";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // textId
            // 
            this.textId.AccessibleName = "textId";
            this.textId.Location = new System.Drawing.Point(23, 107);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(170, 20);
            this.textId.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // gridAlumno
            // 
            this.gridAlumno.AccessibleName = "gridAlumnos";
            this.gridAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlumno.Location = new System.Drawing.Point(43, 229);
            this.gridAlumno.Name = "gridAlumno";
            this.gridAlumno.Size = new System.Drawing.Size(323, 189);
            this.gridAlumno.TabIndex = 9;
            // 
            // textFecha
            // 
            this.textFecha.AccessibleName = "textFecha";
            this.textFecha.Location = new System.Drawing.Point(269, 37);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(169, 20);
            this.textFecha.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AccessibleName = "FechaLabel";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID Profesor";
            // 
            // textIdProfesor
            // 
            this.textIdProfesor.AccessibleName = "textIdProfesor";
            this.textIdProfesor.Location = new System.Drawing.Point(269, 107);
            this.textIdProfesor.Name = "textIdProfesor";
            this.textIdProfesor.Size = new System.Drawing.Size(174, 20);
            this.textIdProfesor.TabIndex = 13;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(43, 183);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(159, 20);
            this.textApellido.TabIndex = 14;
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(72, 152);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(44, 13);
            this.Apellido.TabIndex = 15;
            this.Apellido.Text = "Apellido";
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textIdProfesor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.gridAlumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmAlumno";
            this.Text = "frmAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridAlumno;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textIdProfesor;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label Apellido;
    }
}