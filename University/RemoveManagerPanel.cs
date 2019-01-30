using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using UniversityClasses;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace University
{
    public partial class RemoveManagerPanel : Form
    {
        int id;
        Manager mng;
        public RemoveManagerPanel(int id)
        {
            this.id = id;
            InitializeComponent();
            Manager mng = Manager.SearchManager(id);
         
        }

        private void btn_back33_Click(object sender, EventArgs e)
        {
            ManagerPanel managerpanel = new ManagerPanel(id);
            managerpanel.Show();
            this.Hide();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (id != Int32.Parse(textBox1.Text))
            {
                if (mng.RemoveManagerFully(Int32.Parse(textBox1.Text)))
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
}
