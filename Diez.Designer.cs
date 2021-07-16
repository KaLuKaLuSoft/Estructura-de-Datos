
namespace Estructura_de_Datos
{
    partial class Diez
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
            this.lbl_Verificar = new System.Windows.Forms.ListBox();
            this.btn_InsertarDato = new System.Windows.Forms.Button();
            this.txt_diez = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_Verificar);
            this.groupBox3.Controls.Add(this.btn_InsertarDato);
            this.groupBox3.Controls.Add(this.txt_diez);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 415);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Verificar";
            // 
            // lbl_Verificar
            // 
            this.lbl_Verificar.FormattingEnabled = true;
            this.lbl_Verificar.ItemHeight = 16;
            this.lbl_Verificar.Location = new System.Drawing.Point(6, 99);
            this.lbl_Verificar.Name = "lbl_Verificar";
            this.lbl_Verificar.Size = new System.Drawing.Size(253, 308);
            this.lbl_Verificar.TabIndex = 2;
            // 
            // btn_InsertarDato
            // 
            this.btn_InsertarDato.Location = new System.Drawing.Point(78, 49);
            this.btn_InsertarDato.Name = "btn_InsertarDato";
            this.btn_InsertarDato.Size = new System.Drawing.Size(93, 39);
            this.btn_InsertarDato.TabIndex = 1;
            this.btn_InsertarDato.Text = "Verificar";
            this.btn_InsertarDato.UseVisualStyleBackColor = true;
            // 
            // txt_diez
            // 
            this.txt_diez.Location = new System.Drawing.Point(6, 21);
            this.txt_diez.Name = "txt_diez";
            this.txt_diez.Size = new System.Drawing.Size(246, 22);
            this.txt_diez.TabIndex = 0;
            // 
            // Diez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 430);
            this.Controls.Add(this.groupBox3);
            this.Name = "Diez";
            this.Text = "Diez";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbl_Verificar;
        private System.Windows.Forms.Button btn_InsertarDato;
        private System.Windows.Forms.TextBox txt_diez;
    }
}