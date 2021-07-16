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
    public partial class Tres : Form
    {
        public Tres()
        {
            InitializeComponent();
        }
        int dato;
        clsListaSimple d = new clsListaSimple();
        private void btn_Ordenar_Click(object sender, EventArgs e)
        {
            lbl_EliNodo.Items.Add(txt_EliminarNodo.Text);
            txt_EliminarNodo.Clear();
            txt_EliminarNodo.Focus();      
        }
        private void btn_EliNodo_Click(object sender, EventArgs e)
        {
            dato = int.Parse(txt_EliminarNodo.Text);
            d.EliminarPorPosicion(dato);
            lbl_EliNodo.Items.RemoveAt(lbl_EliNodo.Items.Count - dato);

        }
    }
}
