namespace Factura.Desing
{
    partial class Reportes
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
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTables
            // 
            this.cbTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Items.AddRange(new object[] {
            "Facturas",
            "Clientes",
            "Suplidores",
            "Compras",
            "Usuarios"});
            this.cbTables.Location = new System.Drawing.Point(475, 12);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(216, 28);
            this.cbTables.TabIndex = 0;
            this.cbTables.SelectedIndexChanged += new System.EventHandler(this.cbTables_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(19, 43);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(672, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(19, 73);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(672, 309);
            this.dgv.TabIndex = 3;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(543, 404);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(123, 23);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Generar Reporte";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(405, 404);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(132, 23);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Volver al Menu Principal";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 448);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbTables);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnMenu;
    }
}