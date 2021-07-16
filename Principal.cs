using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_de_Datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ordenado_Click(object sender, EventArgs e)
        {
            Uno uno = new Uno();
            uno.Show();
        }

        private void btn_EliminarNodo_Click(object sender, EventArgs e)
        {
            Dos dos = new Dos();
            dos.Show();
        }

        private void btn_EliminarNodoPos_Click(object sender, EventArgs e)
        {
            Tres tres = new Tres();
            tres.Show();
        }

        private void btn_SumaElementos_Click(object sender, EventArgs e)
        {
            Cuatro cuatro = new Cuatro();
            cuatro.Show();
        }

        private void btn_CantidadPrimo_Click(object sender, EventArgs e)
        {
            Cinco cinco = new Cinco();
            cinco.Show();
        }

        private void btn_CantidadNodos_Click(object sender, EventArgs e)
        {
            Seis seis = new Seis();
            seis.Show();
        }

        private void btn_ProListaSimple_Click(object sender, EventArgs e)
        {
            Siete siete = new Siete();
            siete.Show();
        }

        private void btn_InsertarPrimero_Click(object sender, EventArgs e)
        {
            Ocho ocho = new Ocho();
            ocho.Show();
        }

        private void btn_InsertarUltimo_Click(object sender, EventArgs e)
        {
            Nueve nueve = new Nueve();
            nueve.Show();
        }

        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            Diez diez = new Diez();
            diez.Show();
        }
    }
}
