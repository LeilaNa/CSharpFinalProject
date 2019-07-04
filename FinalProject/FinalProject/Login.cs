using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.Model;

namespace FinalProject
{
    public partial class Login : Form
    {
        public static FinalProject.Model.User MainUser;
        readonly PersonSearchSystemEntities db;
        public Login()
        {
            InitializeComponent();
            db= new PersonSearchSystemEntities();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string UserName = txtName.Text;
                string Password = txtPassword.Text;
                FinalProject.Model.User LoggedUser = db.Users.Where(a => a.Email == UserName).FirstOrDefault();
                MainUser = LoggedUser;
                if (LoggedUser == null)
                {
                    MessageBox.Show("Your email is incorrect, please try again", "Warning");
                    return;
                }
                if (LoggedUser.Email == UserName && LoggedUser.Password != Extensions.hashPassword(Password))
                {
                    MessageBox.Show("Your Password is incorrect, please try again", "Warning");
                    return;
                }
                if (Extensions.checkPassword(Password, LoggedUser.Password))
                {
                    PersonSearchSystem Persons = new PersonSearchSystem();
                    Persons.Show();
                }
               
            }
            catch (Exception ex)
            {
                this.Text = ex.GetType().FullName;
                MessageBox.Show("Program cannot connect with server", "Error");
                Logger.SaveLog(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
