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
            this.TxtFinalizacion = new System.Windows.Forms.TextBox();
            this.TxtResolucion = new System.Windows.Forms.TextBox();
            this.LBLId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmb1
            // 
            this.Cmb1.FormattingEnabled = true;
            this.Cmb1.Location = new System.Drawing.Point(408, 105);
            this.Cmb1.Name = "Cmb1";
            this.Cmb1.Size = new System.Drawing.Size(292, 21);
            this.Cmb1.TabIndex = 0;
            // 
            // dtgv1
            // 
            this.dtgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv1.Location = new System.Drawing.Point(12, 287);
            this.dtgv1.Name = "dtgv1";
            this.dtgv1.Size = new System.Drawing.Size(688, 172);
            this.dtgv1.TabIndex = 1;
            this.dtgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv1_CellContentClick);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(430, 58);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(97, 39);
            this.Btn1.TabIndex = 2;
            this.Btn1.Text = "NOMBRES";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(533, 60);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(90, 39);
            this.Btn2.TabIndex = 3;
            this.Btn2.Text = "APELLIDOS";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(215, 236);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(93, 39);
            this.Btn3.TabIndex = 4;
            this.Btn3.Text = "EDITAR";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CARGAR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CARGAR GRID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(106, 68);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(93, 20);
            this.TxtId.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(106, 94);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(90, 20);
            this.TxtNombre.TabIndex = 10;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(106, 120);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(90, 20);
            this.TxtApellido.TabIndex = 11;
            // 
            // TxtProblema
            // 
            this.TxtProblema.Location = new System.Drawing.Point(106, 146);
            this.TxtProblema.Name = "TxtProblema";
            this.TxtProblema.Size = new System.Drawing.Size(90, 20);
            this.TxtProblema.TabIndex = 12;
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(103, 255);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(90, 20);
            this.TxtFecha.TabIndex = 16;
            // 
            // TxtRemuneracion
            // 
            this.TxtRemuneracion.Location = new System.Drawing.Point(106, 228);
            this.TxtRemuneracion.Name = "TxtRemuneracion";
            this.TxtRemuneracion.Size = new System.Drawing.Size(90, 20);
            this.TxtRemuneracion.TabIndex = 15;
            // 
            // TxtFinalizacion
            // 
            this.TxtFinalizacion.Location = new System.Drawing.Point(106, 202);
            this.TxtFinalizacion.Name = "TxtFinalizacion";
            this.TxtFinalizacion.Size = new System.Drawing.Size(90, 20);
            this.TxtFinalizacion.TabIndex = 14;
            // 
            // TxtResolucion
            // 
            this.TxtResolucion.Location = new System.Drawing.Point(106, 176);
            this.TxtResolucion.Name = "TxtResolucion";
            this.TxtResolucion.Size = new System.Drawing.Size(90, 20);
            this.TxtResolucion.TabIndex = 13;
            // 
            // LBLId
            // 
            this.LBLId.AutoSize = true;
            this.LBLId.Location = new System.Drawing.Point(53, 75);
            this.LBLId.Name = "LBLId";
            this.LBLId.Size = new System.Drawing.Size(19, 13);
            this.LBLId.TabIndex = 17;
            this.LBLId.Text = "Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Problema:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Resolucion:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Finalizacion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Remuneracion:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Fecha:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 471);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBLId);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.TxtRemuneracion);
            this.Controls.Add(this.TxtFinalizacion);
            this.Controls.Add(this.TxtResolucion);
            this.Controls.Add(this.TxtProblema);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.dtgv1);
            this.Controls.Add(this.Cmb1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).EndInit();
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
        private System.Windows.Forms.TextBox TxtFinalizacion;
        private System.Windows.Forms.TextBox TxtResolucion;
        private System.Windows.Forms.Label LBLId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

