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
        }
        private clsPila objPila;
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
                listBox1.Items.Remove(dato);
                MessageBox.Show(this, (dato).ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        } 
    }
}
