using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityClasses;

namespace University
{
    public partial class ManagerPanel : Form
    {
        EnterPage enterPagePanel = new EnterPage();
        string id;
        Manager mng;
        public ManagerPanel(string id)
        {
            Console.WriteLine("panel");
            this.id = id;
            InitializeComponent();
            if (id != "")
            {
                mng = Manager.SearchManager(id).info;
                managername.Text = mng.firstName + " " + mng.lastName;
                managerid.Text = mng.id.ToString();
            }
        }

        private void btn_change_password_Click(object sender, EventArgs e)
        {
            ChangePassword changePasswordPanel = new ChangePassword(id);
            changePasswordPanel.Show();
            this.Hide();
        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            enterPagePanel.Show();
            this.Hide();
        }

        private void btn_sign_up_master_Click(object sender, EventArgs e)
        {
            SignUpMasterPanel addMasterPanelPanel = new SignUpMasterPanel(id);
            addMasterPanelPanel.Show();
            this.Hide();
        }

  

        private void btn_sign_up_student_Click(object sender, EventArgs e)
        {
            SignUpStudentPanel signupStudentPanel = new SignUpStudentPanel(id);
            signupStudentPanel.ShowDialog();
            this.Hide();
        }

        private void btn_sign_up_manager_Click(object sender, EventArgs e)
        {
            SignUpManagerPanel signUpManagerPanel = new SignUpManagerPanel(id);
            signUpManagerPanel.ShowDialog();
            this.Hide();
        }

        private void btn_remove_student_Click(object sender, EventArgs e)
        {
            RemoveStudentPanel removeStudentPanel = new RemoveStudentPanel(id);
            removeStudentPanel.ShowDialog();
            this.Hide();
        }

        private void btn_remove_manager_Click(object sender, EventArgs e)
        {
            RemoveManagerPanel removeManagerPanel = new RemoveManagerPanel(id);
            removeManagerPanel.ShowDialog();
            this.Hide();
        }

        private void btn_remove_student_term_Click(object sender, EventArgs e)
        {
            RemoveStudentSemesterPanel removeStudentSemesterPanel = new RemoveStudentSemesterPanel(id);
            removeStudentSemesterPanel.ShowDialog();
            this.Hide();
        }

        private void btn_remove_master_Click(object sender, EventArgs e)
        {
            RemoveMasterPanel removeMasterPanel = new RemoveMasterPanel(id);
            removeMasterPanel.ShowDialog();
            this.Hide();
        }

        private void ManagerPanel_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_course_Click(object sender, EventArgs e)
        {
            AddCoursePanel addCoursePanel = new AddCoursePanel(id);
            addCoursePanel.ShowDialog();
        }

        private void btn_control_add_remove_course_Click(object sender, EventArgs e)
        {
            ControlerPanel controlerPanel = new ControlerPanel(id);
            controlerPanel.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mng.EndingSemester();
            FileStream file = File.Create("Uni");
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(file, Universal.instance);
            file.Close();
        }
    }
}
