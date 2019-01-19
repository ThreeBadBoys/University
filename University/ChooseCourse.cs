using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using UniversityClasses;

namespace University
{
    public partial class ChooseCourse : Form
    {
        string id;
        Node<Student> node;
        Student std;
        public ChooseCourse(string id)
        {
            this.id = id;
            node = Manager.SearchStudent(id);
            if(node != null)
            {
                std = node.info;
            }
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (std.addLesson(Convert.ToInt32(textBox1.Text)))
            {
                FileStream file = File.Create("Uni");
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, Universal.instance);
                file.Close();
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
