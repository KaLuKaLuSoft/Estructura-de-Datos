
namespace Estructura_de_Datos
{
    partial class Tres
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
            this.btn_EliNodo = new System.Windows.Forms.Button();
            this.lbl_EliNodo = new System.Windows.Forms.ListBox();
            this.btn_InsertarNodo = new System.Windows.Forms.Button();
            this.txt_EliminarNodo = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_EliNodo);
            this.groupBox3.Controls.Add(this.lbl_EliNodo);
            this.groupBox3.Controls.Add(this.btn_InsertarNodo);
            this.groupBox3.Controls.Add(this.txt_EliminarNodo);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 415);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar Nodo de una Posición";
            // 
            // btn_EliNodo
            // 
            this.btn_EliNodo.Location = new System.Drawing.Point(139, 49);
            this.btn_EliNodo.Name = "btn_EliNodo";
            this.btn_EliNodo.Size = new System.Drawing.Size(101, 44);
            this.btn_EliNodo.TabIndex = 3;
            this.btn_EliNodo.Text = "Eliminar Nodo";
            this.btn_EliNodo.UseVisualStyleBackColor = true;
            this.btn_EliNodo.Click += new System.EventHandler(this.btn_EliNodo_Click);
            // 
            // lbl_EliNodo
            // 
            this.lbl_EliNodo.FormattingEnabled = true;
            this.lbl_EliNodo.ItemHeight = 16;
            this.lbl_EliNodo.Location = new System.Drawing.Point(6, 99);
            this.lbl_EliNodo.Name = "lbl_EliNodo";
            this.lbl_EliNodo.Size = new System.Drawing.Size(253, 308);
            this.lbl_EliNodo.TabIndex = 2;
            // 
            // btn_InsertarNodo
            // 
            this.btn_InsertarNodo.Location = new System.Drawing.Point(19, 49);
            this.btn_InsertarNodo.Name = "btn_InsertarNodo";
            this.btn_InsertarNodo.Size = new System.Drawing.Size(93, 39);
            this.btn_InsertarNodo.TabIndex = 1;
            this.btn_InsertarNodo.Text = "Insertar";
            this.btn_InsertarNodo.UseVisualStyleBackColor = true;
            this.btn_InsertarNodo.Click += new System.EventHandler(this.btn_Ordenar_Click);
            // 
            // txt_EliminarNodo
            // 
            this.txt_EliminarNodo.Location = new System.Drawing.Point(6, 21);
            this.txt_EliminarNodo.Name = "txt_EliminarNodo";
            this.txt_EliminarNodo.Size = new System.Drawing.Size(246, 22);
            this.txt_EliminarNodo.TabIndex = 0;
            // 
            // Tres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 430);
            this.Controls.Add(this.groupBox3);
            this.Name = "Tres";
            this.Text = "Tres";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbl_EliNodo;
        private System.Windows.Forms.Button btn_InsertarNodo;
        private System.Windows.Forms.TextBox txt_EliminarNodo;
        private System.Windows.Forms.Button btn_EliNodo;
    }
}