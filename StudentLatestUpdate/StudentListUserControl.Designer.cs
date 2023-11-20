namespace StudentLatestUpdate
{
    partial class StudentListUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgrStudentInfo = new System.Windows.Forms.DataGridView();
            this.Student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_NRC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrAddressInfo = new System.Windows.Forms.DataGridView();
            this.Address_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.lblAddressInfo = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrStudentInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrAddressInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrStudentInfo
            // 
            this.dgrStudentInfo.AllowUserToAddRows = false;
            this.dgrStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrStudentInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_id,
            this.Student_name,
            this.Student_NRC});
            this.dgrStudentInfo.Location = new System.Drawing.Point(34, 99);
            this.dgrStudentInfo.Name = "dgrStudentInfo";
            this.dgrStudentInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrStudentInfo.Size = new System.Drawing.Size(356, 333);
            this.dgrStudentInfo.TabIndex = 0;
            this.dgrStudentInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgrStudentInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrStudentInfo_CellDoubleClick);
            // 
            // Student_id
            // 
            this.Student_id.DataPropertyName = "Student_id";
            this.Student_id.HeaderText = "Student_id";
            this.Student_id.Name = "Student_id";
            this.Student_id.Visible = false;
            // 
            // Student_name
            // 
            this.Student_name.DataPropertyName = "Student_name";
            this.Student_name.HeaderText = "Student_name";
            this.Student_name.Name = "Student_name";
            // 
            // Student_NRC
            // 
            this.Student_NRC.DataPropertyName = "Student_NRC";
            this.Student_NRC.HeaderText = "Student_NRC";
            this.Student_NRC.Name = "Student_NRC";
            // 
            // dgrAddressInfo
            // 
            this.dgrAddressInfo.AllowUserToAddRows = false;
            this.dgrAddressInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrAddressInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Address_id,
            this.Address,
            this.Address_student_id});
            this.dgrAddressInfo.Location = new System.Drawing.Point(425, 99);
            this.dgrAddressInfo.Name = "dgrAddressInfo";
            this.dgrAddressInfo.Size = new System.Drawing.Size(256, 333);
            this.dgrAddressInfo.TabIndex = 2;
            // 
            // Address_id
            // 
            this.Address_id.DataPropertyName = "Address_id";
            this.Address_id.HeaderText = "Address_id";
            this.Address_id.Name = "Address_id";
            this.Address_id.Visible = false;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Address_student_id
            // 
            this.Address_student_id.DataPropertyName = "Address_student_id";
            this.Address_student_id.HeaderText = "Address_student_id";
            this.Address_student_id.Name = "Address_student_id";
            this.Address_student_id.Visible = false;
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentInfo.Location = new System.Drawing.Point(33, 63);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(76, 16);
            this.lblStudentInfo.TabIndex = 3;
            this.lblStudentInfo.Text = "Student Info";
            this.lblStudentInfo.Click += new System.EventHandler(this.lblStudentInfo_Click);
            // 
            // lblAddressInfo
            // 
            this.lblAddressInfo.AutoSize = true;
            this.lblAddressInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressInfo.Location = new System.Drawing.Point(422, 53);
            this.lblAddressInfo.Name = "lblAddressInfo";
            this.lblAddressInfo.Size = new System.Drawing.Size(82, 16);
            this.lblAddressInfo.TabIndex = 4;
            this.lblAddressInfo.Text = "Address Info";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(36, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // StudentListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblAddressInfo);
            this.Controls.Add(this.lblStudentInfo);
            this.Controls.Add(this.dgrAddressInfo);
            this.Controls.Add(this.dgrStudentInfo);
            this.Name = "StudentListUserControl";
            this.Size = new System.Drawing.Size(725, 500);
            this.Load += new System.EventHandler(this.StudentListUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrStudentInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrAddressInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrStudentInfo;
        private System.Windows.Forms.DataGridView dgrAddressInfo;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.Label lblAddressInfo;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_NRC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_student_id;
    }
}
