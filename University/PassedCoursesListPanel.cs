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
    public partial class PassedCoursesListPanel : Form
    {
        List<StudentCourse> lessons;
        int id;
        public PassedCoursesListPanel(int id)
        {
            InitializeComponent();
            this.id = id;
            Student std = Manager.SearchStudent(id);
            if (std != null)
            {
                label1.Text = std.firstName + " " + std.lastName;
                lessons = std.passedLessons;
            }
        }

        private void PassedCoursesListPanel_Load(object sender, EventArgs e)
        {
            update();
        }
        public void update()
        {
            if(lessons == null)
            {
                lessons = new List<StudentCourse>();
            }
            dataGridView2.ColumnCount = 4;
            dataGridView2.Columns[0].Name = "ردیف";
            dataGridView2.Columns[1].Name = "اسم درس";
            dataGridView2.Columns[2].Name = "نمره گرفته شده";
            dataGridView2.Columns[3].Name = "استاد";
            int unitscount=0;
            double sum=0;
            for (int i = 0; i < lessons.Count; i++)
            {
                ArrayList row = new ArrayList();
                row.Add((i + 1).ToString());
                row.Add(lessons[i].course.name.ToString());
                row.Add(lessons[i].grade.ToString());
                row.Add(lessons[i].course.master.firstName+" "+ lessons[i].course.master.lastName);
                dataGridView2.Rows.Add(row.ToArray());
                sum += lessons[i].grade* lessons[i].course.val;
                unitscount += lessons[i].course.val;
            }
            label2.Text = "معدل: "+(sum/unitscount);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            StudentPanel studentPanelPanel = new StudentPanel(id);
            studentPanelPanel.Show();
            this.Hide();

        }
    }
}
