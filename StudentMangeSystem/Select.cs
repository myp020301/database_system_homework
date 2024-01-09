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
    public partial class Select : Form
    {
        Form_Main fm;
        public Select(Form_Main f)
        {
            InitializeComponent();
            fm = f;
            fm.Hide();
        }

        private void Select_Load(object sender, EventArgs e)
        {

        }

        private void sel_stu_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader=fm.u.SelectStu(textBox_Snum.Text);
            while (reader.Read())
            {
                int index = this.dataGridView1.Rows.Add();
                int tem = 0;
                this.dataGridView1.Rows[index].Cells[tem++].Value = reader.GetString("sname");
                this.dataGridView1.Rows[index].Cells[tem++].Value = reader.GetString("snum");
                this.dataGridView1.Rows[index].Cells[tem++].Value = reader.GetString("Sage");
                this.dataGridView1.Rows[index].Cells[tem++].Value = reader.GetString("sgarde");
                this.dataGridView1.Rows[index].Cells[tem++].Value = reader.GetString("sdept");
                this.dataGridView1.Rows[index].Cells[tem++].Value = reader.GetString("Dormitory");
                this.dataGridView1.Rows[index].Cells[tem++].Value = reader.GetString("class");
            }
            reader.Close();
        }

        private void Select_FormClosing(object sender, FormClosingEventArgs e)
        {
            fm.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void class_add_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader = fm.u.Selectcla(class_name.Text);
            while (reader.Read())
            {
                int index = this.dataGridView2.Rows.Add();
                int tem = 0;
                this.dataGridView2.Rows[index].Cells[tem++].Value = reader.GetString("sname");
                this.dataGridView2.Rows[index].Cells[tem++].Value = reader.GetString("snum");
                this.dataGridView2.Rows[index].Cells[tem++].Value = reader.GetString("Sage");
                this.dataGridView2.Rows[index].Cells[tem++].Value = reader.GetString("sgarde");
                this.dataGridView2.Rows[index].Cells[tem++].Value = reader.GetString("sdept");
                this.dataGridView2.Rows[index].Cells[tem++].Value = reader.GetString("Dormitory");
                this.dataGridView2.Rows[index].Cells[tem++].Value = reader.GetString("class");
            }
            reader.Close();
        }

        private void score_add_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader = fm.u.SelectGra(textBox_sum.Text);
            while (reader.Read())
            {
                int index = this.dataGridView3.Rows.Add();
                int tem = 0;
                this.dataGridView3.Rows[index].Cells[tem++].Value = reader.GetString("cname");
                this.dataGridView3.Rows[index].Cells[tem++].Value = reader.GetString("grade");
                

            }
            reader.Close();
        }

        private void course_add_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader= fm.u.SelectCou(textBox1_cno.Text);
            while (reader.Read())
            {
                int index = this.dataGridView4.Rows.Add();
                int tem = 0;
                this.dataGridView4.Rows[index].Cells[tem++].Value = reader.GetString("cno");
                this.dataGridView4.Rows[index].Cells[tem++].Value = reader.GetString("cname");
                this.dataGridView4.Rows[index].Cells[tem++].Value = reader.GetString("ccredit");
                this.dataGridView4.Rows[index].Cells[tem++].Value = reader.GetString("cpno");
                this.dataGridView4.Rows[index].Cells[tem++].Value = reader.GetString("cteacher");

            }
            reader.Close();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {

            dataGridView3.Rows.Clear();
        }
    }
}
