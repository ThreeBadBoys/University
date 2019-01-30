using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using UniversityClasses;

namespace University
{
    public partial class ChooseCourse : Form
    {
        int id;
        Student std;
 
        public ChooseCourse(int id)
        {
            this.id = id;
            std = Manager.SearchStudent(id);
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (std.addLesson(Convert.ToInt32(textBox1.Text)))
            {
                //FileStream file = File.Create("Uni");
                //BinaryFormatter bf = new BinaryFormatter();
                //bf.Serialize(file, Universal.instance);
                //file.Close();
                this.Hide();
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
