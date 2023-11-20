namespace StudentLatestUpdate
{
    partial class classUserControl
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
            this.components = new System.ComponentModel.Container();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblClassDescription = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtClassDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.Location = new System.Drawing.Point(65, 39);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(80, 15);
            this.lblClassName.TabIndex = 0;
            this.lblClassName.Text = "Class Name :";
            // 
            // lblClassDescription
            // 
            this.lblClassDescription.AutoSize = true;
            this.lblClassDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassDescription.Location = new System.Drawing.Point(65, 90);
            this.lblClassDescription.Name = "lblClassDescription";
            this.lblClassDescription.Size = new System.Drawing.Size(108, 15);
            this.lblClassDescription.TabIndex = 1;
            this.lblClassDescription.Text = "Class Description :";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(68, 142);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(121, 19);
            this.chkActive.TabIndex = 2;
            this.chkActive.Text = "Student is Active?";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(68, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(179, 34);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(162, 20);
            this.txtClassName.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtClassDescription
            // 
            this.txtClassDescription.Location = new System.Drawing.Point(179, 85);
            this.txtClassDescription.Name = "txtClassDescription";
            this.txtClassDescription.Size = new System.Drawing.Size(162, 20);
            this.txtClassDescription.TabIndex = 7;
            // 
            // classUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtClassDescription);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.lblClassDescription);
            this.Controls.Add(this.lblClassName);
            this.Name = "classUserControl";
            this.Size = new System.Drawing.Size(725, 500);
            this.Load += new System.EventHandler(this.classUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblClassDescription;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtClassDescription;
    }
}
