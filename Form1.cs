using System;
using System.Windows.Forms;

namespace ModernThreeDLogInPage
{
    public partial class frmLoginPage : Form
    {
        public frmLoginPage()
        {
            InitializeComponent();
        }

        private void txtUserName_MouseHover(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Name")
                txtUserName.Text = "";
        }

        private void txtUserName_MouseLeave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
                txtUserName.Text = "Name";
        }

        private void txtUserPassword_MouseHover(object sender, EventArgs e)
        {
            if (txtUserPassword.Text == "Password")
                txtUserPassword.Text = "";
            txtUserPassword.UseSystemPasswordChar = true;
          
        }

        private void txtUserPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtUserPassword.Text == "" || txtUserPassword.Text == "Password")
                txtUserPassword.Text = "Password";
            txtUserPassword.UseSystemPasswordChar = false;
        }

        private void txtUserPassword_Enter(object sender, EventArgs e)
        {
            if (txtUserPassword.Text == "Password")
            {
                txtUserPassword.Text = "";
                txtUserPassword.UseSystemPasswordChar = true;
            }

            else
            {
                if (txtUserPassword.Text == "")
                {
                    txtUserPassword.Text = "Password";
                    txtUserPassword.UseSystemPasswordChar = true;
                }
            }
              

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
       private Boolean IsLogInFormOk()
        {
            if(txtUserName.Text == "Name" || txtUserName.Text == "")
            {
                picUserNameEmpty.Visible = true;
                txtUserName.Focus();
                return false;
            }
            else
            {
                if (txtUserName.Text != "Name" || txtUserName.Text != "")
                    picUserNameIndicator.Visible = true;
                picUserNameEmpty.Visible = false;
            }
            if(txtUserPassword.Text == "Password" || txtUserPassword.Text == "")
            {
                picUserPasswordEmpty.Visible = true;
                txtUserPassword.Focus();
                return false;
            }
            else
            {
                if (txtUserPassword.Text != "Password" || txtUserPassword.Text != "")
                    picUserPasswordOk.Visible = true;
                picUserPasswordEmpty.Visible = false;
            }

               
            return true;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (IsLogInFormOk())
            {

            }
        }

       
    }
    }

