using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UniversityClasses;
namespace University
{
    public partial class MasterClasses : Form
    {
        int id;
        Master master;
        List<Course> lessons;
        public MasterClasses(int id)
        {
            InitializeComponent();
            this.id = id;
            master = Manager.SearchMaster(id);
            if (master != null)
            {
                lessons = master.lessons;
                master_name.Text = master.firstName + " " + master.lastName;
            }
        }

        private void MasterClasses_Load(object sender, EventArgs e)
        {
            update();
        }
        public void update()
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ردیف";
            dataGridView1.Columns[1].Name = "کد درس";
            dataGridView1.Columns[2].Name = "اسم درس";
            dataGridView1.Columns[3].Name = "تاریخ امتحان";
            dataGridView1.Columns[4].Name = "تعداد دانشجو";

            if (lessons == null)
            {
                lessons = new List<Course>();
            }
            for (int i = 0; i < lessons.Count; i++)
            {
                ArrayList row = new ArrayList();
                row.Add((i+1).ToString());
                row.Add(lessons[i].code.ToString());
                row.Add(lessons[i].name.ToString());
                row.Add(lessons[i].examTime.ToString());
                row.Add(lessons[i].students.Count.ToString());
                dataGridView1.Rows.Add(row.ToArray());
            }
        }
        private void btn_search_stds_Click(object sender, EventArgs e)
        {
            int code=0;
            bool found=false;
            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessons[i].code == Convert.ToInt32(textBox1.Text))
                {
                    found = true;
                    code = lessons[i].code;
                    break;
                }
            }
            if (found)
            {
                InsertingGradePanel insertingGradePanel = new InsertingGradePanel(id,code);
                insertingGradePanel.Show();
            }
            else
            {
                errorProvider1.SetError(textBox1, "چنین درسی موجود نیست");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
