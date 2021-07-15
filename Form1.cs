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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            objPila = new clsPila();
            objCola = new clsCola();
        }
        private clsPila objPila;
        private clsCola objCola;
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(txtDato.Text);
            listBox1.Items.Add(txtDato.Text);
            objPila.push(dato);
            txtDato.Clear();
            txtDato.Focus();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int dato = objPila.pop();
            if (dato == -1)
            {
                MessageBox.Show(this, "La pila está vacía...");
            }
            else
            {
                listBox1.Items.RemoveAt(dato);
                //MessageBox.Show(this, (dato).ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_AgregarCola_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(txt_Cola.Text);
            listBox2.Items.Add(txt_Cola.Text);
            objCola.push(dato);
            txtDato.Clear();
            txtDato.Focus();
        }
    }
}
