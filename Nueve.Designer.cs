
namespace Estructura_de_Datos
{
    partial class Nueve
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
            this.btn_InsertarPrimero = new System.Windows.Forms.Button();
            this.lbl_InsertarPrimero = new System.Windows.Forms.ListBox();
            this.btn_InsertarDato = new System.Windows.Forms.Button();
            this.txt_nueve = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_InsertarPrimero);
            this.groupBox3.Controls.Add(this.lbl_InsertarPrimero);
            this.groupBox3.Controls.Add(this.btn_InsertarDato);
            this.groupBox3.Controls.Add(this.txt_nueve);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 415);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insertar Primero";
            // 
            // btn_InsertarPrimero
            // 
            this.btn_InsertarPrimero.Location = new System.Drawing.Point(139, 49);
            this.btn_InsertarPrimero.Name = "btn_InsertarPrimero";
            this.btn_InsertarPrimero.Size = new System.Drawing.Size(101, 44);
            this.btn_InsertarPrimero.TabIndex = 3;
            this.btn_InsertarPrimero.Text = "Insertar Primero";
            this.btn_InsertarPrimero.UseVisualStyleBackColor = true;
            this.btn_InsertarPrimero.Click += new System.EventHandler(this.btn_InsertarPrimero_Click);
            // 
            // lbl_InsertarPrimero
            // 
            this.lbl_InsertarPrimero.FormattingEnabled = true;
            this.lbl_InsertarPrimero.ItemHeight = 16;
            this.lbl_InsertarPrimero.Location = new System.Drawing.Point(6, 99);
            this.lbl_InsertarPrimero.Name = "lbl_InsertarPrimero";
            this.lbl_InsertarPrimero.Size = new System.Drawing.Size(253, 308);
            this.lbl_InsertarPrimero.TabIndex = 2;
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
            // txt_nueve
            // 
            this.txt_nueve.Location = new System.Drawing.Point(6, 21);
            this.txt_nueve.Name = "txt_nueve";
            this.txt_nueve.Size = new System.Drawing.Size(246, 22);
            this.txt_nueve.TabIndex = 0;
            // 
            // Nueve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 425);
            this.Controls.Add(this.groupBox3);
            this.Name = "Nueve";
            this.Text = "Nueve";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_InsertarPrimero;
        private System.Windows.Forms.ListBox lbl_InsertarPrimero;
        private System.Windows.Forms.Button btn_InsertarDato;
        private System.Windows.Forms.TextBox txt_nueve;
    }
}