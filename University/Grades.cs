using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using UniversityClasses;
namespace University
{
    public partial class Grades : Form
    {
        List<StudentCourse> lessons;
        string id;
        public Grades(string id)
        {
            this.id = id;
            InitializeComponent();
            if (Manager.SearchStudent(id) != null)
            {
                Student std = Manager.SearchStudent(id).info;
                std_name.Text = std.firstName + " " + std.lastName;
                lessons = std.choosenLessons;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Grades_Load(object sender, EventArgs e)
        {
            update();
        }
        public void update()
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ردیف";
            dataGridView1.Columns[1].Name = "اسم درس";
            dataGridView1.Columns[2].Name = "نام استاد";
            dataGridView1.Columns[3].Name = "نمره";
            dataGridView1.Columns[4].Name = "وضعیت";
            if(lessons == null)
            {
                lessons = new List<StudentCourse>();
            }
            for(int i = 0; i < lessons.Count; i++)
            {
                if(lessons[i].grade > 0)
                {
                    ArrayList row = new ArrayList();
                    row.Add((i + 1).ToString());
                    row.Add(lessons[i].course.name.ToString());
                    row.Add(lessons[i].course.master.firstName.ToString() + " "+ lessons[i].course.master.lastName.ToString()  );
                    row.Add(lessons[i].grade.ToString());
                    row.Add(lessons[i].grade>=10? "قبول" : "مردود");
                    dataGridView1.Rows.Add(row.ToArray());
                }
               
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
