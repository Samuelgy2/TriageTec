using System.Drawing.Drawing2D;

namespace TriageTec
{
    /// <summary>
    /// Paleta y estilos compartidos por todas las vistas de TriageTec.
    /// Se aplica en tiempo de ejecución sobre los controles generados por el diseñador.
    /// </summary>
    internal static class Tema
    {
        // Paleta principal
        public static readonly Color Primario = Color.FromArgb(37, 99, 235);       // azul
        public static readonly Color PrimarioHover = Color.FromArgb(29, 78, 216);
        public static readonly Color PrimarioOscuro = Color.FromArgb(30, 41, 59);   // navy (encabezados)
        public static readonly Color PrimarioOscuro2 = Color.FromArgb(15, 23, 42);
        public static readonly Color Fondo = Color.FromArgb(241, 245, 249);        // gris muy claro
        public static readonly Color Tarjeta = Color.White;
        public static readonly Color Borde = Color.FromArgb(226, 232, 240);
        public static readonly Color Texto = Color.FromArgb(30, 41, 59);
        public static readonly Color TextoSuave = Color.FromArgb(100, 116, 139);
        public static readonly Color TextoClaro = Color.FromArgb(203, 213, 225);

        // Colores semánticos
        public static readonly Color Exito = Color.FromArgb(16, 185, 129);
        public static readonly Color Advertencia = Color.FromArgb(245, 158, 11);
        public static readonly Color Peligro = Color.FromArgb(239, 68, 68);
        public static readonly Color PeligroHover = Color.FromArgb(220, 38, 38);
        public static readonly Color Info = Color.FromArgb(14, 165, 233);

        public static readonly Font FuenteBase = new("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        public static readonly Font FuenteNegrita = new("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
        public static readonly Font FuenteTitulo = new("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
        public static readonly Font FuenteSubtitulo = new("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        public static readonly Font FuenteTarjeta = new("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);

        /// <summary>Aplica el tema completo a un formulario y a todos sus controles hijos.</summary>
        public static void Aplicar(Form form)
        {
            form.BackColor = Fondo;
            form.Font = FuenteBase;
            form.ForeColor = Texto;
            AplicarRecursivo(form);
        }

        private static void AplicarRecursivo(Control padre)
        {
            foreach (Control c in padre.Controls)
            {
                switch (c)
                {
                    case DataGridView dgv:
                        EstilizarGrid(dgv);
                        break;
                    case TabControl tabs:
                        EstilizarTabs(tabs);
                        break;
                    case GroupBox gb:
                        EstilizarTarjeta(gb);
                        break;
                    case TextBox tb:
                        EstilizarEntrada(tb);
                        break;
                    case ComboBox cb:
                        EstilizarCombo(cb);
                        break;
                    case NumericUpDown nud:
                        nud.BorderStyle = BorderStyle.FixedSingle;
                        nud.BackColor = Color.White;
                        nud.ForeColor = Texto;
                        nud.Font = FuenteBase;
                        break;
                    case CheckBox chk:
                        chk.ForeColor = Texto;
                        chk.Font = FuenteBase;
                        chk.Cursor = Cursors.Hand;
                        break;
                    case RadioButton rb:
                        rb.ForeColor = Texto;
                        rb.Font = FuenteBase;
                        rb.Cursor = Cursors.Hand;
                        break;
                }
                AplicarRecursivo(c);
            }
        }

        // ---------- Botones ----------

        public static void BotonPrimario(Button b) => Boton(b, Primario, PrimarioHover, Color.White);
        public static void BotonPeligro(Button b) => Boton(b, Peligro, PeligroHover, Color.White);
        public static void BotonExito(Button b) => Boton(b, Exito, Color.FromArgb(5, 150, 105), Color.White);

        public static void BotonSecundario(Button b)
        {
            Boton(b, Color.White, Color.FromArgb(248, 250, 252), Texto);
            b.FlatAppearance.BorderSize = 1;
            b.FlatAppearance.BorderColor = Borde;
        }

        /// <summary>Botón "fantasma" para fondos oscuros (p. ej. cerrar sesión en el encabezado).</summary>
        public static void BotonEncabezado(Button b)
        {
            Boton(b, PrimarioOscuro, Color.FromArgb(51, 65, 85), Color.White);
            b.FlatAppearance.BorderSize = 1;
            b.FlatAppearance.BorderColor = Color.FromArgb(71, 85, 105);
        }

        private static void Boton(Button b, Color fondo, Color hover, Color texto)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseOverBackColor = hover;
            b.FlatAppearance.MouseDownBackColor = hover;
            b.BackColor = fondo;
            b.ForeColor = texto;
            b.Font = FuenteNegrita;
            b.Cursor = Cursors.Hand;
            b.UseVisualStyleBackColor = false;
            if (b.Height < 34) b.Height = 34;
        }

        // ---------- Entradas ----------

        public static void EstilizarEntrada(TextBox tb)
        {
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.BackColor = Color.White;
            tb.ForeColor = Texto;
            tb.Font = FuenteBase;
        }

        public static void EstilizarCombo(ComboBox cb)
        {
            cb.FlatStyle = FlatStyle.Standard;
            cb.BackColor = Color.White;
            cb.ForeColor = Texto;
            cb.Font = FuenteBase;
        }

        // ---------- Tarjetas (GroupBox) ----------

        /// <summary>Convierte un GroupBox en una tarjeta blanca con borde suave y título en color.</summary>
        public static void EstilizarTarjeta(GroupBox gb)
        {
            gb.ForeColor = Primario;
            gb.Font = FuenteTarjeta;
            gb.BackColor = Tarjeta;
            gb.Padding = new Padding(12, 8, 12, 12);
            gb.Paint -= PintarTarjeta;
            gb.Paint += PintarTarjeta;
            // Los hijos deben mostrar texto normal, no el color del título.
            foreach (Control hijo in gb.Controls)
            {
                if (hijo is Label l && l.ForeColor == Primario) l.ForeColor = Texto;
                if (hijo is Label l2 && l2.Font.Equals(gb.Font)) l2.Font = FuenteBase;
            }
        }

        private static void PintarTarjeta(object? sender, PaintEventArgs e)
        {
            if (sender is not GroupBox gb) return;
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(gb.Parent?.BackColor ?? Fondo);

            var rect = new Rectangle(0, 0, gb.Width - 1, gb.Height - 1);
            using var camino = Redondeado(rect, 10);
            using var fondo = new SolidBrush(Tarjeta);
            using var borde = new Pen(Borde, 1);
            g.FillPath(fondo, camino);
            g.DrawPath(borde, camino);

            if (!string.IsNullOrEmpty(gb.Text))
            {
                // Barra de acento a la izquierda del título
                using var acento = new SolidBrush(Primario);
                g.FillRectangle(acento, new Rectangle(14, 12, 4, 18));
                TextRenderer.DrawText(g, gb.Text, gb.Font, new Point(24, 10), gb.ForeColor);
            }
        }

        // ---------- Encabezado ----------

        /// <summary>Panel superior con degradado oscuro.</summary>
        public static void EstilizarEncabezado(Panel p)
        {
            p.BackColor = PrimarioOscuro;
            p.Paint -= PintarEncabezado;
            p.Paint += PintarEncabezado;
        }

        private static void PintarEncabezado(object? sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            using var brocha = new LinearGradientBrush(p.ClientRectangle, PrimarioOscuro2, PrimarioOscuro, LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(brocha, p.ClientRectangle);
            using var linea = new Pen(Primario, 3);
            e.Graphics.DrawLine(linea, 0, p.Height - 2, p.Width, p.Height - 2);
        }

        /// <summary>Panel lateral con degradado azul (pantalla de inicio de sesión).</summary>
        public static void EstilizarLateral(Panel p)
        {
            p.BackColor = Primario;
            p.Paint -= PintarLateral;
            p.Paint += PintarLateral;
        }

        private static void PintarLateral(object? sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            using var brocha = new LinearGradientBrush(p.ClientRectangle, Color.FromArgb(37, 99, 235), Color.FromArgb(30, 41, 59), 60f);
            e.Graphics.FillRectangle(brocha, p.ClientRectangle);
            // Círculos decorativos translúcidos
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using var suave = new SolidBrush(Color.FromArgb(28, 255, 255, 255));
            e.Graphics.FillEllipse(suave, -80, p.Height - 160, 260, 260);
            e.Graphics.FillEllipse(suave, p.Width - 120, -90, 220, 220);
        }

        /// <summary>Panel de resultado / aviso: tarjeta blanca con barra de acento lateral.</summary>
        public static void EstilizarPanelAviso(Panel p, Color acento)
        {
            p.BackColor = Tarjeta;
            p.Tag = acento;
            p.Paint -= PintarAviso;
            p.Paint += PintarAviso;
        }

        private static void PintarAviso(object? sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;
            var acento = p.Tag is Color c ? c : Primario;
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = new Rectangle(0, 0, p.Width - 1, p.Height - 1);
            using var camino = Redondeado(rect, 10);
            using var borde = new Pen(Borde, 1);
            g.DrawPath(borde, camino);
            using var brocha = new SolidBrush(acento);
            g.FillRectangle(brocha, new Rectangle(0, 8, 5, p.Height - 16));
        }

        // ---------- Etiquetas ----------

        /// <summary>Etiqueta tipo "chip" con fondo de color y texto blanco.</summary>
        public static void Insignia(Label l, Color fondo)
        {
            l.AutoSize = true;
            l.BackColor = fondo;
            l.ForeColor = Color.White;
            l.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            l.Padding = new Padding(8, 3, 8, 3);
        }

        /// <summary>Etiqueta de resumen con color semántico.</summary>
        public static void Indicador(Label l, Color color)
        {
            l.AutoSize = true;
            l.ForeColor = color;
            l.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
        }

        public static void Titulo(Label l, Color? color = null)
        {
            l.AutoSize = true;
            l.Font = FuenteTitulo;
            l.ForeColor = color ?? Texto;
        }

        public static void Subtitulo(Label l, Color? color = null)
        {
            l.AutoSize = true;
            l.Font = FuenteSubtitulo;
            l.ForeColor = color ?? TextoSuave;
        }

        // ---------- DataGridView ----------

        public static void EstilizarGrid(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Borde;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Font = FuenteBase;

            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 40;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = PrimarioOscuro;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = PrimarioOscuro;
            dgv.ColumnHeadersDefaultCellStyle.Font = FuenteNegrita;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);

            dgv.RowTemplate.Height = 34;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Texto;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv.DefaultCellStyle.SelectionForeColor = Texto;
            dgv.DefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
        }

        // ---------- TabControl ----------

        public static void EstilizarTabs(TabControl tabs)
        {
            tabs.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabs.SizeMode = TabSizeMode.Fixed;
            tabs.ItemSize = new Size(180, 42);
            tabs.Padding = new Point(0, 0);
            tabs.Font = FuenteNegrita;
            tabs.DrawItem -= DibujarPestana;
            tabs.DrawItem += DibujarPestana;
            foreach (TabPage pagina in tabs.TabPages)
            {
                pagina.BackColor = Fondo;
                pagina.UseVisualStyleBackColor = false;
                pagina.BorderStyle = BorderStyle.None;
                pagina.Padding = new Padding(0);
            }
        }

        private static void DibujarPestana(object? sender, DrawItemEventArgs e)
        {
            if (sender is not TabControl tabs) return;
            var g = e.Graphics;
            var pagina = tabs.TabPages[e.Index];
            var rect = e.Bounds;
            bool activa = e.Index == tabs.SelectedIndex;

            using (var fondo = new SolidBrush(Fondo))
                g.FillRectangle(fondo, rect);

            if (activa)
            {
                using var blanco = new SolidBrush(Color.White);
                g.FillRectangle(blanco, rect);
                using var acento = new SolidBrush(Primario);
                g.FillRectangle(acento, new Rectangle(rect.X, rect.Bottom - 3, rect.Width, 3));
            }

            var fuente = activa ? FuenteNegrita : FuenteBase;
            var color = activa ? Primario : TextoSuave;
            TextRenderer.DrawText(g, pagina.Text, fuente, rect, color,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        // ---------- Utilidades ----------

        public static GraphicsPath Redondeado(Rectangle r, int radio)
        {
            int d = radio * 2;
            var camino = new GraphicsPath();
            camino.AddArc(r.X, r.Y, d, d, 180, 90);
            camino.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            camino.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            camino.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            camino.CloseFigure();
            return camino;
        }
    }
}
