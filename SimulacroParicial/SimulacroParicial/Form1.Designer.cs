namespace SimulacroParicial
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
            this.tbDni = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDenuncia = new System.Windows.Forms.RadioButton();
            this.rbNuevoCliente = new System.Windows.Forms.RadioButton();
            this.tbPatente = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btnTicket = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTurnos = new System.Windows.Forms.ListBox();
            this.btnImportaVehiculos = new System.Windows.Forms.Button();
            this.btnExportarTickets = new System.Windows.Forms.Button();
            this.btnAtenderNuevoCliente = new System.Windows.Forms.Button();
            this.btnAtenderDenuncias = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(118, 32);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(252, 22);
            this.tbDni.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.tbPatente);
            this.groupBox1.Controls.Add(this.rbNuevoCliente);
            this.groupBox1.Controls.Add(this.rbDenuncia);
            this.groupBox1.Location = new System.Drawing.Point(33, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 155);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // rbDenuncia
            // 
            this.rbDenuncia.AutoSize = true;
            this.rbDenuncia.Location = new System.Drawing.Point(6, 45);
            this.rbDenuncia.Name = "rbDenuncia";
            this.rbDenuncia.Size = new System.Drawing.Size(85, 20);
            this.rbDenuncia.TabIndex = 0;
            this.rbDenuncia.TabStop = true;
            this.rbDenuncia.Text = "Denuncia";
            this.rbDenuncia.UseVisualStyleBackColor = true;
            // 
            // rbNuevoCliente
            // 
            this.rbNuevoCliente.AccessibleDescription = "hola}";
            this.rbNuevoCliente.AutoSize = true;
            this.rbNuevoCliente.Location = new System.Drawing.Point(6, 110);
            this.rbNuevoCliente.Name = "rbNuevoCliente";
            this.rbNuevoCliente.Size = new System.Drawing.Size(112, 20);
            this.rbNuevoCliente.TabIndex = 1;
            this.rbNuevoCliente.TabStop = true;
            this.rbNuevoCliente.Text = "Nuevo Cliente";
            this.rbNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // tbPatente
            // 
            this.tbPatente.Location = new System.Drawing.Point(124, 43);
            this.tbPatente.Name = "tbPatente";
            this.tbPatente.Size = new System.Drawing.Size(112, 22);
            this.tbPatente.TabIndex = 2;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(124, 110);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(88, 24);
            this.cbTipo.TabIndex = 3;
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(386, 74);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(99, 155);
            this.btnTicket.TabIndex = 4;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Turnos";
            // 
            // lbTurnos
            // 
            this.lbTurnos.FormattingEnabled = true;
            this.lbTurnos.ItemHeight = 16;
            this.lbTurnos.Location = new System.Drawing.Point(31, 282);
            this.lbTurnos.Name = "lbTurnos";
            this.lbTurnos.Size = new System.Drawing.Size(339, 84);
            this.lbTurnos.TabIndex = 6;
            // 
            // btnImportaVehiculos
            // 
            this.btnImportaVehiculos.Location = new System.Drawing.Point(386, 345);
            this.btnImportaVehiculos.Name = "btnImportaVehiculos";
            this.btnImportaVehiculos.Size = new System.Drawing.Size(116, 57);
            this.btnImportaVehiculos.TabIndex = 7;
            this.btnImportaVehiculos.Text = "Importar vehiculos";
            this.btnImportaVehiculos.UseVisualStyleBackColor = true;
            // 
            // btnExportarTickets
            // 
            this.btnExportarTickets.Location = new System.Drawing.Point(386, 282);
            this.btnExportarTickets.Name = "btnExportarTickets";
            this.btnExportarTickets.Size = new System.Drawing.Size(116, 57);
            this.btnExportarTickets.TabIndex = 8;
            this.btnExportarTickets.Text = "Exportar tickets";
            this.btnExportarTickets.UseVisualStyleBackColor = true;
            // 
            // btnAtenderNuevoCliente
            // 
            this.btnAtenderNuevoCliente.Location = new System.Drawing.Point(192, 383);
            this.btnAtenderNuevoCliente.Name = "btnAtenderNuevoCliente";
            this.btnAtenderNuevoCliente.Size = new System.Drawing.Size(116, 57);
            this.btnAtenderNuevoCliente.TabIndex = 9;
            this.btnAtenderNuevoCliente.Text = "Atender Nuevo Cliente";
            this.btnAtenderNuevoCliente.UseVisualStyleBackColor = true;
            this.btnAtenderNuevoCliente.Click += new System.EventHandler(this.btnAtenderNuevoCliente_Click);
            // 
            // btnAtenderDenuncias
            // 
            this.btnAtenderDenuncias.Location = new System.Drawing.Point(31, 383);
            this.btnAtenderDenuncias.Name = "btnAtenderDenuncias";
            this.btnAtenderDenuncias.Size = new System.Drawing.Size(116, 57);
            this.btnAtenderDenuncias.TabIndex = 10;
            this.btnAtenderDenuncias.Text = "Atender Denuncias";
            this.btnAtenderDenuncias.UseVisualStyleBackColor = true;
            this.btnAtenderDenuncias.Click += new System.EventHandler(this.btnAtenderDenuncias_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 484);
            this.Controls.Add(this.btnAtenderDenuncias);
            this.Controls.Add(this.btnAtenderNuevoCliente);
            this.Controls.Add(this.btnExportarTickets);
            this.Controls.Add(this.btnImportaVehiculos);
            this.Controls.Add(this.lbTurnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "|";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox tbPatente;
        private System.Windows.Forms.RadioButton rbNuevoCliente;
        private System.Windows.Forms.RadioButton rbDenuncia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbTurnos;
        private System.Windows.Forms.Button btnImportaVehiculos;
        private System.Windows.Forms.Button btnExportarTickets;
        private System.Windows.Forms.Button btnAtenderNuevoCliente;
        private System.Windows.Forms.Button btnAtenderDenuncias;
    }
}

