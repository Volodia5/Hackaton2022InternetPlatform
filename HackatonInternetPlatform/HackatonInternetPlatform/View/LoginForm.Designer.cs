namespace HackatonInternetPlatform
{
    partial class LoginForm
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.radioButtonPurchaser = new System.Windows.Forms.RadioButton();
            this.radioButtonSupplier = new System.Windows.Forms.RadioButton();
            this.Login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVisiblePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(12, 25);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(184, 23);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(12, 72);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(156, 23);
            this.textBoxPassword.TabIndex = 0;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(12, 137);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(89, 26);
            this.buttonRegister.TabIndex = 1;
            this.buttonRegister.Text = "Регистрация";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Location = new System.Drawing.Point(107, 137);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(89, 26);
            this.buttonSignIn.TabIndex = 1;
            this.buttonSignIn.Text = "Войти";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            // 
            // radioButtonPurchaser
            // 
            this.radioButtonPurchaser.AutoSize = true;
            this.radioButtonPurchaser.Location = new System.Drawing.Point(12, 112);
            this.radioButtonPurchaser.Name = "radioButtonPurchaser";
            this.radioButtonPurchaser.Size = new System.Drawing.Size(79, 19);
            this.radioButtonPurchaser.TabIndex = 2;
            this.radioButtonPurchaser.TabStop = true;
            this.radioButtonPurchaser.Text = "закупщик";
            this.radioButtonPurchaser.UseVisualStyleBackColor = true;
            // 
            // radioButtonSupplier
            // 
            this.radioButtonSupplier.AutoSize = true;
            this.radioButtonSupplier.Location = new System.Drawing.Point(107, 112);
            this.radioButtonSupplier.Name = "radioButtonSupplier";
            this.radioButtonSupplier.Size = new System.Drawing.Size(86, 19);
            this.radioButtonSupplier.TabIndex = 2;
            this.radioButtonSupplier.TabStop = true;
            this.radioButtonSupplier.Text = "поставщик";
            this.radioButtonSupplier.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(12, 7);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(41, 15);
            this.Login.TabIndex = 3;
            this.Login.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Пароль";
            // 
            // buttonVisiblePassword
            // 
            this.buttonVisiblePassword.Location = new System.Drawing.Point(174, 71);
            this.buttonVisiblePassword.Name = "buttonVisiblePassword";
            this.buttonVisiblePassword.Size = new System.Drawing.Size(22, 23);
            this.buttonVisiblePassword.TabIndex = 4;
            this.buttonVisiblePassword.Text = "v";
            this.buttonVisiblePassword.UseVisualStyleBackColor = true;
            this.buttonVisiblePassword.Click += new System.EventHandler(this.buttonVisiblePassword_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 173);
            this.Controls.Add(this.buttonVisiblePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.radioButtonSupplier);
            this.Controls.Add(this.radioButtonPurchaser);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonRegister;
        private Button buttonSignIn;
        private RadioButton radioButtonPurchaser;
        private RadioButton radioButtonSupplier;
        private Label Login;
        private Label label1;
        private Button buttonVisiblePassword;
    }
}