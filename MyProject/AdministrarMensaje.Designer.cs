namespace MyProject
{
    partial class administrarmensaje
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(administrarmensaje));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.enviados = new System.Windows.Forms.DataGridView();
            this.Facilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Canal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autenticar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Autenticado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ClasificaciónSeguridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transmisión = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precedencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GFH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promotor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Informado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ejecutivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exceptuado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaCentralTráfico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transmitido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransmitidoGFH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaDestinoGRH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enviado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Saliente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UsuarioCrea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUsuarioCrea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.enviados)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Enviados";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(89, 13);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(73, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Recibidos";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(168, 13);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(66, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "A Enviar";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(262, 403);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 5;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(343, 403);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(181, 403);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 6;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Location = new System.Drawing.Point(424, 403);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(75, 23);
            this.buttonImprimir.TabIndex = 7;
            this.buttonImprimir.Text = "Imprime";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            // 
            // enviados
            // 
            this.enviados.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enviados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.enviados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.enviados.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enviados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.enviados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enviados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Facilidad,
            this.Canal,
            this.Autenticar,
            this.Autenticado,
            this.ClasificaciónSeguridad,
            this.NroControl,
            this.NR,
            this.Transmisión,
            this.Precedencia,
            this.GFH,
            this.Promotor,
            this.Informado,
            this.Ejecutivo,
            this.Exceptuado,
            this.Grupos,
            this.EntradaCentralTráfico,
            this.Transmitido,
            this.TransmitidoGFH,
            this.EntradaDestinoGRH,
            this.Enviado,
            this.Saliente,
            this.UsuarioCrea,
            this.FUsuarioCrea});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.enviados.DefaultCellStyle = dataGridViewCellStyle3;
            this.enviados.Location = new System.Drawing.Point(12, 36);
            this.enviados.Name = "enviados";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enviados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.enviados.Size = new System.Drawing.Size(671, 342);
            this.enviados.TabIndex = 10;
            // 
            // Facilidad
            // 
            this.Facilidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Facilidad.HeaderText = "Facilidad";
            this.Facilidad.Name = "Facilidad";
            this.Facilidad.Width = 74;
            // 
            // Canal
            // 
            this.Canal.HeaderText = "Canal";
            this.Canal.Name = "Canal";
            // 
            // Autenticar
            // 
            this.Autenticar.HeaderText = "Autenticar";
            this.Autenticar.Name = "Autenticar";
            // 
            // Autenticado
            // 
            this.Autenticado.HeaderText = "Autenticado";
            this.Autenticado.Name = "Autenticado";
            // 
            // ClasificaciónSeguridad
            // 
            this.ClasificaciónSeguridad.HeaderText = "ClasificaciónSeguridad";
            this.ClasificaciónSeguridad.Name = "ClasificaciónSeguridad";
            // 
            // NroControl
            // 
            this.NroControl.HeaderText = "NroControl";
            this.NroControl.Name = "NroControl";
            // 
            // NR
            // 
            this.NR.HeaderText = "NR";
            this.NR.Name = "NR";
            // 
            // Transmisión
            // 
            this.Transmisión.HeaderText = "Transmisión";
            this.Transmisión.Name = "Transmisión";
            // 
            // Precedencia
            // 
            this.Precedencia.HeaderText = "Precedencia";
            this.Precedencia.Name = "Precedencia";
            // 
            // GFH
            // 
            this.GFH.HeaderText = "GFH";
            this.GFH.Name = "GFH";
            // 
            // Promotor
            // 
            this.Promotor.HeaderText = "Promotor";
            this.Promotor.Name = "Promotor";
            // 
            // Informado
            // 
            this.Informado.HeaderText = "Informado";
            this.Informado.Name = "Informado";
            // 
            // Ejecutivo
            // 
            this.Ejecutivo.HeaderText = "Ejecutivo";
            this.Ejecutivo.Name = "Ejecutivo";
            // 
            // Exceptuado
            // 
            this.Exceptuado.HeaderText = "Exceptuado";
            this.Exceptuado.Name = "Exceptuado";
            // 
            // Grupos
            // 
            this.Grupos.HeaderText = "Grupos";
            this.Grupos.Name = "Grupos";
            // 
            // EntradaCentralTráfico
            // 
            this.EntradaCentralTráfico.HeaderText = "EntradaCentralTráfico";
            this.EntradaCentralTráfico.Name = "EntradaCentralTráfico";
            // 
            // Transmitido
            // 
            this.Transmitido.HeaderText = "Transmitido";
            this.Transmitido.Name = "Transmitido";
            // 
            // TransmitidoGFH
            // 
            this.TransmitidoGFH.HeaderText = "TransmitidoGFH";
            this.TransmitidoGFH.Name = "TransmitidoGFH";
            // 
            // EntradaDestinoGRH
            // 
            this.EntradaDestinoGRH.HeaderText = "EntradaDestinoGRH";
            this.EntradaDestinoGRH.Name = "EntradaDestinoGRH";
            // 
            // Enviado
            // 
            this.Enviado.HeaderText = "Enviado";
            this.Enviado.Name = "Enviado";
            // 
            // Saliente
            // 
            this.Saliente.HeaderText = "Saliente";
            this.Saliente.Name = "Saliente";
            // 
            // UsuarioCrea
            // 
            this.UsuarioCrea.HeaderText = "UsuarioCrea";
            this.UsuarioCrea.Name = "UsuarioCrea";
            // 
            // FUsuarioCrea
            // 
            this.FUsuarioCrea.HeaderText = "FUsuarioCrea";
            this.FUsuarioCrea.Name = "FUsuarioCrea";
            this.FUsuarioCrea.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // administrarmensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 438);
            this.Controls.Add(this.enviados);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "administrarmensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Mensaje";
            ((System.ComponentModel.ISupportInitialize)(this.enviados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.DataGridView enviados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Canal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Autenticar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Autenticado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClasificaciónSeguridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn NR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transmisión;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precedencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GFH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promotor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Informado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ejecutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exceptuado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupos;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntradaCentralTráfico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transmitido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransmitidoGFH;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntradaDestinoGRH;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Enviado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Saliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioCrea;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUsuarioCrea;
    }
}