
namespace Estructura_de_Datos
{
    partial class Dos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_EliminarNodo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.txt_Eliminar = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_EliminarNodo);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.btn_Insertar);
            this.groupBox3.Controls.Add(this.txt_Eliminar);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 415);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar Nodo de una Lista";
            // 
            // btn_EliminarNodo
            // 
            this.btn_EliminarNodo.Location = new System.Drawing.Point(137, 46);
            this.btn_EliminarNodo.Name = "btn_EliminarNodo";
            this.btn_EliminarNodo.Size = new System.Drawing.Size(93, 44);
            this.btn_EliminarNodo.TabIndex = 3;
            this.btn_EliminarNodo.Text = "Eliminar Nodo";
            this.btn_EliminarNodo.UseVisualStyleBackColor = true;
            this.btn_EliminarNodo.Click += new System.EventHandler(this.btn_EliminarNodo_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 308);
            this.listBox1.TabIndex = 2;
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(23, 49);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(93, 39);
            this.btn_Insertar.TabIndex = 1;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // txt_Eliminar
            // 
            this.txt_Eliminar.Location = new System.Drawing.Point(6, 21);
            this.txt_Eliminar.Name = "txt_Eliminar";
            this.txt_Eliminar.Size = new System.Drawing.Size(246, 22);
            this.txt_Eliminar.TabIndex = 0;
            // 
            // Dos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 433);
            this.Controls.Add(this.groupBox3);
            this.Name = "Dos";
            this.Text = "Dos";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.TextBox txt_Eliminar;
        private System.Windows.Forms.Button btn_EliminarNodo;
    }
}