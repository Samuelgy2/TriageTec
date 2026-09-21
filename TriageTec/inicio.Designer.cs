namespace TriageTec
{
    partial class inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            panelLateral = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelContenido = new Panel();
            lblBienvenida = new Label();
            lblInstruccion = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            lblPie = new Label();
            panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContenido.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            //
            // panelLateral
            //
            panelLateral.Controls.Add(label2);
            panelLateral.Controls.Add(label1);
            panelLateral.Controls.Add(pictureBox1);
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Location = new Point(0, 0);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(320, 460);
            panelLateral.TabIndex = 0;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(203, 213, 225);
            label2.Location = new Point(48, 248);
            label2.Name = "label2";
            label2.Size = new Size(230, 19);
            label2.TabIndex = 1;
            label2.Text = "Sistema de gestión de incidencias TI";
            label2.Click += label2_Click;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 200);
            label1.Name = "label1";
            label1.Size = new Size(158, 45);
            label1.TabIndex = 0;
            label1.Text = "TriageTec";
            label1.Click += label1_Click;
            //
            // pictureBox1
            //
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(48, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            //
            // panelContenido
            //
            panelContenido.BackColor = Color.White;
            panelContenido.Controls.Add(lblPie);
            panelContenido.Controls.Add(lblBienvenida);
            panelContenido.Controls.Add(lblInstruccion);
            panelContenido.Controls.Add(groupBox1);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(320, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(460, 460);
            panelContenido.TabIndex = 1;
            //
            // lblBienvenida
            //
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(44, 52);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(176, 32);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Iniciar sesión";
            //
            // lblInstruccion
            //
            lblInstruccion.AutoSize = true;
            lblInstruccion.Location = new Point(46, 88);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(262, 19);
            lblInstruccion.TabIndex = 1;
            lblInstruccion.Text = "Ingrese sus credenciales para continuar.";
            //
            // groupBox1
            //
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(44, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 272);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Credenciales de acceso";
            groupBox1.Enter += groupBox1_Enter;
            //
            // button2
            //
            button2.Location = new Point(196, 208);
            button2.Name = "button2";
            button2.Size = new Size(150, 38);
            button2.TabIndex = 5;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            //
            // button1
            //
            button1.Location = new Point(26, 208);
            button1.Name = "button1";
            button1.Size = new Size(160, 38);
            button1.TabIndex = 4;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            //
            // textBox2
            //
            textBox2.Location = new Point(26, 150);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "••••••••";
            textBox2.Size = new Size(320, 27);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Location = new Point(26, 128);
            label4.Name = "label4";
            label4.Size = new Size(79, 19);
            label4.TabIndex = 2;
            label4.Text = "Contraseña:";
            //
            // textBox1
            //
            textBox1.Location = new Point(26, 78);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "usuario";
            textBox1.Size = new Size(320, 27);
            textBox1.TabIndex = 1;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new Point(26, 56);
            label3.Name = "label3";
            label3.Size = new Size(128, 19);
            label3.TabIndex = 0;
            label3.Text = "Nombre de usuario:";
            //
            // lblPie
            //
            lblPie.AutoSize = true;
            lblPie.Location = new Point(46, 420);
            lblPie.Name = "lblPie";
            lblPie.Size = new Size(215, 19);
            lblPie.TabIndex = 3;
            lblPie.Text = "© TriageTec · Soporte técnico TI";
            //
            // inicio
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 460);
            Controls.Add(panelContenido);
            Controls.Add(panelLateral);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TriageTec — Inicio de sesión";
            Load += Form1_Load;
            panelLateral.ResumeLayout(false);
            panelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLateral;
        private Panel panelContenido;
        private Label lblBienvenida;
        private Label lblInstruccion;
        private Label lblPie;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
    }
}
