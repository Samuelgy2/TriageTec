using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TriageTec
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            AplicarEstilos();
        }

        private void AplicarEstilos()
        {
            Tema.Aplicar(this);

            // Encabezado
            Tema.EstilizarEncabezado(panelEncabezado);
            Tema.BotonEncabezado(btnCerrarSesion);

            // Pestaña Usuarios
            Tema.BotonPrimario(btnNuevoUsuario);
            lblSeparador.ForeColor = Tema.Borde;
            lblBuscar.ForeColor = Tema.TextoSuave;
            lblRol.ForeColor = Tema.TextoSuave;
            lblEstado.ForeColor = Tema.TextoSuave;
            lblDetalleUsuario.ForeColor = Tema.TextoSuave;
            Tema.Indicador(lblActivos, Tema.Exito);
            Tema.Indicador(lblTecnicos, Tema.Advertencia);
            Tema.Indicador(lblInhabilitados, Tema.Peligro);

            // Pestaña Gestión de usuarios
            Tema.BotonPrimario(btnCrearCuenta);
            Tema.BotonSecundario(btnLimpiar);
            Tema.BotonPrimario(btnActualizarContrasena);
            Tema.BotonPeligro(btnInhabilitar);

            Tema.Insignia(lblAyudaAdminTitulo, Tema.Peligro);
            Tema.Insignia(lblAyudaTecnicoTitulo, Tema.Advertencia);
            Tema.Insignia(lblAyudaUsuarioTitulo, Tema.Exito);
            lblAyudaAdmin.ForeColor = Tema.TextoSuave;
            lblAyudaTecnico.ForeColor = Tema.TextoSuave;
            lblAyudaUsuario.ForeColor = Tema.TextoSuave;
        }
    }
}
