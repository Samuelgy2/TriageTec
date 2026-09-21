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
            panelEncabezado = new Panel();
            lblTituloApp = new Label();
            lblSubtituloApp = new Label();
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
            panelEncabezado.SuspendLayout();
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
            // panelEncabezado
            //
            panelEncabezado.Controls.Add(button4);
            panelEncabezado.Controls.Add(lblSubtituloApp);
            panelEncabezado.Controls.Add(lblTituloApp);
            panelEncabezado.Dock = DockStyle.Top;
            panelEncabezado.Location = new Point(0, 0);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(1180, 64);
            panelEncabezado.TabIndex = 0;
            //
            // lblTituloApp
            //
            lblTituloApp.AutoSize = true;
            lblTituloApp.BackColor = Color.Transparent;
            lblTituloApp.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloApp.ForeColor = Color.White;
            lblTituloApp.Location = new Point(20, 8);
            lblTituloApp.Name = "lblTituloApp";
            lblTituloApp.Size = new Size(108, 30);
            lblTituloApp.TabIndex = 0;
            lblTituloApp.Text = "TriageTec";
            //
            // lblSubtituloApp
            //
            lblSubtituloApp.AutoSize = true;
            lblSubtituloApp.BackColor = Color.Transparent;
            lblSubtituloApp.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtituloApp.ForeColor = Color.FromArgb(203, 213, 225);
            lblSubtituloApp.Location = new Point(22, 38);
            lblSubtituloApp.Name = "lblSubtituloApp";
            lblSubtituloApp.Size = new Size(197, 15);
            lblSubtituloApp.TabIndex = 1;
            lblSubtituloApp.Text = "Sistema de gestión de incidencias TI";
            //
            // button4
            //
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Location = new Point(1036, 15);
            button4.Name = "button4";
            button4.Size = new Size(128, 34);
            button4.TabIndex = 2;
            button4.Text = "Cerrar sesión";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            //
            // Equpos
            //
            Equpos.Controls.Add(tabPage1);
            Equpos.Controls.Add(tabPage2);
            Equpos.Controls.Add(tabPage3);
            Equpos.Dock = DockStyle.Fill;
            Equpos.Location = new Point(0, 64);
            Equpos.Name = "Equpos";
            Equpos.SelectedIndex = 0;
            Equpos.Size = new Size(1180, 596);
            Equpos.TabIndex = 1;
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
            tabPage1.Location = new Point(4, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1172, 546);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Equipos";
            tabPage1.UseVisualStyleBackColor = true;
            //
            // groupBox2
            //
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(862, 380);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(294, 154);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resumen";
            //
            // label8
            //
            label8.AutoSize = true;
            label8.Location = new Point(24, 112);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 2;
            label8.Text = "Dados de baja";
            //
            // label7
            //
            label7.AutoSize = true;
            label7.Location = new Point(24, 78);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 1;
            label7.Text = "En reparación";
            //
            // label6
            //
            label6.AutoSize = true;
            label6.Location = new Point(24, 44);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 0;
            label6.Text = "Operativos";
            //
            // groupBox1
            //
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(862, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 300);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles del equipo";
            //
            // label5
            //
            label5.Location = new Point(24, 48);
            label5.Name = "label5";
            label5.Size = new Size(250, 60);
            label5.TabIndex = 0;
            label5.Text = "Seleccione un equipo de la lista para ver su detalle.";
            //
            // dataGridView1
            //
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Equipo, Ubicación, Tipo, Responsable, Ultimo_reporte, Estado });
            dataGridView1.Location = new Point(16, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(830, 470);
            dataGridView1.TabIndex = 6;
            //
            // ID
            //
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.FillWeight = 40F;
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
            comboBox1.Location = new Point(566, 18);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 27);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Location = new Point(512, 22);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "Estado";
            //
            // hola
            //
            hola.Location = new Point(254, 18);
            hola.Name = "hola";
            hola.PlaceholderText = "Nombre, ubicación, tipo...";
            hola.Size = new Size(240, 27);
            hola.TabIndex = 3;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new Point(196, 22);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Buscar:";
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(178, 20);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 1;
            label1.Text = "|";
            label1.Click += label1_Click_1;
            //
            // button1
            //
            button1.Location = new Point(16, 14);
            button1.Name = "button1";
            button1.Size = new Size(150, 34);
            button1.TabIndex = 0;
            button1.Text = "+ Nuevo reporte";
            button1.UseVisualStyleBackColor = true;
            //
            // tabPage2
            //
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1172, 546);
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
            groupBox4.Location = new Point(696, 16);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(340, 330);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ayuda — Cascada de clasificación";
            //
            // label20
            //
            label20.AutoSize = true;
            label20.Location = new Point(24, 292);
            label20.Name = "label20";
            label20.Size = new Size(186, 15);
            label20.TabIndex = 7;
            label20.Text = "Campos obligatorios incompletos";
            //
            // label21
            //
            label21.AutoSize = true;
            label21.BackColor = Color.Red;
            label21.Location = new Point(24, 264);
            label21.Name = "label21";
            label21.Size = new Size(63, 15);
            label21.TabIndex = 6;
            label21.Text = "R1 — Error";
            //
            // label18
            //
            label18.AutoSize = true;
            label18.Location = new Point(24, 222);
            label18.Name = "label18";
            label18.Size = new Size(110, 15);
            label18.TabIndex = 5;
            label18.Text = "Cualquier otro caso";
            //
            // label19
            //
            label19.AutoSize = true;
            label19.BackColor = Color.Green;
            label19.Location = new Point(24, 194);
            label19.Name = "label19";
            label19.Size = new Size(66, 15);
            label19.TabIndex = 4;
            label19.Text = "R4 — BAJA";
            //
            // label17
            //
            label17.AutoSize = true;
            label17.Location = new Point(24, 152);
            label17.Name = "label17";
            label17.Size = new Size(203, 15);
            label17.TabIndex = 3;
            label17.Text = "Falla total, o en uso con 5+ afectados";
            //
            // label16
            //
            label16.AutoSize = true;
            label16.BackColor = Color.Orange;
            label16.Location = new Point(24, 124);
            label16.Name = "label16";
            label16.Size = new Size(74, 15);
            label16.TabIndex = 2;
            label16.Text = "R3 — MEDIA";
            label16.Click += label16_Click;
            //
            // label15
            //
            label15.AutoSize = true;
            label15.Location = new Point(24, 82);
            label15.Name = "label15";
            label15.Size = new Size(184, 15);
            label15.TabIndex = 1;
            label15.Text = "Falla total + en uso + sin respaldo";
            //
            // label14
            //
            label14.AutoSize = true;
            label14.BackColor = Color.Red;
            label14.Location = new Point(24, 54);
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
            panel1.Location = new Point(16, 392);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 128);
            panel1.TabIndex = 11;
            //
            // label13
            //
            label13.AutoSize = true;
            label13.Location = new Point(28, 86);
            label13.Name = "label13";
            label13.Size = new Size(358, 15);
            label13.TabIndex = 2;
            label13.Text = "La prioridad y el plazo de atención se calcularán automáticamente.";
            //
            // label12
            //
            label12.AutoSize = true;
            label12.Location = new Point(28, 60);
            label12.Name = "label12";
            label12.Size = new Size(394, 15);
            label12.TabIndex = 1;
            label12.Text = "Complete los cinco campos del formulario y presione \"Clasificar reporte\".";
            label12.Click += label12_Click;
            //
            // label11
            //
            label11.AutoSize = true;
            label11.Location = new Point(26, 20);
            label11.Name = "label11";
            label11.Size = new Size(130, 15);
            label11.TabIndex = 0;
            label11.Text = "Esperando clasificación";
            //
            // button3
            //
            button3.Location = new Point(212, 336);
            button3.Name = "button3";
            button3.Size = new Size(120, 38);
            button3.TabIndex = 10;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            //
            // button2
            //
            button2.Location = new Point(16, 336);
            button2.Name = "button2";
            button2.Size = new Size(184, 38);
            button2.TabIndex = 9;
            button2.Text = "Clasificar reporte";
            button2.UseVisualStyleBackColor = true;
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
            groupBox3.Location = new Point(16, 16);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(664, 304);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos del reporte";
            groupBox3.Enter += groupBox3_Enter;
            //
            // checkBox2
            //
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(208, 244);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(219, 19);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Hay equipos de respaldo disponibles";
            checkBox2.UseVisualStyleBackColor = true;
            //
            // numericUpDown1
            //
            numericUpDown1.Location = new Point(208, 196);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(90, 27);
            numericUpDown1.TabIndex = 7;
            //
            // radioButton2
            //
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(324, 110);
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
            radioButton1.Location = new Point(208, 110);
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
            checkBox1.Location = new Point(208, 154);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(182, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "El equipo está en uso de clase";
            checkBox1.UseVisualStyleBackColor = true;
            //
            // comboBox2
            //
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(208, 52);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(320, 27);
            comboBox2.TabIndex = 3;
            //
            // label10
            //
            label10.AutoSize = true;
            label10.Location = new Point(28, 200);
            label10.Name = "label10";
            label10.Size = new Size(110, 15);
            label10.TabIndex = 2;
            label10.Text = "Personas afectadas:";
            //
            // label9
            //
            label9.AutoSize = true;
            label9.Location = new Point(28, 112);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 1;
            label9.Text = "Tipo de falla:";
            label9.Click += label9_Click;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(28, 56);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 0;
            label2.Text = "Equipo reportado:";
            label2.Click += label2_Click;
            //
            // tabPage3
            //
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Controls.Add(label22);
            tabPage3.Location = new Point(4, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1172, 546);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Reportes pendientes";
            tabPage3.UseVisualStyleBackColor = true;
            //
            // label22
            //
            label22.AutoSize = true;
            label22.Location = new Point(16, 18);
            label22.Name = "label22";
            label22.Size = new Size(495, 15);
            label22.TabIndex = 0;
            label22.Text = "Ordenados por prioridad y antigüedad. Los reportes vencidos escalan automáticamente (R5).";
            //
            // dataGridView2
            //
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView2.Location = new Point(16, 48);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1140, 486);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            //
            // Column1
            //
            Column1.HeaderText = "Equipo / Incidencia ";
            Column1.Name = "Column1";
            Column1.FillWeight = 200F;
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
            ClientSize = new Size(1180, 660);
            Controls.Add(Equpos);
            Controls.Add(panelEncabezado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1100, 620);
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TriageTec — Vistas del sistema";
            Load += Registro_Load;
            panelEncabezado.ResumeLayout(false);
            panelEncabezado.PerformLayout();
            Equpos.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
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
        private Panel panelEncabezado;
        private Label lblTituloApp;
        private Label lblSubtituloApp;
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
