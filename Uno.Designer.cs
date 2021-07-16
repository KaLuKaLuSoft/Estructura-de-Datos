
namespace Estructura_de_Datos
{
    partial class Uno
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Ordenar = new System.Windows.Forms.Button();
            this.txt_Ordenado = new System.Windows.Forms.TextBox();
            this.btn_Ordenar2 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Ordenar2);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.btn_Ordenar);
            this.groupBox3.Controls.Add(this.txt_Ordenado);
            this.groupBox3.Location = new System.Drawing.Point(12, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 415);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insertar Ordenado de Menor a Mayor";
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
            // btn_Ordenar
            // 
            this.btn_Ordenar.Location = new System.Drawing.Point(6, 54);
            this.btn_Ordenar.Name = "btn_Ordenar";
            this.btn_Ordenar.Size = new System.Drawing.Size(93, 39);
            this.btn_Ordenar.TabIndex = 1;
            this.btn_Ordenar.Text = "Insertar";
            this.btn_Ordenar.UseVisualStyleBackColor = true;
            this.btn_Ordenar.Click += new System.EventHandler(this.btn_Ordenar_Click);
            // 
            // txt_Ordenado
            // 
            this.txt_Ordenado.Location = new System.Drawing.Point(6, 21);
            this.txt_Ordenado.Name = "txt_Ordenado";
            this.txt_Ordenado.Size = new System.Drawing.Size(246, 22);
            this.txt_Ordenado.TabIndex = 0;
            // 
            // btn_Ordenar2
            // 
            this.btn_Ordenar2.Location = new System.Drawing.Point(140, 54);
            this.btn_Ordenar2.Name = "btn_Ordenar2";
            this.btn_Ordenar2.Size = new System.Drawing.Size(93, 39);
            this.btn_Ordenar2.TabIndex = 3;
            this.btn_Ordenar2.Text = "Ordenar";
            this.btn_Ordenar2.UseVisualStyleBackColor = true;
            this.btn_Ordenar2.Click += new System.EventHandler(this.btn_Ordenar2_Click);
            // 
            // Uno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 450);
            this.Controls.Add(this.groupBox3);
            this.Name = "Uno";
            this.Text = "Uno";
            this.Load += new System.EventHandler(this.Uno_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Ordenar;
        private System.Windows.Forms.TextBox txt_Ordenado;
        private System.Windows.Forms.Button btn_Ordenar2;
    }
}