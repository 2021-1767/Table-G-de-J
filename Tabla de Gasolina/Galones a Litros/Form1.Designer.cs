namespace Galones_a_Litros
{
    partial class Form1
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Litros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Galones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gasolinaprecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pase = new System.Windows.Forms.TextBox();
            this.txtpromedio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpromediorms = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnborrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(366, 502);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(176, 57);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Iniciar";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dtgv
            // 
            this.dtgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.Litros,
            this.Galones,
            this.Precio});
            this.dtgv.Location = new System.Drawing.Point(588, 15);
            this.dtgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.Size = new System.Drawing.Size(509, 611);
            this.dtgv.TabIndex = 2;
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentClick);
            // 
            // x
            // 
            this.x.HeaderText = "ID";
            this.x.MinimumWidth = 6;
            this.x.Name = "x";
            this.x.Width = 125;
            // 
            // Litros
            // 
            this.Litros.HeaderText = "Litros/Km";
            this.Litros.MinimumWidth = 6;
            this.Litros.Name = "Litros";
            this.Litros.Width = 80;
            // 
            // Galones
            // 
            this.Galones.HeaderText = "GalonPorKm";
            this.Galones.MinimumWidth = 6;
            this.Galones.Name = "Galones";
            this.Galones.Width = 80;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "CostoPorKM";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 80;
            // 
            // cantidad
            // 
            this.cantidad.BackColor = System.Drawing.Color.FloralWhite;
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(320, 318);
            this.cantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cantidad.Multiline = true;
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(179, 41);
            this.cantidad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tabla de Precios de la Gasolina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Introducir Cantidad de litros";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Promedio Ciudad: 12.5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Promedio carretera: 10.5 ";
            // 
            // gasolinaprecio
            // 
            this.gasolinaprecio.BackColor = System.Drawing.Color.FloralWhite;
            this.gasolinaprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasolinaprecio.Location = new System.Drawing.Point(320, 211);
            this.gasolinaprecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gasolinaprecio.Multiline = true;
            this.gasolinaprecio.Name = "gasolinaprecio";
            this.gasolinaprecio.Size = new System.Drawing.Size(179, 41);
            this.gasolinaprecio.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Introducir precio de gasolina";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 318);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Introducir paso";
            // 
            // pase
            // 
            this.pase.BackColor = System.Drawing.Color.FloralWhite;
            this.pase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pase.Location = new System.Drawing.Point(320, 269);
            this.pase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pase.Multiline = true;
            this.pase.Name = "pase";
            this.pase.Size = new System.Drawing.Size(179, 41);
            this.pase.TabIndex = 12;
            // 
            // txtpromedio
            // 
            this.txtpromedio.BackColor = System.Drawing.Color.FloralWhite;
            this.txtpromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpromedio.Location = new System.Drawing.Point(320, 379);
            this.txtpromedio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpromedio.Multiline = true;
            this.txtpromedio.Name = "txtpromedio";
            this.txtpromedio.ReadOnly = true;
            this.txtpromedio.Size = new System.Drawing.Size(179, 41);
            this.txtpromedio.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(190, 379);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Promedio";
            // 
            // txtpromediorms
            // 
            this.txtpromediorms.BackColor = System.Drawing.Color.FloralWhite;
            this.txtpromediorms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpromediorms.Location = new System.Drawing.Point(320, 440);
            this.txtpromediorms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpromediorms.Multiline = true;
            this.txtpromediorms.Name = "txtpromediorms";
            this.txtpromediorms.ReadOnly = true;
            this.txtpromediorms.Size = new System.Drawing.Size(179, 40);
            this.txtpromediorms.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(134, 440);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Promedio RM/S";
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.Color.Red;
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(366, 585);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(176, 57);
            this.btnborrar.TabIndex = 17;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Galones_a_Litros.Properties.Resources.GAD;
            this.ClientSize = new System.Drawing.Size(1126, 655);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtpromediorms);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtpromedio);
            this.Controls.Add(this.pase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gasolinaprecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.btnCalcular);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Tabla de Gasolina";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn Litros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Galones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gasolinaprecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pase;
        private System.Windows.Forms.TextBox txtpromedio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpromediorms;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnborrar;
    }
}

