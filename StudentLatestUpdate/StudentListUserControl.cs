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
    public partial class StudentListUserControl : UserControl
    {
        public object mainPanel { get; private set; }

        public StudentListUserControl()
        {
            InitializeComponent();
        }

        private void StudentListUserControl_Load(object sender, EventArgs e)
        {
            using (var db = new StudentFinalDBEntities2())
            {
                var students = (from s in db.Students select new { s.Student_id, s.Student_name, s.Student_NRC }).ToList();
                dgrStudentInfo.DataSource = students;
            }
        }

        private void StudentInfoList_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new StudentFinalDBEntities2())
            {
                int student_id = Convert.ToInt32(dgrStudentInfo.Rows[e.RowIndex].Cells[0].Value.ToString());

                var address = (from add in db.Student_Address where add.Address_student_id == student_id select new { add.Address_id, add.Address, add.Address_student_id }).ToList();
                dgrAddressInfo.DataSource = address;
            }
        }

        private void lblStudentInfo_Click(object sender, EventArgs e)
        {

        }

        private void dgrStudentInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(dgrStudentInfo.Rows[dgrStudentInfo.CurrentRow.Index].Cells[0].Value.ToString());

            //StudentUserControl studentUserControl = new StudentUserControl(studentId);
            //studentUserControl.ShowDialog();

            Form form = new Form();
            form.Width = 730;
            form.Height = 550;
            form.StartPosition = FormStartPosition.CenterScreen;
            StudentUserControl studentUserControl = new StudentUserControl(studentId);
            form.Controls.Add(studentUserControl);

            form.Show();

        }
    }
}
