
namespace Farmacia
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.p_btn_cancelar1 = new System.Windows.Forms.Button();
            this.p_btn_agregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.p_txt_codigo = new System.Windows.Forms.TextBox();
            this.p_txt_precio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p_txt_nombre = new System.Windows.Forms.TextBox();
            this.p_txt_cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.p_btn_cancelar2 = new System.Windows.Forms.Button();
            this.p_eliminar = new System.Windows.Forms.Button();
            this.p_txt_codigoEliminar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.p_Lista = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.p_btn_buscarCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.p_btn_buscar = new System.Windows.Forms.Button();
            this.p_txt_buscar = new System.Windows.Forms.TextBox();
            this.i_listaMedicamentos = new System.Windows.Forms.DataGridView();
            this.Ic_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ic_Cantida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ic_PrecioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ic_Montototal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.p_Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.i_listaMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de Medicamentos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.p_btn_cancelar1);
            this.groupBox2.Controls.Add(this.p_btn_agregar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.p_txt_codigo);
            this.groupBox2.Controls.Add(this.p_txt_precio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.p_txt_nombre);
            this.groupBox2.Controls.Add(this.p_txt_cantidad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 243);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crear Medicamento";
            // 
            // p_btn_cancelar1
            // 
            this.p_btn_cancelar1.Location = new System.Drawing.Point(139, 195);
            this.p_btn_cancelar1.Name = "p_btn_cancelar1";
            this.p_btn_cancelar1.Size = new System.Drawing.Size(116, 31);
            this.p_btn_cancelar1.TabIndex = 10;
            this.p_btn_cancelar1.Text = "Cancelar";
            this.p_btn_cancelar1.UseVisualStyleBackColor = true;
            this.p_btn_cancelar1.Click += new System.EventHandler(this.i_btn_cancelar1_Click);
            // 
            // p_btn_agregar
            // 
            this.p_btn_agregar.Location = new System.Drawing.Point(17, 195);
            this.p_btn_agregar.Name = "p_btn_agregar";
            this.p_btn_agregar.Size = new System.Drawing.Size(116, 31);
            this.p_btn_agregar.TabIndex = 9;
            this.p_btn_agregar.Text = "Agregar";
            this.p_btn_agregar.UseVisualStyleBackColor = true;
            this.p_btn_agregar.Click += new System.EventHandler(this.i_btn_agregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio Unitario";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // p_txt_codigo
            // 
            this.p_txt_codigo.Location = new System.Drawing.Point(120, 33);
            this.p_txt_codigo.Multiline = true;
            this.p_txt_codigo.Name = "p_txt_codigo";
            this.p_txt_codigo.Size = new System.Drawing.Size(167, 32);
            this.p_txt_codigo.TabIndex = 4;
            // 
            // p_txt_precio
            // 
            this.p_txt_precio.Location = new System.Drawing.Point(120, 147);
            this.p_txt_precio.Multiline = true;
            this.p_txt_precio.Name = "p_txt_precio";
            this.p_txt_precio.Size = new System.Drawing.Size(167, 32);
            this.p_txt_precio.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Codigo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // p_txt_nombre
            // 
            this.p_txt_nombre.Location = new System.Drawing.Point(120, 71);
            this.p_txt_nombre.Multiline = true;
            this.p_txt_nombre.Name = "p_txt_nombre";
            this.p_txt_nombre.Size = new System.Drawing.Size(167, 32);
            this.p_txt_nombre.TabIndex = 8;
            // 
            // p_txt_cantidad
            // 
            this.p_txt_cantidad.Location = new System.Drawing.Point(120, 109);
            this.p_txt_cantidad.Multiline = true;
            this.p_txt_cantidad.Name = "p_txt_cantidad";
            this.p_txt_cantidad.Size = new System.Drawing.Size(167, 32);
            this.p_txt_cantidad.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.p_btn_cancelar2);
            this.groupBox1.Controls.Add(this.p_eliminar);
            this.groupBox1.Controls.Add(this.p_txt_codigoEliminar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(319, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 120);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar Medicamento";
            // 
            // p_btn_cancelar2
            // 
            this.p_btn_cancelar2.Location = new System.Drawing.Point(141, 74);
            this.p_btn_cancelar2.Name = "p_btn_cancelar2";
            this.p_btn_cancelar2.Size = new System.Drawing.Size(116, 31);
            this.p_btn_cancelar2.TabIndex = 10;
            this.p_btn_cancelar2.Text = "Cancelar";
            this.p_btn_cancelar2.UseVisualStyleBackColor = true;
            this.p_btn_cancelar2.Click += new System.EventHandler(this.i_btn_cancelar2_Click);
            // 
            // p_eliminar
            // 
            this.p_eliminar.Location = new System.Drawing.Point(19, 74);
            this.p_eliminar.Name = "p_eliminar";
            this.p_eliminar.Size = new System.Drawing.Size(116, 31);
            this.p_eliminar.TabIndex = 9;
            this.p_eliminar.Text = "Eliminar";
            this.p_eliminar.UseVisualStyleBackColor = true;
            this.p_eliminar.Click += new System.EventHandler(this.i_eliminar_Click);
            // 
            // p_txt_codigoEliminar
            // 
            this.p_txt_codigoEliminar.Location = new System.Drawing.Point(90, 33);
            this.p_txt_codigoEliminar.Multiline = true;
            this.p_txt_codigoEliminar.Name = "p_txt_codigoEliminar";
            this.p_txt_codigoEliminar.Size = new System.Drawing.Size(201, 32);
            this.p_txt_codigoEliminar.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Codigo";
            // 
            // p_Lista
            // 
            this.p_Lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_Lista.Controls.Add(this.label7);
            this.p_Lista.Controls.Add(this.p_btn_buscarCancelar);
            this.p_Lista.Controls.Add(this.label6);
            this.p_Lista.Controls.Add(this.p_btn_buscar);
            this.p_Lista.Controls.Add(this.p_txt_buscar);
            this.p_Lista.Controls.Add(this.i_listaMedicamentos);
            this.p_Lista.Location = new System.Drawing.Point(12, 303);
            this.p_Lista.Margin = new System.Windows.Forms.Padding(4);
            this.p_Lista.Name = "p_Lista";
            this.p_Lista.Padding = new System.Windows.Forms.Padding(4);
            this.p_Lista.Size = new System.Drawing.Size(778, 349);
            this.p_Lista.TabIndex = 13;
            this.p_Lista.TabStop = false;
            this.p_Lista.Text = "Lista";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ingresa el nombre a buscar";
            // 
            // p_btn_buscarCancelar
            // 
            this.p_btn_buscarCancelar.Location = new System.Drawing.Point(427, 45);
            this.p_btn_buscarCancelar.Name = "p_btn_buscarCancelar";
            this.p_btn_buscarCancelar.Size = new System.Drawing.Size(116, 32);
            this.p_btn_buscarCancelar.TabIndex = 10;
            this.p_btn_buscarCancelar.Text = "Cancelar";
            this.p_btn_buscarCancelar.UseVisualStyleBackColor = true;
            this.p_btn_buscarCancelar.Click += new System.EventHandler(this.i_btn_buscarCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(640, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 4;
            // 
            // p_btn_buscar
            // 
            this.p_btn_buscar.Location = new System.Drawing.Point(305, 45);
            this.p_btn_buscar.Name = "p_btn_buscar";
            this.p_btn_buscar.Size = new System.Drawing.Size(116, 32);
            this.p_btn_buscar.TabIndex = 2;
            this.p_btn_buscar.Text = "Buscar";
            this.p_btn_buscar.UseVisualStyleBackColor = true;
            this.p_btn_buscar.Click += new System.EventHandler(this.I_Buscar_Click);
            // 
            // p_txt_buscar
            // 
            this.p_txt_buscar.Location = new System.Drawing.Point(7, 45);
            this.p_txt_buscar.Multiline = true;
            this.p_txt_buscar.Name = "p_txt_buscar";
            this.p_txt_buscar.Size = new System.Drawing.Size(292, 32);
            this.p_txt_buscar.TabIndex = 1;
            this.p_txt_buscar.TextChanged += new System.EventHandler(this.i_txt_buscar_TextChanged);
            // 
            // i_listaMedicamentos
            // 
            this.i_listaMedicamentos.AllowUserToAddRows = false;
            this.i_listaMedicamentos.AllowUserToDeleteRows = false;
            this.i_listaMedicamentos.AllowUserToOrderColumns = true;
            this.i_listaMedicamentos.AllowUserToResizeRows = false;
            this.i_listaMedicamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.i_listaMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.i_listaMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.i_listaMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ic_Codigo,
            this.p_Nombre,
            this.Ic_Cantida,
            this.Ic_PrecioU,
            this.Ic_Montototal});
            this.i_listaMedicamentos.Enabled = false;
            this.i_listaMedicamentos.Location = new System.Drawing.Point(8, 84);
            this.i_listaMedicamentos.Margin = new System.Windows.Forms.Padding(4);
            this.i_listaMedicamentos.Name = "i_listaMedicamentos";
            this.i_listaMedicamentos.Size = new System.Drawing.Size(762, 257);
            this.i_listaMedicamentos.TabIndex = 0;
            this.i_listaMedicamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.i_listaMedicamentos_CellContentClick);
            // 
            // Ic_Codigo
            // 
            this.Ic_Codigo.HeaderText = "Codigo";
            this.Ic_Codigo.Name = "Ic_Codigo";
            // 
            // p_Nombre
            // 
            this.p_Nombre.HeaderText = "Nombre";
            this.p_Nombre.Name = "p_Nombre";
            // 
            // Ic_Cantida
            // 
            this.Ic_Cantida.HeaderText = "Cantidad";
            this.Ic_Cantida.Name = "Ic_Cantida";
            // 
            // Ic_PrecioU
            // 
            this.Ic_PrecioU.HeaderText = "Precio Unitario";
            this.Ic_PrecioU.Name = "Ic_PrecioU";
            // 
            // Ic_Montototal
            // 
            this.Ic_Montototal.HeaderText = "Monto Invertido";
            this.Ic_Montototal.Name = "Ic_Montototal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 665);
            this.Controls.Add(this.p_Lista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Farmacia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.p_Lista.ResumeLayout(false);
            this.p_Lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.i_listaMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button p_btn_cancelar1;
        private System.Windows.Forms.Button p_btn_agregar;
        public System.Windows.Forms.TextBox p_txt_nombre;
        public System.Windows.Forms.TextBox p_txt_cantidad;
        public System.Windows.Forms.TextBox p_txt_precio;
        public System.Windows.Forms.TextBox p_txt_codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button p_btn_cancelar2;
        private System.Windows.Forms.Button p_eliminar;
        public System.Windows.Forms.TextBox p_txt_codigoEliminar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox p_Lista;
        private System.Windows.Forms.Button p_btn_buscarCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button p_btn_buscar;
        private System.Windows.Forms.TextBox p_txt_buscar;
        private System.Windows.Forms.DataGridView i_listaMedicamentos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ic_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ic_Cantida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ic_PrecioU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ic_Montototal;
    }
}

