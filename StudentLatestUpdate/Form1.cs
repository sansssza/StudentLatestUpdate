using StudentLatestUpdate.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentLatestUpdate
{
   
    public partial class frmStudentMain : Form
    {
        StudentListUserControl studentListUserControl = new StudentListUserControl();
        
        public frmStudentMain()
        {
            InitializeComponent();          
        }

        private void frmStudentMain_Load(object sender, EventArgs e)
        {

        }

        private void studentUserControll1_Load(object sender, EventArgs e)
        {

        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            classUserControl classUserControl = new classUserControl();
            this.mainPanel.Controls.Add(classUserControl);
        }

        private void btnStudentUserControl_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            this.studentUserControll1 = new StudentUserControl();
            this.mainPanel.Controls.Add(this.studentUserControll1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            this.studentListUserControl = new StudentListUserControl();
            this.mainPanel.Controls.Add(this.studentListUserControl);
        }
        private void studentListUserControl1_Load(object sender, EventArgs e)
        {
           
        }

       
    }
}
