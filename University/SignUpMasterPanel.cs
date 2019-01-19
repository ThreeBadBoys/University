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
    public partial class SignUpMasterPanel : Form
    {
        String id;
        Manager mng;
        public SignUpMasterPanel(String id)
        {
            this.id = id;
            mng = Manager.SearchManager(id).info;
            InitializeComponent();
        }

        private void btn_back36_Click(object sender, EventArgs e)
        {
            ManagerPanel amoozesh = new ManagerPanel(id);
            amoozesh.Show();
            this.Hide();
        }

        private void btn_signup_master_Click(object sender, EventArgs e)
        {
            mng.SignUpMaster(firstname_input.Text, lastname_input.Text, new List<Node<Course>>());
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
