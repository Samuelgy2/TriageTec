namespace TriageTec
{
    partial class admin
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
            panelEncabezado = new Panel();
            lblTituloApp = new Label();
            lblSubtituloApp = new Label();
            btnCerrarSesion = new Button();
            tabAdmin = new TabControl();
            tabUsuarios = new TabPage();
            groupBoxResumen = new GroupBox();
            lblInhabilitados = new Label();
            lblTecnicos = new Label();
            lblActivos = new Label();
            groupBoxDetalle = new GroupBox();
            lblDetalleUsuario = new Label();
            dataGridViewUsuarios = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colUsuario = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colRol = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            colUltimoAcceso = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            comboBoxEstado = new ComboBox();
            lblEstado = new Label();
            comboBoxRol = new ComboBox();
            lblRol = new Label();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            lblSeparador = new Label();
            btnNuevoUsuario = new Button();
            tabGestion = new TabPage();
            groupBoxAyuda = new GroupBox();
            lblAyudaUsuario = new Label();
            lblAyudaUsuarioTitulo = new Label();
            lblAyudaTecnico = new Label();
            lblAyudaTecnicoTitulo = new Label();
            lblAyudaAdmin = new Label();
            lblAyudaAdminTitulo = new Label();
            groupBoxInhabilitar = new GroupBox();
            btnInhabilitar = new Button();
            checkConfirmarInhabilitar = new CheckBox();
            txtMotivo = new TextBox();
            lblMotivo = new Label();
            comboBoxUsuarioInhabilitar = new ComboBox();
            lblUsuarioInhabilitar = new Label();
            groupBoxContrasena = new GroupBox();
            btnActualizarContrasena = new Button();
            txtConfirmarNueva = new TextBox();
            lblConfirmarNueva = new Label();
            txtNuevaContrasena = new TextBox();
            lblNuevaContrasena = new Label();
            comboBoxUsuarioContrasena = new ComboBox();
            lblUsuarioContrasena = new Label();
            groupBoxCrear = new GroupBox();
            btnLimpiar = new Button();
            btnCrearCuenta = new Button();
            txtConfirmarContrasena = new TextBox();
            lblConfirmarContrasena = new Label();
            txtContrasena = new TextBox();
            lblContrasena = new Label();
            radioTecnico = new RadioButton();
            radioUsuario = new RadioButton();
            lblTipoCuenta = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            panelEncabezado.SuspendLayout();
            tabAdmin.SuspendLayout();
            tabUsuarios.SuspendLayout();
            groupBoxResumen.SuspendLayout();
            groupBoxDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            tabGestion.SuspendLayout();
            groupBoxAyuda.SuspendLayout();
            groupBoxInhabilitar.SuspendLayout();
            groupBoxContrasena.SuspendLayout();
            groupBoxCrear.SuspendLayout();
            SuspendLayout();
            //
            // panelEncabezado
            //
            panelEncabezado.Controls.Add(btnCerrarSesion);
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
            lblSubtituloApp.Size = new Size(150, 15);
            lblSubtituloApp.TabIndex = 1;
            lblSubtituloApp.Text = "Administración de usuarios";
            //
            // btnCerrarSesion
            //
            btnCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarSesion.Location = new Point(1036, 15);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(128, 34);
            btnCerrarSesion.TabIndex = 2;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            //
            // tabAdmin
            //
            tabAdmin.Controls.Add(tabUsuarios);
            tabAdmin.Controls.Add(tabGestion);
            tabAdmin.Dock = DockStyle.Fill;
            tabAdmin.Location = new Point(0, 64);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.SelectedIndex = 0;
            tabAdmin.Size = new Size(1180, 596);
            tabAdmin.TabIndex = 1;
            //
            // tabUsuarios
            //
            tabUsuarios.Controls.Add(groupBoxResumen);
            tabUsuarios.Controls.Add(groupBoxDetalle);
            tabUsuarios.Controls.Add(dataGridViewUsuarios);
            tabUsuarios.Controls.Add(comboBoxEstado);
            tabUsuarios.Controls.Add(lblEstado);
            tabUsuarios.Controls.Add(comboBoxRol);
            tabUsuarios.Controls.Add(lblRol);
            tabUsuarios.Controls.Add(txtBuscar);
            tabUsuarios.Controls.Add(lblBuscar);
            tabUsuarios.Controls.Add(lblSeparador);
            tabUsuarios.Controls.Add(btnNuevoUsuario);
            tabUsuarios.Location = new Point(4, 46);
            tabUsuarios.Name = "tabUsuarios";
            tabUsuarios.Size = new Size(1172, 546);
            tabUsuarios.TabIndex = 0;
            tabUsuarios.Text = "Usuarios";
            tabUsuarios.UseVisualStyleBackColor = true;
            //
            // groupBoxResumen
            //
            groupBoxResumen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxResumen.Controls.Add(lblInhabilitados);
            groupBoxResumen.Controls.Add(lblTecnicos);
            groupBoxResumen.Controls.Add(lblActivos);
            groupBoxResumen.Location = new Point(862, 380);
            groupBoxResumen.Name = "groupBoxResumen";
            groupBoxResumen.Size = new Size(294, 154);
            groupBoxResumen.TabIndex = 10;
            groupBoxResumen.TabStop = false;
            groupBoxResumen.Text = "Resumen";
            //
            // lblInhabilitados
            //
            lblInhabilitados.AutoSize = true;
            lblInhabilitados.Location = new Point(24, 112);
            lblInhabilitados.Name = "lblInhabilitados";
            lblInhabilitados.Size = new Size(76, 15);
            lblInhabilitados.TabIndex = 2;
            lblInhabilitados.Text = "Inhabilitados";
            //
            // lblTecnicos
            //
            lblTecnicos.AutoSize = true;
            lblTecnicos.Location = new Point(24, 78);
            lblTecnicos.Name = "lblTecnicos";
            lblTecnicos.Size = new Size(53, 15);
            lblTecnicos.TabIndex = 1;
            lblTecnicos.Text = "Técnicos";
            //
            // lblActivos
            //
            lblActivos.AutoSize = true;
            lblActivos.Location = new Point(24, 44);
            lblActivos.Name = "lblActivos";
            lblActivos.Size = new Size(46, 15);
            lblActivos.TabIndex = 0;
            lblActivos.Text = "Activos";
            //
            // groupBoxDetalle
            //
            groupBoxDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxDetalle.Controls.Add(lblDetalleUsuario);
            groupBoxDetalle.Location = new Point(862, 64);
            groupBoxDetalle.Name = "groupBoxDetalle";
            groupBoxDetalle.Size = new Size(294, 300);
            groupBoxDetalle.TabIndex = 9;
            groupBoxDetalle.TabStop = false;
            groupBoxDetalle.Text = "Detalles del usuario";
            //
            // lblDetalleUsuario
            //
            lblDetalleUsuario.Location = new Point(24, 48);
            lblDetalleUsuario.Name = "lblDetalleUsuario";
            lblDetalleUsuario.Size = new Size(250, 60);
            lblDetalleUsuario.TabIndex = 0;
            lblDetalleUsuario.Text = "Seleccione un usuario de la lista para ver su detalle.";
            //
            // dataGridViewUsuarios
            //
            dataGridViewUsuarios.AllowUserToAddRows = false;
            dataGridViewUsuarios.AllowUserToDeleteRows = false;
            dataGridViewUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Columns.AddRange(new DataGridViewColumn[] { colId, colUsuario, colNombre, colRol, colCorreo, colUltimoAcceso, colEstado });
            dataGridViewUsuarios.Location = new Point(16, 64);
            dataGridViewUsuarios.MultiSelect = false;
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsuarios.Size = new Size(830, 470);
            dataGridViewUsuarios.TabIndex = 8;
            //
            // colId
            //
            colId.FillWeight = 40F;
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            //
            // colUsuario
            //
            colUsuario.HeaderText = "Usuario";
            colUsuario.Name = "colUsuario";
            colUsuario.ReadOnly = true;
            //
            // colNombre
            //
            colNombre.FillWeight = 150F;
            colNombre.HeaderText = "Nombre completo";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            //
            // colRol
            //
            colRol.HeaderText = "Rol";
            colRol.Name = "colRol";
            colRol.ReadOnly = true;
            //
            // colCorreo
            //
            colCorreo.FillWeight = 150F;
            colCorreo.HeaderText = "Correo";
            colCorreo.Name = "colCorreo";
            colCorreo.ReadOnly = true;
            //
            // colUltimoAcceso
            //
            colUltimoAcceso.HeaderText = "Últ. acceso";
            colUltimoAcceso.Name = "colUltimoAcceso";
            colUltimoAcceso.ReadOnly = true;
            //
            // colEstado
            //
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            //
            // comboBoxEstado
            //
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Todos", "Activo", "Inhabilitado" });
            comboBoxEstado.Location = new Point(754, 18);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(150, 27);
            comboBoxEstado.TabIndex = 7;
            //
            // lblEstado
            //
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(700, 22);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado";
            //
            // comboBoxRol
            //
            comboBoxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Items.AddRange(new object[] { "Todos", "Administrador", "Técnico", "Usuario" });
            comboBoxRol.Location = new Point(530, 18);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(150, 27);
            comboBoxRol.TabIndex = 5;
            //
            // lblRol
            //
            lblRol.AutoSize = true;
            lblRol.Location = new Point(496, 22);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(25, 15);
            lblRol.TabIndex = 4;
            lblRol.Text = "Rol";
            //
            // txtBuscar
            //
            txtBuscar.Location = new Point(254, 18);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Usuario, nombre, correo...";
            txtBuscar.Size = new Size(224, 27);
            txtBuscar.TabIndex = 3;
            //
            // lblBuscar
            //
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(196, 22);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(45, 15);
            lblBuscar.TabIndex = 2;
            lblBuscar.Text = "Buscar:";
            //
            // lblSeparador
            //
            lblSeparador.AutoSize = true;
            lblSeparador.Location = new Point(178, 20);
            lblSeparador.Name = "lblSeparador";
            lblSeparador.Size = new Size(10, 15);
            lblSeparador.TabIndex = 1;
            lblSeparador.Text = "|";
            //
            // btnNuevoUsuario
            //
            btnNuevoUsuario.Location = new Point(16, 14);
            btnNuevoUsuario.Name = "btnNuevoUsuario";
            btnNuevoUsuario.Size = new Size(150, 34);
            btnNuevoUsuario.TabIndex = 0;
            btnNuevoUsuario.Text = "+ Nuevo usuario";
            btnNuevoUsuario.UseVisualStyleBackColor = true;
            //
            // tabGestion
            //
            tabGestion.Controls.Add(groupBoxAyuda);
            tabGestion.Controls.Add(groupBoxInhabilitar);
            tabGestion.Controls.Add(groupBoxContrasena);
            tabGestion.Controls.Add(groupBoxCrear);
            tabGestion.Location = new Point(4, 46);
            tabGestion.Name = "tabGestion";
            tabGestion.Size = new Size(1172, 546);
            tabGestion.TabIndex = 1;
            tabGestion.Text = "Gestión de usuarios";
            tabGestion.UseVisualStyleBackColor = true;
            //
            // groupBoxAyuda
            //
            groupBoxAyuda.Controls.Add(lblAyudaUsuario);
            groupBoxAyuda.Controls.Add(lblAyudaUsuarioTitulo);
            groupBoxAyuda.Controls.Add(lblAyudaTecnico);
            groupBoxAyuda.Controls.Add(lblAyudaTecnicoTitulo);
            groupBoxAyuda.Controls.Add(lblAyudaAdmin);
            groupBoxAyuda.Controls.Add(lblAyudaAdminTitulo);
            groupBoxAyuda.Location = new Point(808, 16);
            groupBoxAyuda.Name = "groupBoxAyuda";
            groupBoxAyuda.Size = new Size(348, 300);
            groupBoxAyuda.TabIndex = 3;
            groupBoxAyuda.TabStop = false;
            groupBoxAyuda.Text = "Ayuda — Roles del sistema";
            //
            // lblAyudaUsuario
            //
            lblAyudaUsuario.AutoSize = true;
            lblAyudaUsuario.Location = new Point(24, 244);
            lblAyudaUsuario.Name = "lblAyudaUsuario";
            lblAyudaUsuario.Size = new Size(228, 30);
            lblAyudaUsuario.TabIndex = 5;
            lblAyudaUsuario.Text = "Registra reportes de incidencias y consulta\r\nel estado de sus equipos.";
            //
            // lblAyudaUsuarioTitulo
            //
            lblAyudaUsuarioTitulo.AutoSize = true;
            lblAyudaUsuarioTitulo.BackColor = Color.Green;
            lblAyudaUsuarioTitulo.Location = new Point(24, 214);
            lblAyudaUsuarioTitulo.Name = "lblAyudaUsuarioTitulo";
            lblAyudaUsuarioTitulo.Size = new Size(49, 15);
            lblAyudaUsuarioTitulo.TabIndex = 4;
            lblAyudaUsuarioTitulo.Text = "Usuario";
            //
            // lblAyudaTecnico
            //
            lblAyudaTecnico.AutoSize = true;
            lblAyudaTecnico.Location = new Point(24, 162);
            lblAyudaTecnico.Name = "lblAyudaTecnico";
            lblAyudaTecnico.Size = new Size(236, 30);
            lblAyudaTecnico.TabIndex = 3;
            lblAyudaTecnico.Text = "Atiende reportes asignados, actualiza estado\r\nde equipos y cierra incidencias.";
            //
            // lblAyudaTecnicoTitulo
            //
            lblAyudaTecnicoTitulo.AutoSize = true;
            lblAyudaTecnicoTitulo.BackColor = Color.Orange;
            lblAyudaTecnicoTitulo.Location = new Point(24, 132);
            lblAyudaTecnicoTitulo.Name = "lblAyudaTecnicoTitulo";
            lblAyudaTecnicoTitulo.Size = new Size(48, 15);
            lblAyudaTecnicoTitulo.TabIndex = 2;
            lblAyudaTecnicoTitulo.Text = "Técnico";
            //
            // lblAyudaAdmin
            //
            lblAyudaAdmin.AutoSize = true;
            lblAyudaAdmin.Location = new Point(24, 80);
            lblAyudaAdmin.Name = "lblAyudaAdmin";
            lblAyudaAdmin.Size = new Size(238, 30);
            lblAyudaAdmin.TabIndex = 1;
            lblAyudaAdmin.Text = "Gestiona cuentas, contraseñas y permisos.\r\nAcceso total al sistema.";
            //
            // lblAyudaAdminTitulo
            //
            lblAyudaAdminTitulo.AutoSize = true;
            lblAyudaAdminTitulo.BackColor = Color.Red;
            lblAyudaAdminTitulo.Location = new Point(24, 50);
            lblAyudaAdminTitulo.Name = "lblAyudaAdminTitulo";
            lblAyudaAdminTitulo.Size = new Size(82, 15);
            lblAyudaAdminTitulo.TabIndex = 0;
            lblAyudaAdminTitulo.Text = "Administrador";
            //
            // groupBoxInhabilitar
            //
            groupBoxInhabilitar.Controls.Add(btnInhabilitar);
            groupBoxInhabilitar.Controls.Add(checkConfirmarInhabilitar);
            groupBoxInhabilitar.Controls.Add(txtMotivo);
            groupBoxInhabilitar.Controls.Add(lblMotivo);
            groupBoxInhabilitar.Controls.Add(comboBoxUsuarioInhabilitar);
            groupBoxInhabilitar.Controls.Add(lblUsuarioInhabilitar);
            groupBoxInhabilitar.Location = new Point(432, 300);
            groupBoxInhabilitar.Name = "groupBoxInhabilitar";
            groupBoxInhabilitar.Size = new Size(360, 240);
            groupBoxInhabilitar.TabIndex = 2;
            groupBoxInhabilitar.TabStop = false;
            groupBoxInhabilitar.Text = "Inhabilitar usuario";
            //
            // btnInhabilitar
            //
            btnInhabilitar.Location = new Point(190, 196);
            btnInhabilitar.Name = "btnInhabilitar";
            btnInhabilitar.Size = new Size(146, 34);
            btnInhabilitar.TabIndex = 5;
            btnInhabilitar.Text = "Inhabilitar cuenta";
            btnInhabilitar.UseVisualStyleBackColor = true;
            //
            // checkConfirmarInhabilitar
            //
            checkConfirmarInhabilitar.AutoSize = true;
            checkConfirmarInhabilitar.Location = new Point(24, 170);
            checkConfirmarInhabilitar.Name = "checkConfirmarInhabilitar";
            checkConfirmarInhabilitar.Size = new Size(283, 19);
            checkConfirmarInhabilitar.TabIndex = 4;
            checkConfirmarInhabilitar.Text = "Confirmo que deseo inhabilitar esta cuenta";
            checkConfirmarInhabilitar.UseVisualStyleBackColor = true;
            //
            // txtMotivo
            //
            txtMotivo.Location = new Point(24, 124);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(312, 40);
            txtMotivo.TabIndex = 3;
            //
            // lblMotivo
            //
            lblMotivo.AutoSize = true;
            lblMotivo.Location = new Point(24, 102);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(48, 15);
            lblMotivo.TabIndex = 2;
            lblMotivo.Text = "Motivo:";
            //
            // comboBoxUsuarioInhabilitar
            //
            comboBoxUsuarioInhabilitar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUsuarioInhabilitar.FormattingEnabled = true;
            comboBoxUsuarioInhabilitar.Location = new Point(24, 66);
            comboBoxUsuarioInhabilitar.Name = "comboBoxUsuarioInhabilitar";
            comboBoxUsuarioInhabilitar.Size = new Size(312, 27);
            comboBoxUsuarioInhabilitar.TabIndex = 1;
            //
            // lblUsuarioInhabilitar
            //
            lblUsuarioInhabilitar.AutoSize = true;
            lblUsuarioInhabilitar.Location = new Point(24, 44);
            lblUsuarioInhabilitar.Name = "lblUsuarioInhabilitar";
            lblUsuarioInhabilitar.Size = new Size(51, 15);
            lblUsuarioInhabilitar.TabIndex = 0;
            lblUsuarioInhabilitar.Text = "Usuario:";
            //
            // groupBoxContrasena
            //
            groupBoxContrasena.Controls.Add(btnActualizarContrasena);
            groupBoxContrasena.Controls.Add(txtConfirmarNueva);
            groupBoxContrasena.Controls.Add(lblConfirmarNueva);
            groupBoxContrasena.Controls.Add(txtNuevaContrasena);
            groupBoxContrasena.Controls.Add(lblNuevaContrasena);
            groupBoxContrasena.Controls.Add(comboBoxUsuarioContrasena);
            groupBoxContrasena.Controls.Add(lblUsuarioContrasena);
            groupBoxContrasena.Location = new Point(432, 16);
            groupBoxContrasena.Name = "groupBoxContrasena";
            groupBoxContrasena.Size = new Size(360, 268);
            groupBoxContrasena.TabIndex = 1;
            groupBoxContrasena.TabStop = false;
            groupBoxContrasena.Text = "Cambiar contraseña";
            //
            // btnActualizarContrasena
            //
            btnActualizarContrasena.Location = new Point(166, 222);
            btnActualizarContrasena.Name = "btnActualizarContrasena";
            btnActualizarContrasena.Size = new Size(170, 34);
            btnActualizarContrasena.TabIndex = 6;
            btnActualizarContrasena.Text = "Actualizar contraseña";
            btnActualizarContrasena.UseVisualStyleBackColor = true;
            //
            // txtConfirmarNueva
            //
            txtConfirmarNueva.Location = new Point(24, 184);
            txtConfirmarNueva.Name = "txtConfirmarNueva";
            txtConfirmarNueva.PasswordChar = '•';
            txtConfirmarNueva.Size = new Size(312, 27);
            txtConfirmarNueva.TabIndex = 5;
            //
            // lblConfirmarNueva
            //
            lblConfirmarNueva.AutoSize = true;
            lblConfirmarNueva.Location = new Point(24, 162);
            lblConfirmarNueva.Name = "lblConfirmarNueva";
            lblConfirmarNueva.Size = new Size(160, 15);
            lblConfirmarNueva.TabIndex = 4;
            lblConfirmarNueva.Text = "Confirmar nueva contraseña:";
            //
            // txtNuevaContrasena
            //
            txtNuevaContrasena.Location = new Point(24, 126);
            txtNuevaContrasena.Name = "txtNuevaContrasena";
            txtNuevaContrasena.PasswordChar = '•';
            txtNuevaContrasena.Size = new Size(312, 27);
            txtNuevaContrasena.TabIndex = 3;
            //
            // lblNuevaContrasena
            //
            lblNuevaContrasena.AutoSize = true;
            lblNuevaContrasena.Location = new Point(24, 104);
            lblNuevaContrasena.Name = "lblNuevaContrasena";
            lblNuevaContrasena.Size = new Size(107, 15);
            lblNuevaContrasena.TabIndex = 2;
            lblNuevaContrasena.Text = "Nueva contraseña:";
            //
            // comboBoxUsuarioContrasena
            //
            comboBoxUsuarioContrasena.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUsuarioContrasena.FormattingEnabled = true;
            comboBoxUsuarioContrasena.Location = new Point(24, 68);
            comboBoxUsuarioContrasena.Name = "comboBoxUsuarioContrasena";
            comboBoxUsuarioContrasena.Size = new Size(312, 27);
            comboBoxUsuarioContrasena.TabIndex = 1;
            //
            // lblUsuarioContrasena
            //
            lblUsuarioContrasena.AutoSize = true;
            lblUsuarioContrasena.Location = new Point(24, 46);
            lblUsuarioContrasena.Name = "lblUsuarioContrasena";
            lblUsuarioContrasena.Size = new Size(51, 15);
            lblUsuarioContrasena.TabIndex = 0;
            lblUsuarioContrasena.Text = "Usuario:";
            //
            // groupBoxCrear
            //
            groupBoxCrear.Controls.Add(btnLimpiar);
            groupBoxCrear.Controls.Add(btnCrearCuenta);
            groupBoxCrear.Controls.Add(txtConfirmarContrasena);
            groupBoxCrear.Controls.Add(lblConfirmarContrasena);
            groupBoxCrear.Controls.Add(txtContrasena);
            groupBoxCrear.Controls.Add(lblContrasena);
            groupBoxCrear.Controls.Add(radioTecnico);
            groupBoxCrear.Controls.Add(radioUsuario);
            groupBoxCrear.Controls.Add(lblTipoCuenta);
            groupBoxCrear.Controls.Add(txtCorreo);
            groupBoxCrear.Controls.Add(lblCorreo);
            groupBoxCrear.Controls.Add(txtUsuario);
            groupBoxCrear.Controls.Add(lblUsuario);
            groupBoxCrear.Controls.Add(txtNombre);
            groupBoxCrear.Controls.Add(lblNombre);
            groupBoxCrear.Location = new Point(16, 16);
            groupBoxCrear.Name = "groupBoxCrear";
            groupBoxCrear.Size = new Size(400, 524);
            groupBoxCrear.TabIndex = 0;
            groupBoxCrear.TabStop = false;
            groupBoxCrear.Text = "Crear usuario / técnico";
            //
            // btnLimpiar
            //
            btnLimpiar.Location = new Point(128, 466);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 38);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            //
            // btnCrearCuenta
            //
            btnCrearCuenta.Location = new Point(250, 466);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(126, 38);
            btnCrearCuenta.TabIndex = 13;
            btnCrearCuenta.Text = "Crear cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = true;
            //
            // txtConfirmarContrasena
            //
            txtConfirmarContrasena.Location = new Point(24, 402);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.PasswordChar = '•';
            txtConfirmarContrasena.Size = new Size(352, 27);
            txtConfirmarContrasena.TabIndex = 12;
            //
            // lblConfirmarContrasena
            //
            lblConfirmarContrasena.AutoSize = true;
            lblConfirmarContrasena.Location = new Point(24, 380);
            lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            lblConfirmarContrasena.Size = new Size(125, 15);
            lblConfirmarContrasena.TabIndex = 11;
            lblConfirmarContrasena.Text = "Confirmar contraseña:";
            //
            // txtContrasena
            //
            txtContrasena.Location = new Point(24, 336);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '•';
            txtContrasena.Size = new Size(352, 27);
            txtContrasena.TabIndex = 10;
            //
            // lblContrasena
            //
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(24, 314);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(70, 15);
            lblContrasena.TabIndex = 9;
            lblContrasena.Text = "Contraseña:";
            //
            // radioTecnico
            //
            radioTecnico.AutoSize = true;
            radioTecnico.Location = new Point(134, 272);
            radioTecnico.Name = "radioTecnico";
            radioTecnico.Size = new Size(64, 19);
            radioTecnico.TabIndex = 8;
            radioTecnico.Text = "Técnico";
            radioTecnico.UseVisualStyleBackColor = true;
            //
            // radioUsuario
            //
            radioUsuario.AutoSize = true;
            radioUsuario.Checked = true;
            radioUsuario.Location = new Point(24, 272);
            radioUsuario.Name = "radioUsuario";
            radioUsuario.Size = new Size(65, 19);
            radioUsuario.TabIndex = 7;
            radioUsuario.TabStop = true;
            radioUsuario.Text = "Usuario";
            radioUsuario.UseVisualStyleBackColor = true;
            //
            // lblTipoCuenta
            //
            lblTipoCuenta.AutoSize = true;
            lblTipoCuenta.Location = new Point(24, 250);
            lblTipoCuenta.Name = "lblTipoCuenta";
            lblTipoCuenta.Size = new Size(88, 15);
            lblTipoCuenta.TabIndex = 6;
            lblTipoCuenta.Text = "Tipo de cuenta:";
            //
            // txtCorreo
            //
            txtCorreo.Location = new Point(24, 206);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "nombre@dominio.com";
            txtCorreo.Size = new Size(352, 27);
            txtCorreo.TabIndex = 5;
            //
            // lblCorreo
            //
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(24, 184);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(112, 15);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "Correo electrónico:";
            //
            // txtUsuario
            //
            txtUsuario.Location = new Point(24, 140);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(352, 27);
            txtUsuario.TabIndex = 3;
            //
            // lblUsuario
            //
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(24, 118);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(112, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Nombre de usuario:";
            //
            // txtNombre
            //
            txtNombre.Location = new Point(24, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(352, 27);
            txtNombre.TabIndex = 1;
            //
            // lblNombre
            //
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(24, 52);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(104, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre completo:";
            //
            // admin
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 660);
            Controls.Add(tabAdmin);
            Controls.Add(panelEncabezado);
            MinimumSize = new Size(1100, 620);
            Name = "admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TriageTec — Administración de usuarios";
            panelEncabezado.ResumeLayout(false);
            panelEncabezado.PerformLayout();
            tabAdmin.ResumeLayout(false);
            tabUsuarios.ResumeLayout(false);
            tabUsuarios.PerformLayout();
            groupBoxResumen.ResumeLayout(false);
            groupBoxResumen.PerformLayout();
            groupBoxDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            tabGestion.ResumeLayout(false);
            groupBoxAyuda.ResumeLayout(false);
            groupBoxAyuda.PerformLayout();
            groupBoxInhabilitar.ResumeLayout(false);
            groupBoxInhabilitar.PerformLayout();
            groupBoxContrasena.ResumeLayout(false);
            groupBoxContrasena.PerformLayout();
            groupBoxCrear.ResumeLayout(false);
            groupBoxCrear.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEncabezado;
        private Label lblTituloApp;
        private Label lblSubtituloApp;
        private Button btnCerrarSesion;
        private TabControl tabAdmin;
        private TabPage tabUsuarios;
        private TabPage tabGestion;
        private GroupBox groupBoxResumen;
        private Label lblInhabilitados;
        private Label lblTecnicos;
        private Label lblActivos;
        private GroupBox groupBoxDetalle;
        private Label lblDetalleUsuario;
        private DataGridView dataGridViewUsuarios;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colUsuario;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colRol;
        private DataGridViewTextBoxColumn colCorreo;
        private DataGridViewTextBoxColumn colUltimoAcceso;
        private DataGridViewTextBoxColumn colEstado;
        private ComboBox comboBoxEstado;
        private Label lblEstado;
        private ComboBox comboBoxRol;
        private Label lblRol;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Label lblSeparador;
        private Button btnNuevoUsuario;
        private GroupBox groupBoxAyuda;
        private Label lblAyudaUsuario;
        private Label lblAyudaUsuarioTitulo;
        private Label lblAyudaTecnico;
        private Label lblAyudaTecnicoTitulo;
        private Label lblAyudaAdmin;
        private Label lblAyudaAdminTitulo;
        private GroupBox groupBoxInhabilitar;
        private Button btnInhabilitar;
        private CheckBox checkConfirmarInhabilitar;
        private TextBox txtMotivo;
        private Label lblMotivo;
        private ComboBox comboBoxUsuarioInhabilitar;
        private Label lblUsuarioInhabilitar;
        private GroupBox groupBoxContrasena;
        private Button btnActualizarContrasena;
        private TextBox txtConfirmarNueva;
        private Label lblConfirmarNueva;
        private TextBox txtNuevaContrasena;
        private Label lblNuevaContrasena;
        private ComboBox comboBoxUsuarioContrasena;
        private Label lblUsuarioContrasena;
        private GroupBox groupBoxCrear;
        private Button btnLimpiar;
        private Button btnCrearCuenta;
        private TextBox txtConfirmarContrasena;
        private Label lblConfirmarContrasena;
        private TextBox txtContrasena;
        private Label lblContrasena;
        private RadioButton radioTecnico;
        private RadioButton radioUsuario;
        private Label lblTipoCuenta;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private TextBox txtNombre;
        private Label lblNombre;
    }
}
