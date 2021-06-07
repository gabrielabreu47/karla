namespace Factura
{
    partial class Suplidores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suplidores));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewSUPLIDOR = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.TELEFONO = new System.Windows.Forms.TextBox();
            this.REPRESENTANTE = new System.Windows.Forms.TextBox();
            this.COMPAÑIA = new System.Windows.Forms.TextBox();
            this.txtCODSUPLI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSUPLIDOR)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(551, 229);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 22);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "Ver deshabilitados";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(424, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 23);
            this.button5.TabIndex = 34;
            this.button5.Text = "Habilitar/Deshabilitar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(123, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(668, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 32;
            this.button4.Text = "Editar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(668, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewSUPLIDOR
            // 
            this.dataGridViewSUPLIDOR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSUPLIDOR.Location = new System.Drawing.Point(123, 257);
            this.dataGridViewSUPLIDOR.Name = "dataGridViewSUPLIDOR";
            this.dataGridViewSUPLIDOR.ReadOnly = true;
            this.dataGridViewSUPLIDOR.Size = new System.Drawing.Size(539, 150);
            this.dataGridViewSUPLIDOR.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 22);
            this.button1.TabIndex = 28;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TELEFONO
            // 
            this.TELEFONO.Location = new System.Drawing.Point(379, 204);
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.Size = new System.Drawing.Size(212, 20);
            this.TELEFONO.TabIndex = 27;
            // 
            // REPRESENTANTE
            // 
            this.REPRESENTANTE.Location = new System.Drawing.Point(380, 179);
            this.REPRESENTANTE.Name = "REPRESENTANTE";
            this.REPRESENTANTE.Size = new System.Drawing.Size(211, 20);
            this.REPRESENTANTE.TabIndex = 26;
            // 
            // COMPAÑIA
            // 
            this.COMPAÑIA.Location = new System.Drawing.Point(379, 152);
            this.COMPAÑIA.Name = "COMPAÑIA";
            this.COMPAÑIA.Size = new System.Drawing.Size(212, 20);
            this.COMPAÑIA.TabIndex = 25;
            // 
            // txtCODSUPLI
            // 
            this.txtCODSUPLI.Location = new System.Drawing.Point(379, 126);
            this.txtCODSUPLI.Name = "txtCODSUPLI";
            this.txtCODSUPLI.Size = new System.Drawing.Size(50, 20);
            this.txtCODSUPLI.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(304, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(268, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Representante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(296, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Compañia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(296, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cod_Supli";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(668, 351);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 36;
            this.button6.Text = "Cancelar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(764, 472);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 22);
            this.button7.TabIndex = 102;
            this.button7.Text = "Volver al menu";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Suplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(866, 506);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewSUPLIDOR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TELEFONO);
            this.Controls.Add(this.REPRESENTANTE);
            this.Controls.Add(this.COMPAÑIA);
            this.Controls.Add(this.txtCODSUPLI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Suplidores";
            this.Text = "Suplidor";
            this.Load += new System.EventHandler(this.Suplidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSUPLIDOR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewSUPLIDOR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TELEFONO;
        private System.Windows.Forms.TextBox REPRESENTANTE;
        private System.Windows.Forms.TextBox COMPAÑIA;
        private System.Windows.Forms.TextBox txtCODSUPLI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}