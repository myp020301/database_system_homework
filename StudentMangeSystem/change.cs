using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMangeSystem
{
    public partial class change : Form
    {
        string snum;
        Form_Main fm;
        public change(Form_Main f)
        {
            fm = f;
            fm.Hide();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            snum = textBox3.Text;
            MySqlDataReader reader = fm.u.SelectStu(snum);
            while(reader.Read())
            {
                label1.Text = "学号："+reader.GetInt32("snum")+Environment.NewLine + "姓名："+reader.GetString("sname") + Environment.NewLine+"系别"+ reader.GetString("sdept");
            }
            reader.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean b;
            if(textBox2.Text=="")
            {
                b=fm.u.changestusdept(snum, textBox1.Text);
            }
            else if(textBox1.Text == "")
            {
                b=fm.u.changestuname(snum, textBox2.Text);
            }
            else
            {
                b = fm.u.changestuall(snum, textBox2.Text,textBox1.Text);
            }
            if (b)
            {
                MessageBox.Show("更改成功");
            }
            else
            {
                MessageBox.Show("更改失败");
            }
        }

        private void change_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出更新", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                fm.Show();
            }
        }
    }
}
