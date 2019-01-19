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
    public partial class SignUpStudentPanel : Form
    {
        String id;
        Manager mng;
        public SignUpStudentPanel(String id)
        {
            this.id = id;
            mng = Manager.SearchManager(id).info;
            InitializeComponent();
        }

        private void btn_back35_Click(object sender, EventArgs e)
        {
            ManagerPanel managerpanel = new ManagerPanel(id);
            managerpanel.Show();
            this.Hide();
        }

        private void btn_std_signup_Click(object sender, EventArgs e)
        {
            mng.SignUpStudent(std_first_name.Text, std_last_name.Text, std_major.Text);
            FileStream file = File.Create("Uni");
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(file, Universal.instance);
            file.Close();
            ManagerPanel managerpanel = new ManagerPanel(id);
            managerpanel.Show();
            this.Hide();
        }
    }
}
