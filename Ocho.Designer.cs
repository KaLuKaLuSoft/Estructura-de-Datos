
namespace Estructura_de_Datos
{
    partial class Ocho
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
            this.btn_InsertarUltimo = new System.Windows.Forms.Button();
            this.lbl_InsertarUltimo = new System.Windows.Forms.ListBox();
            this.btn_InsertarDato = new System.Windows.Forms.Button();
            this.txt_ocho = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_InsertarUltimo);
            this.groupBox3.Controls.Add(this.lbl_InsertarUltimo);
            this.groupBox3.Controls.Add(this.btn_InsertarDato);
            this.groupBox3.Controls.Add(this.txt_ocho);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 415);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insertar Último";
            // 
            // btn_InsertarUltimo
            // 
            this.btn_InsertarUltimo.Location = new System.Drawing.Point(139, 49);
            this.btn_InsertarUltimo.Name = "btn_InsertarUltimo";
            this.btn_InsertarUltimo.Size = new System.Drawing.Size(101, 44);
            this.btn_InsertarUltimo.TabIndex = 3;
            this.btn_InsertarUltimo.Text = "Eliminar Nodo";
            this.btn_InsertarUltimo.UseVisualStyleBackColor = true;
            this.btn_InsertarUltimo.Click += new System.EventHandler(this.btn_InsertarUltimo_Click);
            // 
            // lbl_InsertarUltimo
            // 
            this.lbl_InsertarUltimo.FormattingEnabled = true;
            this.lbl_InsertarUltimo.ItemHeight = 16;
            this.lbl_InsertarUltimo.Location = new System.Drawing.Point(6, 99);
            this.lbl_InsertarUltimo.Name = "lbl_InsertarUltimo";
            this.lbl_InsertarUltimo.Size = new System.Drawing.Size(253, 308);
            this.lbl_InsertarUltimo.TabIndex = 2;
            // 
            // btn_InsertarDato
            // 
            this.btn_InsertarDato.Location = new System.Drawing.Point(19, 49);
            this.btn_InsertarDato.Name = "btn_InsertarDato";
            this.btn_InsertarDato.Size = new System.Drawing.Size(93, 39);
            this.btn_InsertarDato.TabIndex = 1;
            this.btn_InsertarDato.Text = "Insertar";
            this.btn_InsertarDato.UseVisualStyleBackColor = true;
            this.btn_InsertarDato.Click += new System.EventHandler(this.btn_InsertarDato_Click);
            // 
            // txt_ocho
            // 
            this.txt_ocho.Location = new System.Drawing.Point(6, 21);
            this.txt_ocho.Name = "txt_ocho";
            this.txt_ocho.Size = new System.Drawing.Size(246, 22);
            this.txt_ocho.TabIndex = 0;
            // 
            // Ocho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 431);
            this.Controls.Add(this.groupBox3);
            this.Name = "Ocho";
            this.Text = "Ocho";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_InsertarUltimo;
        private System.Windows.Forms.ListBox lbl_InsertarUltimo;
        private System.Windows.Forms.Button btn_InsertarDato;
        private System.Windows.Forms.TextBox txt_ocho;
    }
}