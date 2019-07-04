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
    public partial class EyeColor : Form
    {
      readonly  PersonSearchSystemEntities db;
        FinalProject.Model.EyeColor selectedEyeColor;
        public EyeColor()
        {
            InitializeComponent();
            db = new PersonSearchSystemEntities();
        }

        private void UpdateDatagrid()
        {
            dgvEyeColor.DataSource = db.EyeColors.Select(n => new
            {
                n.Id,
                Nationalities = n.Name,
                DeletedDate = n.DeletedDate
            }).ToList();
            dgvEyeColor.Columns[0].Visible = false;
            txtEyeColor.Text = "";
        }

        private void EyeColor_Load(object sender, EventArgs e)
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
                string eyeColor = txtEyeColor.Text;
                FinalProject.Model.EyeColor eye = new FinalProject.Model.EyeColor()
                {
                    Name = eyeColor
                };
                db.EyeColors.Add(eye);
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
                string eyeColor = txtEyeColor.Text;
                selectedEyeColor.Name = eyeColor;
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
                selectedEyeColor.DeletedDate = DateTime.Now;
                db.SaveChanges();
                UpdateDatagrid();
            }
            catch (Exception ex)
            {

                this.Text = ex.GetType().FullName;
                MessageBox.Show("Program cannot connect with server", "Error");
                Logger.SaveLog(ex); ;
            }
        }

        private void dgvEyeColor_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                int id = (int)dgvEyeColor.Rows[e.RowIndex].Cells[0].Value;
                selectedEyeColor = db.EyeColors.Where(a => a.Id == id).FirstOrDefault();
                txtEyeColor.Text = selectedEyeColor.Name;
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
