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
    public partial class Cinco : Form
    {
        public Cinco()
        {
            InitializeComponent();
        }
        int dato;
        clsListaSimple d = new clsListaSimple();
        private void btn_InsertarPrimo_Click(object sender, EventArgs e)
        {
            dato = int.Parse(txt_cuatro.Text);
            listBox1.Items.Add(txt_cuatro.Text);
            txt_cuatro.Clear();
            txt_cuatro.Focus();
        }

        private void btn_VerPrimos_Click(object sender, EventArgs e)
        {
            d.cantPrimos(txt_cuatro.Text);

        }
    }
}
