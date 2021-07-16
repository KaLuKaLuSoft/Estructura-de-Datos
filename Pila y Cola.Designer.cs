
namespace Estructura_de_Datos
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDato = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Pila = new System.Windows.Forms.ListBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Cola = new System.Windows.Forms.ListBox();
            this.btn_EliminarCola = new System.Windows.Forms.Button();
            this.btn_AgregarCola = new System.Windows.Forms.Button();
            this.txt_Cola = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(6, 21);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(194, 22);
            this.txtDato.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Pila);
            this.groupBox1.Controls.Add(this.btn_Eliminar);
            this.groupBox1.Controls.Add(this.btn_Agregar);
            this.groupBox1.Controls.Add(this.txtDato);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 415);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pila";
            // 
            // lbl_Pila
            // 
            this.lbl_Pila.FormattingEnabled = true;
            this.lbl_Pila.ItemHeight = 16;
            this.lbl_Pila.Location = new System.Drawing.Point(6, 100);
            this.lbl_Pila.Name = "lbl_Pila";
            this.lbl_Pila.Size = new System.Drawing.Size(194, 308);
            this.lbl_Pila.TabIndex = 8;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(106, 49);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(94, 39);
            this.btn_Eliminar.TabIndex = 5;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(6, 49);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(94, 39);
            this.btn_Agregar.TabIndex = 4;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Cola);
            this.groupBox2.Controls.Add(this.btn_EliminarCola);
            this.groupBox2.Controls.Add(this.btn_AgregarCola);
            this.groupBox2.Controls.Add(this.txt_Cola);
            this.groupBox2.Location = new System.Drawing.Point(224, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 415);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cola";
            // 
            // lbl_Cola
            // 
            this.lbl_Cola.FormattingEnabled = true;
            this.lbl_Cola.ItemHeight = 16;
            this.lbl_Cola.Location = new System.Drawing.Point(6, 100);
            this.lbl_Cola.Name = "lbl_Cola";
            this.lbl_Cola.Size = new System.Drawing.Size(194, 308);
            this.lbl_Cola.TabIndex = 4;
            // 
            // btn_EliminarCola
            // 
            this.btn_EliminarCola.Location = new System.Drawing.Point(106, 49);
            this.btn_EliminarCola.Name = "btn_EliminarCola";
            this.btn_EliminarCola.Size = new System.Drawing.Size(94, 39);
            this.btn_EliminarCola.TabIndex = 3;
            this.btn_EliminarCola.Text = "Eliminar";
            this.btn_EliminarCola.UseVisualStyleBackColor = true;
            this.btn_EliminarCola.Click += new System.EventHandler(this.btn_EliminarCola_Click);
            // 
            // btn_AgregarCola
            // 
            this.btn_AgregarCola.Location = new System.Drawing.Point(6, 49);
            this.btn_AgregarCola.Name = "btn_AgregarCola";
            this.btn_AgregarCola.Size = new System.Drawing.Size(94, 39);
            this.btn_AgregarCola.TabIndex = 2;
            this.btn_AgregarCola.Text = "Agregar";
            this.btn_AgregarCola.UseVisualStyleBackColor = true;
            this.btn_AgregarCola.Click += new System.EventHandler(this.btn_AgregarCola_Click);
            // 
            // txt_Cola
            // 
            this.txt_Cola.Location = new System.Drawing.Point(6, 21);
            this.txt_Cola.Name = "txt_Cola";
            this.txt_Cola.Size = new System.Drawing.Size(194, 22);
            this.txt_Cola.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 434);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Cola;
        private System.Windows.Forms.Button btn_AgregarCola;
        private System.Windows.Forms.Button btn_EliminarCola;
        private System.Windows.Forms.ListBox lbl_Pila;
        private System.Windows.Forms.ListBox lbl_Cola;
    }
}

