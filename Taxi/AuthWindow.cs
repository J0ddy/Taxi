using System.Text.RegularExpressions;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Taxi
{
    public partial class AuthWindow : MaterialForm
    {
        public AuthWindow()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow600, Primary.BlueGrey900, Primary.Yellow500,
                Accent.LightBlue200, TextShade.WHITE);
        }

        private static bool ValidateEmail(string str)
        {
            return Regex.IsMatch(str, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        }

        private static bool ValidateUsername(string str)
        {
            return Regex.IsMatch(str, @"/^[A-Za-z0-9]+(?:[ _-][A-Za-z0-9]+)*$/");
        }
        /// <summary>
        /// Display an error to the user.
        ///
        /// <list>username_invalid, user_invalid, username_exists, email_exists, email_invalid, password_short, company_invalid, company_exists, database_error</list>
        /// </summary>
        /// <param name="error">Error Type</param>
        private string AuthErrorParse(string error)
        {
            string? errorMessage = null;
            if (error == "username_invalid") errorMessage = "Invalid Username";
            else if (error == "user_invalid") errorMessage = "Invalid Username/Email";
            else if (error == "username_exists") errorMessage = "Username Exists";
            else if (error == "email_exists") errorMessage = "Email Exists";
            else if (error == "email_invalid") errorMessage = "Invalid Email";
            else if (error == "password_mismatch") errorMessage = "Passwords don't match";
            else if (error == "password_short") errorMessage = "Password too short";
            else if (error == "company_invalid") errorMessage = "Invalid Company";
            else if (error == "company_exists") errorMessage = "Company Exists";
            else if (error == "database_error") errorMessage = "Database Error";
            else if (string.IsNullOrWhiteSpace(errorMessage)) throw new ArgumentNullException(paramName: error);
            return errorMessage;
        }

        private void NewAuthError(string error)
        {
            MessageBox.Show(AuthErrorParse(error),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateEmail(txtUser.Text))
                {
                    //TODO: Auth using email
                    throw new NotImplementedException();
                }
                else if (ValidateUsername(txtUser.Text))
                {
                    //TODO: Auth using username
                    throw new NotImplementedException();
                }
                else NewAuthError("user_invalid");
                
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(AuthErrorParse(exception.Message), "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            tabControlAuthWindow.SelectedTab = tabPageRegister;
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            tabControlAuthWindow.SelectedTab = tabPageLogin;
        }

        private void btnRegisterGo_Click(object sender, EventArgs e)
        {
            //TODO: Check Username Valid or Exists
            if (!ValidateUsername(txtRegisterUsername.Text))
            {
                NewAuthError("invalid_username");
                return;
            } //TODO: Check Username exists

            //TODO: Check Email Valid or Exists
            if (!ValidateEmail(txtRegisterEmail.Text))
            {
                NewAuthError("invalid_email");
                return;
            } //TODO: Check Email exists

            //TODO: Check Passwords Valid and Match

            //TODO: Password Safety Check

            if (txtRegisterPassword.Text != txtRegisterPasswordConfirm.Text)
            {
                NewAuthError("password_mismatch");
                return;
            } 

            //TODO: Check Company Valid or Exists
            if (!ValidateUsername(txtRegisterCompany.Text))
            {
                NewAuthError("company_invalid");
                return;
            } //TODO: Check Company exists


            throw new NotImplementedException();
        }
    }
}
