using StudentLatestUpdate.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentLatestUpdate
{
    public partial class StudentUserControl : UserControl
    {
        Student student = new Student();
        int selectedRowIndex;

        int studentId;
        public StudentUserControl()
        {
            InitializeComponent();
            Load_To_Class_Combo_box();
        }

        public StudentUserControl(int studentId)
        {
            InitializeComponent();

            Load_To_Class_Combo_box();

            using (var db = new StudentFinalDBEntities2())
            {
                student = db.Students.Where(s => s.Student_id == studentId).FirstOrDefault();

                txtStudentName.Text = student.Student_name;
                txtStudentNrc.Text = student.Student_NRC;

                cboClass.SelectedValue = student.Student_class_id;
                chkIsActive.Checked = student.Student_is_active;

                Load_To_Address_dgr();
            }
        }

        private void studentUserControl_Load(object sender, EventArgs e)
        {

        }

        public void Load_To_Class_Combo_box()
        {
            using (var db = new StudentFinalDBEntities2())
            {
                List<Class> classes = db.Classes.ToList();
                cboClass.DataSource = classes;
                cboClass.ValueMember = "Class_id";
                cboClass.DisplayMember = "Class_name";
            }
        }

        public void Load_To_Address_dgr()
        {
            using (var db = new StudentFinalDBEntities2())
            {

                var addresses = (from add in db.Student_Address where add.Address_student_id == student.Student_id select new { add.Address_id, add.Address, add.Address_student_id }).ToList();

                foreach (var address in addresses)
                {
                    dgrAddress.Rows.Add(address.Address_id, address.Address, address.Address_student_id);
                }
            }
        }

        //Address add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgrAddress.Rows.Add(0, txtAddress.Text, Student_Address_id);
            txtAddress.Clear();
        }

        //Student Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            string student_name = txtStudentName.Text;
            string student_nrc = txtStudentNrc.Text;

            using (var db = new StudentFinalDBEntities2())
            {

                bool isExitName = (from s in db.Students where s.Student_name == student_name select s).Any();
                if (isExitName)
                    MessageBox.Show("Student name is already exit!");

                bool isExitNRC = (from s in db.Students where s.Student_NRC == student_nrc select s).Any();
                if (isExitNRC)
                    MessageBox.Show("Student NRC is already exit!");

                if (!isExitName && !isExitNRC)
                {
                    if (cboClass.SelectedValue != null)
                    {
                        //Student student = new Student();

                        student.Student_name = txtStudentName.Text;
                        student.Student_NRC = txtStudentNrc.Text;
                        student.Student_class_id = Convert.ToInt32(cboClass.SelectedValue.ToString());
                        student.Student_is_active = chkIsActive.Checked;

                        foreach (DataGridViewRow row in dgrAddress.Rows)
                        {
                            Student_Address address = new Student_Address();
                            address.Address = row.Cells[1].Value.ToString();
                            student.Student_Address.Add(address);
                        }

                        if (studentId == 0)
                            db.Students.Add(student);
                        db.SaveChanges();
                        MessageBox.Show("Successfully submitted.");

                        txtStudentName.Clear();
                        txtStudentNrc.Clear();
                        cboClass.SelectedValue = false;
                        chkIsActive.Checked = false;
                        dgrAddress.Rows.Clear();

                    }
                }
            }
        }

        private void dgrAddress_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            selectedRowIndex = e.RowIndex;
            txtAddress.Text = dgrAddress.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        //Address update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgrAddress.Rows[selectedRowIndex].Cells[1].Value = txtAddress.Text.ToString();

            using (var db = new StudentFinalDBEntities2())
            {
                var addresses = (from add in db.Student_Address where add.Address_student_id == student.Student_id select add).FirstOrDefault();

                if (addresses != null)
                {
                    addresses.Address = txtAddress.Text;
                    txtAddress.Clear();
                    db.SaveChanges();
                    MessageBox.Show("Successfully Submitted.");
                }
            }
        }

        //Student update
        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            string student_name = txtStudentName.Text;
            string student_nrc = txtStudentNrc.Text;

            if (chkUpdate.Checked == true)
            {
                using (var db = new StudentFinalDBEntities2())
                {
                    Student student_to_update = (from s in db.Students where (s.Student_id == student.Student_id) select s).FirstOrDefault();

                    bool isExitName = (from s in db.Students where s.Student_name == student_name select s ).Any();
                    if (isExitName)
                        MessageBox.Show("Student Name is already exit!");

                    bool isExitNRC = (from s in db.Students where s.Student_NRC == student_nrc select s).Any();
                    if (isExitNRC)
                        MessageBox.Show("Student NRC is already exit!");

                    if (!isExitName && !isExitNRC)
                    {
                        if (cboClass.SelectedValue != null)
                        {
                            student_to_update.Student_name = txtStudentName.Text;
                            student_to_update.Student_NRC = txtStudentNrc.Text;
                            student_to_update.Student_class_id = Convert.ToInt32(cboClass.SelectedValue.ToString());
                            student_to_update.Student_is_active = chkIsActive.Checked;

                            foreach (DataGridViewRow row in dgrAddress.Rows)
                            {
                                int address_id = Convert.ToInt32(row.Cells[0].Value.ToString());

                                if (address_id != 0)
                                {
                                    Student_Address address = (from add in db.Student_Address where add.Address_id == address_id select add).FirstOrDefault();
                                    address.Address = row.Cells[1].Value.ToString();
                                }

                                else
                                {
                                    Student_Address address = new Student_Address();
                                    address.Address = row.Cells[1].Value.ToString();
                                    student_to_update.Student_Address.Add(address);
                                }
                                db.SaveChanges();
                            }

                            MessageBox.Show("Successfully Submitted.");
                            txtStudentName.Clear();
                            txtStudentNrc.Clear();
                            cboClass.SelectedValue = false;
                            chkIsActive.Checked = false;
                            dgrAddress.Rows.Clear();
                        }
                    }
                }
            }
            else
            {

                using (var db = new StudentFinalDBEntities2())
                {

                    Student student_to_update = (from s in db.Students where (s.Student_id == student.Student_id) select s).FirstOrDefault();

                    if (cboClass.SelectedValue != null)
                    {
                        student_to_update.Student_name = student_to_update.Student_name;
                        student_to_update.Student_NRC = student_to_update.Student_NRC;
                        student_to_update.Student_class_id = Convert.ToInt32(cboClass.SelectedValue.ToString());
                        student_to_update.Student_is_active = chkIsActive.Checked;

                        foreach (DataGridViewRow row in dgrAddress.Rows)
                        {
                            int address_id = Convert.ToInt32(row.Cells[0].Value.ToString());

                            if (address_id != 0)
                            {
                                Student_Address address = (from add in db.Student_Address where add.Address_id == address_id select add).FirstOrDefault();
                                address.Address = row.Cells[1].Value.ToString();
                            }

                            else
                            {
                                Student_Address address = new Student_Address();
                                address.Address = row.Cells[1].Value.ToString();
                                student_to_update.Student_Address.Add(address);
                            }
                            db.SaveChanges();
                        }

                        MessageBox.Show("Successfully Submitted.");
                        txtStudentName.Clear();
                        txtStudentNrc.Clear();
                        cboClass.SelectedValue = false;
                        chkIsActive.Checked = false;
                        dgrAddress.Rows.Clear();
                    }
                }
            }
        }

        //button student click
        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure want to delete!!!");
            using (var db = new StudentFinalDBEntities2())
            {
                Student delete_student = db.Students.Where(s => s.Student_id == student.Student_id).SingleOrDefault();

                db.Students.Remove(delete_student);
                db.SaveChanges();
            }
        }

        private void dgrAddress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtStudentNrc_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkUpdate_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
