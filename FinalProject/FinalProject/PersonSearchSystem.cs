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
using System.IO;
namespace FinalProject
{
    public partial class PersonSearchSystem : Form
    {
        const string folder = "img";
        readonly PersonSearchSystemEntities db;
        Person SelectedPerson;
        public PersonSearchSystem()
        {
            InitializeComponent();
            db = new PersonSearchSystemEntities();
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
        }

        //Methods ##############################
        public void UpdateDatagrid()
        {
            if (Login.MainUser.RoleId != 1)
            {
                dgvPersonInfo.DataSource = db.Persons.Where(p => p.DeletedDate == null).Select(p => new
                {
                    p.Id,
                    NSF = p.FirsName + " " + p.LastName + " " + p.FatherName,
                    p.BirtofDate,
                    p.BirthPlace,
                    Gender = p.Gender.Name,
                    Citizenship = p.NAtionality.Name,
                    LivingPlace = p.LivingPlace,
                    BloodGroup = p.BloodGroup.Name,
                    EyeColor = p.EyeColor.Name,
                    Height = p.height,
                    MartialStatus = p.MartialStatu.Name,
                    MilitaryStatus = p.MilitaryStatu.Name,
                    Code = p.Code,
                    Number = p.Number,
                    IssuingAuthory = p.IssuingAuthory,
                    p.IssueDate,
                    p.ExpiryDate
                }).ToList();
                dgvPersonInfo.Columns[0].Visible = false;
                
            }
            else if (Login.MainUser.RoleId == 1)
            {
                dgvPersonInfo.DataSource = db.Persons.Select(p => new
                {
                    p.Id,
                    NSF = p.FirsName + " " + p.LastName + " " + p.FatherName,
                    p.BirtofDate,
                    p.BirthPlace,
                    Gender = p.Gender.Name,
                    Citizenship = p.NAtionality.Name,
                    LivingPlace = p.LivingPlace,
                    BloodGroup = p.BloodGroup.Name,
                    EyeColor = p.EyeColor.Name,
                    Height = p.height,
                    MartialStatus = p.MartialStatu.Name,
                    MilitaryStatus = p.MilitaryStatu.Name,
                    Code = p.Code,
                    Number = p.Number,
                    IssuingAuthory = p.IssuingAuthory,
                    p.IssueDate,
                    p.ExpiryDate,
                    DeletedDate=p.DeletedDate
                }).ToList();
                dgvPersonInfo.Columns[0].Visible = false;
                
            }
        }

        public void CreateNewPerson()
        {
            string name = txtName.Text;
            string surName = txtSurname.Text;
            string fatherName = txtFatherName.Text;
            string birthPlace = txtBirthPlace.Text;
            DateTime birthDate = dtpBirthDate.Value.Date;
            ComboItem gender = cmbGender.SelectedItem as ComboItem;
            ComboItem Nationality = cmbNationality.SelectedItem as ComboItem;
            ComboItem martialStatus = cmbMartialStatus.SelectedItem as ComboItem;
            ComboItem militaryStatus = cmbMilitaryStatus.SelectedItem as ComboItem;
            int height = Convert.ToInt32(txtHeight.Text);
            ComboItem eyeColor = cmbEyeColor.SelectedItem as ComboItem;
            ComboItem bloodGroup = cmbBloodGroup.SelectedItem as ComboItem;
            string livingPlace = txtLivingPlace.Text;
            DateTime issueDate = dtpIssueDate.Value.Date;
            DateTime expiryDate = dtpExpiry.Value.Date;
            string code = txtCode.Text;
            string number = txtNumber.Text;
            string issuinAuthory = txtIssuingAuthory.Text;
            Person newPerson = new Person()
            {
                FirsName = name,
                LastName = surName,
                FatherName = fatherName,
                BirthPlace = birthPlace,
                BirtofDate = birthDate,
                GenderId = gender.Value,
                NationalityId = Nationality.Value,
                MartialStatusId = martialStatus.Value,
                MilitaryStatusId = militaryStatus.Value,
                height = (byte)height,
                EyeColorId = eyeColor.Value,
                BloodGroupId = bloodGroup.Value,
                LivingPlace = livingPlace,
                IssueDate = issueDate,
                ExpiryDate = expiryDate,
                Code = code,
                Number = number,
                IssuingAuthory = issuinAuthory
            };
            picUser.Name = newPerson.Id.ToString();
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surName) && !string.IsNullOrWhiteSpace(code) &&
                !string.IsNullOrWhiteSpace(number) && !string.IsNullOrEmpty(issuinAuthory))
            {
                db.Persons.Add(newPerson);
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider1.SetError(txtName, "Please fill the required field");
            }
            else if (string.IsNullOrWhiteSpace(surName))
            {
                errorProvider1.SetError(txtSurname, "Please fill the required field");
            }
            else if (string.IsNullOrWhiteSpace(code))
            {
                errorProvider1.SetError(txtCode, "Please fill the required field");
            }
            else if (string.IsNullOrWhiteSpace(number))
            {
                errorProvider1.SetError(txtNumber, "Please fill the required field");
            }
            else if (string.IsNullOrEmpty(issuinAuthory))
            {
                errorProvider1.SetError(txtIssuingAuthory, "Please fill the required field");
            }


        }

        public void UpdatePerson()
        {
            string name = txtName.Text;
            string surName = txtSurname.Text;
            string fatherName = txtFatherName.Text;
            string birthPlace = txtBirthPlace.Text;
            DateTime birthDate = dtpBirthDate.Value.Date;
            ComboItem gender = cmbGender.SelectedItem as ComboItem;
            ComboItem Nationality = cmbNationality.SelectedItem as ComboItem;
            ComboItem martialStatus = cmbMartialStatus.SelectedItem as ComboItem;
            ComboItem militaryStatus = cmbMilitaryStatus.SelectedItem as ComboItem;
            int height = Convert.ToInt32(txtHeight.Text);
            ComboItem eyeColor = cmbEyeColor.SelectedItem as ComboItem;
            ComboItem bloodGroup = cmbBloodGroup.SelectedItem as ComboItem;
            string livingPlace = txtLivingPlace.Text;
            DateTime issueDate = dtpIssueDate.Value.Date;
            DateTime expiryDate = dtpExpiry.Value.Date;
            string code = txtCode.Text;
            string number = txtNumber.Text;
            string issuinAuthory = txtIssuingAuthory.Text;

            SelectedPerson.FirsName = name;
            SelectedPerson.LastName = surName;
            SelectedPerson.FatherName = fatherName;
            SelectedPerson.BirthPlace = birthPlace;
            SelectedPerson.BirtofDate = birthDate;
            SelectedPerson.GenderId = gender.Value;
            SelectedPerson.NationalityId = Nationality.Value;
            SelectedPerson.MartialStatusId = martialStatus.Value;
            SelectedPerson.MilitaryStatusId = militaryStatus.Value;
            SelectedPerson.height =(byte) height;
            SelectedPerson.EyeColorId = eyeColor.Value;
            SelectedPerson.BloodGroupId = bloodGroup.Value;
            SelectedPerson.LivingPlace = livingPlace;
            SelectedPerson.IssueDate = issueDate;
            SelectedPerson.ExpiryDate = expiryDate;
            SelectedPerson.Code = code;
            SelectedPerson.Number = number;
            SelectedPerson.IssuingAuthory = issuinAuthory;


            db.SaveChanges();
            UpdateDatagrid();
        }

        public void DeletePerson()
        {
            SelectedPerson.DeletedDate = DateTime.Now;
            db.SaveChanges();
            UpdateDatagrid();
        } 

        public void Clear()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtFatherName.Text = "";
            txtBirthPlace.Text = "";
            txtLivingPlace.Text = "";
            txtCode.Text = "";
            txtNumber.Text = "";
            txtIssuingAuthory.Text = "";
        }

        public void Search()
        {
            string name = txtName.Text;
            string surName = txtSurname.Text;
            string fatherName = txtFatherName.Text;
            string birthPlace = txtBirthPlace.Text;
            DateTime birthDate = dtpBirthDate.Value.Date;
            ComboItem Nationality = cmbNationality.SelectedItem as ComboItem;
            ComboItem martialStatus = cmbMartialStatus.SelectedItem as ComboItem;
            ComboItem militaryStatus = cmbMilitaryStatus.SelectedItem as ComboItem;
            int height = Convert.ToInt32(txtHeight.Text);
            ComboItem eyeColor = cmbEyeColor.SelectedItem as ComboItem;
            ComboItem bloodGroup = cmbBloodGroup.SelectedItem as ComboItem;
            string livingPlace = txtLivingPlace.Text;
            DateTime issueDate = dtpIssueDate.Value.Date;

            string code = txtCode.Text;
            string number = txtNumber.Text;
            string issuinAuthory = txtIssuingAuthory.Text;
            var data = db.Persons.AsQueryable();
            if (!string.IsNullOrWhiteSpace(name))
            {
                data = data.Where(d => d.FirsName == name);
            }
            if (!string.IsNullOrWhiteSpace(surName))
            {
                data = data.Where(d => d.LastName == surName);
            }
            if (!string.IsNullOrWhiteSpace(fatherName))
            {
                data = data.Where(d => d.FatherName == fatherName);
            }
            if (!string.IsNullOrWhiteSpace(livingPlace))
            {
                data = data.Where(d => d.LivingPlace == livingPlace);
            }
            if (!string.IsNullOrWhiteSpace(code))
            {
                data = data.Where(d => d.Code == code);
            }
            if (!string.IsNullOrWhiteSpace(number))
            {
                data = data.Where(d => d.Number == number);
            }
            if (!string.IsNullOrWhiteSpace(issuinAuthory))
            {
                data = data.Where(d => d.IssuingAuthory == issuinAuthory);
            }
            int genderId = Convert.ToInt32(cmbGender.SelectedValue);
            data = data.Where(d => d.GenderId == genderId);
            if (dtpBirthDate.Checked == true)
            {
                data = data.Where(d => d.BirtofDate == birthDate);
            }
            if (dtpIssueDate.Checked)
            {
                data = data.Where(d => d.IssueDate == issueDate);
            }
            if (dtpExpiry.Checked)
            {
                DateTime expiryDate = dtpExpiry.Value.Date;
                data = data.Where(d => d.ExpiryDate == expiryDate);
            }

            data = data.Where(d => d.NationalityId == Nationality.Value);
            data = data.Where(d => d.MartialStatusId == martialStatus.Value);
            data = data.Where(d => d.MilitaryStatusId == militaryStatus.Value);
            data = data.Where(d => d.height == height);
            data = data.Where(d => d.EyeColorId == eyeColor.Value);
            data = data.Where(d => d.BloodGroupId == bloodGroup.Value);

            var result = data.Select(p => new
            {
                p.Id,
                NSF = p.FirsName + " " + p.LastName + " " + p.FatherName,
                p.BirtofDate,
                p.BirthPlace,
                Gender = p.Gender.Name,
                Citizenship = p.NAtionality.Name,
                LivingPlace = p.LivingPlace,
                BloodGroup = p.BloodGroup.Name,
                EyeColor = p.EyeColor.Name,
                Height = p.height,
                MartialStatus = p.MartialStatu.Name,
                MilitaryStatus = p.MilitaryStatu.Name,
                Code = p.Code,
                Number = p.Number,
                IssuingAuthory = p.IssuingAuthory,
                p.IssueDate,
                p.ExpiryDate,
                p.DeletedDate
            });

            if (Login.MainUser.Id == 1)
            {
                dgvPersonInfo.DataSource = result.ToList();
            }
            else if (Login.MainUser.Id != 1)
            {
                dgvPersonInfo.DataSource = result.Where(p => p.DeletedDate == null).ToList();
            }
            Clear();

        }

        //Form Events  #################################################
        private void PersonSearchSystem_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                UpdateDatagrid();
                if (Login.MainUser.RoleId != 1)
                {
                    btnDelete.Enabled = false;
                    mnsMainMenu.Enabled = false;
                }
                cmbGender.DataSource = db.Genders.Where(g => g.DeletedDate == null).Select(g => new ComboItem
                {
                    Value = g.Id,
                    Name = g.Name
                }).ToList();
                cmbBloodGroup.DataSource = db.BloodGroups.Where(b => b.DeletedDate == null).Select(b => new ComboItem
                {
                    Value = b.Id,
                    Name = b.Name
                }).ToList();

                cmbNationality.DataSource = db.NAtionalities.Where(c => c.DeletedDate == null).Select(c => new ComboItem
                {
                    Value = c.Id,
                    Name = c.Name
                }).ToList();

                cmbEyeColor.DataSource = db.EyeColors.Where(b => b.DeletedDate == null).Select(b => new ComboItem
                {
                    Value = b.Id,
                    Name = b.Name
                }).ToList();
                cmbMartialStatus.DataSource = db.MartialStatus.Where(m => m.DeletedDate == null).Select(m => new ComboItem
                {
                    Value = m.Id,
                    Name = m.Name
                }).ToList();
                cmbMilitaryStatus.DataSource = db.MilitaryStatus.Where(m => m.deletedDate == null).Select(m => new ComboItem
                {
                    Value = m.Id,
                    Name = m.Name
                }).ToList();
                
                dtpBirthDate.MaxDate = DateTime.Now.Date;
                dtpIssueDate.MaxDate = DateTime.Now.Date;
                dtpExpiry.MaxDate = DateTime.Now.Date;
            }
            catch (Exception ex)
            {
                this.Text = ex.GetType().FullName;
                MessageBox.Show("Program cannot connect with server", "Error");
                Logger.SaveLog(ex);
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            //int id = db.Persons.Where(p => p.Id < SelectedPerson.Id).Last().Id;
            //SelectedPerson = db.Persons.Where(p => p.Id == id).First();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            //int id = db.Persons.Where(p => p.Id > SelectedPerson.Id).First().Id;
            //SelectedPerson = db.Persons.Where(p => p.Id == id).First();
        }
    
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                CreateNewPerson();
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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CreateNewPerson();
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

        private void dgvPersonInfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Id = (int)dgvPersonInfo.Rows[e.RowIndex].Cells[0].Value;
            SelectedPerson = db.Persons.Where(p => p.Id == Id).FirstOrDefault();
            txtName.Text = SelectedPerson.FirsName;
            txtSurname.Text = SelectedPerson.LastName;
            txtFatherName.Text = SelectedPerson.FatherName;
            txtBirthPlace.Text = SelectedPerson.BirthPlace;
            dtpBirthDate.Value = SelectedPerson.BirtofDate.Value;
            cmbGender.SelectedItem = SelectedPerson.Gender;
            cmbNationality.SelectedItem = SelectedPerson.NAtionality;
            cmbMartialStatus.SelectedItem = SelectedPerson.MartialStatu;
            cmbMilitaryStatus.SelectedItem = SelectedPerson.MilitaryStatu;
            txtHeight.Text =SelectedPerson.height.ToString();
            cmbEyeColor.SelectedItem = SelectedPerson.EyeColor;
            cmbBloodGroup.SelectedItem = SelectedPerson.BloodGroup;
            txtLivingPlace.Text = SelectedPerson.LivingPlace;
            dtpIssueDate.Value = SelectedPerson.IssueDate;
            dtpExpiry.Value = SelectedPerson.ExpiryDate.Value;
            txtCode.Text = SelectedPerson.Code;
            txtNumber.Text = SelectedPerson.Number;
            txtIssuingAuthory.Text = SelectedPerson.IssuingAuthory;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdatePerson();
                Clear();
            }
            catch (Exception ex)
            {
                this.Text = ex.GetType().FullName;
                MessageBox.Show("Program cannot connect with server", "Error");
                Logger.SaveLog(ex);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                UpdatePerson();
                Clear();
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

                DeletePerson();
                Clear();
            }
            catch (Exception ex)
            {
                this.Text = ex.GetType().FullName;
                MessageBox.Show("Program cannot connect with server", "Error");
                Logger.SaveLog(ex);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DeletePerson();
                Clear();
            }
            catch (Exception ex)
            {
                this.Text = ex.GetType().FullName;
                MessageBox.Show("Program cannot connect with server", "Error");
                Logger.SaveLog(ex);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Catagories ##############################################################################

        private void citizenshipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nationality N = new Nationality();
            N.Show();
        }

        private void maritalStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaritalStatus mr = new MaritalStatus();
            mr.Show();
        }

        private void militaryStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MilitaryStatus ml = new MilitaryStatus();
            ml.Show();
        }

        private void eyeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EyeColor eye = new EyeColor();
            eye.Show();
        }

        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bloodgroup blood = new Bloodgroup();
            blood.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User us = new User();
            us.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Search();
            }
            catch (Exception ex)
            {
                this.Text = ex.GetType().FullName;
                MessageBox.Show("Program cannot connect with server", "Error");
                Logger.SaveLog(ex);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateDatagrid();
            Clear();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Search();
            }
            catch (Exception ex)
            {
                this.Text = ex.GetType().FullName;
                MessageBox.Show("Program cannot connect with server", "Error");
                Logger.SaveLog(ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                picUser.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            picUser.Image = null;
        }
    }
    }
