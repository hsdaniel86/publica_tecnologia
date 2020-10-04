namespace PLACAR
{
    partial class Inserir
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btninserir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtplacar = new System.Windows.Forms.TextBox();
            this.txtmintemp = new System.Windows.Forms.TextBox();
            this.txtmaxtemp = new System.Windows.Forms.TextBox();
            this.txtrecmin = new System.Windows.Forms.TextBox();
            this.txtrecmax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btninserir
            // 
            this.btninserir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btninserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserir.Location = new System.Drawing.Point(412, 205);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(84, 35);
            this.btninserir.TabIndex = 1;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = false;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(501, 205);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(84, 35);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtplacar
            // 
            this.txtplacar.Location = new System.Drawing.Point(476, 75);
            this.txtplacar.Name = "txtplacar";
            this.txtplacar.Size = new System.Drawing.Size(100, 20);
            this.txtplacar.TabIndex = 3;
            // 
            // txtmintemp
            // 
            this.txtmintemp.Location = new System.Drawing.Point(420, 101);
            this.txtmintemp.Name = "txtmintemp";
            this.txtmintemp.Size = new System.Drawing.Size(100, 20);
            this.txtmintemp.TabIndex = 4;
            // 
            // txtmaxtemp
            // 
            this.txtmaxtemp.Location = new System.Drawing.Point(476, 127);
            this.txtmaxtemp.Name = "txtmaxtemp";
            this.txtmaxtemp.Size = new System.Drawing.Size(100, 20);
            this.txtmaxtemp.TabIndex = 5;
            // 
            // txtrecmin
            // 
            this.txtrecmin.Location = new System.Drawing.Point(420, 153);
            this.txtrecmin.Name = "txtrecmin";
            this.txtrecmin.Size = new System.Drawing.Size(100, 20);
            this.txtrecmin.TabIndex = 6;
            // 
            // txtrecmax
            // 
            this.txtrecmax.Location = new System.Drawing.Point(476, 179);
            this.txtrecmax.Name = "txtrecmax";
            this.txtrecmax.Size = new System.Drawing.Size(100, 20);
            this.txtrecmax.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Placar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(526, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Minimo temporada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Máximo temporada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(526, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quebra de recorde minimo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "quebra de recorde máximo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 185);
            this.dataGridView1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Image = global::PLACAR.Properties.Resources.logo_publica;
            this.label6.Location = new System.Drawing.Point(12, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 116);
            this.label6.TabIndex = 14;
            // 
            // Inserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtrecmax);
            this.Controls.Add(this.txtrecmin);
            this.Controls.Add(this.txtmaxtemp);
            this.Controls.Add(this.txtmintemp);
            this.Controls.Add(this.txtplacar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btninserir);
            this.Name = "Inserir";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtplacar;
        private System.Windows.Forms.TextBox txtmintemp;
        private System.Windows.Forms.TextBox txtmaxtemp;
        private System.Windows.Forms.TextBox txtrecmin;
        private System.Windows.Forms.TextBox txtrecmax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
    }
}

