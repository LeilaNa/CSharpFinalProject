namespace FinalProject
{
    partial class MilitaryStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MilitaryStatus));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvMilitaryStatus = new System.Windows.Forms.DataGridView();
            this.txtMilitaryStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilitaryStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(319, 257);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 29);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(179, 257);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 29);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(54, 257);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(106, 29);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgvMilitaryStatus
            // 
            this.dgvMilitaryStatus.AllowUserToAddRows = false;
            this.dgvMilitaryStatus.AllowUserToDeleteRows = false;
            this.dgvMilitaryStatus.AllowUserToResizeColumns = false;
            this.dgvMilitaryStatus.AllowUserToResizeRows = false;
            this.dgvMilitaryStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMilitaryStatus.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvMilitaryStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMilitaryStatus.Location = new System.Drawing.Point(54, 80);
            this.dgvMilitaryStatus.Name = "dgvMilitaryStatus";
            this.dgvMilitaryStatus.ReadOnly = true;
            this.dgvMilitaryStatus.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMilitaryStatus.RowTemplate.Height = 24;
            this.dgvMilitaryStatus.Size = new System.Drawing.Size(371, 150);
            this.dgvMilitaryStatus.TabIndex = 6;
            this.dgvMilitaryStatus.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMilitaryStatus_RowHeaderMouseDoubleClick);
            // 
            // txtMilitaryStatus
            // 
            this.txtMilitaryStatus.Location = new System.Drawing.Point(54, 29);
            this.txtMilitaryStatus.Name = "txtMilitaryStatus";
            this.txtMilitaryStatus.Size = new System.Drawing.Size(371, 22);
            this.txtMilitaryStatus.TabIndex = 5;
            // 
            // MilitaryStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 315);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvMilitaryStatus);
            this.Controls.Add(this.txtMilitaryStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MilitaryStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Military Status";
            this.Load += new System.EventHandler(this.MilitaryStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilitaryStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvMilitaryStatus;
        private System.Windows.Forms.TextBox txtMilitaryStatus;
    }
}