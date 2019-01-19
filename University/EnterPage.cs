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
//In this Class Be careful !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
namespace University
{
    public partial class EnterPage : Form
    {

        public EnterPage()
        {
            Universal u;
            InitializeComponent();
            LogInType.SelectedItem = "دانشجو";
            Node<Master> mst = Universal.instance.firstMst;
            //Console.WriteLine(mst.info.lessons[0].info.students.Count);
        }
        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (this.LogInType.GetItemText(this.LogInType.SelectedItem) == "دانشجو")
            {
                if (authentication(0, username_id.Text, password1.Text))
                {
                    StudentPanel studentPanel = new StudentPanel(username_id.Text);
                    studentPanel.Show();
                    this.Hide();
                }
         
            }
            else if (this.LogInType.GetItemText(this.LogInType.SelectedItem) == "استاد")
            {
                if (authentication(1, username_id.Text, password1.Text))
                {
                    MasterPanel teacherPanel = new MasterPanel(username_id.Text);
                    teacherPanel.Show();
                    this.Hide();
                }
              
            }
            else if (this.LogInType.GetItemText(LogInType.SelectedItem) == "آموزش")
            {
                if (authentication(2, username_id.Text, password1.Text))
                {
                    ManagerPanel amoozesh = new ManagerPanel(username_id.Text);
                    amoozesh.Show();
                    this.Hide();
                }
              
            }
        }
        public bool authentication(int type, string id, string password)
        {
            if (password != "")
            {
                if (type == 0)//"دانشجو"
                {
                    Node<Student> std = new Node<Student>();
                    std = Manager.SearchStudent(id);
                    if (std != null)
                    {
                        if (std.info.password.Equals(password))
                        {
                            return true;
                        }
                        else
                        {
                            errorProvider2.SetError(password1, "رمز عبور اشتباه است");
                            return false;
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(username_id, " دانشجو بااین مشخصات موجود نمی باشد");
                    }
                }
                else if (type == 1)//"استاد"
                {
                    Node<Master> master = new Node<Master>();
                    if (master != null)
                    {
                        master = Manager.SearchMaster(id);
                        if (master.info.password.Equals(password))
                        {
                            return true;
                        }
                        else
                        {
                            errorProvider2.SetError(password1, "رمز عبور اشتباه است");
                            return false;
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(username_id, " استاد بااین مشخصات موجود نمی باشد");
                        return false;
                    }
                }
                else//"آموزش"
                {
                    Node<Manager> mng = Manager.SearchManager(id);
                    if (mng != null)
                    {
                        if (mng.info.password.Equals(password))
                        {
                            return true;
                        }
                        else
                        {
                            errorProvider2.SetError(password1, "رمز عبور اشتباه است");
                            return false;
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(username_id, " آموزش بااین مشخصات موجود نمی باشد");
                        return false;
                    }
                }
            }
            errorProvider1.SetError(username_id, "شناسه کاربری معتبر نیست");
            return false;
        }
    }
}
