
namespace Estructura_de_Datos
{
    partial class Seis
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
            this.btn_CantNodos = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_InsertarNodo = new System.Windows.Forms.Button();
            this.txt_seis = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_CantNodos);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.btn_InsertarNodo);
            this.groupBox3.Controls.Add(this.txt_seis);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 415);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cantidad de Elementos de Nodos";
            // 
            // btn_CantNodos
            // 
            this.btn_CantNodos.Location = new System.Drawing.Point(135, 49);
            this.btn_CantNodos.Name = "btn_CantNodos";
            this.btn_CantNodos.Size = new System.Drawing.Size(92, 44);
            this.btn_CantNodos.TabIndex = 3;
            this.btn_CantNodos.Text = "Cantidad Nodos";
            this.btn_CantNodos.UseVisualStyleBackColor = true;
            this.btn_CantNodos.Click += new System.EventHandler(this.btn_CantNodos_Click);
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
            // btn_InsertarNodo
            // 
            this.btn_InsertarNodo.Location = new System.Drawing.Point(6, 54);
            this.btn_InsertarNodo.Name = "btn_InsertarNodo";
            this.btn_InsertarNodo.Size = new System.Drawing.Size(93, 39);
            this.btn_InsertarNodo.TabIndex = 1;
            this.btn_InsertarNodo.Text = "Insertar";
            this.btn_InsertarNodo.UseVisualStyleBackColor = true;
            this.btn_InsertarNodo.Click += new System.EventHandler(this.btn_InsertarNodo_Click);
            // 
            // txt_seis
            // 
            this.txt_seis.Location = new System.Drawing.Point(6, 21);
            this.txt_seis.Name = "txt_seis";
            this.txt_seis.Size = new System.Drawing.Size(246, 22);
            this.txt_seis.TabIndex = 0;
            // 
            // Seis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 434);
            this.Controls.Add(this.groupBox3);
            this.Name = "Seis";
            this.Text = "Seis";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_CantNodos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_InsertarNodo;
        private System.Windows.Forms.TextBox txt_seis;
    }
}