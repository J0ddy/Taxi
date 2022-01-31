using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateEmail(txtUser.Text))
                {
                    //TODO: Auth using email
                    throw new NotImplementedException();
                }
                else
                {
                    //TODO: Auth using username
                    throw new NotImplementedException();
                }
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            //TODO: Check Email Valid or Exists
            //TODO: Check Passwords Match
            //TODO: Check Company Valid or Exists
            throw new NotImplementedException();
        }
    }
}
