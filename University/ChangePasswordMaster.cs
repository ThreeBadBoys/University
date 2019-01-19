using System;
using UniversityClasses;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace University
{
    public partial class ChangePasswordMaster : Form
    {
        string id;
        Master master;
        public ChangePasswordMaster(string id)
        {
            this.id = id;
            InitializeComponent();
            master = Manager.SearchMaster(id).info;
        }

        private void btn_Back2_Click(object sender, EventArgs e)
        {
            MasterPanel teacherPanel = new MasterPanel(id);
            teacherPanel.Show();
            this.Hide();
        }

        private void confirm2_Click(object sender, EventArgs e)
        {
            if (master.EditPassword(currentpassword2.Text, newpassword2.Text, confirmpassword2.Text) == 2)
            {
                FileStream file = File.Create("Uni");
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, Universal.instance);
                file.Close();
                MasterPanel teacherPanel = new MasterPanel(id);
                teacherPanel.Show();
                this.Hide();
            }
            else if (master.EditPassword(currentpassword2.Text, newpassword2.Text, confirmpassword2.Text) == 1)
            {
                errorProvider2.SetError(confirmpassword2, "تکرار رمز عبور صحیح نیست");
            }
            else
            {
                errorProvider1.SetError(currentpassword2, "رمز عبور اشتباه است");
            }

        }
    }
}
