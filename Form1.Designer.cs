namespace Dante3
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
            this.Cmb1 = new System.Windows.Forms.ComboBox();
            this.dtgv1 = new System.Windows.Forms.DataGridView();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtProblema = new System.Windows.Forms.TextBox();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.TxtRemuneracion = new System.Windows.Forms.TextBox();
            this.TxtResolucion = new System.Windows.Forms.TextBox();
            this.LBLId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFinalizacion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbBool = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cmb1
            // 
            this.Cmb1.FormattingEnabled = true;
            this.Cmb1.ItemHeight = 13;
            this.Cmb1.Location = new System.Drawing.Point(218, 227);
            this.Cmb1.Name = "Cmb1";
            this.Cmb1.Size = new System.Drawing.Size(292, 21);
            this.Cmb1.TabIndex = 80;
            // 
            // dtgv1
            // 
            this.dtgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgv1.Location = new System.Drawing.Point(12, 254);
            this.dtgv1.Name = "dtgv1";
            this.dtgv1.Size = new System.Drawing.Size(688, 172);
            this.dtgv1.TabIndex = 300;
            this.dtgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv1_CellClick);
            this.dtgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv1_CellContentClick);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(280, 175);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(97, 39);
            this.Btn1.TabIndex = 200;
            this.Btn1.Text = "NOMBRES";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(386, 175);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(90, 39);
            this.Btn2.TabIndex = 210;
            this.Btn2.Text = "APELLIDOS";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(424, 110);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(152, 21);
            this.Btn3.TabIndex = 120;
            this.Btn3.Text = "EDITAR";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CARGAR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = " GRID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 21);
            this.button1.TabIndex = 8;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(60, 34);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(93, 20);
            this.TxtId.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 21);
            this.button2.TabIndex = 110;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(63, 60);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(90, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(242, 34);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(90, 20);
            this.TxtApellido.TabIndex = 2;
            // 
            // TxtProblema
            // 
            this.TxtProblema.Location = new System.Drawing.Point(242, 67);
            this.TxtProblema.Name = "TxtProblema";
            this.TxtProblema.Size = new System.Drawing.Size(90, 20);
            this.TxtProblema.TabIndex = 3;
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(599, 41);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(90, 20);
            this.TxtFecha.TabIndex = 6;
            // 
            // TxtRemuneracion
            // 
            this.TxtRemuneracion.Location = new System.Drawing.Point(599, 64);
            this.TxtRemuneracion.Name = "TxtRemuneracion";
            this.TxtRemuneracion.Size = new System.Drawing.Size(90, 20);
            this.TxtRemuneracion.TabIndex = 7;
            // 
            // TxtResolucion
            // 
            this.TxtResolucion.Location = new System.Drawing.Point(416, 37);
            this.TxtResolucion.Name = "TxtResolucion";
            this.TxtResolucion.Size = new System.Drawing.Size(90, 20);
            this.TxtResolucion.TabIndex = 4;
            // 
            // LBLId
            // 
            this.LBLId.AutoSize = true;
            this.LBLId.Location = new System.Drawing.Point(24, 37);
            this.LBLId.Name = "LBLId";
            this.LBLId.Size = new System.Drawing.Size(19, 13);
            this.LBLId.TabIndex = 17;
            this.LBLId.Text = "Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Problema:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Resolucion:";
            // 
            // lblFinalizacion
            // 
            this.lblFinalizacion.AutoSize = true;
            this.lblFinalizacion.Location = new System.Drawing.Point(350, 67);
            this.lblFinalizacion.Name = "lblFinalizacion";
            this.lblFinalizacion.Size = new System.Drawing.Size(51, 13);
            this.lblFinalizacion.TabIndex = 22;
            this.lblFinalizacion.Text = "Finalizo?:";
            this.lblFinalizacion.Click += new System.EventHandler(this.lblFinalizacion_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(518, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Remuneracion:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(536, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Fecha:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbBool);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Btn3);
            this.groupBox1.Controls.Add(this.lblFinalizacion);
            this.groupBox1.Controls.Add(this.LBLId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TxtFecha);
            this.groupBox1.Controls.Add(this.TxtRemuneracion);
            this.groupBox1.Controls.Add(this.TxtResolucion);
            this.groupBox1.Controls.Add(this.TxtProblema);
            this.groupBox1.Controls.Add(this.TxtApellido);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AGREGAR";
            // 
            // CmbBool
            // 
            this.CmbBool.FormattingEnabled = true;
            this.CmbBool.Items.AddRange(new object[] {
            "true",
            "false"});
            this.CmbBool.Location = new System.Drawing.Point(416, 63);
            this.CmbBool.Name = "CmbBool";
            this.CmbBool.Size = new System.Drawing.Size(90, 21);
            this.CmbBool.TabIndex = 301;
            this.CmbBool.SelectionChangeCommitted += new System.EventHandler(this.CmbBool_SelectionChangeCommitted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.dtgv1);
            this.Controls.Add(this.Cmb1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cmb1;
        private System.Windows.Forms.DataGridView dtgv1;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtProblema;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.TextBox TxtRemuneracion;
        private System.Windows.Forms.TextBox TxtResolucion;
        private System.Windows.Forms.Label LBLId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFinalizacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbBool;
    }
}

