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
    public partial class Nationality : Form
    {
        readonly PersonSearchSystemEntities db;
        NAtionality SelectedNationality;
        public Nationality()
        {
            InitializeComponent();
            db = new PersonSearchSystemEntities();
        }

        private void Nationality_Load(object sender, EventArgs e)
        {
            try
            {
                UpdateDataGrid();
            }
            catch (Exception ex)
            {
                this.Text = ex.GetType().FullName;
                MessageBox.Show("Program cannot connect with server", "Error");
                Logger.SaveLog(ex);
            }      
        }

        private void UpdateDataGrid()
        {
            dgvNationality.DataSource = db.NAtionalities.Select(n => new
            {
                n.Id,
                Nationalities = n.Name,
                DeletedDate = n.DeletedDate
            }).ToList();
            dgvNationality.Columns[0].Visible = false;
            txtNationality.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string nationality = txtNationality.Text;
                NAtionality nat = new NAtionality()
                {
                    Name = nationality
                };
                db.NAtionalities.Add(nat);
                db.SaveChanges();
                UpdateDataGrid();
            }
            catch (Exception ex)
            {
                this.Text = ex.GetType().FullName;
                MessageBox.Show("Program cannot connect with server", "Error");
                Logger.SaveLog(ex);
            }
        }

        private void dgvNationality_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = (int)dgvNationality.Rows[e.RowIndex].Cells[0].Value;
                SelectedNationality = db.NAtionalities.Where(n => n.Id == id).FirstOrDefault();
                txtNationality.Text = SelectedNationality.Name;
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
                string nationality = txtNationality.Text;
                SelectedNationality.Name = nationality;
                db.SaveChanges();
                UpdateDataGrid();
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
                SelectedNationality.DeletedDate = DateTime.Now;
                db.SaveChanges();
                UpdateDataGrid();
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
