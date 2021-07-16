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
    public partial class Nueve : Form
    {
        public Nueve()
        {
            InitializeComponent();
        }
        int dato;
        clsListaSimple d = new clsListaSimple();
        private void btn_InsertarDato_Click(object sender, EventArgs e)
        {
            lbl_InsertarPrimero.Items.Add(txt_nueve.Text);
            txt_nueve.Clear();
            txt_nueve.Focus();
        }
        private void btn_InsertarPrimero_Click(object sender, EventArgs e)
        {
            d.InsertarInicio(dato);
            dato = lbl_InsertarPrimero.Items.Add(txt_nueve.Text);
            //txt_nueve.Text = dato.ToString();
        }
    }
}
