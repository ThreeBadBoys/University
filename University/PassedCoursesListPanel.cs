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
        List<Node<Course>> lessons;
        string id;
        public PassedCoursesListPanel(string id)
        {
            InitializeComponent();
            this.id = id;
            if (Manager.SearchStudent(id) != null)
            {
                Student std = Manager.SearchStudent(id).info;
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
                lessons = new List<Node<Course>>();
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
                row.Add(lessons[i].info.name.ToString());
                row.Add(lessons[i].info.grade.ToString());
                row.Add(lessons[i].info.master.firstName+" "+ lessons[i].info.master.lastName);
                dataGridView2.Rows.Add(row.ToArray());
                sum += lessons[i].info.grade* lessons[i].info.val;
                unitscount += lessons[i].info.val;
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
