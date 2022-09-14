
namespace MetodosNumericos__Parcial_3_
{
    partial class FrmGaussSeider
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
            this.txtM1 = new System.Windows.Forms.TextBox();
            this.txtM2 = new System.Windows.Forms.TextBox();
            this.txtM3 = new System.Windows.Forms.TextBox();
            this.txtR1 = new System.Windows.Forms.TextBox();
            this.txtM4 = new System.Windows.Forms.TextBox();
            this.txtM5 = new System.Windows.Forms.TextBox();
            this.txtM6 = new System.Windows.Forms.TextBox();
            this.txtR2 = new System.Windows.Forms.TextBox();
            this.txtM7 = new System.Windows.Forms.TextBox();
            this.txtM8 = new System.Windows.Forms.TextBox();
            this.txtM9 = new System.Windows.Forms.TextBox();
            this.txtR3 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtZ3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegresarInicio1 = new System.Windows.Forms.Button();
            this.dataGauss = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMatriz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGauss)).BeginInit();
            this.SuspendLayout();
            // 
            // txtM1
            // 
            this.txtM1.Location = new System.Drawing.Point(60, 259);
            this.txtM1.Name = "txtM1";
            this.txtM1.Size = new System.Drawing.Size(100, 20);
            this.txtM1.TabIndex = 1;
            this.txtM1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtM2
            // 
            this.txtM2.Location = new System.Drawing.Point(222, 259);
            this.txtM2.Name = "txtM2";
            this.txtM2.Size = new System.Drawing.Size(100, 20);
            this.txtM2.TabIndex = 2;
            // 
            // txtM3
            // 
            this.txtM3.Location = new System.Drawing.Point(391, 259);
            this.txtM3.Name = "txtM3";
            this.txtM3.Size = new System.Drawing.Size(100, 20);
            this.txtM3.TabIndex = 3;
            // 
            // txtR1
            // 
            this.txtR1.Location = new System.Drawing.Point(539, 259);
            this.txtR1.Name = "txtR1";
            this.txtR1.Size = new System.Drawing.Size(100, 20);
            this.txtR1.TabIndex = 4;
            // 
            // txtM4
            // 
            this.txtM4.Location = new System.Drawing.Point(60, 285);
            this.txtM4.Name = "txtM4";
            this.txtM4.Size = new System.Drawing.Size(100, 20);
            this.txtM4.TabIndex = 5;
            // 
            // txtM5
            // 
            this.txtM5.Location = new System.Drawing.Point(222, 285);
            this.txtM5.Name = "txtM5";
            this.txtM5.Size = new System.Drawing.Size(100, 20);
            this.txtM5.TabIndex = 6;
            // 
            // txtM6
            // 
            this.txtM6.Location = new System.Drawing.Point(391, 285);
            this.txtM6.Name = "txtM6";
            this.txtM6.Size = new System.Drawing.Size(100, 20);
            this.txtM6.TabIndex = 7;
            // 
            // txtR2
            // 
            this.txtR2.Location = new System.Drawing.Point(539, 285);
            this.txtR2.Name = "txtR2";
            this.txtR2.Size = new System.Drawing.Size(100, 20);
            this.txtR2.TabIndex = 8;
            // 
            // txtM7
            // 
            this.txtM7.Location = new System.Drawing.Point(60, 317);
            this.txtM7.Name = "txtM7";
            this.txtM7.Size = new System.Drawing.Size(100, 20);
            this.txtM7.TabIndex = 9;
            // 
            // txtM8
            // 
            this.txtM8.Location = new System.Drawing.Point(222, 317);
            this.txtM8.Name = "txtM8";
            this.txtM8.Size = new System.Drawing.Size(100, 20);
            this.txtM8.TabIndex = 10;
            // 
            // txtM9
            // 
            this.txtM9.Location = new System.Drawing.Point(391, 317);
            this.txtM9.Name = "txtM9";
            this.txtM9.Size = new System.Drawing.Size(100, 20);
            this.txtM9.TabIndex = 11;
            // 
            // txtR3
            // 
            this.txtR3.Location = new System.Drawing.Point(539, 317);
            this.txtR3.Name = "txtR3";
            this.txtR3.Size = new System.Drawing.Size(100, 20);
            this.txtR3.TabIndex = 12;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(60, 353);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(100, 20);
            this.txtX1.TabIndex = 13;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(222, 353);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(100, 20);
            this.txtY2.TabIndex = 14;
            // 
            // txtZ3
            // 
            this.txtZ3.Location = new System.Drawing.Point(391, 353);
            this.txtZ3.Name = "txtZ3";
            this.txtZ3.Size = new System.Drawing.Size(100, 20);
            this.txtZ3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Valor x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(174, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Valor y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(343, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Valor z:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MetodosNumericos__Parcial_3_.Properties.Resources.Captura_de_pantalla__100_;
            this.pictureBox2.Location = new System.Drawing.Point(-3, 506);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(849, 138);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MetodosNumericos__Parcial_3_.Properties.Resources.Captura_de_pantalla__99_;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(849, 517);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Black;
            this.btnCalcular.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCalcular.Location = new System.Drawing.Point(656, 259);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 25;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.Location = new System.Drawing.Point(656, 285);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 23);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegresarInicio1
            // 
            this.btnRegresarInicio1.BackColor = System.Drawing.Color.Black;
            this.btnRegresarInicio1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarInicio1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRegresarInicio1.Location = new System.Drawing.Point(656, 317);
            this.btnRegresarInicio1.Name = "btnRegresarInicio1";
            this.btnRegresarInicio1.Size = new System.Drawing.Size(100, 23);
            this.btnRegresarInicio1.TabIndex = 27;
            this.btnRegresarInicio1.Text = "Volover a Menu";
            this.btnRegresarInicio1.UseVisualStyleBackColor = false;
            this.btnRegresarInicio1.Click += new System.EventHandler(this.btnRegresarInicio1_Click);
            // 
            // dataGauss
            // 
            this.dataGauss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGauss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGauss.Location = new System.Drawing.Point(37, 426);
            this.dataGauss.Name = "dataGauss";
            this.dataGauss.Size = new System.Drawing.Size(743, 150);
            this.dataGauss.TabIndex = 28;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero de Interacciones";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Valor de Xi";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Valor de Y1";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Valor de Zi";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Error Relativo de Xi";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Error Relativo de Yi";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Error Relativo de Zi";
            this.Column7.Name = "Column7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Gabriola", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(540, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Matrices";
            // 
            // lblMatriz
            // 
            this.lblMatriz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMatriz.AutoSize = true;
            this.lblMatriz.Location = new System.Drawing.Point(541, 377);
            this.lblMatriz.Name = "lblMatriz";
            this.lblMatriz.Size = new System.Drawing.Size(10, 13);
            this.lblMatriz.TabIndex = 30;
            this.lblMatriz.Text = ".";
            // 
            // FrmGaussSeider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 627);
            this.Controls.Add(this.lblMatriz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGauss);
            this.Controls.Add(this.btnRegresarInicio1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZ3);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.txtR3);
            this.Controls.Add(this.txtM9);
            this.Controls.Add(this.txtM8);
            this.Controls.Add(this.txtM7);
            this.Controls.Add(this.txtR2);
            this.Controls.Add(this.txtM6);
            this.Controls.Add(this.txtM5);
            this.Controls.Add(this.txtM4);
            this.Controls.Add(this.txtR1);
            this.Controls.Add(this.txtM3);
            this.Controls.Add(this.txtM2);
            this.Controls.Add(this.txtM1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmGaussSeider";
            this.Text = "Gauss_Seider";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGauss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtM1;
        private System.Windows.Forms.TextBox txtM2;
        private System.Windows.Forms.TextBox txtM3;
        private System.Windows.Forms.TextBox txtR1;
        private System.Windows.Forms.TextBox txtM4;
        private System.Windows.Forms.TextBox txtM5;
        private System.Windows.Forms.TextBox txtM6;
        private System.Windows.Forms.TextBox txtR2;
        private System.Windows.Forms.TextBox txtM7;
        private System.Windows.Forms.TextBox txtM8;
        private System.Windows.Forms.TextBox txtM9;
        private System.Windows.Forms.TextBox txtR3;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtZ3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegresarInicio1;
        private System.Windows.Forms.DataGridView dataGauss;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMatriz;
    }
}