namespace PLACAR
{
    partial class Calcular
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
            this.btncancela = new System.Windows.Forms.Button();
            this.btncalmin = new System.Windows.Forms.Button();
            this.btncamin = new System.Windows.Forms.Button();
            this.btnrecmax = new System.Windows.Forms.Button();
            this.btncalmax = new System.Windows.Forms.Button();
            this.btncalpla = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncancela
            // 
            this.btncancela.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncancela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancela.Location = new System.Drawing.Point(12, 288);
            this.btncancela.Name = "btncancela";
            this.btncancela.Size = new System.Drawing.Size(156, 31);
            this.btncancela.TabIndex = 14;
            this.btncancela.Text = "Cancelar";
            this.btncancela.UseVisualStyleBackColor = false;
            this.btncancela.Click += new System.EventHandler(this.btncancela_Click);
            // 
            // btncalmin
            // 
            this.btncalmin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncalmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalmin.Location = new System.Drawing.Point(12, 177);
            this.btncalmin.Name = "btncalmin";
            this.btncalmin.Size = new System.Drawing.Size(156, 31);
            this.btncalmin.TabIndex = 13;
            this.btncalmin.Text = "Calcular minimo";
            this.btncalmin.UseVisualStyleBackColor = false;
            this.btncalmin.Click += new System.EventHandler(this.btncalmin_Click);
            // 
            // btncamin
            // 
            this.btncamin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncamin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncamin.Location = new System.Drawing.Point(12, 251);
            this.btncamin.Name = "btncamin";
            this.btncamin.Size = new System.Drawing.Size(156, 31);
            this.btncamin.TabIndex = 12;
            this.btncamin.Text = "Recorde minimo";
            this.btncamin.UseVisualStyleBackColor = false;
            this.btncamin.Click += new System.EventHandler(this.btncamin_Click);
            // 
            // btnrecmax
            // 
            this.btnrecmax.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnrecmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecmax.Location = new System.Drawing.Point(12, 214);
            this.btnrecmax.Name = "btnrecmax";
            this.btnrecmax.Size = new System.Drawing.Size(156, 31);
            this.btnrecmax.TabIndex = 11;
            this.btnrecmax.Text = "Recorde maximo";
            this.btnrecmax.UseVisualStyleBackColor = false;
            this.btnrecmax.Click += new System.EventHandler(this.btnrecmax_Click);
            // 
            // btncalmax
            // 
            this.btncalmax.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncalmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalmax.Location = new System.Drawing.Point(12, 140);
            this.btncalmax.Name = "btncalmax";
            this.btncalmax.Size = new System.Drawing.Size(156, 31);
            this.btncalmax.TabIndex = 10;
            this.btncalmax.Text = "calcular maximo";
            this.btncalmax.UseVisualStyleBackColor = false;
            this.btncalmax.Click += new System.EventHandler(this.btncalmax_Click);
            // 
            // btncalpla
            // 
            this.btncalpla.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncalpla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalpla.Location = new System.Drawing.Point(12, 103);
            this.btncalpla.Name = "btncalpla";
            this.btncalpla.Size = new System.Drawing.Size(156, 31);
            this.btncalpla.TabIndex = 9;
            this.btncalpla.Text = "Calcular placar";
            this.btncalpla.UseVisualStyleBackColor = false;
            this.btncalpla.Click += new System.EventHandler(this.btncalpla_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(12, 66);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(156, 31);
            this.txttotal.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Image = global::PLACAR.Properties.Resources.logo_publica6;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 54);
            this.label1.TabIndex = 15;
            // 
            // Calcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(181, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancela);
            this.Controls.Add(this.btncalmin);
            this.Controls.Add(this.btncamin);
            this.Controls.Add(this.btnrecmax);
            this.Controls.Add(this.btncalmax);
            this.Controls.Add(this.btncalpla);
            this.Controls.Add(this.txttotal);
            this.Name = "Calcular";
            this.Text = "Calcular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancela;
        private System.Windows.Forms.Button btncalmin;
        private System.Windows.Forms.Button btncamin;
        private System.Windows.Forms.Button btnrecmax;
        private System.Windows.Forms.Button btncalmax;
        private System.Windows.Forms.Button btncalpla;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label1;
    }
}