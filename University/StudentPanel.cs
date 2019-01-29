using System;
using System.Windows.Forms;
using UniversityClasses;
namespace University
{
    
    public partial class StudentPanel : Form
    {
        int id;
   
        public StudentPanel(int id)
        {
            InitializeComponent();
            this.id = id;
           Student std = Manager.SearchStudent(id);
            if ( std!= null)
            {
                studentId.Text = std.id.ToString();
                studentName.Text = std.firstName + " " + std.lastName;

            }
            btn_unitChoose.Enabled = Universal.instance.isAbleUnitChoice;
            btn_addRemove.Enabled = Universal.instance.isAbleUnitEdit;


        }
         
        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            EnterPage enterPagePanel = new EnterPage();
            enterPagePanel.Show();
            this.Hide();
        }

        private void btn_editPassword_Click(object sender, EventArgs e)
        {
            ChangePasswordStudent changePasswordPanel = new ChangePasswordStudent(id);
            changePasswordPanel.Show();
            this.Hide();
        }

        private void btn_addRemove_Click(object sender, EventArgs e)
        {
            Add_Remove_Course add_remove_Panel = new Add_Remove_Course(id);
            add_remove_Panel.Show();
        }

        private void btn_unitChoose_Click(object sender, EventArgs e)
        {
            ChooseCourse chooseCoursePanel = new ChooseCourse(id);
            chooseCoursePanel.Show();
        }

        private void btn_getResult_Click(object sender, EventArgs e)
        {
            Grades gradesPanel = new Grades(id);
            gradesPanel.Show();
            this.Close();
        }

        private void btn_passed_courses_Click(object sender, EventArgs e)
        {
            PassedCoursesListPanel passedCoursesListPanel = new PassedCoursesListPanel(id);
            passedCoursesListPanel.Show();
            this.Close();
        }

        private void btn_presentedLessons_Click(object sender, EventArgs e)
        {
            TermCourses termCourses = new TermCourses(id);
            termCourses.Show();
            this.Close();
        }
    }
}