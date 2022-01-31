namespace Taxi
{
    partial class AuthWindow
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
            this.tabControlAuthWindow = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.btnRegister = new MaterialSkin.Controls.MaterialButton();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtUser = new MaterialSkin.Controls.MaterialTextBox2();
            this.pbAuthIcon = new System.Windows.Forms.PictureBox();
            this.tabPageRegister = new System.Windows.Forms.TabPage();
            this.btnBackToLogin = new MaterialSkin.Controls.MaterialButton();
            this.btnRegisterGo = new MaterialSkin.Controls.MaterialButton();
            this.txtRegisterCompany = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtRegisterEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtRegisterPasswordConfirm = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtRegisterPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtRegisterUsername = new MaterialSkin.Controls.MaterialTextBox2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlAuthWindow.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuthIcon)).BeginInit();
            this.tabPageRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAuthWindow
            // 
            this.tabControlAuthWindow.Controls.Add(this.tabPageLogin);
            this.tabControlAuthWindow.Controls.Add(this.tabPageRegister);
            this.tabControlAuthWindow.Depth = 0;
            this.tabControlAuthWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAuthWindow.Location = new System.Drawing.Point(3, 24);
            this.tabControlAuthWindow.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlAuthWindow.Multiline = true;
            this.tabControlAuthWindow.Name = "tabControlAuthWindow";
            this.tabControlAuthWindow.SelectedIndex = 0;
            this.tabControlAuthWindow.Size = new System.Drawing.Size(694, 523);
            this.tabControlAuthWindow.TabIndex = 9;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.Controls.Add(this.btnRegister);
            this.tabPageLogin.Controls.Add(this.btnLogin);
            this.tabPageLogin.Controls.Add(this.txtPassword);
            this.tabPageLogin.Controls.Add(this.txtUser);
            this.tabPageLogin.Controls.Add(this.pbAuthIcon);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 24);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(686, 495);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Login";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.AutoSize = false;
            this.btnRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegister.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegister.Depth = 0;
            this.btnRegister.HighEmphasis = true;
            this.btnRegister.Icon = null;
            this.btnRegister.Location = new System.Drawing.Point(217, 401);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegister.Size = new System.Drawing.Size(253, 53);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegister.UseAccentColor = true;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.AutoSize = false;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(217, 336);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(253, 53);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = true;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.HelperText = "Password";
            this.txtPassword.HideSelection = true;
            this.txtPassword.Hint = "Password";
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(163, 257);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PrefixSuffixText = null;
            this.txtPassword.ReadOnly = false;
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(360, 48);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.TabStop = false;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.AnimateReadOnly = false;
            this.txtUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUser.Depth = 0;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUser.HelperText = "Username / Email";
            this.txtUser.HideSelection = true;
            this.txtUser.Hint = "Username / Email";
            this.txtUser.LeadingIcon = null;
            this.txtUser.Location = new System.Drawing.Point(163, 203);
            this.txtUser.MaxLength = 100;
            this.txtUser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PrefixSuffixText = null;
            this.txtUser.ReadOnly = false;
            this.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(360, 48);
            this.txtUser.TabIndex = 9;
            this.txtUser.TabStop = false;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.TrailingIcon = null;
            this.txtUser.UseSystemPasswordChar = false;
            // 
            // pbAuthIcon
            // 
            this.pbAuthIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAuthIcon.BackgroundImage = global::Taxi.Properties.Resources.taxi_auth_96;
            this.pbAuthIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbAuthIcon.Location = new System.Drawing.Point(279, 41);
            this.pbAuthIcon.Name = "pbAuthIcon";
            this.pbAuthIcon.Size = new System.Drawing.Size(128, 128);
            this.pbAuthIcon.TabIndex = 11;
            this.pbAuthIcon.TabStop = false;
            // 
            // tabPageRegister
            // 
            this.tabPageRegister.Controls.Add(this.btnBackToLogin);
            this.tabPageRegister.Controls.Add(this.btnRegisterGo);
            this.tabPageRegister.Controls.Add(this.txtRegisterCompany);
            this.tabPageRegister.Controls.Add(this.txtRegisterEmail);
            this.tabPageRegister.Controls.Add(this.txtRegisterPasswordConfirm);
            this.tabPageRegister.Controls.Add(this.txtRegisterPassword);
            this.tabPageRegister.Controls.Add(this.txtRegisterUsername);
            this.tabPageRegister.Controls.Add(this.pictureBox1);
            this.tabPageRegister.Location = new System.Drawing.Point(4, 24);
            this.tabPageRegister.Name = "tabPageRegister";
            this.tabPageRegister.Size = new System.Drawing.Size(686, 495);
            this.tabPageRegister.TabIndex = 1;
            this.tabPageRegister.Text = "Register";
            this.tabPageRegister.UseVisualStyleBackColor = true;
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackToLogin.AutoSize = false;
            this.btnBackToLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackToLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBackToLogin.Depth = 0;
            this.btnBackToLogin.HighEmphasis = true;
            this.btnBackToLogin.Icon = null;
            this.btnBackToLogin.Location = new System.Drawing.Point(86, 422);
            this.btnBackToLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBackToLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBackToLogin.Size = new System.Drawing.Size(253, 53);
            this.btnBackToLogin.TabIndex = 18;
            this.btnBackToLogin.Text = "Back to Login";
            this.btnBackToLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBackToLogin.UseAccentColor = true;
            this.btnBackToLogin.UseVisualStyleBackColor = true;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // btnRegisterGo
            // 
            this.btnRegisterGo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegisterGo.AutoSize = false;
            this.btnRegisterGo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegisterGo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegisterGo.Depth = 0;
            this.btnRegisterGo.HighEmphasis = true;
            this.btnRegisterGo.Icon = null;
            this.btnRegisterGo.Location = new System.Drawing.Point(347, 422);
            this.btnRegisterGo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegisterGo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegisterGo.Name = "btnRegisterGo";
            this.btnRegisterGo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegisterGo.Size = new System.Drawing.Size(253, 53);
            this.btnRegisterGo.TabIndex = 17;
            this.btnRegisterGo.Text = "Register";
            this.btnRegisterGo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegisterGo.UseAccentColor = true;
            this.btnRegisterGo.UseVisualStyleBackColor = true;
            this.btnRegisterGo.Click += new System.EventHandler(this.btnRegisterGo_Click);
            // 
            // txtRegisterCompany
            // 
            this.txtRegisterCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegisterCompany.AnimateReadOnly = false;
            this.txtRegisterCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRegisterCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRegisterCompany.Depth = 0;
            this.txtRegisterCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegisterCompany.HelperText = "Company Name";
            this.txtRegisterCompany.HideSelection = true;
            this.txtRegisterCompany.Hint = "Company Name";
            this.txtRegisterCompany.LeadingIcon = null;
            this.txtRegisterCompany.Location = new System.Drawing.Point(163, 357);
            this.txtRegisterCompany.MaxLength = 100;
            this.txtRegisterCompany.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRegisterCompany.Name = "txtRegisterCompany";
            this.txtRegisterCompany.PasswordChar = '●';
            this.txtRegisterCompany.PrefixSuffixText = null;
            this.txtRegisterCompany.ReadOnly = false;
            this.txtRegisterCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegisterCompany.SelectedText = "";
            this.txtRegisterCompany.SelectionLength = 0;
            this.txtRegisterCompany.SelectionStart = 0;
            this.txtRegisterCompany.ShortcutsEnabled = true;
            this.txtRegisterCompany.Size = new System.Drawing.Size(360, 48);
            this.txtRegisterCompany.TabIndex = 4;
            this.txtRegisterCompany.TabStop = false;
            this.txtRegisterCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegisterCompany.TrailingIcon = null;
            this.txtRegisterCompany.UseSystemPasswordChar = false;
            // 
            // txtRegisterEmail
            // 
            this.txtRegisterEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegisterEmail.AnimateReadOnly = false;
            this.txtRegisterEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRegisterEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRegisterEmail.Depth = 0;
            this.txtRegisterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegisterEmail.HelperText = "Email";
            this.txtRegisterEmail.HideSelection = true;
            this.txtRegisterEmail.Hint = "Email";
            this.txtRegisterEmail.LeadingIcon = null;
            this.txtRegisterEmail.Location = new System.Drawing.Point(163, 195);
            this.txtRegisterEmail.MaxLength = 100;
            this.txtRegisterEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRegisterEmail.Name = "txtRegisterEmail";
            this.txtRegisterEmail.PasswordChar = '\0';
            this.txtRegisterEmail.PrefixSuffixText = null;
            this.txtRegisterEmail.ReadOnly = false;
            this.txtRegisterEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegisterEmail.SelectedText = "";
            this.txtRegisterEmail.SelectionLength = 0;
            this.txtRegisterEmail.SelectionStart = 0;
            this.txtRegisterEmail.ShortcutsEnabled = true;
            this.txtRegisterEmail.Size = new System.Drawing.Size(360, 48);
            this.txtRegisterEmail.TabIndex = 1;
            this.txtRegisterEmail.TabStop = false;
            this.txtRegisterEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegisterEmail.TrailingIcon = null;
            this.txtRegisterEmail.UseSystemPasswordChar = false;
            // 
            // txtRegisterPasswordConfirm
            // 
            this.txtRegisterPasswordConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegisterPasswordConfirm.AnimateReadOnly = false;
            this.txtRegisterPasswordConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRegisterPasswordConfirm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRegisterPasswordConfirm.Depth = 0;
            this.txtRegisterPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegisterPasswordConfirm.HelperText = "Confirm Password";
            this.txtRegisterPasswordConfirm.HideSelection = true;
            this.txtRegisterPasswordConfirm.Hint = "Confirm Password";
            this.txtRegisterPasswordConfirm.LeadingIcon = null;
            this.txtRegisterPasswordConfirm.Location = new System.Drawing.Point(163, 303);
            this.txtRegisterPasswordConfirm.MaxLength = 100;
            this.txtRegisterPasswordConfirm.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRegisterPasswordConfirm.Name = "txtRegisterPasswordConfirm";
            this.txtRegisterPasswordConfirm.PasswordChar = '●';
            this.txtRegisterPasswordConfirm.PrefixSuffixText = null;
            this.txtRegisterPasswordConfirm.ReadOnly = false;
            this.txtRegisterPasswordConfirm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegisterPasswordConfirm.SelectedText = "";
            this.txtRegisterPasswordConfirm.SelectionLength = 0;
            this.txtRegisterPasswordConfirm.SelectionStart = 0;
            this.txtRegisterPasswordConfirm.ShortcutsEnabled = true;
            this.txtRegisterPasswordConfirm.Size = new System.Drawing.Size(360, 48);
            this.txtRegisterPasswordConfirm.TabIndex = 3;
            this.txtRegisterPasswordConfirm.TabStop = false;
            this.txtRegisterPasswordConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegisterPasswordConfirm.TrailingIcon = null;
            this.txtRegisterPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegisterPassword.AnimateReadOnly = false;
            this.txtRegisterPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRegisterPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRegisterPassword.Depth = 0;
            this.txtRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegisterPassword.HelperText = "Password";
            this.txtRegisterPassword.HideSelection = true;
            this.txtRegisterPassword.Hint = "Password";
            this.txtRegisterPassword.LeadingIcon = null;
            this.txtRegisterPassword.Location = new System.Drawing.Point(163, 249);
            this.txtRegisterPassword.MaxLength = 100;
            this.txtRegisterPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.PasswordChar = '●';
            this.txtRegisterPassword.PrefixSuffixText = null;
            this.txtRegisterPassword.ReadOnly = false;
            this.txtRegisterPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegisterPassword.SelectedText = "";
            this.txtRegisterPassword.SelectionLength = 0;
            this.txtRegisterPassword.SelectionStart = 0;
            this.txtRegisterPassword.ShortcutsEnabled = true;
            this.txtRegisterPassword.Size = new System.Drawing.Size(360, 48);
            this.txtRegisterPassword.TabIndex = 2;
            this.txtRegisterPassword.TabStop = false;
            this.txtRegisterPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegisterPassword.TrailingIcon = null;
            this.txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegisterUsername.AnimateReadOnly = false;
            this.txtRegisterUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRegisterUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRegisterUsername.Depth = 0;
            this.txtRegisterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegisterUsername.HelperText = "Username";
            this.txtRegisterUsername.HideSelection = true;
            this.txtRegisterUsername.Hint = "Username";
            this.txtRegisterUsername.LeadingIcon = null;
            this.txtRegisterUsername.Location = new System.Drawing.Point(163, 141);
            this.txtRegisterUsername.MaxLength = 100;
            this.txtRegisterUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.PasswordChar = '\0';
            this.txtRegisterUsername.PrefixSuffixText = null;
            this.txtRegisterUsername.ReadOnly = false;
            this.txtRegisterUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegisterUsername.SelectedText = "";
            this.txtRegisterUsername.SelectionLength = 0;
            this.txtRegisterUsername.SelectionStart = 0;
            this.txtRegisterUsername.ShortcutsEnabled = true;
            this.txtRegisterUsername.Size = new System.Drawing.Size(360, 48);
            this.txtRegisterUsername.TabIndex = 0;
            this.txtRegisterUsername.TabStop = false;
            this.txtRegisterUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegisterUsername.TrailingIcon = null;
            this.txtRegisterUsername.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::Taxi.Properties.Resources.taxi_auth_96;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(279, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // AuthWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.tabControlAuthWindow);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 550);
            this.Name = "AuthWindow";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taxi - Authentication";
            this.tabControlAuthWindow.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAuthIcon)).EndInit();
            this.tabPageRegister.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControlAuthWindow;
        private TabPage tabPageLogin;
        private MaterialSkin.Controls.MaterialButton btnRegister;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialTextBox2 txtPassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtUser;
        private PictureBox pbAuthIcon;
        private TabPage tabPageRegister;
        private MaterialSkin.Controls.MaterialTextBox2 txtRegisterCompany;
        private MaterialSkin.Controls.MaterialTextBox2 txtRegisterEmail;
        private MaterialSkin.Controls.MaterialTextBox2 txtRegisterPasswordConfirm;
        private MaterialSkin.Controls.MaterialTextBox2 txtRegisterPassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtRegisterUsername;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btnBackToLogin;
        private MaterialSkin.Controls.MaterialButton btnRegisterGo;
    }
}