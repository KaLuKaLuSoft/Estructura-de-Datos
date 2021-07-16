
namespace Estructura_de_Datos
{
    partial class Cinco
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
            this.btn_VerPrimos = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_InsertarPrimo = new System.Windows.Forms.Button();
            this.txt_cuatro = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_VerPrimos);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.btn_InsertarPrimo);
            this.groupBox3.Controls.Add(this.txt_cuatro);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 415);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cantidad de Elementos Primos";
            // 
            // btn_VerPrimos
            // 
            this.btn_VerPrimos.Location = new System.Drawing.Point(140, 54);
            this.btn_VerPrimos.Name = "btn_VerPrimos";
            this.btn_VerPrimos.Size = new System.Drawing.Size(93, 39);
            this.btn_VerPrimos.TabIndex = 3;
            this.btn_VerPrimos.Text = "Ver Primos";
            this.btn_VerPrimos.UseVisualStyleBackColor = true;
            this.btn_VerPrimos.Click += new System.EventHandler(this.btn_VerPrimos_Click);
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
            // btn_InsertarPrimo
            // 
            this.btn_InsertarPrimo.Location = new System.Drawing.Point(6, 54);
            this.btn_InsertarPrimo.Name = "btn_InsertarPrimo";
            this.btn_InsertarPrimo.Size = new System.Drawing.Size(93, 39);
            this.btn_InsertarPrimo.TabIndex = 1;
            this.btn_InsertarPrimo.Text = "Insertar";
            this.btn_InsertarPrimo.UseVisualStyleBackColor = true;
            this.btn_InsertarPrimo.Click += new System.EventHandler(this.btn_InsertarPrimo_Click);
            // 
            // txt_cuatro
            // 
            this.txt_cuatro.Location = new System.Drawing.Point(6, 21);
            this.txt_cuatro.Name = "txt_cuatro";
            this.txt_cuatro.Size = new System.Drawing.Size(246, 22);
            this.txt_cuatro.TabIndex = 0;
            // 
            // Cinco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 425);
            this.Controls.Add(this.groupBox3);
            this.Name = "Cinco";
            this.Text = "Cinco";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_VerPrimos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_InsertarPrimo;
        private System.Windows.Forms.TextBox txt_cuatro;
    }
}