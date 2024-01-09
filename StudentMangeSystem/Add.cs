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
    public partial class Add : Form
    {
        Form_Main fm;
        public Add(Form_Main f)
        {
            fm = f;
            fm.Hide();
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result= MessageBox.Show("是否退出添加", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result==DialogResult.OK)
            {
                fm.Show();
            }
            
        }

        private void cla_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void add_stu_Click(object sender, EventArgs e)
        {
            Boolean b= fm.u.addstu(textBox_name.Text, textBox_Snum.Text, textBox_sex.Text, textBox_age.Text, textBox_grade.Text, comboBox_Sdept.Text, textBox_dom.Text, textBox_class.Text);
            if (b)
            {
                status.Text = $"添加{textBox_name.Text}成功";
                foreach (Control Ctrol in this.Controls)
                {
                    if (Ctrol is TextBox)
                    {
                        Ctrol.Text = "";
                    }
                }
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void class_add_Click(object sender, EventArgs e)
        {
            Boolean b= fm.u.addclass(class_name.Text, class_snum.Text, class_sdept.Text, class_tea.Text);
            if (b)
            {
                status.Text = $"添加{class_name.Text}成功";
                foreach (Control Ctrol in this.Controls)
                {
                    if (Ctrol is TextBox)
                    {
                        Ctrol.Text = "";
                    }
                }
            }
        }

        private void course_add_Click(object sender, EventArgs e)
        {
            Boolean b = fm.u.addcourse(textBox1_cno.Text, textBox_cname.Text, textBox3_cpno.Text, textBox_crad.Text, textBox5_cteacher.Text);
            if (b)
            {
                status.Text = $"添加{class_name.Text}成功";
                foreach (Control Ctrol in this.Controls)
                {
                    if (Ctrol is TextBox)
                    {
                        Ctrol.Text = "";
                    }
                }
            }
        }

        private void score_add_Click(object sender, EventArgs e)
        {
            Boolean b = fm.u.addgrade(textBox_sum.Text, textBox_cno.Text, textBox_gro.Text);
            if (b)
            {
                status.Text = $"添加{textBox_sum.Text}成功";
                foreach (Control Ctrol in this.Controls)
                {
                    if (Ctrol is TextBox)
                    {
                        Ctrol.Text = "";
                    }
                }
            }
        }
        
        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm.Login = false;
            fm.panel_Mian.Visible = false;
            fm.Login_panel.Visible = true;
            fm.Login_state.Text = "未登录";
            fm.conn.Close();
            this.Close();
            fm.Show();
        }
    }
}
