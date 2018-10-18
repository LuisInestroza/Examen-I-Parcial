namespace ExamenPOO
{
    partial class frmReseñaAnalisis
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxProductos = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptarInsertarDatos = new System.Windows.Forms.Button();
            this.txtComantarios = new System.Windows.Forms.TextBox();
            this.lbComentarios = new System.Windows.Forms.Label();
            this.txtValoracion = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lbValoracion = new System.Windows.Forms.Label();
            this.lbNombreCompleto = new System.Windows.Forms.Label();
            this.llbCorreroElectronico = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxProductos);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnAceptarInsertarDatos);
            this.groupBox1.Controls.Add(this.txtComantarios);
            this.groupBox1.Controls.Add(this.lbComentarios);
            this.groupBox1.Controls.Add(this.txtValoracion);
            this.groupBox1.Controls.Add(this.txtCorreoElectronico);
            this.groupBox1.Controls.Add(this.txtNombreCompleto);
            this.groupBox1.Controls.Add(this.lbValoracion);
            this.groupBox1.Controls.Add(this.lbNombreCompleto);
            this.groupBox1.Controls.Add(this.llbCorreroElectronico);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el producto a realizar su reseña/análisis";
            // 
            // lbxProductos
            // 
            this.lbxProductos.FormattingEnabled = true;
            this.lbxProductos.ItemHeight = 18;
            this.lbxProductos.Location = new System.Drawing.Point(16, 29);
            this.lbxProductos.Name = "lbxProductos";
            this.lbxProductos.Size = new System.Drawing.Size(205, 274);
            this.lbxProductos.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(298, 320);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 28);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptarInsertarDatos
            // 
            this.btnAceptarInsertarDatos.Location = new System.Drawing.Point(122, 320);
            this.btnAceptarInsertarDatos.Name = "btnAceptarInsertarDatos";
            this.btnAceptarInsertarDatos.Size = new System.Drawing.Size(138, 28);
            this.btnAceptarInsertarDatos.TabIndex = 10;
            this.btnAceptarInsertarDatos.Text = "Aceptar";
            this.btnAceptarInsertarDatos.UseVisualStyleBackColor = true;
            this.btnAceptarInsertarDatos.Click += new System.EventHandler(this.btnAceptarInsertarDatos_Click);
            // 
            // txtComantarios
            // 
            this.txtComantarios.Location = new System.Drawing.Point(268, 198);
            this.txtComantarios.Multiline = true;
            this.txtComantarios.Name = "txtComantarios";
            this.txtComantarios.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComantarios.Size = new System.Drawing.Size(275, 102);
            this.txtComantarios.TabIndex = 8;
            // 
            // lbComentarios
            // 
            this.lbComentarios.AutoSize = true;
            this.lbComentarios.Location = new System.Drawing.Point(266, 177);
            this.lbComentarios.Name = "lbComentarios";
            this.lbComentarios.Size = new System.Drawing.Size(94, 18);
            this.lbComentarios.TabIndex = 4;
            this.lbComentarios.Text = "Comentarios";
            // 
            // txtValoracion
            // 
            this.txtValoracion.Location = new System.Drawing.Point(269, 150);
            this.txtValoracion.Name = "txtValoracion";
            this.txtValoracion.Size = new System.Drawing.Size(274, 24);
            this.txtValoracion.TabIndex = 7;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(269, 102);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(274, 24);
            this.txtCorreoElectronico.TabIndex = 6;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(268, 54);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(275, 24);
            this.txtNombreCompleto.TabIndex = 5;
            // 
            // lbValoracion
            // 
            this.lbValoracion.AutoSize = true;
            this.lbValoracion.Location = new System.Drawing.Point(266, 129);
            this.lbValoracion.Name = "lbValoracion";
            this.lbValoracion.Size = new System.Drawing.Size(78, 18);
            this.lbValoracion.TabIndex = 3;
            this.lbValoracion.Text = "Valoración";
            // 
            // lbNombreCompleto
            // 
            this.lbNombreCompleto.AutoSize = true;
            this.lbNombreCompleto.Location = new System.Drawing.Point(265, 29);
            this.lbNombreCompleto.Name = "lbNombreCompleto";
            this.lbNombreCompleto.Size = new System.Drawing.Size(135, 18);
            this.lbNombreCompleto.TabIndex = 1;
            this.lbNombreCompleto.Text = "Nombre Completo:";
            // 
            // llbCorreroElectronico
            // 
            this.llbCorreroElectronico.AutoSize = true;
            this.llbCorreroElectronico.Location = new System.Drawing.Point(266, 81);
            this.llbCorreroElectronico.Name = "llbCorreroElectronico";
            this.llbCorreroElectronico.Size = new System.Drawing.Size(134, 18);
            this.llbCorreroElectronico.TabIndex = 2;
            this.llbCorreroElectronico.Text = "Correo Electrónico";
            // 
            // frmReseñaAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 393);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReseñaAnalisis";
            this.Text = "Reseña/Análisis de Productos - AdventureWorks";
            this.Load += new System.EventHandler(this.frmReseñaAnalisis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptarInsertarDatos;
        private System.Windows.Forms.TextBox txtComantarios;
        private System.Windows.Forms.Label lbComentarios;
        private System.Windows.Forms.TextBox txtValoracion;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lbValoracion;
        private System.Windows.Forms.Label lbNombreCompleto;
        private System.Windows.Forms.Label llbCorreroElectronico;
        private System.Windows.Forms.ListBox lbxProductos;
    }
}

