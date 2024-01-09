
namespace StudentMangeSystem
{
    partial class Select
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.stu = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sel_stu = new System.Windows.Forms.Button();
            this.textBox_Snum = new System.Windows.Forms.TextBox();
            this.Snum = new System.Windows.Forms.Label();
            this.cla = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_add = new System.Windows.Forms.Button();
            this.class_name = new System.Windows.Forms.TextBox();
            this.label_cname = new System.Windows.Forms.Label();
            this.cou = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_add = new System.Windows.Forms.Button();
            this.textBox1_cno = new System.Windows.Forms.TextBox();
            this.Cno = new System.Windows.Forms.Label();
            this.gra = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score_add = new System.Windows.Forms.Button();
            this.textBox_sum = new System.Windows.Forms.TextBox();
            this.g_sno = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.stu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.cou.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.gra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.stu);
            this.tabControl1.Controls.Add(this.cla);
            this.tabControl1.Controls.Add(this.cou);
            this.tabControl1.Controls.Add(this.gra);
            this.tabControl1.Location = new System.Drawing.Point(12, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 398);
            this.tabControl1.TabIndex = 3;
            // 
            // stu
            // 
            this.stu.Controls.Add(this.dataGridView1);
            this.stu.Controls.Add(this.sel_stu);
            this.stu.Controls.Add(this.textBox_Snum);
            this.stu.Controls.Add(this.Snum);
            this.stu.Location = new System.Drawing.Point(4, 25);
            this.stu.Name = "stu";
            this.stu.Padding = new System.Windows.Forms.Padding(3);
            this.stu.Size = new System.Drawing.Size(788, 369);
            this.stu.TabIndex = 0;
            this.stu.Text = "学生信息";
            this.stu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(9, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(951, 225);
            this.dataGridView1.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "姓名";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "学号";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "年龄";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "年级";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "系别";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "宿舍";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "班级";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // sel_stu
            // 
            this.sel_stu.Location = new System.Drawing.Point(379, 28);
            this.sel_stu.Name = "sel_stu";
            this.sel_stu.Size = new System.Drawing.Size(151, 52);
            this.sel_stu.TabIndex = 19;
            this.sel_stu.Text = "提交";
            this.sel_stu.UseVisualStyleBackColor = true;
            this.sel_stu.Click += new System.EventHandler(this.sel_stu_Click);
            // 
            // textBox_Snum
            // 
            this.textBox_Snum.Location = new System.Drawing.Point(124, 38);
            this.textBox_Snum.Name = "textBox_Snum";
            this.textBox_Snum.Size = new System.Drawing.Size(195, 25);
            this.textBox_Snum.TabIndex = 15;
            // 
            // Snum
            // 
            this.Snum.AutoSize = true;
            this.Snum.Font = new System.Drawing.Font("宋体", 12F);
            this.Snum.Location = new System.Drawing.Point(60, 43);
            this.Snum.Name = "Snum";
            this.Snum.Size = new System.Drawing.Size(49, 20);
            this.Snum.TabIndex = 6;
            this.Snum.Text = "学号";
            // 
            // cla
            // 
            this.cla.Controls.Add(this.dataGridView2);
            this.cla.Controls.Add(this.class_add);
            this.cla.Controls.Add(this.class_name);
            this.cla.Controls.Add(this.label_cname);
            this.cla.Location = new System.Drawing.Point(4, 25);
            this.cla.Name = "cla";
            this.cla.Padding = new System.Windows.Forms.Padding(3);
            this.cla.Size = new System.Drawing.Size(788, 369);
            this.cla.TabIndex = 1;
            this.cla.Text = "班级信息";
            this.cla.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView2.Location = new System.Drawing.Point(3, 138);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(726, 225);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "学号";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "年龄";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "年级";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "系别";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "宿舍";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "班级";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // class_add
            // 
            this.class_add.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_add.Location = new System.Drawing.Point(454, 36);
            this.class_add.Name = "class_add";
            this.class_add.Size = new System.Drawing.Size(207, 54);
            this.class_add.TabIndex = 11;
            this.class_add.Text = "提交";
            this.class_add.UseVisualStyleBackColor = true;
            this.class_add.Click += new System.EventHandler(this.class_add_Click);
            // 
            // class_name
            // 
            this.class_name.Location = new System.Drawing.Point(129, 36);
            this.class_name.Name = "class_name";
            this.class_name.Size = new System.Drawing.Size(142, 25);
            this.class_name.TabIndex = 4;
            // 
            // label_cname
            // 
            this.label_cname.AutoSize = true;
            this.label_cname.Font = new System.Drawing.Font("宋体", 12F);
            this.label_cname.Location = new System.Drawing.Point(34, 36);
            this.label_cname.Name = "label_cname";
            this.label_cname.Size = new System.Drawing.Size(89, 20);
            this.label_cname.TabIndex = 0;
            this.label_cname.Text = "班级名称";
            // 
            // cou
            // 
            this.cou.Controls.Add(this.dataGridView4);
            this.cou.Controls.Add(this.course_add);
            this.cou.Controls.Add(this.textBox1_cno);
            this.cou.Controls.Add(this.Cno);
            this.cou.Location = new System.Drawing.Point(4, 25);
            this.cou.Name = "cou";
            this.cou.Size = new System.Drawing.Size(788, 369);
            this.cou.TabIndex = 2;
            this.cou.Text = "课程信息";
            this.cou.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dataGridView4.Location = new System.Drawing.Point(11, 107);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 27;
            this.dataGridView4.Size = new System.Drawing.Size(774, 250);
            this.dataGridView4.TabIndex = 4;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // Column10
            // 
            this.Column10.HeaderText = "课程号";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "课程名";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "开课时间";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "学分";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 125;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "先修课";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.Width = 125;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "授课教师";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.Width = 125;
            // 
            // course_add
            // 
            this.course_add.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_add.Location = new System.Drawing.Point(479, 24);
            this.course_add.Name = "course_add";
            this.course_add.Size = new System.Drawing.Size(207, 54);
            this.course_add.TabIndex = 10;
            this.course_add.Text = "提交";
            this.course_add.UseVisualStyleBackColor = true;
            this.course_add.Click += new System.EventHandler(this.course_add_Click);
            // 
            // textBox1_cno
            // 
            this.textBox1_cno.Location = new System.Drawing.Point(153, 38);
            this.textBox1_cno.Name = "textBox1_cno";
            this.textBox1_cno.Size = new System.Drawing.Size(143, 25);
            this.textBox1_cno.TabIndex = 5;
            // 
            // Cno
            // 
            this.Cno.AutoSize = true;
            this.Cno.Font = new System.Drawing.Font("宋体", 13F);
            this.Cno.Location = new System.Drawing.Point(71, 41);
            this.Cno.Name = "Cno";
            this.Cno.Size = new System.Drawing.Size(76, 22);
            this.Cno.TabIndex = 0;
            this.Cno.Text = "课序号";
            // 
            // gra
            // 
            this.gra.Controls.Add(this.button2);
            this.gra.Controls.Add(this.dataGridView3);
            this.gra.Controls.Add(this.score_add);
            this.gra.Controls.Add(this.textBox_sum);
            this.gra.Controls.Add(this.g_sno);
            this.gra.Location = new System.Drawing.Point(4, 25);
            this.gra.Name = "gra";
            this.gra.Size = new System.Drawing.Size(788, 369);
            this.gra.TabIndex = 3;
            this.gra.Text = "成绩查询";
            this.gra.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9});
            this.dataGridView3.Location = new System.Drawing.Point(3, 192);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(774, 161);
            this.dataGridView3.TabIndex = 14;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "课程名";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "成绩";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // score_add
            // 
            this.score_add.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_add.Location = new System.Drawing.Point(519, 25);
            this.score_add.Name = "score_add";
            this.score_add.Size = new System.Drawing.Size(207, 54);
            this.score_add.TabIndex = 11;
            this.score_add.Text = "提交";
            this.score_add.UseVisualStyleBackColor = true;
            this.score_add.Click += new System.EventHandler(this.score_add_Click);
            // 
            // textBox_sum
            // 
            this.textBox_sum.Location = new System.Drawing.Point(101, 25);
            this.textBox_sum.Name = "textBox_sum";
            this.textBox_sum.Size = new System.Drawing.Size(140, 25);
            this.textBox_sum.TabIndex = 3;
            // 
            // g_sno
            // 
            this.g_sno.AutoSize = true;
            this.g_sno.Font = new System.Drawing.Font("宋体", 12F);
            this.g_sno.Location = new System.Drawing.Point(46, 30);
            this.g_sno.Name = "g_sno";
            this.g_sno.Size = new System.Drawing.Size(49, 20);
            this.g_sno.TabIndex = 1;
            this.g_sno.Text = "学号";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(519, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 52);
            this.button2.TabIndex = 22;
            this.button2.Text = "清空";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Select";
            this.Text = "Select";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Select_FormClosing);
            this.Load += new System.EventHandler(this.Select_Load);
            this.tabControl1.ResumeLayout(false);
            this.stu.ResumeLayout(false);
            this.stu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cla.ResumeLayout(false);
            this.cla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.cou.ResumeLayout(false);
            this.cou.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.gra.ResumeLayout(false);
            this.gra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage stu;
        private System.Windows.Forms.Button sel_stu;
        private System.Windows.Forms.TextBox textBox_Snum;
        private System.Windows.Forms.Label Snum;
        private System.Windows.Forms.TabPage cla;
        private System.Windows.Forms.Button class_add;
        private System.Windows.Forms.TextBox class_name;
        private System.Windows.Forms.Label label_cname;
        private System.Windows.Forms.TabPage gra;
        private System.Windows.Forms.Button score_add;
        private System.Windows.Forms.TextBox textBox_sum;
        private System.Windows.Forms.Label g_sno;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TabPage cou;
        private System.Windows.Forms.Button course_add;
        private System.Windows.Forms.TextBox textBox1_cno;
        private System.Windows.Forms.Label Cno;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.Button button2;
    }
}