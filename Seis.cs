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
    public partial class Seis : Form
    {
        public Seis()
        {
            InitializeComponent();
        }
        int dato;
        clsListaSimple d = new clsListaSimple();
        private void btn_InsertarNodo_Click(object sender, EventArgs e)
        {
            dato = int.Parse(txt_seis.Text);
            listBox1.Items.Add(txt_seis.Text);
            txt_seis.Clear();
            txt_seis.Focus();
        }
        private void btn_CantNodos_Click(object sender, EventArgs e)
        {
            //txt_seis.Text = listBox1.SelectedItem.ToString(); 
            dato = d.canNodos();
            //foreach (object item in listBox1.Items)
            //{
            //    dato += Convert.ToInt32(item);
            //}
            txt_seis.Text = Convert.ToString("La suma es : " + dato);
        }
    }
}
