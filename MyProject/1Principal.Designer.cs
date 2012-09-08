namespace MyProject
{
    partial class Principal1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal1));
            this.Recibo = new System.Windows.Forms.Button();
            this.Procesados = new System.Windows.Forms.Button();
            this.enviarrecibir = new System.Windows.Forms.Button();
            this.cambiarOP = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mensajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorDeMensajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorMMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarMMCComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarLibretaDeDireccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionLocalServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diccionarioDeErToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borradores = new System.Windows.Forms.Button();
            this.editor = new System.Windows.Forms.Button();
            this.archivo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.transmitidos = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Recibo
            // 
            this.Recibo.BackColor = System.Drawing.SystemColors.Control;
            this.Recibo.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Recibo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Recibo.Image = ((System.Drawing.Image)(resources.GetObject("Recibo.Image")));
            this.Recibo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Recibo.Location = new System.Drawing.Point(12, 41);
            this.Recibo.Name = "Recibo";
            this.Recibo.Size = new System.Drawing.Size(114, 86);
            this.Recibo.TabIndex = 0;
            this.Recibo.Text = "RECIBIDOS";
            this.Recibo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Recibo.UseVisualStyleBackColor = true;
            this.Recibo.Click += new System.EventHandler(this.Recibo_Click);
            // 
            // Procesados
            // 
            this.Procesados.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Procesados.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Procesados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Procesados.Image = ((System.Drawing.Image)(resources.GetObject("Procesados.Image")));
            this.Procesados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Procesados.Location = new System.Drawing.Point(12, 238);
            this.Procesados.Name = "Procesados";
            this.Procesados.Size = new System.Drawing.Size(114, 86);
            this.Procesados.TabIndex = 3;
            this.Procesados.Text = "PROCESADOS";
            this.Procesados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Procesados.UseVisualStyleBackColor = true;
            // 
            // enviarrecibir
            // 
            this.enviarrecibir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.enviarrecibir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviarrecibir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.enviarrecibir.Image = ((System.Drawing.Image)(resources.GetObject("enviarrecibir.Image")));
            this.enviarrecibir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.enviarrecibir.Location = new System.Drawing.Point(255, 146);
            this.enviarrecibir.Name = "enviarrecibir";
            this.enviarrecibir.Size = new System.Drawing.Size(114, 86);
            this.enviarrecibir.TabIndex = 4;
            this.enviarrecibir.Text = "ENVIAR/RECIBIR";
            this.enviarrecibir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.enviarrecibir.UseVisualStyleBackColor = true;
            this.enviarrecibir.Click += new System.EventHandler(this.enviarrecibir_Click);
            // 
            // cambiarOP
            // 
            this.cambiarOP.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cambiarOP.Font = new System.Drawing.Font("Arial", 8.25F);
            this.cambiarOP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cambiarOP.Image = ((System.Drawing.Image)(resources.GetObject("cambiarOP.Image")));
            this.cambiarOP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cambiarOP.Location = new System.Drawing.Point(132, 146);
            this.cambiarOP.Name = "cambiarOP";
            this.cambiarOP.Size = new System.Drawing.Size(114, 86);
            this.cambiarOP.TabIndex = 5;
            this.cambiarOP.Text = "CAMBIAR OP";
            this.cambiarOP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cambiarOP.UseVisualStyleBackColor = true;
            this.cambiarOP.Click += new System.EventHandler(this.cambiarOP_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mensajesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mensajesToolStripMenuItem
            // 
            this.mensajesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorDeMensajesToolStripMenuItem,
            this.editorMMCToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mensajesToolStripMenuItem.Name = "mensajesToolStripMenuItem";
            this.mensajesToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.mensajesToolStripMenuItem.Text = "Mensajes";
            // 
            // administradorDeMensajesToolStripMenuItem
            // 
            this.administradorDeMensajesToolStripMenuItem.Name = "administradorDeMensajesToolStripMenuItem";
            this.administradorDeMensajesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.administradorDeMensajesToolStripMenuItem.Text = "Administrador de Mensajes";
            this.administradorDeMensajesToolStripMenuItem.Click += new System.EventHandler(this.administradorDeMensajesToolStripMenuItem_Click);
            // 
            // editorMMCToolStripMenuItem
            // 
            this.editorMMCToolStripMenuItem.Name = "editorMMCToolStripMenuItem";
            this.editorMMCToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.editorMMCToolStripMenuItem.Text = "Editor MMC";
            this.editorMMCToolStripMenuItem.Click += new System.EventHandler(this.editorMMCToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enviarToolStripMenuItem,
            this.turnosToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // enviarToolStripMenuItem
            // 
            this.enviarToolStripMenuItem.Name = "enviarToolStripMenuItem";
            this.enviarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.enviarToolStripMenuItem.Text = "Enviar y Recibir";
            this.enviarToolStripMenuItem.Click += new System.EventHandler(this.enviarToolStripMenuItem_Click);
            // 
            // turnosToolStripMenuItem
            // 
            this.turnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarTurnoToolStripMenuItem});
            this.turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            this.turnosToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.turnosToolStripMenuItem.Text = "Turnos";
            // 
            // cambiarTurnoToolStripMenuItem
            // 
            this.cambiarTurnoToolStripMenuItem.Name = "cambiarTurnoToolStripMenuItem";
            this.cambiarTurnoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.cambiarTurnoToolStripMenuItem.Text = "Cambiar Turno";
            this.cambiarTurnoToolStripMenuItem.Click += new System.EventHandler(this.cambiarTurnoToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarMMCComoToolStripMenuItem,
            this.actualizarLibretaDeDireccionesToolStripMenuItem,
            this.configuracionLocalServerToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // guardarMMCComoToolStripMenuItem
            // 
            this.guardarMMCComoToolStripMenuItem.Name = "guardarMMCComoToolStripMenuItem";
            this.guardarMMCComoToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.guardarMMCComoToolStripMenuItem.Text = "Carpeta Destino de Guardado";
            // 
            // actualizarLibretaDeDireccionesToolStripMenuItem
            // 
            this.actualizarLibretaDeDireccionesToolStripMenuItem.Name = "actualizarLibretaDeDireccionesToolStripMenuItem";
            this.actualizarLibretaDeDireccionesToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.actualizarLibretaDeDireccionesToolStripMenuItem.Text = "Actualizar Libreta de Direcciones";
            // 
            // configuracionLocalServerToolStripMenuItem
            // 
            this.configuracionLocalServerToolStripMenuItem.Name = "configuracionLocalServerToolStripMenuItem";
            this.configuracionLocalServerToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.configuracionLocalServerToolStripMenuItem.Text = "Configuracion Local Server";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soporteTécnicoToolStripMenuItem,
            this.diccionarioDeErToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // soporteTécnicoToolStripMenuItem
            // 
            this.soporteTécnicoToolStripMenuItem.Name = "soporteTécnicoToolStripMenuItem";
            this.soporteTécnicoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.soporteTécnicoToolStripMenuItem.Text = "Soporte Técnico";
            this.soporteTécnicoToolStripMenuItem.Click += new System.EventHandler(this.soporteTécnicoToolStripMenuItem_Click);
            // 
            // diccionarioDeErToolStripMenuItem
            // 
            this.diccionarioDeErToolStripMenuItem.Name = "diccionarioDeErToolStripMenuItem";
            this.diccionarioDeErToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.diccionarioDeErToolStripMenuItem.Text = "Manuales SITMv2.0";
            // 
            // borradores
            // 
            this.borradores.BackColor = System.Drawing.SystemColors.Control;
            this.borradores.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borradores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.borradores.Image = ((System.Drawing.Image)(resources.GetObject("borradores.Image")));
            this.borradores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.borradores.Location = new System.Drawing.Point(12, 146);
            this.borradores.Name = "borradores";
            this.borradores.Size = new System.Drawing.Size(114, 86);
            this.borradores.TabIndex = 10;
            this.borradores.Text = "BORRADORES";
            this.borradores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.borradores.UseVisualStyleBackColor = true;
            this.borradores.Click += new System.EventHandler(this.borradores_Click);
            // 
            // editor
            // 
            this.editor.BackColor = System.Drawing.SystemColors.Control;
            this.editor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editor.Image = ((System.Drawing.Image)(resources.GetObject("editor.Image")));
            this.editor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.editor.Location = new System.Drawing.Point(132, 41);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(114, 86);
            this.editor.TabIndex = 11;
            this.editor.Text = "EDITOR MMC";
            this.editor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.editor.UseVisualStyleBackColor = true;
            this.editor.Click += new System.EventHandler(this.editor_Click);
            // 
            // archivo
            // 
            this.archivo.BackColor = System.Drawing.SystemColors.Control;
            this.archivo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.archivo.Image = ((System.Drawing.Image)(resources.GetObject("archivo.Image")));
            this.archivo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.archivo.Location = new System.Drawing.Point(12, 331);
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(114, 86);
            this.archivo.TabIndex = 12;
            this.archivo.Text = "ARCHIVO";
            this.archivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.archivo.UseVisualStyleBackColor = true;
            this.archivo.Click += new System.EventHandler(this.archivo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(759, 614);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(375, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 86);
            this.button2.TabIndex = 16;
            this.button2.Text = "EN TRAMITE";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(132, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 86);
            this.button4.TabIndex = 15;
            this.button4.Text = "BUSQUEDA";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // transmitidos
            // 
            this.transmitidos.Font = new System.Drawing.Font("Arial", 8.25F);
            this.transmitidos.Image = ((System.Drawing.Image)(resources.GetObject("transmitidos.Image")));
            this.transmitidos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.transmitidos.Location = new System.Drawing.Point(255, 41);
            this.transmitidos.Name = "transmitidos";
            this.transmitidos.Size = new System.Drawing.Size(114, 86);
            this.transmitidos.TabIndex = 18;
            this.transmitidos.Text = "TRANSMITIDOS";
            this.transmitidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.transmitidos.UseVisualStyleBackColor = true;
            // 
            // Principal1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 614);
            this.Controls.Add(this.transmitidos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.archivo);
            this.Controls.Add(this.editor);
            this.Controls.Add(this.borradores);
            this.Controls.Add(this.cambiarOP);
            this.Controls.Add(this.enviarrecibir);
            this.Controls.Add(this.Procesados);
            this.Controls.Add(this.Recibo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Informatico de Transmision de Mensajes v2.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Recibo;
        private System.Windows.Forms.Button Procesados;
        private System.Windows.Forms.Button enviarrecibir;
        private System.Windows.Forms.Button cambiarOP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mensajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Button borradores;
        private System.Windows.Forms.Button editor;
        private System.Windows.Forms.Button archivo;
        private System.Windows.Forms.ToolStripMenuItem editorMMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarMMCComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteTécnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diccionarioDeErToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem administradorDeMensajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarLibretaDeDireccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionLocalServerToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button transmitidos;
    }
}