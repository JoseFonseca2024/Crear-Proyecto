namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            dtpFechaInicio = new DateTimePicker();
            btnCrearProyecto = new Button();
            btnMostrarDetalles = new Button();
            label4 = new Label();
            label5 = new Label();
            txtTareaDescripcion = new TextBox();
            numDuraciónHoras = new NumericUpDown();
            btnAgregarTarea_Click = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtRolRecurso = new TextBox();
            btnAginarRecurso = new Button();
            txtRecursoNombre = new TextBox();
            label6 = new Label();
            label7 = new Label();
            lstDetalles = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numDuraciónHoras).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 9);
            label1.Name = "label1";
            label1.Size = new Size(326, 30);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Gestón de Proyectos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 57);
            label2.Name = "label2";
            label2.Size = new Size(165, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre del Proyecto: ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(203, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(351, 23);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 98);
            label3.Name = "label3";
            label3.Size = new Size(201, 21);
            label3.TabIndex = 3;
            label3.Text = "Fecha de inicio de Proyecto:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(234, 96);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(312, 23);
            dtpFechaInicio.TabIndex = 4;
            // 
            // btnCrearProyecto
            // 
            btnCrearProyecto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrearProyecto.Location = new Point(234, 128);
            btnCrearProyecto.Name = "btnCrearProyecto";
            btnCrearProyecto.Size = new Size(232, 27);
            btnCrearProyecto.TabIndex = 5;
            btnCrearProyecto.Text = "Crear Proyecto";
            btnCrearProyecto.UseVisualStyleBackColor = true;
            btnCrearProyecto.Click += btnCrearProyecto_Click;
            // 
            // btnMostrarDetalles
            // 
            btnMostrarDetalles.Location = new Point(493, 128);
            btnMostrarDetalles.Name = "btnMostrarDetalles";
            btnMostrarDetalles.Size = new Size(232, 27);
            btnMostrarDetalles.TabIndex = 6;
            btnMostrarDetalles.Text = "Mostrar detalles del Proyecto";
            btnMostrarDetalles.UseVisualStyleBackColor = true;
            btnMostrarDetalles.Click += btnMostrarDetalles_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 36);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 7;
            label4.Text = "Descripción:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 66);
            label5.Name = "label5";
            label5.Size = new Size(144, 21);
            label5.TabIndex = 8;
            label5.Text = "Duración en horas: ";
            // 
            // txtTareaDescripcion
            // 
            txtTareaDescripcion.Location = new Point(191, 28);
            txtTareaDescripcion.Name = "txtTareaDescripcion";
            txtTareaDescripcion.Size = new Size(522, 29);
            txtTareaDescripcion.TabIndex = 9;
            // 
            // numDuraciónHoras
            // 
            numDuraciónHoras.Font = new Font("Segoe UI", 9F);
            numDuraciónHoras.Location = new Point(191, 63);
            numDuraciónHoras.Name = "numDuraciónHoras";
            numDuraciónHoras.Size = new Size(98, 23);
            numDuraciónHoras.TabIndex = 10;
            // 
            // btnAgregarTarea_Click
            // 
            btnAgregarTarea_Click.Font = new Font("Segoe UI", 9F);
            btnAgregarTarea_Click.Location = new Point(481, 64);
            btnAgregarTarea_Click.Name = "btnAgregarTarea_Click";
            btnAgregarTarea_Click.Size = new Size(232, 23);
            btnAgregarTarea_Click.TabIndex = 11;
            btnAgregarTarea_Click.Text = "Agregar Tarea al Proyecto";
            btnAgregarTarea_Click.UseVisualStyleBackColor = true;
            btnAgregarTarea_Click.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregarTarea_Click);
            groupBox1.Controls.Add(numDuraciónHoras);
            groupBox1.Controls.Add(txtTareaDescripcion);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(753, 105);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tarea";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtRolRecurso);
            groupBox2.Controls.Add(btnAginarRecurso);
            groupBox2.Controls.Add(txtRecursoNombre);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 272);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(753, 149);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Recursos";
            // 
            // txtRolRecurso
            // 
            txtRolRecurso.Location = new Point(191, 63);
            txtRolRecurso.Name = "txtRolRecurso";
            txtRolRecurso.Size = new Size(522, 29);
            txtRolRecurso.TabIndex = 12;
            // 
            // btnAginarRecurso
            // 
            btnAginarRecurso.Font = new Font("Segoe UI", 9F);
            btnAginarRecurso.Location = new Point(506, 110);
            btnAginarRecurso.Name = "btnAginarRecurso";
            btnAginarRecurso.Size = new Size(232, 23);
            btnAginarRecurso.TabIndex = 11;
            btnAginarRecurso.Text = "Asignar recurso al Proyecto";
            btnAginarRecurso.UseVisualStyleBackColor = true;
            btnAginarRecurso.Click += btnAginarRecurso_Click;
            // 
            // txtRecursoNombre
            // 
            txtRecursoNombre.Location = new Point(191, 28);
            txtRecursoNombre.Name = "txtRecursoNombre";
            txtRecursoNombre.Size = new Size(522, 29);
            txtRecursoNombre.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 66);
            label6.Name = "label6";
            label6.Size = new Size(40, 21);
            label6.TabIndex = 8;
            label6.Text = "Rol: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(11, 36);
            label7.Name = "label7";
            label7.Size = new Size(71, 21);
            label7.TabIndex = 7;
            label7.Text = "Nombre:";
            // 
            // lstDetalles
            // 
            lstDetalles.FormattingEnabled = true;
            lstDetalles.ItemHeight = 15;
            lstDetalles.Location = new Point(12, 427);
            lstDetalles.Name = "lstDetalles";
            lstDetalles.Size = new Size(753, 124);
            lstDetalles.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 573);
            Controls.Add(lstDetalles);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnMostrarDetalles);
            Controls.Add(btnCrearProyecto);
            Controls.Add(dtpFechaInicio);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numDuraciónHoras).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private DateTimePicker dtpFechaInicio;
        private Button btnCrearProyecto;
        private Button btnMostrarDetalles;
        private Label label4;
        private Label label5;
        private TextBox txtTareaDescripcion;
        private NumericUpDown numDuraciónHoras;
        private Button btnAgregarTarea_Click;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnAginarRecurso;
        private TextBox txtRecursoNombre;
        private Label label6;
        private Label label7;
        private TextBox txtRolRecurso;
        private ListBox lstDetalles;
    }
}
