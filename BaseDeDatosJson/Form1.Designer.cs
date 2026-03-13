namespace BaseDeDatosJson
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
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.txtUser = new CuoreUI.Controls.cuiTextBox();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.txtPassword = new CuoreUI.Controls.cuiTextBox();
            this.btnIniciar = new ReaLTaiizor.Controls.AirButton();
            this.btnCrearUsuario = new ReaLTaiizor.Controls.AirButton();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(50, 21);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(340, 57);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Inicio De Seccion";
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "Usuario";
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(26, 149);
            this.cuiLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(116, 23);
            this.cuiLabel1.TabIndex = 1;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txtUser
            // 
            this.txtUser.BackgroundColor = System.Drawing.Color.White;
            this.txtUser.Content = "";
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.FocusBackgroundColor = System.Drawing.Color.White;
            this.txtUser.FocusImageTint = System.Drawing.Color.White;
            this.txtUser.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.txtUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Gray;
            this.txtUser.Image = null;
            this.txtUser.ImageExpand = new System.Drawing.Point(0, 0);
            this.txtUser.ImageOffset = new System.Drawing.Point(0, 0);
            this.txtUser.Location = new System.Drawing.Point(129, 140);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.NormalImageTint = System.Drawing.Color.White;
            this.txtUser.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtUser.Padding = new System.Windows.Forms.Padding(20, 6, 20, 0);
            this.txtUser.PasswordChar = false;
            this.txtUser.PlaceholderColor = System.Drawing.Color.LightGray;
            this.txtUser.PlaceholderText = "";
            this.txtUser.Rounding = new System.Windows.Forms.Padding(8);
            this.txtUser.Size = new System.Drawing.Size(252, 32);
            this.txtUser.TabIndex = 2;
            this.txtUser.TextOffset = new System.Drawing.Size(0, 0);
            this.txtUser.UnderlinedStyle = true;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Content = "Contraseña";
            this.cuiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel2.Location = new System.Drawing.Point(26, 199);
            this.cuiLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(116, 23);
            this.cuiLabel2.TabIndex = 3;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txtPassword
            // 
            this.txtPassword.BackgroundColor = System.Drawing.Color.White;
            this.txtPassword.Content = "";
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusBackgroundColor = System.Drawing.Color.White;
            this.txtPassword.FocusImageTint = System.Drawing.Color.White;
            this.txtPassword.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Image = null;
            this.txtPassword.ImageExpand = new System.Drawing.Point(0, 0);
            this.txtPassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.txtPassword.Location = new System.Drawing.Point(129, 199);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NormalImageTint = System.Drawing.Color.White;
            this.txtPassword.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtPassword.Padding = new System.Windows.Forms.Padding(20, 6, 20, 0);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.LightGray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Rounding = new System.Windows.Forms.Padding(8);
            this.txtPassword.Size = new System.Drawing.Size(252, 32);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextOffset = new System.Drawing.Size(0, 0);
            this.txtPassword.UnderlinedStyle = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIniciar.Image = null;
            this.btnIniciar.Location = new System.Drawing.Point(281, 238);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.NoRounding = false;
            this.btnIniciar.Size = new System.Drawing.Size(100, 45);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Ingresar";
            this.btnIniciar.Transparent = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearUsuario.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnCrearUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCrearUsuario.Image = null;
            this.btnCrearUsuario.Location = new System.Drawing.Point(249, 71);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.NoRounding = false;
            this.btnCrearUsuario.Size = new System.Drawing.Size(132, 35);
            this.btnCrearUsuario.TabIndex = 6;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.Transparent = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 345);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cuiLabel2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.cuiLabel1);
            this.Controls.Add(this.bigLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiTextBox txtUser;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiTextBox txtPassword;
        private ReaLTaiizor.Controls.AirButton btnIniciar;
        private ReaLTaiizor.Controls.AirButton btnCrearUsuario;
    }
}

