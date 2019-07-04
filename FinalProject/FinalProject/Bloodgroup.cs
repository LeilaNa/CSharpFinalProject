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
    public partial class Bloodgroup : Form
    {
        readonly PersonSearchSystemEntities db;
        BloodGroup SelectedBloodGroup;
        public Bloodgroup()
        {
            InitializeComponent();
            db = new PersonSearchSystemEntities();
        }
        private void UpdateDatagrid()
        {
            dgvBloodGroup.DataSource = db.BloodGroups.Select(n => new
            {
                n.Id,
                BloodGroup = n.Name,
                DeletedDate = n.DeletedDate
            }).ToList();
            dgvBloodGroup.Columns[0].Visible = false;
            txtBloodGroup.Text = "";
        }

        private void Bloodgroup_Load(object sender, EventArgs e)
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
                string bloodGroup = txtBloodGroup.Text;
                FinalProject.Model.BloodGroup blood = new FinalProject.Model.BloodGroup()
                {
                    Name = bloodGroup
                };
                db.BloodGroups.Add(blood);
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
                string blood = txtBloodGroup.Text;
                SelectedBloodGroup.Name = blood;
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
                SelectedBloodGroup.DeletedDate = DateTime.Now;
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

        private void dgvBloodGroup_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                int id = (int)dgvBloodGroup.Rows[e.RowIndex].Cells[0].Value;
                SelectedBloodGroup = db.BloodGroups.Where(a => a.Id == id).FirstOrDefault();
                txtBloodGroup.Text = SelectedBloodGroup.Name;
            }
            catch (Exception ex)
            {
                this.Text = ex.GetType().FullName;
                MessageBox.Show("Program cannot connect with server", "Error");
                Logger.SaveLog(ex); ;
            }
        }
    }
}
