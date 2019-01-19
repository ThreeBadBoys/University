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
    public partial class ChangePassword : Form
    {
        string id;
        Manager mng;
        public ChangePassword(String id)
        {
            this.id = id;
            mng = Manager.SearchManager(id).info;
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            ManagerPanel managerPanel = new ManagerPanel(id);
            managerPanel.Show();
            this.Hide();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if(mng.EditPassword(currentpassword.Text, newpassword.Text, confirmpassword.Text)==2)
            {
                FileStream file = File.Create("Uni");
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, Universal.instance);
                file.Close();
                ManagerPanel managerpanel = new ManagerPanel(id);
                managerpanel.Show();
                this.Hide();
            }
            else if(mng.EditPassword(currentpassword.Text, newpassword.Text, confirmpassword.Text) == 1)
            {
                errorProvider2.SetError(confirmpassword, "تکرار رمز عبور صحیح نیست");
            }
            else
            {
                errorProvider1.SetError(currentpassword, "رمز عبور اشتباه است");
            }
            
        }
    }
}
