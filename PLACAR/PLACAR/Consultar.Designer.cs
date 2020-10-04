namespace PLACAR
{
    partial class Consultar
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.btnjogos = new System.Windows.Forms.Button();
            this.btnminimo = new System.Windows.Forms.Button();
            this.btnmax = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncancelar.Location = new System.Drawing.Point(457, 168);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(107, 33);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtconsulta
            // 
            this.txtconsulta.Location = new System.Drawing.Point(351, 168);
            this.txtconsulta.Multiline = true;
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(100, 33);
            this.txtconsulta.TabIndex = 10;
            // 
            // btnjogos
            // 
            this.btnjogos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnjogos.Location = new System.Drawing.Point(238, 168);
            this.btnjogos.Name = "btnjogos";
            this.btnjogos.Size = new System.Drawing.Size(107, 33);
            this.btnjogos.TabIndex = 9;
            this.btnjogos.Text = "Total de jogos ";
            this.btnjogos.UseVisualStyleBackColor = false;
            this.btnjogos.Click += new System.EventHandler(this.btnjogos_Click);
            // 
            // btnminimo
            // 
            this.btnminimo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnminimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimo.Location = new System.Drawing.Point(125, 168);
            this.btnminimo.Name = "btnminimo";
            this.btnminimo.Size = new System.Drawing.Size(107, 33);
            this.btnminimo.TabIndex = 8;
            this.btnminimo.Text = "Placar minimo";
            this.btnminimo.UseVisualStyleBackColor = false;
            this.btnminimo.Click += new System.EventHandler(this.btnminimo_Click);
            // 
            // btnmax
            // 
            this.btnmax.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmax.Location = new System.Drawing.Point(12, 168);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(107, 33);
            this.btnmax.TabIndex = 7;
            this.btnmax.Text = "Placar maximo";
            this.btnmax.UseVisualStyleBackColor = false;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(721, 200);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Image = global::PLACAR.Properties.Resources.logo_publica;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 85);
            this.label1.TabIndex = 12;
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(745, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtconsulta);
            this.Controls.Add(this.btnjogos);
            this.Controls.Add(this.btnminimo);
            this.Controls.Add(this.btnmax);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Consultar";
            this.Text = "Consultar dados";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtconsulta;
        private System.Windows.Forms.Button btnjogos;
        private System.Windows.Forms.Button btnminimo;
        private System.Windows.Forms.Button btnmax;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}