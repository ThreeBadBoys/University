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
    public partial class RemoveMasterPanel : Form
    {
        Manager mng;
        int id;
        public RemoveMasterPanel(int id)
        {
            this.id = id;
            InitializeComponent();
            mng = Manager.SearchManager(id);
          
        }

        private void btn_back31_Click(object sender, EventArgs e)
        {
            ManagerPanel managerPanel = new ManagerPanel(id);
            managerPanel.Show();
            this.Close();

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (mng.RemoveMasterFully(Int32.Parse(textBox1.Text))){
                FileStream file = File.Create("Uni");
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, Universal.instance);
                file.Close();
                ManagerPanel managerpanel = new ManagerPanel(id);
                managerpanel.Show();
                this.Close();
            }
        }
    }
}
