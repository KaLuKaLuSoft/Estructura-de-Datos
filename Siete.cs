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
    public partial class Siete : Form
    {
        public Siete()
        {
            InitializeComponent();
        }
        int dato;
        clsListaSimple d = new clsListaSimple();
        private void btn_InsertarDato_Click(object sender, EventArgs e)
        {
            dato = int.Parse(txt_siete.Text);
            listBox1.Items.Add(txt_siete.Text);
            txt_siete.Clear();
            txt_siete.Focus();
        }

        private void btn_Promedio_Click(object sender, EventArgs e)
        {
            double promedio = d.Promedio();
            foreach (var item in listBox1.Items)
            {
                promedio += Convert.ToDouble(item);
            }
            txt_siete.Text = "El promedio es: " +  (promedio / (double)listBox1.Items.Count).ToString();
        }
    }
}
