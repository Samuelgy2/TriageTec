using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TriageTec
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            AplicarEstilos();
        }

        private void AplicarEstilos()
        {
            Tema.Aplicar(this);

            // Encabezado
            Tema.EstilizarEncabezado(panelEncabezado);
            Tema.BotonEncabezado(button4);

            // Pestaña Equipos
            Tema.BotonPrimario(button1);
            label1.ForeColor = Tema.Borde;
            label3.ForeColor = Tema.TextoSuave;
            label4.ForeColor = Tema.TextoSuave;
            label5.ForeColor = Tema.TextoSuave;
            Tema.Indicador(label6, Tema.Exito);
            Tema.Indicador(label7, Tema.Advertencia);
            Tema.Indicador(label8, Tema.Peligro);

            // Pestaña Nuevo reporte
            Tema.BotonPrimario(button2);
            Tema.BotonSecundario(button3);
            Tema.EstilizarPanelAviso(panel1, Tema.Info);
            label11.Font = Tema.FuenteTarjeta;
            label11.ForeColor = Tema.Info;
            label12.ForeColor = Tema.TextoSuave;
            label13.ForeColor = Tema.TextoSuave;

            Tema.Insignia(label14, Tema.Peligro);
            Tema.Insignia(label16, Tema.Advertencia);
            Tema.Insignia(label19, Tema.Exito);
            Tema.Insignia(label21, Tema.TextoSuave);
            label15.ForeColor = Tema.TextoSuave;
            label17.ForeColor = Tema.TextoSuave;
            label18.ForeColor = Tema.TextoSuave;
            label20.ForeColor = Tema.TextoSuave;

            // Pestaña Reportes pendientes
            label22.ForeColor = Tema.TextoSuave;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
