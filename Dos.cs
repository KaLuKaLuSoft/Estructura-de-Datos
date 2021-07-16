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
    public partial class Dos : Form
    {
        public Dos()
        {
            InitializeComponent();
        }
        int dato;
        clsListaSimple d = new clsListaSimple();
        private void btn_EliminarNodo_Click(object sender, EventArgs e)
        {
            dato = int.Parse(txt_Eliminar.Text);
            d.Elimnar(dato);
            listBox1.Items.RemoveAt(listBox1.Items.IndexOf(txt_Eliminar.Text));
        }
        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txt_Eliminar.Text);
            txt_Eliminar.Clear();
            txt_Eliminar.Focus();
        }
    }
}
