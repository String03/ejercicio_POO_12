namespace ejercicio_POO_12
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
            this.GrillaContenedores = new System.Windows.Forms.DataGridView();
            this.GrillaContenedoresCliente = new System.Windows.Forms.DataGridView();
            this.GrillaClientes = new System.Windows.Forms.DataGridView();
            this.btn_alta_contenedor = new System.Windows.Forms.Button();
            this.btn_modificacion_contenedor = new System.Windows.Forms.Button();
            this.btn_baja_contenedor = new System.Windows.Forms.Button();
            this.btn_alta_cliente = new System.Windows.Forms.Button();
            this.btn_modificacion_cliente = new System.Windows.Forms.Button();
            this.btn_baja_cliente = new System.Windows.Forms.Button();
            this.btn_contenedores_cliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo_contenedor_a = new System.Windows.Forms.RadioButton();
            this.rdo_contenedor_b = new System.Windows.Forms.RadioButton();
            this.rdo_persona_cliente = new System.Windows.Forms.RadioButton();
            this.rdo_empresa_cliente = new System.Windows.Forms.RadioButton();
            this.txt_codigo_contenedor = new System.Windows.Forms.TextBox();
            this.txt_denominacion_contenedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_legajo_persona_cliente = new System.Windows.Forms.TextBox();
            this.txt_nombre_persona_cliente = new System.Windows.Forms.TextBox();
            this.txt_apellido_persona_cliente = new System.Windows.Forms.TextBox();
            this.txt_legajo_empresa_cliente = new System.Windows.Forms.TextBox();
            this.txt_razonsocial_persona_cliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_fecha_de_ingreso_contenedor = new System.Windows.Forms.TextBox();
            this.txt_peso_contenedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaContenedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaContenedoresCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrillaContenedores
            // 
            this.GrillaContenedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaContenedores.Location = new System.Drawing.Point(63, 95);
            this.GrillaContenedores.MultiSelect = false;
            this.GrillaContenedores.Name = "GrillaContenedores";
            this.GrillaContenedores.ReadOnly = true;
            this.GrillaContenedores.RowTemplate.Height = 24;
            this.GrillaContenedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaContenedores.Size = new System.Drawing.Size(421, 153);
            this.GrillaContenedores.TabIndex = 0;
            // 
            // GrillaContenedoresCliente
            // 
            this.GrillaContenedoresCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaContenedoresCliente.Location = new System.Drawing.Point(777, 95);
            this.GrillaContenedoresCliente.MultiSelect = false;
            this.GrillaContenedoresCliente.Name = "GrillaContenedoresCliente";
            this.GrillaContenedoresCliente.ReadOnly = true;
            this.GrillaContenedoresCliente.RowTemplate.Height = 24;
            this.GrillaContenedoresCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaContenedoresCliente.Size = new System.Drawing.Size(421, 150);
            this.GrillaContenedoresCliente.TabIndex = 1;
            // 
            // GrillaClientes
            // 
            this.GrillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaClientes.Location = new System.Drawing.Point(63, 439);
            this.GrillaClientes.MultiSelect = false;
            this.GrillaClientes.Name = "GrillaClientes";
            this.GrillaClientes.ReadOnly = true;
            this.GrillaClientes.RowTemplate.Height = 24;
            this.GrillaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaClientes.Size = new System.Drawing.Size(421, 153);
            this.GrillaClientes.TabIndex = 2;
            // 
            // btn_alta_contenedor
            // 
            this.btn_alta_contenedor.Location = new System.Drawing.Point(84, 277);
            this.btn_alta_contenedor.Name = "btn_alta_contenedor";
            this.btn_alta_contenedor.Size = new System.Drawing.Size(118, 49);
            this.btn_alta_contenedor.TabIndex = 3;
            this.btn_alta_contenedor.Text = "Alta Contenedor";
            this.btn_alta_contenedor.UseVisualStyleBackColor = true;
            this.btn_alta_contenedor.Click += new System.EventHandler(this.btn_alta_contenedor_Click);
            // 
            // btn_modificacion_contenedor
            // 
            this.btn_modificacion_contenedor.Location = new System.Drawing.Point(233, 277);
            this.btn_modificacion_contenedor.Name = "btn_modificacion_contenedor";
            this.btn_modificacion_contenedor.Size = new System.Drawing.Size(117, 49);
            this.btn_modificacion_contenedor.TabIndex = 4;
            this.btn_modificacion_contenedor.Text = "Modificación Contenedor";
            this.btn_modificacion_contenedor.UseVisualStyleBackColor = true;
            this.btn_modificacion_contenedor.Click += new System.EventHandler(this.btn_modificacion_contenedor_Click);
            // 
            // btn_baja_contenedor
            // 
            this.btn_baja_contenedor.Location = new System.Drawing.Point(397, 277);
            this.btn_baja_contenedor.Name = "btn_baja_contenedor";
            this.btn_baja_contenedor.Size = new System.Drawing.Size(111, 49);
            this.btn_baja_contenedor.TabIndex = 5;
            this.btn_baja_contenedor.Text = "Baja Contenedor";
            this.btn_baja_contenedor.UseVisualStyleBackColor = true;
            this.btn_baja_contenedor.Click += new System.EventHandler(this.btn_baja_contenedor_Click);
            // 
            // btn_alta_cliente
            // 
            this.btn_alta_cliente.Location = new System.Drawing.Point(75, 637);
            this.btn_alta_cliente.Name = "btn_alta_cliente";
            this.btn_alta_cliente.Size = new System.Drawing.Size(118, 23);
            this.btn_alta_cliente.TabIndex = 6;
            this.btn_alta_cliente.Text = "Alta Cliente";
            this.btn_alta_cliente.UseVisualStyleBackColor = true;
            this.btn_alta_cliente.Click += new System.EventHandler(this.btn_alta_cliente_Click);
            // 
            // btn_modificacion_cliente
            // 
            this.btn_modificacion_cliente.Location = new System.Drawing.Point(214, 637);
            this.btn_modificacion_cliente.Name = "btn_modificacion_cliente";
            this.btn_modificacion_cliente.Size = new System.Drawing.Size(117, 52);
            this.btn_modificacion_cliente.TabIndex = 7;
            this.btn_modificacion_cliente.Text = "Modificación Cliente";
            this.btn_modificacion_cliente.UseVisualStyleBackColor = true;
            this.btn_modificacion_cliente.Click += new System.EventHandler(this.btn_modificacion_cliente_Click);
            // 
            // btn_baja_cliente
            // 
            this.btn_baja_cliente.Location = new System.Drawing.Point(373, 637);
            this.btn_baja_cliente.Name = "btn_baja_cliente";
            this.btn_baja_cliente.Size = new System.Drawing.Size(111, 23);
            this.btn_baja_cliente.TabIndex = 8;
            this.btn_baja_cliente.Text = "Baja Cliente";
            this.btn_baja_cliente.UseVisualStyleBackColor = true;
            this.btn_baja_cliente.Click += new System.EventHandler(this.btn_baja_cliente_Click);
            // 
            // btn_contenedores_cliente
            // 
            this.btn_contenedores_cliente.Location = new System.Drawing.Point(777, 294);
            this.btn_contenedores_cliente.Name = "btn_contenedores_cliente";
            this.btn_contenedores_cliente.Size = new System.Drawing.Size(118, 54);
            this.btn_contenedores_cliente.TabIndex = 9;
            this.btn_contenedores_cliente.Text = "Contenedores del Cliente";
            this.btn_contenedores_cliente.UseVisualStyleBackColor = true;
            this.btn_contenedores_cliente.Click += new System.EventHandler(this.btn_contenedores_cliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_empresa_cliente);
            this.groupBox1.Controls.Add(this.rdo_persona_cliente);
            this.groupBox1.Location = new System.Drawing.Point(524, 476);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_contenedor_b);
            this.groupBox2.Controls.Add(this.rdo_contenedor_a);
            this.groupBox2.Location = new System.Drawing.Point(524, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Contenedor";
            // 
            // rdo_contenedor_a
            // 
            this.rdo_contenedor_a.AutoSize = true;
            this.rdo_contenedor_a.Checked = true;
            this.rdo_contenedor_a.Location = new System.Drawing.Point(7, 31);
            this.rdo_contenedor_a.Name = "rdo_contenedor_a";
            this.rdo_contenedor_a.Size = new System.Drawing.Size(116, 21);
            this.rdo_contenedor_a.TabIndex = 0;
            this.rdo_contenedor_a.TabStop = true;
            this.rdo_contenedor_a.Text = "Contenedor A";
            this.rdo_contenedor_a.UseVisualStyleBackColor = true;
            // 
            // rdo_contenedor_b
            // 
            this.rdo_contenedor_b.AutoSize = true;
            this.rdo_contenedor_b.Location = new System.Drawing.Point(7, 59);
            this.rdo_contenedor_b.Name = "rdo_contenedor_b";
            this.rdo_contenedor_b.Size = new System.Drawing.Size(116, 21);
            this.rdo_contenedor_b.TabIndex = 1;
            this.rdo_contenedor_b.Text = "Contenedor B";
            this.rdo_contenedor_b.UseVisualStyleBackColor = true;
            // 
            // rdo_persona_cliente
            // 
            this.rdo_persona_cliente.AutoSize = true;
            this.rdo_persona_cliente.Checked = true;
            this.rdo_persona_cliente.Location = new System.Drawing.Point(7, 32);
            this.rdo_persona_cliente.Name = "rdo_persona_cliente";
            this.rdo_persona_cliente.Size = new System.Drawing.Size(82, 21);
            this.rdo_persona_cliente.TabIndex = 0;
            this.rdo_persona_cliente.TabStop = true;
            this.rdo_persona_cliente.Text = "Persona";
            this.rdo_persona_cliente.UseVisualStyleBackColor = true;
            // 
            // rdo_empresa_cliente
            // 
            this.rdo_empresa_cliente.AutoSize = true;
            this.rdo_empresa_cliente.Location = new System.Drawing.Point(7, 60);
            this.rdo_empresa_cliente.Name = "rdo_empresa_cliente";
            this.rdo_empresa_cliente.Size = new System.Drawing.Size(85, 21);
            this.rdo_empresa_cliente.TabIndex = 1;
            this.rdo_empresa_cliente.Text = "Empresa";
            this.rdo_empresa_cliente.UseVisualStyleBackColor = true;
            // 
            // txt_codigo_contenedor
            // 
            this.txt_codigo_contenedor.Location = new System.Drawing.Point(126, 345);
            this.txt_codigo_contenedor.Name = "txt_codigo_contenedor";
            this.txt_codigo_contenedor.Size = new System.Drawing.Size(100, 22);
            this.txt_codigo_contenedor.TabIndex = 13;
            // 
            // txt_denominacion_contenedor
            // 
            this.txt_denominacion_contenedor.Location = new System.Drawing.Point(126, 384);
            this.txt_denominacion_contenedor.Name = "txt_denominacion_contenedor";
            this.txt_denominacion_contenedor.Size = new System.Drawing.Size(100, 22);
            this.txt_denominacion_contenedor.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Denominación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 718);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Persona";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 717);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Empresa";
            // 
            // txt_legajo_persona_cliente
            // 
            this.txt_legajo_persona_cliente.Location = new System.Drawing.Point(126, 751);
            this.txt_legajo_persona_cliente.Name = "txt_legajo_persona_cliente";
            this.txt_legajo_persona_cliente.Size = new System.Drawing.Size(100, 22);
            this.txt_legajo_persona_cliente.TabIndex = 19;
            // 
            // txt_nombre_persona_cliente
            // 
            this.txt_nombre_persona_cliente.Location = new System.Drawing.Point(126, 793);
            this.txt_nombre_persona_cliente.Name = "txt_nombre_persona_cliente";
            this.txt_nombre_persona_cliente.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre_persona_cliente.TabIndex = 20;
            // 
            // txt_apellido_persona_cliente
            // 
            this.txt_apellido_persona_cliente.Location = new System.Drawing.Point(126, 832);
            this.txt_apellido_persona_cliente.Name = "txt_apellido_persona_cliente";
            this.txt_apellido_persona_cliente.Size = new System.Drawing.Size(100, 22);
            this.txt_apellido_persona_cliente.TabIndex = 21;
            // 
            // txt_legajo_empresa_cliente
            // 
            this.txt_legajo_empresa_cliente.Location = new System.Drawing.Point(373, 751);
            this.txt_legajo_empresa_cliente.Name = "txt_legajo_empresa_cliente";
            this.txt_legajo_empresa_cliente.Size = new System.Drawing.Size(100, 22);
            this.txt_legajo_empresa_cliente.TabIndex = 22;
            // 
            // txt_razonsocial_persona_cliente
            // 
            this.txt_razonsocial_persona_cliente.Location = new System.Drawing.Point(373, 793);
            this.txt_razonsocial_persona_cliente.Name = "txt_razonsocial_persona_cliente";
            this.txt_razonsocial_persona_cliente.Size = new System.Drawing.Size(100, 22);
            this.txt_razonsocial_persona_cliente.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 751);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Legajo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 793);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Razón Social";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 750);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Legajo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 793);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 832);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Apellido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Fecha de Ingreso";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(272, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Peso";
            // 
            // txt_fecha_de_ingreso_contenedor
            // 
            this.txt_fecha_de_ingreso_contenedor.Location = new System.Drawing.Point(397, 344);
            this.txt_fecha_de_ingreso_contenedor.Name = "txt_fecha_de_ingreso_contenedor";
            this.txt_fecha_de_ingreso_contenedor.Size = new System.Drawing.Size(100, 22);
            this.txt_fecha_de_ingreso_contenedor.TabIndex = 31;
            // 
            // txt_peso_contenedor
            // 
            this.txt_peso_contenedor.Location = new System.Drawing.Point(397, 383);
            this.txt_peso_contenedor.Name = "txt_peso_contenedor";
            this.txt_peso_contenedor.Size = new System.Drawing.Size(100, 22);
            this.txt_peso_contenedor.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 1030);
            this.Controls.Add(this.txt_peso_contenedor);
            this.Controls.Add(this.txt_fecha_de_ingreso_contenedor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_razonsocial_persona_cliente);
            this.Controls.Add(this.txt_legajo_empresa_cliente);
            this.Controls.Add(this.txt_apellido_persona_cliente);
            this.Controls.Add(this.txt_nombre_persona_cliente);
            this.Controls.Add(this.txt_legajo_persona_cliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_denominacion_contenedor);
            this.Controls.Add(this.txt_codigo_contenedor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_contenedores_cliente);
            this.Controls.Add(this.btn_baja_cliente);
            this.Controls.Add(this.btn_modificacion_cliente);
            this.Controls.Add(this.btn_alta_cliente);
            this.Controls.Add(this.btn_baja_contenedor);
            this.Controls.Add(this.btn_modificacion_contenedor);
            this.Controls.Add(this.btn_alta_contenedor);
            this.Controls.Add(this.GrillaClientes);
            this.Controls.Add(this.GrillaContenedoresCliente);
            this.Controls.Add(this.GrillaContenedores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaContenedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaContenedoresCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaContenedores;
        private System.Windows.Forms.DataGridView GrillaContenedoresCliente;
        private System.Windows.Forms.DataGridView GrillaClientes;
        private System.Windows.Forms.Button btn_alta_contenedor;
        private System.Windows.Forms.Button btn_modificacion_contenedor;
        private System.Windows.Forms.Button btn_baja_contenedor;
        private System.Windows.Forms.Button btn_alta_cliente;
        private System.Windows.Forms.Button btn_modificacion_cliente;
        private System.Windows.Forms.Button btn_baja_cliente;
        private System.Windows.Forms.Button btn_contenedores_cliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_empresa_cliente;
        private System.Windows.Forms.RadioButton rdo_persona_cliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo_contenedor_b;
        private System.Windows.Forms.RadioButton rdo_contenedor_a;
        private System.Windows.Forms.TextBox txt_codigo_contenedor;
        private System.Windows.Forms.TextBox txt_denominacion_contenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_legajo_persona_cliente;
        private System.Windows.Forms.TextBox txt_nombre_persona_cliente;
        private System.Windows.Forms.TextBox txt_apellido_persona_cliente;
        private System.Windows.Forms.TextBox txt_legajo_empresa_cliente;
        private System.Windows.Forms.TextBox txt_razonsocial_persona_cliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_fecha_de_ingreso_contenedor;
        private System.Windows.Forms.TextBox txt_peso_contenedor;
    }
}

