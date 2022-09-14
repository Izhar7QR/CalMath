
namespace MetodosNumericos__Parcial_3_
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMetodoEuler = new System.Windows.Forms.Button();
            this.btnMetodoEulerMejorado = new System.Windows.Forms.Button();
            this.btnMetodoRungeKutta = new System.Windows.Forms.Button();
            this.btnMetodoNewtonRaphson = new System.Windows.Forms.Button();
            this.btnCerrarPrograma = new System.Windows.Forms.Button();
            this.btnGauss = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MetodosNumericos__Parcial_3_.Properties.Resources.Captura_de_pantalla__2532_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(678, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMetodoEuler
            // 
            this.btnMetodoEuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMetodoEuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodoEuler.Location = new System.Drawing.Point(13, 74);
            this.btnMetodoEuler.Name = "btnMetodoEuler";
            this.btnMetodoEuler.Size = new System.Drawing.Size(125, 34);
            this.btnMetodoEuler.TabIndex = 1;
            this.btnMetodoEuler.Text = "Metodo Euler";
            this.btnMetodoEuler.UseVisualStyleBackColor = false;
            this.btnMetodoEuler.Click += new System.EventHandler(this.btnMetodoEuler_Click);
            // 
            // btnMetodoEulerMejorado
            // 
            this.btnMetodoEulerMejorado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMetodoEulerMejorado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodoEulerMejorado.Location = new System.Drawing.Point(13, 114);
            this.btnMetodoEulerMejorado.Name = "btnMetodoEulerMejorado";
            this.btnMetodoEulerMejorado.Size = new System.Drawing.Size(125, 53);
            this.btnMetodoEulerMejorado.TabIndex = 2;
            this.btnMetodoEulerMejorado.Text = "Metodo Euler Mejorado";
            this.btnMetodoEulerMejorado.UseVisualStyleBackColor = false;
            this.btnMetodoEulerMejorado.Click += new System.EventHandler(this.btnMetodoEulerMejorado_Click);
            // 
            // btnMetodoRungeKutta
            // 
            this.btnMetodoRungeKutta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMetodoRungeKutta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodoRungeKutta.Location = new System.Drawing.Point(13, 173);
            this.btnMetodoRungeKutta.Name = "btnMetodoRungeKutta";
            this.btnMetodoRungeKutta.Size = new System.Drawing.Size(125, 47);
            this.btnMetodoRungeKutta.TabIndex = 3;
            this.btnMetodoRungeKutta.Text = "Metodo Runge Kutta";
            this.btnMetodoRungeKutta.UseVisualStyleBackColor = false;
            this.btnMetodoRungeKutta.Click += new System.EventHandler(this.btnMetodoRungeKutta_Click);
            // 
            // btnMetodoNewtonRaphson
            // 
            this.btnMetodoNewtonRaphson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMetodoNewtonRaphson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodoNewtonRaphson.Location = new System.Drawing.Point(13, 226);
            this.btnMetodoNewtonRaphson.Name = "btnMetodoNewtonRaphson";
            this.btnMetodoNewtonRaphson.Size = new System.Drawing.Size(125, 47);
            this.btnMetodoNewtonRaphson.TabIndex = 4;
            this.btnMetodoNewtonRaphson.Text = "Metodo Newton Raphson";
            this.btnMetodoNewtonRaphson.UseVisualStyleBackColor = false;
            this.btnMetodoNewtonRaphson.Click += new System.EventHandler(this.btnMetodoNewtonRaphson_Click);
            // 
            // btnCerrarPrograma
            // 
            this.btnCerrarPrograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCerrarPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPrograma.Location = new System.Drawing.Point(12, 332);
            this.btnCerrarPrograma.Name = "btnCerrarPrograma";
            this.btnCerrarPrograma.Size = new System.Drawing.Size(125, 34);
            this.btnCerrarPrograma.TabIndex = 5;
            this.btnCerrarPrograma.Text = "Cerrar Programa";
            this.btnCerrarPrograma.UseVisualStyleBackColor = false;
            this.btnCerrarPrograma.Click += new System.EventHandler(this.btnCerrarPrograma_Click);
            // 
            // btnGauss
            // 
            this.btnGauss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGauss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGauss.Location = new System.Drawing.Point(13, 279);
            this.btnGauss.Name = "btnGauss";
            this.btnGauss.Size = new System.Drawing.Size(125, 47);
            this.btnGauss.TabIndex = 6;
            this.btnGauss.Text = "Metodo Gauss Seider";
            this.btnGauss.UseVisualStyleBackColor = false;
            this.btnGauss.Click += new System.EventHandler(this.btnGauss_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 391);
            this.Controls.Add(this.btnGauss);
            this.Controls.Add(this.btnCerrarPrograma);
            this.Controls.Add(this.btnMetodoNewtonRaphson);
            this.Controls.Add(this.btnMetodoRungeKutta);
            this.Controls.Add(this.btnMetodoEulerMejorado);
            this.Controls.Add(this.btnMetodoEuler);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMetodoEuler;
        private System.Windows.Forms.Button btnMetodoEulerMejorado;
        private System.Windows.Forms.Button btnMetodoRungeKutta;
        private System.Windows.Forms.Button btnMetodoNewtonRaphson;
        private System.Windows.Forms.Button btnCerrarPrograma;
        private System.Windows.Forms.Button btnGauss;
    }
}

