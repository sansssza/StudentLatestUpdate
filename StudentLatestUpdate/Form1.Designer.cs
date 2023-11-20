namespace StudentLatestUpdate
{
    partial class frmStudentMain
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
            this.panel = new System.Windows.Forms.Panel();
            this.btnStudentUserControl = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel.Controls.Add(this.btnStudentUserControl);
            this.panel.Controls.Add(this.button2);
            this.panel.Controls.Add(this.btnClass);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(160, 631);
            this.panel.TabIndex = 0;
            // 
            // btnStudentUserControl
            // 
            this.btnStudentUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStudentUserControl.FlatAppearance.BorderSize = 0;
            this.btnStudentUserControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentUserControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentUserControl.ForeColor = System.Drawing.Color.White;
            this.btnStudentUserControl.Location = new System.Drawing.Point(29, 127);
            this.btnStudentUserControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStudentUserControl.Name = "btnStudentUserControl";
            this.btnStudentUserControl.Size = new System.Drawing.Size(100, 28);
            this.btnStudentUserControl.TabIndex = 16;
            this.btnStudentUserControl.Text = "Student Form";
            this.btnStudentUserControl.UseVisualStyleBackColor = false;
            this.btnStudentUserControl.Click += new System.EventHandler(this.btnStudentUserControl_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(0, 197);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Student List Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClass
            // 
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.ForeColor = System.Drawing.Color.Transparent;
            this.btnClass.Location = new System.Drawing.Point(29, 46);
            this.btnClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(100, 32);
            this.btnClass.TabIndex = 1;
            this.btnClass.Text = "Class Form";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(160, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(963, 631);
            this.mainPanel.TabIndex = 1;
            // 
            // frmStudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 631);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStudentMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Main Form";
            this.Load += new System.EventHandler(this.frmStudentMain_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnStudentUserControl;
        private StudentUserControl studentUserControll1;
        private System.Windows.Forms.Panel mainPanel;
    }
}

