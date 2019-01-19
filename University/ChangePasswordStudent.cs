using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using UniversityClasses;
using System.Windows.Forms;

namespace University
{
    public partial class ChangePasswordStudent : Form
    {
        string id;
        Student std;
        public ChangePasswordStudent(string id)
        {
            this.id = id;
            InitializeComponent();
            std = Manager.SearchStudent(id).info;
          
        }
    

        private void btn_Back1_Click(object sender, EventArgs e)
        {

            StudentPanel studentpanel = new StudentPanel(id);
            studentpanel.Show();
            this.Hide();
        }

        private void confirm1_Click(object sender, EventArgs e)
        {
            if (std.EditPassword(currentpassword1.Text, newpassword1.Text, confirmpassword1.Text) == 2)
            {
                FileStream file = File.Create("Uni");
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, Universal.instance);
                file.Close();
                StudentPanel studentPanel = new StudentPanel(id);
                studentPanel.Show();
                this.Hide();
            }
            else if (std.EditPassword(currentpassword1.Text, newpassword1.Text, confirmpassword1.Text) == 1)
            {
                errorProvider2.SetError(confirmpassword1, "تکرار رمز عبور صحیح نیست");
            }
            else
            {
                errorProvider1.SetError(currentpassword1, "رمز عبور اشتباه است");
            }

        }
    }
}
