namespace Factura.Desing
{
    partial class VerReportes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFechaFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFPFactura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalFactura = new System.Windows.Forms.TextBox();
            this.txtUserFactura = new System.Windows.Forms.TextBox();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientFactura = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalClient = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhoneClient = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCedulaClient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtRepreSupplier = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProductMostBuyedSupplier = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPhoneSupplier = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtFechaFactura);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtFPFactura);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtTotalFactura);
            this.tabPage1.Controls.Add(this.txtUserFactura);
            this.tabPage1.Controls.Add(this.dgvFactura);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtClientFactura);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(574, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Factura";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha";
            // 
            // txtFechaFactura
            // 
            this.txtFechaFactura.Location = new System.Drawing.Point(113, 36);
            this.txtFechaFactura.Name = "txtFechaFactura";
            this.txtFechaFactura.ReadOnly = true;
            this.txtFechaFactura.Size = new System.Drawing.Size(140, 27);
            this.txtFechaFactura.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Forma de Pago";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtFPFactura
            // 
            this.txtFPFactura.Location = new System.Drawing.Point(396, 435);
            this.txtFPFactura.Name = "txtFPFactura";
            this.txtFPFactura.ReadOnly = true;
            this.txtFPFactura.Size = new System.Drawing.Size(114, 27);
            this.txtFPFactura.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Atendido por";
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Location = new System.Drawing.Point(396, 400);
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.ReadOnly = true;
            this.txtTotalFactura.Size = new System.Drawing.Size(114, 27);
            this.txtTotalFactura.TabIndex = 4;
            // 
            // txtUserFactura
            // 
            this.txtUserFactura.Location = new System.Drawing.Point(370, 36);
            this.txtUserFactura.Name = "txtUserFactura";
            this.txtUserFactura.ReadOnly = true;
            this.txtUserFactura.Size = new System.Drawing.Size(140, 27);
            this.txtUserFactura.TabIndex = 3;
            // 
            // dgvFactura
            // 
            this.dgvFactura.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(53, 69);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.Size = new System.Drawing.Size(457, 325);
            this.dgvFactura.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // txtClientFactura
            // 
            this.txtClientFactura.Location = new System.Drawing.Point(113, 6);
            this.txtClientFactura.Name = "txtClientFactura";
            this.txtClientFactura.ReadOnly = true;
            this.txtClientFactura.Size = new System.Drawing.Size(397, 27);
            this.txtClientFactura.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtTotalClient);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtPhoneClient);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtCedulaClient);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dgvClient);
            this.tabPage2.Controls.Add(this.txtClient);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(574, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cliente";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Facturas:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtTotalClient
            // 
            this.txtTotalClient.Location = new System.Drawing.Point(372, 428);
            this.txtTotalClient.Name = "txtTotalClient";
            this.txtTotalClient.ReadOnly = true;
            this.txtTotalClient.Size = new System.Drawing.Size(159, 20);
            this.txtTotalClient.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Total en compras";
            // 
            // txtPhoneClient
            // 
            this.txtPhoneClient.Location = new System.Drawing.Point(93, 59);
            this.txtPhoneClient.Name = "txtPhoneClient";
            this.txtPhoneClient.ReadOnly = true;
            this.txtPhoneClient.Size = new System.Drawing.Size(159, 20);
            this.txtPhoneClient.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Telefono";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtCedulaClient
            // 
            this.txtCedulaClient.Location = new System.Drawing.Point(366, 59);
            this.txtCedulaClient.Name = "txtCedulaClient";
            this.txtCedulaClient.ReadOnly = true;
            this.txtCedulaClient.Size = new System.Drawing.Size(164, 20);
            this.txtCedulaClient.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cedula de Identidad";
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(41, 143);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.Size = new System.Drawing.Size(490, 265);
            this.dgvClient.TabIndex = 2;
            this.dgvClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(253, 33);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(277, 20);
            this.txtClient.TabIndex = 1;
            this.txtClient.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cliente";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtRepreSupplier);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtProductMostBuyedSupplier);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtPhoneSupplier);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.dgvSupplier);
            this.tabPage3.Controls.Add(this.txtSupplier);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(574, 470);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Suplidor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtRepreSupplier
            // 
            this.txtRepreSupplier.Location = new System.Drawing.Point(345, 25);
            this.txtRepreSupplier.Name = "txtRepreSupplier";
            this.txtRepreSupplier.ReadOnly = true;
            this.txtRepreSupplier.Size = new System.Drawing.Size(188, 20);
            this.txtRepreSupplier.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(262, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Representante";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Productos:";
            // 
            // txtProductMostBuyedSupplier
            // 
            this.txtProductMostBuyedSupplier.Location = new System.Drawing.Point(375, 423);
            this.txtProductMostBuyedSupplier.Name = "txtProductMostBuyedSupplier";
            this.txtProductMostBuyedSupplier.ReadOnly = true;
            this.txtProductMostBuyedSupplier.Size = new System.Drawing.Size(159, 20);
            this.txtProductMostBuyedSupplier.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(246, 426);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Producto mas comprado";
            // 
            // txtPhoneSupplier
            // 
            this.txtPhoneSupplier.Location = new System.Drawing.Point(374, 51);
            this.txtPhoneSupplier.Name = "txtPhoneSupplier";
            this.txtPhoneSupplier.ReadOnly = true;
            this.txtPhoneSupplier.Size = new System.Drawing.Size(159, 20);
            this.txtPhoneSupplier.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(319, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Telefono";
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(44, 113);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.Size = new System.Drawing.Size(490, 290);
            this.dgvSupplier.TabIndex = 12;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(96, 25);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(159, 20);
            this.txtSupplier.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Suplidor";
            // 
            // VerReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 496);
            this.Controls.Add(this.tabControl1);
            this.Name = "VerReportes";
            this.Text = "VerReportes";
            this.Load += new System.EventHandler(this.VerReportes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFPFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalFactura;
        private System.Windows.Forms.TextBox txtUserFactura;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFechaFactura;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCedulaClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalClient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtRepreSupplier;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProductMostBuyedSupplier;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPhoneSupplier;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label label15;
    }
}