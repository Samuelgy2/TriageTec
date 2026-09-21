namespace TriageTec
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            button4 = new Button();
            Equpos = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Equipo = new DataGridViewTextBoxColumn();
            Ubicación = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Responsable = new DataGridViewTextBoxColumn();
            Ultimo_reporte = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            label4 = new Label();
            hola = new TextBox();
            label3 = new Label();
            label1 = new Label();
            button1 = new Button();
            tabPage2 = new TabPage();
            groupBox4 = new GroupBox();
            label20 = new Label();
            label21 = new Label();
            label18 = new Label();
            label19 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            panel1 = new Panel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            button3 = new Button();
            button2 = new Button();
            groupBox3 = new GroupBox();
            checkBox2 = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            checkBox1 = new CheckBox();
            comboBox2 = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label2 = new Label();
            tabPage3 = new TabPage();
            label22 = new Label();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Equpos.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(1046, 2);
            button4.Name = "button4";
            button4.Size = new Size(111, 23);
            button4.TabIndex = 3;
            button4.Text = "Cerrar sesíon";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Equpos
            // 
            Equpos.Controls.Add(tabPage1);
            Equpos.Controls.Add(tabPage2);
            Equpos.Controls.Add(tabPage3);
            Equpos.Location = new Point(0, 2);
            Equpos.Name = "Equpos";
            Equpos.SelectedIndex = 0;
            Equpos.Size = new Size(1157, 545);
            Equpos.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(hola);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1149, 517);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Equipos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(829, 370);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(283, 119);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resumen";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 83);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 2;
            label8.Text = "Dados de baja";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 56);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 1;
            label7.Text = "En reparacion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 31);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 0;
            label6.Text = "Operativos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(829, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 327);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles del equipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(273, 15);
            label5.TabIndex = 0;
            label5.Text = "Seleccione un equipo de la lista para ver su detalle.";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Equipo, Ubicación, Tipo, Responsable, Ultimo_reporte, Estado });
            dataGridView1.Location = new Point(6, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(803, 474);
            dataGridView1.TabIndex = 6;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Equipo
            // 
            Equipo.HeaderText = "Equipo";
            Equipo.Name = "Equipo";
            // 
            // Ubicación
            // 
            Ubicación.HeaderText = "Ubicación";
            Ubicación.Name = "Ubicación";
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            // 
            // Responsable
            // 
            Responsable.HeaderText = "Responsable";
            Responsable.Name = "Responsable";
            // 
            // Ultimo_reporte
            // 
            Ultimo_reporte.HeaderText = "Últ. reporte";
            Ultimo_reporte.Name = "Ultimo_reporte";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Todos ", "Operativo", "En operacion", "Dado de baja" });
            comboBox1.Location = new Point(411, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(363, 11);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "Estado";
            // 
            // hola
            // 
            hola.Location = new Point(202, 6);
            hola.Name = "hola";
            hola.PlaceholderText = " Nombre, ubicacion, tipo...";
            hola.Size = new Size(155, 23);
            hola.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 10);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Buscar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 10);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 1;
            label1.Text = "|";
            label1.Click += label1_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(9, 6);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 0;
            button1.Text = "+ Nuevo reporte";
            button1.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1149, 517);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Nuevo reporte";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label20);
            groupBox4.Controls.Add(label21);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label14);
            groupBox4.Location = new Point(652, 18);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 312);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ayuda — Cascada de clasificación";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(17, 214);
            label20.Name = "label20";
            label20.Size = new Size(186, 15);
            label20.TabIndex = 7;
            label20.Text = "Campos obligatorios incompletos";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Red;
            label21.Location = new Point(6, 199);
            label21.Name = "label21";
            label21.Size = new Size(63, 15);
            label21.TabIndex = 6;
            label21.Text = "R1 — Error";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(17, 161);
            label18.Name = "label18";
            label18.Size = new Size(110, 15);
            label18.TabIndex = 5;
            label18.Text = "Cualquier otro caso";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Green;
            label19.Location = new Point(6, 146);
            label19.Name = "label19";
            label19.Size = new Size(66, 15);
            label19.TabIndex = 4;
            label19.Text = "R4 — BAJA";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(17, 103);
            label17.Name = "label17";
            label17.Size = new Size(203, 15);
            label17.TabIndex = 3;
            label17.Text = "Falla total, o en uso con 5+ afectados";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Orange;
            label16.Location = new Point(6, 88);
            label16.Name = "label16";
            label16.Size = new Size(74, 15);
            label16.TabIndex = 2;
            label16.Text = "R3 — MEDIA";
            label16.Click += label16_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(10, 57);
            label15.Name = "label15";
            label15.Size = new Size(184, 15);
            label15.TabIndex = 1;
            label15.Text = "Falla total + en uso + sin respaldo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Red;
            label14.Location = new Point(6, 42);
            label14.Name = "label14";
            label14.Size = new Size(65, 15);
            label14.TabIndex = 0;
            label14.Text = "R2 — ALTA";
            // 
            // panel1
            // 
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(12, 322);
            panel1.Name = "panel1";
            panel1.Size = new Size(621, 101);
            panel1.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(33, 63);
            label13.Name = "label13";
            label13.Size = new Size(358, 15);
            label13.TabIndex = 2;
            label13.Text = "La prioridad y el plazo de atención se calcularán automáticamente.";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(33, 37);
            label12.Name = "label12";
            label12.Size = new Size(394, 15);
            label12.TabIndex = 1;
            label12.Text = "Complete los cinco campos del formulario y presione \"Clasificar reporte\".";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 14);
            label11.Name = "label11";
            label11.Size = new Size(130, 15);
            label11.TabIndex = 0;
            label11.Text = "Esperando clasificacion";
            // 
            // button3
            // 
            button3.Location = new Point(172, 293);
            button3.Name = "button3";
            button3.Size = new Size(99, 23);
            button3.TabIndex = 10;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.Location = new Point(8, 293);
            button2.Name = "button2";
            button2.Size = new Size(152, 23);
            button2.TabIndex = 9;
            button2.Text = "Clasificar reporte";
            button2.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(8, 18);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(625, 260);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos del reporte";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(187, 199);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(219, 19);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Hay equipos de respaldo disponibles";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(187, 161);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(45, 23);
            numericUpDown1.TabIndex = 7;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(292, 99);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(87, 19);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Falla parcial";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(187, 99);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Falla total";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(187, 133);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(182, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "El equipo esta en uso de clase";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(187, 39);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(242, 23);
            comboBox2.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 169);
            label10.Name = "label10";
            label10.Size = new Size(110, 15);
            label10.TabIndex = 2;
            label10.Text = "Personas afectadas:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 103);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 1;
            label9.Text = "Tipo de falla:";
            label9.Click += label9_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 32);
            label2.Name = "label2";
            label2.Size = new Size(102, 30);
            label2.TabIndex = 0;
            label2.Text = "\r\nEquipo reportado:";
            label2.Click += label2_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Controls.Add(label22);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1149, 517);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Reporte pendiente";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(3, 9);
            label22.Name = "label22";
            label22.Size = new Size(495, 15);
            label22.TabIndex = 0;
            label22.Text = "Ordenados por prioridad y antigüedad. Los reportes vencidos escalan automáticamente (R5).";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView2.Location = new Point(3, 27);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(773, 150);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Equipo / Incidencia ";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Prioridad";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Registro";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Vence";
            Column4.Name = "Column4";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 547);
            Controls.Add(button4);
            Controls.Add(Equpos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Registro";
            Text = "TriageTec — Vistas del sistema";
            Load += Registro_Load;
            Equpos.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button4;
        private TabControl Equpos;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button1;
        private Label label1;
        private Label label4;
        private TextBox hola;
        private Label label3;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Equipo;
        private DataGridViewTextBoxColumn Ubicación;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Responsable;
        private DataGridViewTextBoxColumn Ultimo_reporte;
        private DataGridViewTextBoxColumn Estado;
        private GroupBox groupBox1;
        private Label label5;
        private GroupBox groupBox2;
        private Label label6;
        private Label label8;
        private Label label7;
        private GroupBox groupBox3;
        private Label label2;
        private Label label10;
        private Label label9;
        private ComboBox comboBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox2;
        private Button button3;
        private Button button2;
        private Panel panel1;
        private Label label12;
        private Label label11;
        private Label label13;
        private GroupBox groupBox4;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label20;
        private Label label21;
        private Label label18;
        private Label label19;
        private Label label17;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label22;
        private DataGridViewTextBoxColumn Column4;
    }
}