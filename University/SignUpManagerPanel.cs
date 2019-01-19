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
    public partial class SignUpManagerPanel : Form
    {
        string id;
        Manager mng;
        public SignUpManagerPanel(String id)
        {
            this.id = id;
            mng = Manager.SearchManager(id).info;
            InitializeComponent();
        }

        private void btn_back34_Click(object sender, EventArgs e)
        {
            ManagerPanel managerpanel = new ManagerPanel(id);
            managerpanel.Show();
            this.Hide();
        }

        private void btn_std_signup_Click(object sender, EventArgs e)
        {
            mng.SignUpManager(mng_first_name.Text,mng_last_name.Text,password.Text);
            FileStream file = File.Create("Uni");
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(file, Universal.instance);
            file.Close();
            ManagerPanel managerpanel = new ManagerPanel(id);
            managerpanel.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
