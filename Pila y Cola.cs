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
            lbl_Pila.Items.Add(txtDato.Text);
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
                //dato = Convert.ToInt32(txtDato.Text);
                lbl_Pila.Items.RemoveAt(lbl_Pila.Items.Count - 1);
                //lbl_Pila.Items.RemoveAt(lbl_Pila.Items.IndexOf(txtDato.Text));
                MessageBox.Show(this, (dato).ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btn_AgregarCola_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(txt_Cola.Text);
            lbl_Cola.Items.Add(txt_Cola.Text);
            objCola.push(dato);
            txt_Cola.Clear();
            txt_Cola.Focus();
        }
        private void btn_EliminarCola_Click(object sender, EventArgs e)
        {
            int dato = objCola.pop();
            if (dato == -1)
            {
                MessageBox.Show(this, "La cola está vacía...");
            }
            else
            {
                MessageBox.Show(this, (dato).ToString());
            }
        }
        private void btn_Ordenar_Click(object sender, EventArgs e)
        {
            

        }
    }
}
