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
    public partial class User : Form
    {
        PersonSearchSystemEntities db;
        FinalProject.Model.User SelectedUser;
        public User()
        {
            InitializeComponent();
            db = new PersonSearchSystemEntities();
        }

        private void User_Load(object sender, EventArgs e)
        {
            try
            {
                UpdateDatagrid();
                cmbRole.DataSource = db.Roles.Where(b => b.DeletedDate == null).Select(b => new ComboItem
                {
                    Value = b.Id,
                    Name = b.Name
                }).ToList();

            }
            catch (Exception ex)
            {
                this.Text = ex.GetType().FullName;
                MessageBox.Show("Program cannot connect with server", "Error");
                Logger.SaveLog(ex);
            }
        }
        private void UpdateDatagrid()
        {
            dgvUser.DataSource = db.Users.Select(n => new
            {
                n.Id,
                Email = n.Email,
                Role = n.Role.Name,
                DeletedDate = n.DeletedDate
            }).ToList();
            dgvUser.Columns[0].Visible = false;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                 string email = txtEmail.Text;
            string password = Extensions.hashPassword(txtPassword.Text);
            ComboItem role = cmbRole.SelectedItem as ComboItem;
            FinalProject.Model.User user = new FinalProject.Model.User()
            {
               Email=email,
               Password=password,
               RoleId=role.Value
            };
            db.Users.Add(user);
            db.SaveChanges();
            UpdateDatagrid();
                txtEmail.Text = "";
                txtPassword.Text = "";
                cmbRole.Text = "";
            }
            catch (Exception ex)
            {
                this.Text = ex.GetType().FullName;
                MessageBox.Show("Program cannot connect with server", "Error");
                Logger.SaveLog(ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                ComboItem role = new ComboItem();
                SelectedUser.Email = email;
                SelectedUser.RoleId = role.Value;
                db.SaveChanges();
                UpdateDatagrid();
                txtEmail.Text = "";
                txtPassword.Text = "";
                cmbRole.Text = "";
            }
            catch (Exception ex)
            {
                this.Text = ex.GetType().FullName;
                MessageBox.Show("Program cannot connect with server", "Error");
                Logger.SaveLog(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedUser.DeletedDate = DateTime.Now;
                db.SaveChanges();
                UpdateDatagrid();
                txtEmail.Text = "";
                txtPassword.Text = "";
                cmbRole.Text = "";
            }
            catch (Exception ex)
            {
                this.Text = ex.GetType().FullName;
                MessageBox.Show("Program cannot connect with server", "Error");
                Logger.SaveLog(ex);
            }
        }

        private void dgvUser_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                int id = (int)dgvUser.Rows[e.RowIndex].Cells[0].Value;
                SelectedUser = db.Users.Where(a => a.Id == id).FirstOrDefault();
                txtEmail.Text = SelectedUser.Email;
                cmbRole.SelectedItem = SelectedUser.Role;
            }
            catch (Exception ex)
            {
                this.Text = ex.GetType().FullName;
                MessageBox.Show("Program cannot connect with server", "Error");
                Logger.SaveLog(ex);
            }
        }
    }
}
