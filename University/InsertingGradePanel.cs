using System;
using System.Collections;
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
    public partial class InsertingGradePanel : Form
    {
        int id;
        int code;
        Master master;
        List<Student> students;
        public InsertingGradePanel(int id, int code)
        {
            InitializeComponent();
            this.id = id;
            this.code = code;
            master = Manager.SearchMaster(id);
            if (master != null)
            {
                for (int i = 0; i < master.lessons.Count; i++)
                {
                    if (master.lessons[i].code == code)
                    {
                        course_title.Text = master.lessons[i].name;
                        students = master.lessons[i].students;
                        break;
                    }
                }
            }
        }

        private void InsertingGradePanel_Load(object sender, EventArgs e)
        {
            update();
        }
        public void update()
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ردیف";
            dataGridView1.Columns[1].Name = "نام و نام خانوادگی دانشجو";
            dataGridView1.Columns[2].Name = "شماره دانشجویی دانشجو";
            dataGridView1.Columns[3].Name = "نمره";
            dataGridView1.Columns[4].Name = "وضعیت";
           
            if (students == null)
            {
                students = new List<Student>();
            }
            for (int i = 0; i < students.Count; i++)
            {
                ArrayList row = new ArrayList();
                double grade = -1;
                for(int j = 0; j < students[i].choosenLessons.Count; j++)
                {
                    if (students[i].choosenLessons[j].course.code == code)
                    {
                        grade = students[i].choosenLessons[j].grade;
                    }
                }
                row.Add((i+1).ToString());
                row.Add(students[i].firstName +" "+ students[i].lastName);
                row.Add(students[i].id+"");
                row.Add(grade.ToString());
                row.Add(grade==-1?"نمره ثبت نشده":grade<10?"مردود":"گذرانده");
                dataGridView1.Rows.Add(row.ToArray());
            }
        }
        private void btn_insert_stds_Click(object sender, EventArgs e)
        {
            if(stdid.Text.Length!=0 && grade.Text.Length != 0 && master.insertingGrade(Int32.Parse(stdid.Text),Double.Parse(grade.Text),code))
            {
                //FileStream file = File.Create("Uni");
                //BinaryFormatter bf = new BinaryFormatter();
                //bf.Serialize(file, Universal.instance);
                //file.Close();
            }
        }
    }
}
