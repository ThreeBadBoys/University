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
    public partial class RemoveStudentSemesterPanel : Form
    {
        int id;
        Manager mng;
        public RemoveStudentSemesterPanel(int id)
        {
            this.id = id;
            mng = Manager.SearchManager(id);
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ManagerPanel managerpanel = new ManagerPanel(id);
            managerpanel.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mng.RemoveStudentsSemester(Int32.Parse(id_input.Text)))
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
