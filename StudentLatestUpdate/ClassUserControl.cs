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
    public partial class classUserControl : UserControl
    {
        public classUserControl()
        {
            InitializeComponent();
        }

        private void classUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Class save_to_class = new Class();
            using (var db = new StudentFinalDBEntities2())
            {
                save_to_class.Class_name = txtClassName.Text;
                save_to_class.Class_description = txtClassDescription.Text;
                save_to_class.Class_is_active = true;

                db.Classes.Add(save_to_class);
                db.SaveChanges();
                MessageBox.Show("Successfully Submitted!");
            }

            txtClassName.Clear();
            txtClassDescription.Clear();
            chkActive.Checked = false;
        }
    }
}
