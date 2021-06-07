namespace Factura
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.TxtPass);
            this.panel1.Controls.Add(this.TxtUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(105, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 329);
            this.panel1.TabIndex = 14;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(220, 271);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 20;
            this.BtnExit.Text = "Cancelar";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(123, 271);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 19;
            this.BtnLogin.Text = "Entrar";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(195, 224);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.Size = new System.Drawing.Size(100, 20);
            this.TxtPass.TabIndex = 18;
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(195, 189);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(100, 20);
            this.TxtUser.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(628, 463);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

