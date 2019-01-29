using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityClasses;
namespace University
{
    public partial class MasterPanel : Form
    {
        int id;
        public MasterPanel(int id)
        {
            this.id = id;
            InitializeComponent();
            Master mst = Manager.SearchMaster(id);
            if(mst != null)
            {
                teachername.Text = mst.firstName + " " + mst.lastName;
                labelTeacherId.Text = mst.id.ToString();
            }
        }

        private void btn_back2_Click(object sender, EventArgs e)
        {
            EnterPage enterPagePanel = new EnterPage();
            enterPagePanel.Show();
            this.Hide();
        }

        private void btn_change_password_Click(object sender, EventArgs e)
        {
            ChangePasswordMaster changePasswordPanel = new ChangePasswordMaster(id);
            changePasswordPanel.Show();
        }

        private void btn_get_classes_list_Click(object sender, EventArgs e)
        {
            MasterClasses masterclasses = new MasterClasses(id);
            masterclasses.Show();
        }
    }
}
