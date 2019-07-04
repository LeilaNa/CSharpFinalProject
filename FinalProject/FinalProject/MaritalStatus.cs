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
    public partial class MaritalStatus : Form
    {
        readonly PersonSearchSystemEntities db;
        MartialStatu SelectedMaritalStatus;
        public MaritalStatus()
        {
            InitializeComponent();
            db = new PersonSearchSystemEntities();
        }

        private void MaritalStatus_Load(object sender, EventArgs e)
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
        
        private void UpdateDatagrid()
        {
            dgvMaritalStatus.DataSource = db.MartialStatus.Select(n => new
            {
                n.Id,
                Nationalities = n.Name,
                DeletedDate = n.DeletedDate
            }).ToList();
            dgvMaritalStatus.Columns[0].Visible = false;
            txtMaritalStatus.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string MartialStatus = txtMaritalStatus.Text;
                NAtionality nat = new NAtionality()
                {
                    Name = MartialStatus
                };
                db.NAtionalities.Add(nat);
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

        private void dgvMaritalStatus_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = (int)dgvMaritalStatus.Rows[e.RowIndex].Cells[0].Value;
                SelectedMaritalStatus = db.MartialStatus.Where(b => b.Id == id).FirstOrDefault();
                txtMaritalStatus.Text = SelectedMaritalStatus.Name;
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
                string MaritalStatus = txtMaritalStatus.Text;
                SelectedMaritalStatus.Name = MaritalStatus;
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

            SelectedMaritalStatus.DeletedDate = DateTime.Now;
            db.SaveChanges();
            UpdateDatagrid();
        }
    }
}
