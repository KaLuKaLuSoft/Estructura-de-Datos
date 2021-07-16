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
    public partial class Uno : Form
    {
        public Uno()
        {
            InitializeComponent();
            objLista = new clsListaSimple();
            
        }
        int dato;
        private clsListaSimple objLista;
        private void btn_Ordenar_Click(object sender, EventArgs e)
        {
            dato = int.Parse(txt_Ordenado.Text);
            listBox1.Items.Add(txt_Ordenado.Text);
            txt_Ordenado.Clear();
            txt_Ordenado.Focus();
        }

        private void Uno_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ordenar2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
