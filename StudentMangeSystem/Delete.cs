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
    public partial class Delete : Form
    {
        Form_Main fm;

        public Delete(Form_Main f)
        {
            fm = f;
            InitializeComponent();
            fm.Hide();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
        }

        private void Delete_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出删除", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                fm.Show();
            }
        }

        private void 选项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void DEL_Click(object sender, EventArgs e)
        {
            Boolean b = fm.u.deletestu(textBox1_sno.Text);
            if (b)
            {
                status.Text = $"删除{textBox1_sno.Text}成功";
                foreach (Control Ctrol in this.Controls)
                {
                    if (Ctrol is TextBox)
                    {
                        Ctrol.Text = "";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean b = fm.u.deletecourse(textBox1.Text);
            if (b)
            {
                status.Text = $"删除{textBox1.Text}成功";
                foreach (Control Ctrol in this.Controls)
                {
                    if (Ctrol is TextBox)
                    {
                        Ctrol.Text = "";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean b = fm.u.deleteclass(textBox2.Text);
            if (b)
            {
                status.Text = $"删除{textBox2.Text}成功";
                foreach (Control Ctrol in this.Controls)
                {
                    if (Ctrol is TextBox)
                    {
                        Ctrol.Text = "";
                    }
                }
            }
        }
    }
}