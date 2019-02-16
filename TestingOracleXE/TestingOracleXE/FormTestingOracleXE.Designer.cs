namespace TestingOracleXE
{
    partial class FormTestingOracleXE
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
            this.SERVIDOR = new System.Windows.Forms.Label();
            this.PUERTO = new System.Windows.Forms.Label();
            this.USUARIO = new System.Windows.Forms.Label();
            this.PASSWORD = new System.Windows.Forms.Label();
            this.ServidorTextBox = new System.Windows.Forms.TextBox();
            this.PuertoTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.PassWordTextBox = new System.Windows.Forms.TextBox();
            this.ConectarAOracle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SERVIDOR
            // 
            this.SERVIDOR.AutoSize = true;
            this.SERVIDOR.BackColor = System.Drawing.Color.Transparent;
            this.SERVIDOR.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SERVIDOR.Location = new System.Drawing.Point(68, 44);
            this.SERVIDOR.Name = "SERVIDOR";
            this.SERVIDOR.Size = new System.Drawing.Size(73, 16);
            this.SERVIDOR.TabIndex = 0;
            this.SERVIDOR.Text = "Servidor:";
            // 
            // PUERTO
            // 
            this.PUERTO.AutoSize = true;
            this.PUERTO.BackColor = System.Drawing.Color.Transparent;
            this.PUERTO.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PUERTO.Location = new System.Drawing.Point(68, 95);
            this.PUERTO.Name = "PUERTO";
            this.PUERTO.Size = new System.Drawing.Size(59, 16);
            this.PUERTO.TabIndex = 0;
            this.PUERTO.Text = "Puerto:";
            // 
            // USUARIO
            // 
            this.USUARIO.AutoSize = true;
            this.USUARIO.BackColor = System.Drawing.Color.Transparent;
            this.USUARIO.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USUARIO.Location = new System.Drawing.Point(68, 146);
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.Size = new System.Drawing.Size(66, 16);
            this.USUARIO.TabIndex = 0;
            this.USUARIO.Text = "Usuario:";
            // 
            // PASSWORD
            // 
            this.PASSWORD.AutoSize = true;
            this.PASSWORD.BackColor = System.Drawing.Color.Transparent;
            this.PASSWORD.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD.Location = new System.Drawing.Point(68, 197);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(80, 16);
            this.PASSWORD.TabIndex = 0;
            this.PASSWORD.Text = "Password:";
            // 
            // ServidorTextBox
            // 
            this.ServidorTextBox.Location = new System.Drawing.Point(288, 39);
            this.ServidorTextBox.Name = "ServidorTextBox";
            this.ServidorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ServidorTextBox.TabIndex = 1;
            // 
            // PuertoTextBox
            // 
            this.PuertoTextBox.Location = new System.Drawing.Point(288, 94);
            this.PuertoTextBox.Name = "PuertoTextBox";
            this.PuertoTextBox.Size = new System.Drawing.Size(100, 20);
            this.PuertoTextBox.TabIndex = 2;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(288, 142);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.UsuarioTextBox.TabIndex = 3;
            // 
            // PassWordTextBox
            // 
            this.PassWordTextBox.Location = new System.Drawing.Point(288, 193);
            this.PassWordTextBox.Name = "PassWordTextBox";
            this.PassWordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PassWordTextBox.TabIndex = 4;
            // 
            // ConectarAOracle
            // 
            this.ConectarAOracle.BackColor = System.Drawing.Color.CadetBlue;
            this.ConectarAOracle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConectarAOracle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConectarAOracle.Location = new System.Drawing.Point(71, 381);
            this.ConectarAOracle.Name = "ConectarAOracle";
            this.ConectarAOracle.Size = new System.Drawing.Size(317, 34);
            this.ConectarAOracle.TabIndex = 5;
            this.ConectarAOracle.Text = "Conectar con Oracle XE";
            this.ConectarAOracle.UseVisualStyleBackColor = false;
            this.ConectarAOracle.Click += new System.EventHandler(this.ConectarAOracle_Click);
            // 
            // FormTestingOracleXE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = global::TestingOracleXE.Properties.Resources.LogoOracleXE;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.ConectarAOracle);
            this.Controls.Add(this.PassWordTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.PuertoTextBox);
            this.Controls.Add(this.ServidorTextBox);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.USUARIO);
            this.Controls.Add(this.PUERTO);
            this.Controls.Add(this.SERVIDOR);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTestingOracleXE";
            this.Text = "Texting Oracle XE Data Base";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SERVIDOR;
        private System.Windows.Forms.Label PUERTO;
        private System.Windows.Forms.Label USUARIO;
        private System.Windows.Forms.Label PASSWORD;
        private System.Windows.Forms.TextBox ServidorTextBox;
        private System.Windows.Forms.TextBox PuertoTextBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox PassWordTextBox;
        private System.Windows.Forms.Button ConectarAOracle;
    }
}

