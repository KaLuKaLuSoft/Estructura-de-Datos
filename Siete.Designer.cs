
namespace Estructura_de_Datos
{
    partial class Siete
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
            this.btn_Promedio = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_InsertarDato = new System.Windows.Forms.Button();
            this.txt_siete = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Promedio);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.btn_InsertarDato);
            this.groupBox3.Controls.Add(this.txt_siete);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 415);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Promedio de Lista Simple";
            // 
            // btn_Promedio
            // 
            this.btn_Promedio.Location = new System.Drawing.Point(140, 54);
            this.btn_Promedio.Name = "btn_Promedio";
            this.btn_Promedio.Size = new System.Drawing.Size(93, 39);
            this.btn_Promedio.TabIndex = 3;
            this.btn_Promedio.Text = "Promedio";
            this.btn_Promedio.UseVisualStyleBackColor = true;
            this.btn_Promedio.Click += new System.EventHandler(this.btn_Promedio_Click);
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
            // btn_InsertarDato
            // 
            this.btn_InsertarDato.Location = new System.Drawing.Point(6, 54);
            this.btn_InsertarDato.Name = "btn_InsertarDato";
            this.btn_InsertarDato.Size = new System.Drawing.Size(93, 39);
            this.btn_InsertarDato.TabIndex = 1;
            this.btn_InsertarDato.Text = "Insertar";
            this.btn_InsertarDato.UseVisualStyleBackColor = true;
            this.btn_InsertarDato.Click += new System.EventHandler(this.btn_InsertarDato_Click);
            // 
            // txt_siete
            // 
            this.txt_siete.Location = new System.Drawing.Point(6, 21);
            this.txt_siete.Name = "txt_siete";
            this.txt_siete.Size = new System.Drawing.Size(246, 22);
            this.txt_siete.TabIndex = 0;
            // 
            // Siete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 434);
            this.Controls.Add(this.groupBox3);
            this.Name = "Siete";
            this.Text = "Siete";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Promedio;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_InsertarDato;
        private System.Windows.Forms.TextBox txt_siete;
    }
}