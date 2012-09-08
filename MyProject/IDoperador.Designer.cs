namespace MyProject
{
    partial class IDoperador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IDoperador));
            this.nameoperador = new System.Windows.Forms.Label();
            this.pswop = new System.Windows.Forms.Label();
            this.pswtd = new System.Windows.Forms.Label();
            this.aceptarOP = new System.Windows.Forms.Button();
            this.cancelarOP = new System.Windows.Forms.Button();
            this.nombreOP = new System.Windows.Forms.TextBox();
            this.contraseñaop = new System.Windows.Forms.TextBox();
            this.contraseñatd = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameoperador
            // 
            this.nameoperador.AutoSize = true;
            this.nameoperador.Location = new System.Drawing.Point(95, 23);
            this.nameoperador.Name = "nameoperador";
            this.nameoperador.Size = new System.Drawing.Size(54, 13);
            this.nameoperador.TabIndex = 0;
            this.nameoperador.Text = "Operador:";
            // 
            // pswop
            // 
            this.pswop.AutoSize = true;
            this.pswop.Location = new System.Drawing.Point(67, 54);
            this.pswop.Name = "pswop";
            this.pswop.Size = new System.Drawing.Size(82, 13);
            this.pswop.TabIndex = 1;
            this.pswop.Text = "Contraseña OP:";
            // 
            // pswtd
            // 
            this.pswtd.AutoSize = true;
            this.pswtd.Location = new System.Drawing.Point(67, 86);
            this.pswtd.Name = "pswtd";
            this.pswtd.Size = new System.Drawing.Size(82, 13);
            this.pswtd.TabIndex = 2;
            this.pswtd.Text = "Contraseña TD:";
            // 
            // aceptarOP
            // 
            this.aceptarOP.Location = new System.Drawing.Point(12, 139);
            this.aceptarOP.Name = "aceptarOP";
            this.aceptarOP.Size = new System.Drawing.Size(75, 23);
            this.aceptarOP.TabIndex = 3;
            this.aceptarOP.Text = "Aceptar";
            this.aceptarOP.UseVisualStyleBackColor = true;
            this.aceptarOP.Click += new System.EventHandler(this.aceptarOP_Click);
            // 
            // cancelarOP
            // 
            this.cancelarOP.Location = new System.Drawing.Point(270, 139);
            this.cancelarOP.Name = "cancelarOP";
            this.cancelarOP.Size = new System.Drawing.Size(75, 23);
            this.cancelarOP.TabIndex = 4;
            this.cancelarOP.Text = "Cancelar";
            this.cancelarOP.UseVisualStyleBackColor = true;
            this.cancelarOP.Click += new System.EventHandler(this.cancelarOP_Click);
            // 
            // nombreOP
            // 
            this.nombreOP.Location = new System.Drawing.Point(170, 21);
            this.nombreOP.Name = "nombreOP";
            this.nombreOP.Size = new System.Drawing.Size(100, 20);
            this.nombreOP.TabIndex = 5;
            // 
            // contraseñaop
            // 
            this.contraseñaop.Location = new System.Drawing.Point(170, 52);
            this.contraseñaop.Name = "contraseñaop";
            this.contraseñaop.Size = new System.Drawing.Size(100, 20);
            this.contraseñaop.TabIndex = 6;
            this.contraseñaop.UseSystemPasswordChar = true;
            // 
            // contraseñatd
            // 
            this.contraseñatd.Location = new System.Drawing.Point(170, 84);
            this.contraseñatd.Name = "contraseñatd";
            this.contraseñatd.Size = new System.Drawing.Size(100, 20);
            this.contraseñatd.TabIndex = 7;
            this.contraseñatd.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // IDoperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 174);
            this.Controls.Add(this.contraseñatd);
            this.Controls.Add(this.contraseñaop);
            this.Controls.Add(this.nombreOP);
            this.Controls.Add(this.cancelarOP);
            this.Controls.Add(this.aceptarOP);
            this.Controls.Add(this.pswtd);
            this.Controls.Add(this.pswop);
            this.Controls.Add(this.nameoperador);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IDoperador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identificación de Operadores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameoperador;
        private System.Windows.Forms.Label pswop;
        private System.Windows.Forms.Label pswtd;
        private System.Windows.Forms.Button aceptarOP;
        private System.Windows.Forms.Button cancelarOP;
        private System.Windows.Forms.TextBox nombreOP;
        private System.Windows.Forms.TextBox contraseñaop;
        private System.Windows.Forms.TextBox contraseñatd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}