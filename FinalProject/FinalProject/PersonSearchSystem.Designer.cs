namespace FinalProject
{
    partial class PersonSearchSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonSearchSystem));
            this.mnsMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citizenshipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maritalStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.militaryStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eyeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvPersonInfo = new System.Windows.Forms.DataGridView();
            this.txtIssuingAuthory = new System.Windows.Forms.TextBox();
            this.lblİssuingAuthory = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.txtLivingPlace = new System.Windows.Forms.TextBox();
            this.lblLivingPlace = new System.Windows.Forms.Label();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.cmbEyeColor = new System.Windows.Forms.ComboBox();
            this.lblEyeColor = new System.Windows.Forms.Label();
            this.cmbMilitaryStatus = new System.Windows.Forms.ComboBox();
            this.lblMilitaryStatus = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.cmbMartialStatus = new System.Windows.Forms.ComboBox();
            this.lblMartialStatus = new System.Windows.Forms.Label();
            this.cmbNationality = new System.Windows.Forms.ComboBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            this.lblBirthPlace = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mnsMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsMainMenu
            // 
            this.mnsMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.directoriesToolStripMenuItem,
            this.authorityToolStripMenuItem});
            this.mnsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMainMenu.Name = "mnsMainMenu";
            this.mnsMainMenu.Size = new System.Drawing.Size(1199, 28);
            this.mnsMainMenu.TabIndex = 1;
            this.mnsMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // directoriesToolStripMenuItem
            // 
            this.directoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citizenshipToolStripMenuItem,
            this.maritalStatusToolStripMenuItem,
            this.militaryStatusToolStripMenuItem,
            this.eyeColorToolStripMenuItem,
            this.bloodGroupToolStripMenuItem});
            this.directoriesToolStripMenuItem.Name = "directoriesToolStripMenuItem";
            this.directoriesToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.directoriesToolStripMenuItem.Text = "Directories";
            // 
            // citizenshipToolStripMenuItem
            // 
            this.citizenshipToolStripMenuItem.Name = "citizenshipToolStripMenuItem";
            this.citizenshipToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.citizenshipToolStripMenuItem.Text = "Nationality";
            this.citizenshipToolStripMenuItem.Click += new System.EventHandler(this.citizenshipToolStripMenuItem_Click);
            // 
            // maritalStatusToolStripMenuItem
            // 
            this.maritalStatusToolStripMenuItem.Name = "maritalStatusToolStripMenuItem";
            this.maritalStatusToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.maritalStatusToolStripMenuItem.Text = "Marital status";
            this.maritalStatusToolStripMenuItem.Click += new System.EventHandler(this.maritalStatusToolStripMenuItem_Click);
            // 
            // militaryStatusToolStripMenuItem
            // 
            this.militaryStatusToolStripMenuItem.Name = "militaryStatusToolStripMenuItem";
            this.militaryStatusToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.militaryStatusToolStripMenuItem.Text = "Military Status";
            this.militaryStatusToolStripMenuItem.Click += new System.EventHandler(this.militaryStatusToolStripMenuItem_Click);
            // 
            // eyeColorToolStripMenuItem
            // 
            this.eyeColorToolStripMenuItem.Name = "eyeColorToolStripMenuItem";
            this.eyeColorToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.eyeColorToolStripMenuItem.Text = "Eye color";
            this.eyeColorToolStripMenuItem.Click += new System.EventHandler(this.eyeColorToolStripMenuItem_Click);
            // 
            // bloodGroupToolStripMenuItem
            // 
            this.bloodGroupToolStripMenuItem.Name = "bloodGroupToolStripMenuItem";
            this.bloodGroupToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.bloodGroupToolStripMenuItem.Text = "Blood group";
            this.bloodGroupToolStripMenuItem.Click += new System.EventHandler(this.bloodGroupToolStripMenuItem_Click);
            // 
            // authorityToolStripMenuItem
            // 
            this.authorityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.authorityToolStripMenuItem.Name = "authorityToolStripMenuItem";
            this.authorityToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.authorityToolStripMenuItem.Text = "Authority";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpBirthDate.CustomFormat = "dd.mm.yyyy";
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(122, 288);
            this.dtpBirthDate.MaxDate = new System.DateTime(2019, 4, 7, 0, 36, 18, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.RightToLeftLayout = true;
            this.dtpBirthDate.ShowCheckBox = true;
            this.dtpBirthDate.Size = new System.Drawing.Size(120, 22);
            this.dtpBirthDate.TabIndex = 5;
            this.dtpBirthDate.Value = new System.DateTime(2019, 4, 6, 0, 0, 0, 0);
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.CustomFormat = "dd.MM.yyyy";
            this.dtpExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiry.Location = new System.Drawing.Point(325, 477);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.ShowCheckBox = true;
            this.dtpExpiry.Size = new System.Drawing.Size(120, 22);
            this.dtpExpiry.TabIndex = 94;
            this.dtpExpiry.Value = new System.DateTime(2019, 4, 6, 0, 0, 0, 0);
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.CustomFormat = "dd.MM.yyyy";
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDate.Location = new System.Drawing.Point(122, 478);
            this.dtpIssueDate.MaxDate = new System.DateTime(2019, 4, 7, 0, 0, 0, 0);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.ShowCheckBox = true;
            this.dtpIssueDate.Size = new System.Drawing.Size(120, 22);
            this.dtpIssueDate.TabIndex = 93;
            this.dtpIssueDate.Value = new System.DateTime(2019, 4, 6, 0, 0, 0, 0);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(966, 514);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 27);
            this.btnUpdate.TabIndex = 92;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(856, 515);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(104, 27);
            this.btnNew.TabIndex = 91;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1076, 515);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 27);
            this.btnDelete.TabIndex = 90;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(688, 513);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 28);
            this.btnSearch.TabIndex = 89;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(594, 515);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(88, 28);
            this.btnRight.TabIndex = 88;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(500, 515);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(88, 28);
            this.btnLeft.TabIndex = 87;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(127, 131);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(38, 36);
            this.btnRemove.TabIndex = 86;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(127, 89);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 36);
            this.btnAdd.TabIndex = 85;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvPersonInfo
            // 
            this.dgvPersonInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonInfo.Location = new System.Drawing.Point(500, 31);
            this.dgvPersonInfo.Name = "dgvPersonInfo";
            this.dgvPersonInfo.RowTemplate.Height = 24;
            this.dgvPersonInfo.Size = new System.Drawing.Size(681, 466);
            this.dgvPersonInfo.TabIndex = 84;
            this.dgvPersonInfo.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPersonInfo_RowHeaderMouseDoubleClick);
            // 
            // txtIssuingAuthory
            // 
            this.txtIssuingAuthory.Location = new System.Drawing.Point(122, 541);
            this.txtIssuingAuthory.Name = "txtIssuingAuthory";
            this.txtIssuingAuthory.Size = new System.Drawing.Size(324, 22);
            this.txtIssuingAuthory.TabIndex = 83;
            // 
            // lblİssuingAuthory
            // 
            this.lblİssuingAuthory.AutoSize = true;
            this.lblİssuingAuthory.Location = new System.Drawing.Point(11, 541);
            this.lblİssuingAuthory.Name = "lblİssuingAuthory";
            this.lblİssuingAuthory.Size = new System.Drawing.Size(105, 17);
            this.lblİssuingAuthory.TabIndex = 82;
            this.lblİssuingAuthory.Text = "Issuing Authory";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(299, 510);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(146, 22);
            this.txtNumber.TabIndex = 81;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(266, 515);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(22, 17);
            this.lblNumber.TabIndex = 80;
            this.lblNumber.Text = "№";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(122, 508);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 22);
            this.txtCode.TabIndex = 79;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(12, 513);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(41, 17);
            this.lblCode.TabIndex = 78;
            this.lblCode.Text = "Code";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(12, 480);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIssueDate.Size = new System.Drawing.Size(75, 17);
            this.lblIssueDate.TabIndex = 77;
            this.lblIssueDate.Text = "Issue Date";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(248, 479);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(80, 17);
            this.lblExpiryDate.TabIndex = 76;
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // txtLivingPlace
            // 
            this.txtLivingPlace.Location = new System.Drawing.Point(122, 443);
            this.txtLivingPlace.Name = "txtLivingPlace";
            this.txtLivingPlace.Size = new System.Drawing.Size(323, 22);
            this.txtLivingPlace.TabIndex = 75;
            // 
            // lblLivingPlace
            // 
            this.lblLivingPlace.AutoSize = true;
            this.lblLivingPlace.Location = new System.Drawing.Point(12, 448);
            this.lblLivingPlace.Name = "lblLivingPlace";
            this.lblLivingPlace.Size = new System.Drawing.Size(83, 17);
            this.lblLivingPlace.TabIndex = 74;
            this.lblLivingPlace.Text = "Living place";
            // 
            // cmbBloodGroup
            // 
            this.cmbBloodGroup.FormattingEnabled = true;
            this.cmbBloodGroup.Location = new System.Drawing.Point(358, 413);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(88, 24);
            this.cmbBloodGroup.TabIndex = 73;
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Location = new System.Drawing.Point(266, 416);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(88, 17);
            this.lblBloodGroup.TabIndex = 72;
            this.lblBloodGroup.Text = "Blood Group";
            // 
            // cmbEyeColor
            // 
            this.cmbEyeColor.FormattingEnabled = true;
            this.cmbEyeColor.Location = new System.Drawing.Point(122, 413);
            this.cmbEyeColor.Name = "cmbEyeColor";
            this.cmbEyeColor.Size = new System.Drawing.Size(121, 24);
            this.cmbEyeColor.TabIndex = 71;
            // 
            // lblEyeColor
            // 
            this.lblEyeColor.AutoSize = true;
            this.lblEyeColor.Location = new System.Drawing.Point(14, 420);
            this.lblEyeColor.Name = "lblEyeColor";
            this.lblEyeColor.Size = new System.Drawing.Size(69, 17);
            this.lblEyeColor.TabIndex = 70;
            this.lblEyeColor.Text = "Eye Color";
            // 
            // cmbMilitaryStatus
            // 
            this.cmbMilitaryStatus.FormattingEnabled = true;
            this.cmbMilitaryStatus.Location = new System.Drawing.Point(122, 378);
            this.cmbMilitaryStatus.Name = "cmbMilitaryStatus";
            this.cmbMilitaryStatus.Size = new System.Drawing.Size(323, 24);
            this.cmbMilitaryStatus.TabIndex = 69;
            // 
            // lblMilitaryStatus
            // 
            this.lblMilitaryStatus.AutoSize = true;
            this.lblMilitaryStatus.Location = new System.Drawing.Point(12, 385);
            this.lblMilitaryStatus.Name = "lblMilitaryStatus";
            this.lblMilitaryStatus.Size = new System.Drawing.Size(96, 17);
            this.lblMilitaryStatus.TabIndex = 68;
            this.lblMilitaryStatus.Text = "Military Status";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(266, 350);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(49, 17);
            this.lblHeight.TabIndex = 67;
            this.lblHeight.Text = "Height";
            // 
            // cmbMartialStatus
            // 
            this.cmbMartialStatus.FormattingEnabled = true;
            this.cmbMartialStatus.Location = new System.Drawing.Point(122, 347);
            this.cmbMartialStatus.Name = "cmbMartialStatus";
            this.cmbMartialStatus.Size = new System.Drawing.Size(121, 24);
            this.cmbMartialStatus.TabIndex = 66;
            // 
            // lblMartialStatus
            // 
            this.lblMartialStatus.AutoSize = true;
            this.lblMartialStatus.Location = new System.Drawing.Point(12, 355);
            this.lblMartialStatus.Name = "lblMartialStatus";
            this.lblMartialStatus.Size = new System.Drawing.Size(94, 17);
            this.lblMartialStatus.TabIndex = 65;
            this.lblMartialStatus.Text = "Marital Status";
            // 
            // cmbNationality
            // 
            this.cmbNationality.FormattingEnabled = true;
            this.cmbNationality.Location = new System.Drawing.Point(122, 316);
            this.cmbNationality.Name = "cmbNationality";
            this.cmbNationality.Size = new System.Drawing.Size(323, 24);
            this.cmbNationality.TabIndex = 64;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(12, 319);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(76, 17);
            this.lblNationality.TabIndex = 63;
            this.lblNationality.Text = "Citizenship";
            // 
            // cmbGender
            // 
            this.cmbGender.DisplayMember = "Name";
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(321, 286);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(124, 24);
            this.cmbGender.TabIndex = 6;
            this.cmbGender.ValueMember = "Value";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(259, 289);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 61;
            this.lblGender.Text = "Gender";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(11, 293);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(71, 17);
            this.lblBirthDate.TabIndex = 60;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.Location = new System.Drawing.Point(122, 258);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(323, 22);
            this.txtBirthPlace.TabIndex = 59;
            // 
            // lblBirthPlace
            // 
            this.lblBirthPlace.AutoSize = true;
            this.lblBirthPlace.Location = new System.Drawing.Point(11, 261);
            this.lblBirthPlace.Name = "lblBirthPlace";
            this.lblBirthPlace.Size = new System.Drawing.Size(76, 17);
            this.lblBirthPlace.TabIndex = 58;
            this.lblBirthPlace.Text = "Birth Place";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(122, 230);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(323, 22);
            this.txtFatherName.TabIndex = 57;
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(11, 233);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(88, 17);
            this.lblFatherName.TabIndex = 56;
            this.lblFatherName.Text = "Father name";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(122, 202);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(323, 22);
            this.txtSurname.TabIndex = 55;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(11, 199);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 17);
            this.lblSurname.TabIndex = 54;
            this.lblSurname.Text = "Surname";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 174);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(323, 22);
            this.txtName.TabIndex = 53;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 174);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 52;
            this.lblName.Text = "Name";
            // 
            // picUser
            // 
            this.picUser.Location = new System.Drawing.Point(12, 31);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(108, 136);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 51;
            this.picUser.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1022, 547);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(159, 36);
            this.btnRefresh.TabIndex = 98;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(321, 349);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(121, 22);
            this.txtHeight.TabIndex = 99;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PersonSearchSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 585);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.dtpExpiry);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPersonInfo);
            this.Controls.Add(this.txtIssuingAuthory);
            this.Controls.Add(this.lblİssuingAuthory);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.txtLivingPlace);
            this.Controls.Add(this.lblLivingPlace);
            this.Controls.Add(this.cmbBloodGroup);
            this.Controls.Add(this.lblBloodGroup);
            this.Controls.Add(this.cmbEyeColor);
            this.Controls.Add(this.lblEyeColor);
            this.Controls.Add(this.cmbMilitaryStatus);
            this.Controls.Add(this.lblMilitaryStatus);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.cmbMartialStatus);
            this.Controls.Add(this.lblMartialStatus);
            this.Controls.Add(this.cmbNationality);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.txtBirthPlace);
            this.Controls.Add(this.lblBirthPlace);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.lblFatherName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.mnsMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonSearchSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Search System";
            this.Load += new System.EventHandler(this.PersonSearchSystem_Load);
            this.mnsMainMenu.ResumeLayout(false);
            this.mnsMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citizenshipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maritalStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem militaryStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eyeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvPersonInfo;
        private System.Windows.Forms.TextBox txtIssuingAuthory;
        private System.Windows.Forms.Label lblİssuingAuthory;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.TextBox txtLivingPlace;
        private System.Windows.Forms.Label lblLivingPlace;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.ComboBox cmbEyeColor;
        private System.Windows.Forms.Label lblEyeColor;
        private System.Windows.Forms.ComboBox cmbMilitaryStatus;
        private System.Windows.Forms.Label lblMilitaryStatus;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.ComboBox cmbMartialStatus;
        private System.Windows.Forms.Label lblMartialStatus;
        private System.Windows.Forms.ComboBox cmbNationality;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtBirthPlace;
        private System.Windows.Forms.Label lblBirthPlace;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}