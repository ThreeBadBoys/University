using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using UniversityClasses;
namespace University
{
    public partial class Add_Remove_Course : Form
    {
        string id;
        Node<Student> node;
        Student std;
        public Add_Remove_Course(string id)
        {
            this.id = id;
            node = Manager.SearchStudent(id);
            if (node != null)
            {
                std = node.info;
            }
            InitializeComponent();
        }

        private void btn_back38_Click(object sender, EventArgs e)
        {
            StudentPanel studentPanel = new StudentPanel(id);
            studentPanel.Show();
            this.Hide();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "کد درسی وارد نشده است");
            }
            else
            {
                if (std.removeLesson(Convert.ToInt32(textBox1.Text)))
                {
                    FileStream file = File.Create("Uni");
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(file, Universal.instance);
                    file.Close();
                    this.Hide();
                }
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "کد درسی وارد نشده است");
            }
            else
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
        }
    }
}
