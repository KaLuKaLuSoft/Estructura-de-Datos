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
    public partial class Ocho : Form
    {
        public Ocho()
        {
            InitializeComponent();
        }
        int dato;
        clsListaSimple d = new clsListaSimple();
        private void btn_InsertarDato_Click(object sender, EventArgs e)
        {
            lbl_InsertarUltimo.Items.Add(txt_ocho.Text);
            txt_ocho.Clear();
            txt_ocho.Focus();
        }
        private void btn_InsertarUltimo_Click(object sender, EventArgs e)
        {
            d.InsertarUltimo(dato);
            dato = lbl_InsertarUltimo.Items.Add(txt_ocho.Text);
            //lbl_InsertarUltimo.Items.Add(lbl_InsertarUltimo.Items.Count + dato);
            //for (int i = lbl_InsertarUltimo.SelectedItems.Count - 1; i >= 0; i--)
            //{
            //    lbl_InsertarUltimo.Items.Add(lbl_InsertarUltimo.SelectedItems[i]);
                
            //}

        }
    }
}
