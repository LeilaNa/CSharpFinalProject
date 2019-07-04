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
    public partial class MilitaryStatus : Form
    {
        readonly PersonSearchSystemEntities db;
        MilitaryStatu selectedMilitaryStatus;
        public MilitaryStatus()
        {
            InitializeComponent();
            db = new PersonSearchSystemEntities();
        }

        private void UpdateDatagrid()
        {
            dgvMilitaryStatus.DataSource = db.MilitaryStatus.Select(n => new
            {
                n.Id,
                Nationalities = n.Name,
                DeletedDate = n.deletedDate
            }).ToList();
            dgvMilitaryStatus.Columns[0].Visible = false;
            txtMilitaryStatus.Text = "";
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {    
            try
            {
                string military = txtMilitaryStatus.Text;
                MilitaryStatu mil = new MilitaryStatu()
                {
                    Name = military
                };
                db.MilitaryStatus.Add(mil);
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

        private void MilitaryStatus_Load(object sender, EventArgs e)
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

        private void dgvMilitaryStatus_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                int id = (int)dgvMilitaryStatus.Rows[e.RowIndex].Cells[0].Value;
                selectedMilitaryStatus = db.MilitaryStatus.Where(n => n.Id == id).FirstOrDefault();
                txtMilitaryStatus.Text = selectedMilitaryStatus.Name;
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
                string military = txtMilitaryStatus.Text;
                selectedMilitaryStatus.Name = military;
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
                selectedMilitaryStatus.deletedDate = DateTime.Now;
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
    }
}
