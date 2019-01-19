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
    public partial class AddCoursePanel : Form
    {
        String id;
        Manager mng;
        public AddCoursePanel(String id)
        {
            this.id = id;
            mng = Manager.SearchManager(id).info;
            InitializeComponent();
        }

        private void btn_add_course_Click(object sender, EventArgs e)
        {
            if(mng.AddCourse(code.Text, name.Text, masterCode.Text, time.Text, examTime.Text, Convert.ToInt32(val.Text)))
            {
                FileStream file = File.Create("Uni");
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, Universal.instance);
                file.Close();
                this.Hide();
            }
        }

        private void btn_back9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
