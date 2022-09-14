
namespace MetodosNumericos__Parcial_3_
{
    partial class FrmEuler
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValoresX0 = new System.Windows.Forms.TextBox();
            this.txtValoresY0 = new System.Windows.Forms.TextBox();
            this.txtValorHastaH = new System.Windows.Forms.TextBox();
            this.txtValorHastaX = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolverMenu1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MetodosNumericos__Parcial_3_.Properties.Resources.Captura_de_pantalla__2534_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(691, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X0:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(237, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor de H:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(223, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Interacciones:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Y0:";
            // 
            // txtValoresX0
            // 
            this.txtValoresX0.Location = new System.Drawing.Point(41, 223);
            this.txtValoresX0.Name = "txtValoresX0";
            this.txtValoresX0.Size = new System.Drawing.Size(136, 20);
            this.txtValoresX0.TabIndex = 5;
            this.txtValoresX0.TextChanged += new System.EventHandler(this.txtValoresX0_TextChanged);
            this.txtValoresX0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValoresX0_KeyPress);
            // 
            // txtValoresY0
            // 
            this.txtValoresY0.Location = new System.Drawing.Point(41, 249);
            this.txtValoresY0.Name = "txtValoresY0";
            this.txtValoresY0.Size = new System.Drawing.Size(136, 20);
            this.txtValoresY0.TabIndex = 6;
            this.txtValoresY0.TextChanged += new System.EventHandler(this.txtValoresY0_TextChanged);
            this.txtValoresY0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValoresY0_KeyPress);
            // 
            // txtValorHastaH
            // 
            this.txtValorHastaH.Location = new System.Drawing.Point(303, 223);
            this.txtValorHastaH.Name = "txtValorHastaH";
            this.txtValorHastaH.Size = new System.Drawing.Size(140, 20);
            this.txtValorHastaH.TabIndex = 7;
            this.txtValorHastaH.TextChanged += new System.EventHandler(this.txtValorHastaX_TextChanged);
            this.txtValorHastaH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorHastaH_KeyPress);
            // 
            // txtValorHastaX
            // 
            this.txtValorHastaX.Location = new System.Drawing.Point(303, 249);
            this.txtValorHastaX.Name = "txtValorHastaX";
            this.txtValorHastaX.Size = new System.Drawing.Size(140, 20);
            this.txtValorHastaX.TabIndex = 8;
            this.txtValorHastaX.TextChanged += new System.EventHandler(this.xtValorH_TextChanged);
            this.txtValorHastaX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xtValorH_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Black;
            this.btnCalcular.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCalcular.Location = new System.Drawing.Point(465, 220);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.Location = new System.Drawing.Point(571, 220);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVolverMenu1
            // 
            this.btnVolverMenu1.BackColor = System.Drawing.Color.Black;
            this.btnVolverMenu1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnVolverMenu1.Location = new System.Drawing.Point(515, 247);
            this.btnVolverMenu1.Name = "btnVolverMenu1";
            this.btnVolverMenu1.Size = new System.Drawing.Size(100, 23);
            this.btnVolverMenu1.TabIndex = 11;
            this.btnVolverMenu1.Text = "Volver Menu";
            this.btnVolverMenu1.UseVisualStyleBackColor = false;
            this.btnVolverMenu1.Click += new System.EventHandler(this.btnVolverMenu1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(61, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero de Interacciones";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Valor de Xn";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Valor Y real";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Valor Y Euler";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Valor Er Euler %";
            this.Column5.Name = "Column5";
            // 
            // FrmEuler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 445);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVolverMenu1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorHastaX);
            this.Controls.Add(this.txtValorHastaH);
            this.Controls.Add(this.txtValoresY0);
            this.Controls.Add(this.txtValoresX0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmEuler";
            this.Text = "Euler";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValoresX0;
        private System.Windows.Forms.TextBox txtValoresY0;
        private System.Windows.Forms.TextBox txtValorHastaH;
        private System.Windows.Forms.TextBox txtValorHastaX;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolverMenu1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}