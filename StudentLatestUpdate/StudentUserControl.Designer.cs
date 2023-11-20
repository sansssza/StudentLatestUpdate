namespace StudentLatestUpdate
{
    partial class StudentUserControl
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
            this.btnStudentUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgrAddress = new System.Windows.Forms.DataGridView();
            this.Address_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Address_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.txtStudentNrc = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblStudentNrc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.Content = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkUpdate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrAddress)).BeginInit();
            this.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStudentUpdate
            // 
            this.btnStudentUpdate.BackColor = System.Drawing.Color.Olive;
            this.btnStudentUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentUpdate.Location = new System.Drawing.Point(537, 460);
            this.btnStudentUpdate.Name = "btnStudentUpdate";
            this.btnStudentUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnStudentUpdate.TabIndex = 28;
            this.btnStudentUpdate.Text = "Update";
            this.btnStudentUpdate.UseVisualStyleBackColor = false;
            this.btnStudentUpdate.Click += new System.EventHandler(this.btnStudentUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(456, 460);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(368, 187);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(281, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgrAddress
            // 
            this.dgrAddress.AllowUserToAddRows = false;
            this.dgrAddress.AllowUserToOrderColumns = true;
            this.dgrAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Address_id,
            this.Address,
            this.Student_Address_id});
            this.dgrAddress.Location = new System.Drawing.Point(26, 230);
            this.dgrAddress.Name = "dgrAddress";
            this.dgrAddress.Size = new System.Drawing.Size(417, 253);
            this.dgrAddress.TabIndex = 24;
            this.dgrAddress.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrAddress_CellContentClick);
            this.dgrAddress.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrAddress_CellDoubleClick);
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
            this.Address.DataPropertyName = "Address_name";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Student_Address_id
            // 
            this.Student_Address_id.DataPropertyName = "Address_student_id";
            this.Student_Address_id.HeaderText = "Student_Address_id";
            this.Student_Address_id.Name = "Student_Address_id";
            this.Student_Address_id.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(132, 187);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(143, 20);
            this.txtAddress.TabIndex = 23;
            this.txtAddress.Tag = "4";
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(132, 101);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(143, 21);
            this.cboClass.TabIndex = 22;
            this.cboClass.Tag = "3";
            // 
            // txtStudentNrc
            // 
            this.txtStudentNrc.Location = new System.Drawing.Point(132, 61);
            this.txtStudentNrc.Name = "txtStudentNrc";
            this.txtStudentNrc.Size = new System.Drawing.Size(143, 20);
            this.txtStudentNrc.TabIndex = 21;
            this.txtStudentNrc.Tag = "2";
            this.txtStudentNrc.TextChanged += new System.EventHandler(this.txtStudentNrc_TextChanged);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(132, 16);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(143, 20);
            this.txtStudentName.TabIndex = 20;
            this.txtStudentName.Tag = "1";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.Location = new System.Drawing.Point(26, 147);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(121, 19);
            this.chkIsActive.TabIndex = 19;
            this.chkIsActive.Text = "Student is active?";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(23, 192);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 15);
            this.lblAddress.TabIndex = 18;
            this.lblAddress.Text = "Address :";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(23, 109);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(43, 15);
            this.lblClass.TabIndex = 17;
            this.lblClass.Text = "Class :";
            // 
            // lblStudentNrc
            // 
            this.lblStudentNrc.AutoSize = true;
            this.lblStudentNrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNrc.Location = new System.Drawing.Point(23, 68);
            this.lblStudentNrc.Name = "lblStudentNrc";
            this.lblStudentNrc.Size = new System.Drawing.Size(84, 15);
            this.lblStudentNrc.TabIndex = 16;
            this.lblStudentNrc.Text = "Student NRC :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(23, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 15);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Student Name :";
            // 
            // Content
            // 
            this.Content.Controls.Add(this.btnStudentUpdate);
            this.Content.Controls.Add(this.btnDelete);
            this.Content.Controls.Add(this.btnSave);
            this.Content.Controls.Add(this.chkUpdate);
            this.Content.Location = new System.Drawing.Point(3, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(722, 511);
            this.Content.TabIndex = 29;
            this.Content.Paint += new System.Windows.Forms.PaintEventHandler(this.Content_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(618, 461);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkUpdate
            // 
            this.chkUpdate.AutoSize = true;
            this.chkUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkUpdate.Location = new System.Drawing.Point(291, 61);
            this.chkUpdate.Name = "chkUpdate";
            this.chkUpdate.Size = new System.Drawing.Size(252, 17);
            this.chkUpdate.TabIndex = 0;
            this.chkUpdate.Text = "Do you want to update Student Name and Nrc?";
            this.chkUpdate.UseVisualStyleBackColor = false;
            this.chkUpdate.CheckedChanged += new System.EventHandler(this.chkUpdate_CheckedChanged);
            // 
            // StudentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgrAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.txtStudentNrc);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblStudentNrc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.Content);
            this.Name = "StudentUserControl";
            this.Size = new System.Drawing.Size(725, 517);
            this.Load += new System.EventHandler(this.studentUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrAddress)).EndInit();
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudentUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgrAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.TextBox txtStudentNrc;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblStudentNrc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Address_id;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.CheckBox chkUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}
