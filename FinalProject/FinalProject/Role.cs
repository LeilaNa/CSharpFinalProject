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
    public partial class Role : Form
    {
       readonly PersonSearchSystemEntities db;
        FinalProject.Model.Role SelectedRole;
        public Role()
        {
            InitializeComponent();
            db = new PersonSearchSystemEntities();
        }
        private void UpdateDatagrid()
        {
            dgvRole.DataSource =db.Roles.Select(n => new
            {
                n.Id,
                Nationalities = n.Name,
                DeletedDate = n.DeletedDate
            }).ToList();
            dgvRole.Columns[0].Visible = false;
            txtRole.Text = "";
        }
        private void Role_Load(object sender, EventArgs e)
        {
            try
            {
                UpdateDatagrid();
            }
            catch (Exception ex)
            {
                this.Text = ex.GetType().FullName;
                MessageBox.Show("Program cannot connect with server", "Error");
                Logger.SaveLog(ex);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string role = txtRole.Text;
                FinalProject.Model.Role roles = new FinalProject.Model.Role()
                {
                    Name = role
                };
                db.Roles.Add(roles);
                db.SaveChanges();
                UpdateDatagrid();
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
                string role = txtRole.Text;
                SelectedRole.Name = role;
                db.SaveChanges();
                UpdateDatagrid();
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
                SelectedRole.DeletedDate = DateTime.Now;
                db.SaveChanges();
                UpdateDatagrid();
            }
            catch (Exception ex)
            {
                this.Text = ex.GetType().FullName;
                MessageBox.Show("Program cannot connect with server", "Error");
                Logger.SaveLog(ex);
            }
        }

        private void dgvRole_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = (int)dgvRole.Rows[e.RowIndex].Cells[0].Value;
                SelectedRole = db.Roles.Where(a => a.Id == id).FirstOrDefault();
                txtRole.Text = SelectedRole.Name;
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
