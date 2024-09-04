namespace SistemaPatologiaIA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtContraseña = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnLogin = new Button();
            databaseConnectionBindingSource = new BindingSource(components);
            btnRegDoc = new Button();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)databaseConnectionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label1.Location = new Point(143, 18);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 0;
            label1.Text = "Inicio de Sesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 25);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 105);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(69, 65);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(67, 137);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(125, 27);
            txtContraseña.TabIndex = 5;
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 255, 192);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtContraseña);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(103, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 230);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 224, 192);
            btnLogin.Location = new Point(79, 195);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // databaseConnectionBindingSource
            // 
            databaseConnectionBindingSource.DataSource = typeof(DatabaseConnection);
            // 
            // btnRegDoc
            // 
            btnRegDoc.BackColor = Color.FromArgb(255, 224, 192);
            btnRegDoc.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegDoc.Location = new Point(162, 315);
            btnRegDoc.Name = "btnRegDoc";
            btnRegDoc.Size = new Size(148, 31);
            btnRegDoc.TabIndex = 12;
            btnRegDoc.Text = "Registrar Usuario";
            btnRegDoc.UseVisualStyleBackColor = false;
            btnRegDoc.Click += btnRegDoc_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label4.Location = new Point(164, 411);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 13;
            label4.Text = "Copy Iss & Dani";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(481, 449);
            Controls.Add(label4);
            Controls.Add(btnRegDoc);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)databaseConnectionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtContraseña;
        private Label label5;
        private GroupBox groupBox1;
        private BindingSource databaseConnectionBindingSource;
        private Button btnRegDoc;
        private Button btnLogin;
        private Label label4;
    }
}
