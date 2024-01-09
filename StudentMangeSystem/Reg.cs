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
    public partial class Reg : Form
    {
        Form_Main fm = null;
        public Reg(Form_Main f)
        {
            fm = f;
            fm.Hide();
            InitializeComponent();
        }

        private void Reg_Load(object sender, EventArgs e)
        {
            
        }

        private void Reg_FormClosing(object sender, FormClosingEventArgs e)
        {
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fm.conn = mysqlconn.getConn("root", "123456");
            fm.conn.Open();
            fm.u = new util(fm.conn);
            Boolean reg = fm.u.register(textBox2.Text, textBox1.Text);
            if (reg)
            {
                MessageBox.Show("注册成功");
            }
            else
            {
                MessageBox.Show("注册失败");
            }
        }
    }
}
