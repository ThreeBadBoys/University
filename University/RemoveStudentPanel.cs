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
    public partial class RemoveStudentPanel : Form
    {
        int id;
        Manager mng;
        public RemoveStudentPanel(int id)
        {
            this.id = id;
            InitializeComponent();
            Manager mng = Manager.SearchManager(id);
        
        }

        private void btn_back32_Click(object sender, EventArgs e)
        {
            ManagerPanel managerPanel = new ManagerPanel(id);
            managerPanel.Show();
            this.Hide();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (mng.RemoveStudentFully(Int32.Parse(std_id.Text)))
            {
                //FileStream file = File.Create("Uni");
                //BinaryFormatter bf = new BinaryFormatter();
                //bf.Serialize(file, Universal.instance);
                //file.Close();
                ManagerPanel managerpanel = new ManagerPanel(id);
                managerpanel.Show();
                this.Hide();
            }
        }
    }
}
