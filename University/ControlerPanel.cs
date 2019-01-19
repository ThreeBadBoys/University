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
    public partial class ControlerPanel : Form
    {
        string id;
        public ControlerPanel(string id)
        {
            InitializeComponent();
            this.id = id;
            chooseUnit.Checked = Universal.instance.isAbleUnitChoice;
            addOrRemove.Checked = Universal.instance.isAbleUnitEdit;
        }

        private void controlerPanel_Closing(object sender, FormClosingEventArgs e)
        {

        }

        private void addOrRemove_CheckedChanged(object sender, EventArgs e)
        {
            Universal.instance.isAbleUnitEdit = addOrRemove.Checked;
        }

        private void chooseUnit_CheckedChanged(object sender, EventArgs e)
        {
            Universal.instance.isAbleUnitChoice = chooseUnit.Checked;
        }

        private void btn_back13_Click(object sender, EventArgs e)
        {

            ManagerPanel managerPanel = new ManagerPanel(id);
            managerPanel.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream file = File.Open("Uni", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(file, Universal.instance);
            file.Close();
            this.Hide();
        }
    }
}
