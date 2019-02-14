using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityClasses;
namespace University
{
    public partial class TermCourses : Form
    {
        List<StudentCourse> lessons;
        int id;
        public TermCourses(int id)
        {
            InitializeComponent();
            this.id = id;
            Student std = Manager.SearchStudent(id);
            if(std != null)
            {
                label1.Text = std.firstName + " " + std.lastName;
                lessons = std.choosenLessons;
            }




        }

        private void TermCourses_Load(object sender, EventArgs e)
        {
            update();
        }
        public void update()
        {

            if (lessons == null)
            {
                lessons = new List<StudentCourse>();
            }
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ردیف";
            dataGridView1.Columns[1].Name = "کد درس";
            dataGridView1.Columns[2].Name = "اسم درس";
            dataGridView1.Columns[3].Name = "تاریخ امتحان";

            for (int i = 0; i < lessons.Count; i++)
            {
                ArrayList row = new ArrayList();
                row.Add((i + 1).ToString());
                row.Add(lessons[i].course.code.ToString());
                row.Add(lessons[i].course.name.ToString());
                row.Add(lessons[i].course.examTime.ToString());

                dataGridView1.Rows.Add(row.ToArray());
            }



        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            StudentPanel studentPanelPanel = new StudentPanel(id);
            studentPanelPanel.Show();
            this.Hide();

        }

   
    }
}
