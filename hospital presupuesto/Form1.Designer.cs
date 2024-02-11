namespace hospital_presupuesto
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
            btn_Distribuir = new Button();
            btn_Limpiar = new Button();
            btn_Salir = new Button();
            txtPresupuesto = new TextBox();
            txtSuministros = new TextBox();
            txtAdministracion = new TextBox();
            txtLaboratorio = new TextBox();
            txtImagenes = new TextBox();
            txtCirugia = new TextBox();
            txtEmergencia = new TextBox();
            txt_Departamentos = new Label();
            txt_Emergencia = new Label();
            txt_cirugia = new Label();
            txt_Suministros = new Label();
            txt_Administracion = new Label();
            txt_Laboratorio = new Label();
            txt_Imagenes = new Label();
            txt_Presupuesto = new Label();
            SuspendLayout();
            // 
            // btn_Distribuir
            // 
            btn_Distribuir.BackColor = SystemColors.ButtonHighlight;
            btn_Distribuir.Location = new Point(586, 51);
            btn_Distribuir.Name = "btn_Distribuir";
            btn_Distribuir.Size = new Size(125, 42);
            btn_Distribuir.TabIndex = 0;
            btn_Distribuir.Text = "Distribuir";
            btn_Distribuir.UseVisualStyleBackColor = false;
            btn_Distribuir.Click += btn_Distribuir_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor = SystemColors.ButtonHighlight;
            btn_Limpiar.Location = new Point(586, 126);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(125, 39);
            btn_Limpiar.TabIndex = 1;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = false;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = SystemColors.ButtonHighlight;
            btn_Salir.Location = new Point(586, 207);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(125, 39);
            btn_Salir.TabIndex = 2;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // txtPresupuesto
            // 
            txtPresupuesto.Location = new Point(315, 62);
            txtPresupuesto.Name = "txtPresupuesto";
            txtPresupuesto.Size = new Size(142, 31);
            txtPresupuesto.TabIndex = 3;
            // 
            // txtSuministros
            // 
            txtSuministros.Location = new Point(315, 207);
            txtSuministros.Name = "txtSuministros";
            txtSuministros.Size = new Size(104, 31);
            txtSuministros.TabIndex = 4;
            // 
            // txtAdministracion
            // 
            txtAdministracion.Location = new Point(315, 256);
            txtAdministracion.Name = "txtAdministracion";
            txtAdministracion.Size = new Size(104, 31);
            txtAdministracion.TabIndex = 5;
            // 
            // txtLaboratorio
            // 
            txtLaboratorio.Location = new Point(315, 304);
            txtLaboratorio.Name = "txtLaboratorio";
            txtLaboratorio.Size = new Size(104, 31);
            txtLaboratorio.TabIndex = 6;
            // 
            // txtImagenes
            // 
            txtImagenes.Location = new Point(315, 354);
            txtImagenes.Name = "txtImagenes";
            txtImagenes.Size = new Size(104, 31);
            txtImagenes.TabIndex = 7;
            // 
            // txtCirugia
            // 
            txtCirugia.Location = new Point(315, 158);
            txtCirugia.Name = "txtCirugia";
            txtCirugia.Size = new Size(104, 31);
            txtCirugia.TabIndex = 8;
            // 
            // txtEmergencia
            // 
            txtEmergencia.Location = new Point(315, 105);
            txtEmergencia.Name = "txtEmergencia";
            txtEmergencia.Size = new Size(104, 31);
            txtEmergencia.TabIndex = 9;
            // 
            // txt_Departamentos
            // 
            txt_Departamentos.AutoSize = true;
            txt_Departamentos.Location = new Point(41, 68);
            txt_Departamentos.Name = "txt_Departamentos";
            txt_Departamentos.Size = new Size(129, 25);
            txt_Departamentos.TabIndex = 10;
            txt_Departamentos.Text = "Deparamentos";
            txt_Departamentos.Click += label1_Click;
            // 
            // txt_Emergencia
            // 
            txt_Emergencia.AutoSize = true;
            txt_Emergencia.Location = new Point(205, 111);
            txt_Emergencia.Name = "txt_Emergencia";
            txt_Emergencia.Size = new Size(103, 25);
            txt_Emergencia.TabIndex = 11;
            txt_Emergencia.Text = "Emergencia";
            // 
            // txt_cirugia
            // 
            txt_cirugia.AutoSize = true;
            txt_cirugia.Location = new Point(220, 176);
            txt_cirugia.Name = "txt_cirugia";
            txt_cirugia.Size = new Size(67, 25);
            txt_cirugia.TabIndex = 12;
            txt_cirugia.Text = "Cirugia";
            // 
            // txt_Suministros
            // 
            txt_Suministros.AutoSize = true;
            txt_Suministros.Location = new Point(206, 210);
            txt_Suministros.Name = "txt_Suministros";
            txt_Suministros.Size = new Size(105, 25);
            txt_Suministros.TabIndex = 13;
            txt_Suministros.Text = "Suministros";
            // 
            // txt_Administracion
            // 
            txt_Administracion.AutoSize = true;
            txt_Administracion.Location = new Point(180, 259);
            txt_Administracion.Name = "txt_Administracion";
            txt_Administracion.Size = new Size(131, 25);
            txt_Administracion.TabIndex = 14;
            txt_Administracion.Text = "Administracion";
            // 
            // txt_Laboratorio
            // 
            txt_Laboratorio.AutoSize = true;
            txt_Laboratorio.Location = new Point(205, 304);
            txt_Laboratorio.Name = "txt_Laboratorio";
            txt_Laboratorio.Size = new Size(104, 25);
            txt_Laboratorio.TabIndex = 15;
            txt_Laboratorio.Text = "Laboratorio";
            // 
            // txt_Imagenes
            // 
            txt_Imagenes.AutoSize = true;
            txt_Imagenes.Location = new Point(220, 357);
            txt_Imagenes.Name = "txt_Imagenes";
            txt_Imagenes.Size = new Size(89, 25);
            txt_Imagenes.TabIndex = 16;
            txt_Imagenes.Text = "Imagenes";
            // 
            // txt_Presupuesto
            // 
            txt_Presupuesto.AutoSize = true;
            txt_Presupuesto.Location = new Point(315, 21);
            txt_Presupuesto.Name = "txt_Presupuesto";
            txt_Presupuesto.Size = new Size(110, 25);
            txt_Presupuesto.TabIndex = 17;
            txt_Presupuesto.Text = "Presupuesto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Presupuesto);
            Controls.Add(txt_Imagenes);
            Controls.Add(txt_Laboratorio);
            Controls.Add(txt_Administracion);
            Controls.Add(txt_Suministros);
            Controls.Add(txt_cirugia);
            Controls.Add(txt_Emergencia);
            Controls.Add(txt_Departamentos);
            Controls.Add(txtEmergencia);
            Controls.Add(txtCirugia);
            Controls.Add(txtImagenes);
            Controls.Add(txtLaboratorio);
            Controls.Add(txtAdministracion);
            Controls.Add(txtSuministros);
            Controls.Add(txtPresupuesto);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Distribuir);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Distribuir;
        private Button btn_Limpiar;
        private Button btn_Salir;
        private TextBox txtPresupuesto;
        private TextBox txtSuministros;
        private TextBox txtAdministracion;
        private TextBox txtLaboratorio;
        private TextBox txtImagenes;
        private TextBox txtCirugia;
        private TextBox txtEmergencia;
        private Label txt_Departamentos;
        private Label txt_Emergencia;
        private Label txt_cirugia;
        private Label txt_Suministros;
        private Label txt_Administracion;
        private Label txt_Laboratorio;
        private Label txt_Imagenes;
        private Label txt_Presupuesto;
    }
}
