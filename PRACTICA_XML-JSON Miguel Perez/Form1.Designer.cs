namespace PRACTICA_XML_JSON_Miguel_Perez
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargarJSON = new System.Windows.Forms.Button();
            this.btnCargarXML = new System.Windows.Forms.Button();
            this.pntitulo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.pnlbltitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pntitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.pnlbltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.pnMenu.Controls.Add(this.panel2);
            this.pnMenu.Controls.Add(this.pntitulo);
            this.pnMenu.Controls.Add(this.pnLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnMenu.Location = new System.Drawing.Point(767, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(205, 413);
            this.pnMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnCargarJSON);
            this.panel2.Controls.Add(this.btnCargarXML);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 228);
            this.panel2.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(188)))), ((int)(((byte)(102)))));
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(0, 173);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(205, 55);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargarJSON
            // 
            this.btnCargarJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(188)))), ((int)(((byte)(102)))));
            this.btnCargarJSON.FlatAppearance.BorderSize = 0;
            this.btnCargarJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarJSON.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCargarJSON.Location = new System.Drawing.Point(0, 88);
            this.btnCargarJSON.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnCargarJSON.Name = "btnCargarJSON";
            this.btnCargarJSON.Size = new System.Drawing.Size(205, 55);
            this.btnCargarJSON.TabIndex = 1;
            this.btnCargarJSON.Text = "Cargar JSON";
            this.btnCargarJSON.UseVisualStyleBackColor = false;
            this.btnCargarJSON.Click += new System.EventHandler(this.btnCargarJSON_Click);
            // 
            // btnCargarXML
            // 
            this.btnCargarXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(188)))), ((int)(((byte)(102)))));
            this.btnCargarXML.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargarXML.FlatAppearance.BorderSize = 0;
            this.btnCargarXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarXML.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCargarXML.Location = new System.Drawing.Point(0, 0);
            this.btnCargarXML.Name = "btnCargarXML";
            this.btnCargarXML.Size = new System.Drawing.Size(205, 55);
            this.btnCargarXML.TabIndex = 0;
            this.btnCargarXML.Text = "Cargar XML";
            this.btnCargarXML.UseVisualStyleBackColor = false;
            this.btnCargarXML.Click += new System.EventHandler(this.btnCargarXML_Click);
            // 
            // pntitulo
            // 
            this.pntitulo.Controls.Add(this.panel1);
            this.pntitulo.Controls.Add(this.label1);
            this.pntitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pntitulo.Location = new System.Drawing.Point(0, 105);
            this.pntitulo.Name = "pntitulo";
            this.pntitulo.Size = new System.Drawing.Size(205, 80);
            this.pntitulo.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 54);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(148)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(22, 10, 15, 15);
            this.label2.Size = new System.Drawing.Size(201, 64);
            this.label2.TabIndex = 0;
            this.label2.Text = "Opciones";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.pnLogo.Controls.Add(this.pictureBox1);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnLogo.Size = new System.Drawing.Size(205, 105);
            this.pnLogo.TabIndex = 0;
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            this.dgEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgEmpleados.Location = new System.Drawing.Point(8, 67);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.RowHeadersWidth = 51;
            this.dgEmpleados.RowTemplate.Height = 24;
            this.dgEmpleados.Size = new System.Drawing.Size(753, 340);
            this.dgEmpleados.TabIndex = 1;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(148)))), ((int)(((byte)(96)))));
            this.lbltitulo.Location = new System.Drawing.Point(0, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.lbltitulo.Size = new System.Drawing.Size(478, 59);
            this.lbltitulo.TabIndex = 2;
            this.lbltitulo.Text = "Administración de Empleados";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlbltitulo
            // 
            this.pnlbltitulo.Controls.Add(this.lbltitulo);
            this.pnlbltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbltitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlbltitulo.Name = "pnlbltitulo";
            this.pnlbltitulo.Size = new System.Drawing.Size(767, 58);
            this.pnlbltitulo.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PRACTICA_XML_JSON_Miguel_Perez.Properties.Resources.list;
            this.pictureBox1.Location = new System.Drawing.Point(0, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(205, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(972, 413);
            this.Controls.Add(this.pnlbltitulo);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.pnMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practica XML Y JSON";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pntitulo.ResumeLayout(false);
            this.pntitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.pnlbltitulo.ResumeLayout(false);
            this.pnlbltitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCargarJSON;
        private System.Windows.Forms.Button btnCargarXML;
        private System.Windows.Forms.Panel pntitulo;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Panel pnlbltitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

