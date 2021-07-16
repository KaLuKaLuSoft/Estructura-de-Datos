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
    public partial class Cuatro : Form
    {
        public Cuatro()
        {
            InitializeComponent();
        }
        int dato;
        clsListaSimple d = new clsListaSimple();
        private void btn_Ordenar_Click(object sender, EventArgs e)
        {
            dato = int.Parse(txt_cuatro.Text);
            listBox1.Items.Add(txt_cuatro.Text);
            txt_cuatro.Clear();
            txt_cuatro.Focus();
        }

        private void btn_Sumar_Click(object sender, EventArgs e)
        {
            double suma = d.SumarElementos();
            foreach (object item in listBox1.Items)
            {
                suma += Convert.ToDouble(item);
            }
            txt_cuatro.Text = Convert.ToString("La suma es : " + suma);
        }
    }
}
