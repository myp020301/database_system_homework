using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace StudentMangeSystem
{
    public partial class Form_Main : Form
    {
        internal Boolean Login = false; //登陆标记
        internal MySqlConnection conn = null;
        internal util u = null;

        public Form_Main()
        {
            InitializeComponent();
            panel_Mian.Visible = false;
            Login_panel.Visible = true;
        }


        private void Form_Main_Load(object sender, EventArgs e)
        {
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            conn = mysqlconn.getConn(textBox_id.Text, textBox_pw.Text);
            try
            {
                conn.Open();
                Login = true;
                Login_panel.Visible = false;
                panel_Mian.Visible = true;
                u = new util(conn);
                MySqlDataReader reader = u.selectLevel(textBox_id.Text);
                int level = 0;
                if (reader.Read())
                {
                    level = reader.GetInt32("user_level");
                }

                reader.Close();
                Login_state.Text = $"已登录，欢迎您，{level}";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            Reg reg = new Reg(this);
            reg.Show();
        }


        private void panel_Mian_Paint(object sender, PaintEventArgs e)
        {
        }


        private void Add_Click(object sender, EventArgs e)
        {
            Add add = new Add(this);
            add.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Delete del = new Delete(this);
            del.Show();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            change ch = new change(this);
            ch.ShowDialog();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            Select sel = new Select(this);
            sel.Show();
        }
        
        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login = false;
            panel_Mian.Visible = false;
            Login_panel.Visible = true;
            Login_state.Text = "未登录";
            conn.Close();
        }

        private void 退出本系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}