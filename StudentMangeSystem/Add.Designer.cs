
namespace StudentMangeSystem
{
    partial class Add
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.stu = new System.Windows.Forms.TabPage();
            this.add_stu = new System.Windows.Forms.Button();
            this.textBox_class = new System.Windows.Forms.TextBox();
            this.textBox_dom = new System.Windows.Forms.TextBox();
            this.textBox_grade = new System.Windows.Forms.TextBox();
            this.textBox_Snum = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_sex = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.comboBox_Sdept = new System.Windows.Forms.ComboBox();
            this.clas = new System.Windows.Forms.Label();
            this.Sname = new System.Windows.Forms.Label();
            this.Ssex = new System.Windows.Forms.Label();
            this.Sage = new System.Windows.Forms.Label();
            this.Snum = new System.Windows.Forms.Label();
            this.Sgrade = new System.Windows.Forms.Label();
            this.Sdept = new System.Windows.Forms.Label();
            this.Dormitory = new System.Windows.Forms.Label();
            this.cla = new System.Windows.Forms.TabPage();
            this.class_add = new System.Windows.Forms.Button();
            this.class_tea = new System.Windows.Forms.TextBox();
            this.class_sdept = new System.Windows.Forms.TextBox();
            this.class_snum = new System.Windows.Forms.TextBox();
            this.class_name = new System.Windows.Forms.TextBox();
            this.label_cteacher = new System.Windows.Forms.Label();
            this.label_sdept = new System.Windows.Forms.Label();
            this.label_csnum = new System.Windows.Forms.Label();
            this.label_cname = new System.Windows.Forms.Label();
            this.cou = new System.Windows.Forms.TabPage();
            this.course_add = new System.Windows.Forms.Button();
            this.textBox5_cteacher = new System.Windows.Forms.TextBox();
            this.textBox_crad = new System.Windows.Forms.TextBox();
            this.textBox3_cpno = new System.Windows.Forms.TextBox();
            this.textBox_cname = new System.Windows.Forms.TextBox();
            this.textBox1_cno = new System.Windows.Forms.TextBox();
            this.teacher = new System.Windows.Forms.Label();
            this.caredit = new System.Windows.Forms.Label();
            this.cpno = new System.Windows.Forms.Label();
            this.cname = new System.Windows.Forms.Label();
            this.Cno = new System.Windows.Forms.Label();
            this.gra = new System.Windows.Forms.TabPage();
            this.score_add = new System.Windows.Forms.Button();
            this.textBox_gro = new System.Windows.Forms.TextBox();
            this.textBox_cno = new System.Windows.Forms.TextBox();
            this.textBox_sum = new System.Windows.Forms.TextBox();
            this.g_gra = new System.Windows.Forms.Label();
            this.g_sno = new System.Windows.Forms.Label();
            this.g_cno = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出本系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.stu.SuspendLayout();
            this.cla.SuspendLayout();
            this.cou.SuspendLayout();
            this.gra.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.status });
            this.statusStrip1.Location = new System.Drawing.Point(0, 684);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1200, 36);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(70, 31);
            this.status.Text = "state";
            this.status.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.stu);
            this.tabControl1.Controls.Add(this.cla);
            this.tabControl1.Controls.Add(this.cou);
            this.tabControl1.Controls.Add(this.gra);
            this.tabControl1.Location = new System.Drawing.Point(18, 43);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1164, 637);
            this.tabControl1.TabIndex = 2;
            // 
            // stu
            // 
            this.stu.Controls.Add(this.add_stu);
            this.stu.Controls.Add(this.textBox_class);
            this.stu.Controls.Add(this.textBox_dom);
            this.stu.Controls.Add(this.textBox_grade);
            this.stu.Controls.Add(this.textBox_Snum);
            this.stu.Controls.Add(this.textBox_age);
            this.stu.Controls.Add(this.textBox_sex);
            this.stu.Controls.Add(this.textBox_name);
            this.stu.Controls.Add(this.comboBox_Sdept);
            this.stu.Controls.Add(this.clas);
            this.stu.Controls.Add(this.Sname);
            this.stu.Controls.Add(this.Ssex);
            this.stu.Controls.Add(this.Sage);
            this.stu.Controls.Add(this.Snum);
            this.stu.Controls.Add(this.Sgrade);
            this.stu.Controls.Add(this.Sdept);
            this.stu.Controls.Add(this.Dormitory);
            this.stu.Location = new System.Drawing.Point(8, 39);
            this.stu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stu.Name = "stu";
            this.stu.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stu.Size = new System.Drawing.Size(1148, 590);
            this.stu.TabIndex = 0;
            this.stu.Text = "学生信息";
            this.stu.UseVisualStyleBackColor = true;
            // 
            // add_stu
            // 
            this.add_stu.Location = new System.Drawing.Point(784, 373);
            this.add_stu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_stu.Name = "add_stu";
            this.add_stu.Size = new System.Drawing.Size(226, 83);
            this.add_stu.TabIndex = 19;
            this.add_stu.Text = "提交";
            this.add_stu.UseVisualStyleBackColor = true;
            this.add_stu.Click += new System.EventHandler(this.add_stu_Click);
            // 
            // textBox_class
            // 
            this.textBox_class.Location = new System.Drawing.Point(186, 416);
            this.textBox_class.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_class.Name = "textBox_class";
            this.textBox_class.Size = new System.Drawing.Size(290, 35);
            this.textBox_class.TabIndex = 18;
            // 
            // textBox_dom
            // 
            this.textBox_dom.Location = new System.Drawing.Point(861, 280);
            this.textBox_dom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_dom.Name = "textBox_dom";
            this.textBox_dom.Size = new System.Drawing.Size(148, 35);
            this.textBox_dom.TabIndex = 17;
            // 
            // textBox_grade
            // 
            this.textBox_grade.Location = new System.Drawing.Point(861, 158);
            this.textBox_grade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_grade.Name = "textBox_grade";
            this.textBox_grade.Size = new System.Drawing.Size(148, 35);
            this.textBox_grade.TabIndex = 16;
            // 
            // textBox_Snum
            // 
            this.textBox_Snum.Location = new System.Drawing.Point(177, 166);
            this.textBox_Snum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Snum.Name = "textBox_Snum";
            this.textBox_Snum.Size = new System.Drawing.Size(290, 35);
            this.textBox_Snum.TabIndex = 15;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(861, 51);
            this.textBox_age.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(148, 35);
            this.textBox_age.TabIndex = 14;
            // 
            // textBox_sex
            // 
            this.textBox_sex.Location = new System.Drawing.Point(506, 59);
            this.textBox_sex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_sex.Name = "textBox_sex";
            this.textBox_sex.Size = new System.Drawing.Size(148, 35);
            this.textBox_sex.TabIndex = 13;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(186, 59);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(148, 35);
            this.textBox_name.TabIndex = 12;
            // 
            // comboBox_Sdept
            // 
            this.comboBox_Sdept.FormattingEnabled = true;
            this.comboBox_Sdept.Items.AddRange(new object[] { "物理", "计算机", "软件工程", "大数据", "数学" });
            this.comboBox_Sdept.Location = new System.Drawing.Point(186, 280);
            this.comboBox_Sdept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_Sdept.Name = "comboBox_Sdept";
            this.comboBox_Sdept.Size = new System.Drawing.Size(290, 32);
            this.comboBox_Sdept.TabIndex = 11;
            // 
            // clas
            // 
            this.clas.AutoSize = true;
            this.clas.Font = new System.Drawing.Font("宋体", 12F);
            this.clas.Location = new System.Drawing.Point(90, 424);
            this.clas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clas.Name = "clas";
            this.clas.Size = new System.Drawing.Size(79, 33);
            this.clas.TabIndex = 10;
            this.clas.Text = "班级";
            // 
            // Sname
            // 
            this.Sname.AutoSize = true;
            this.Sname.Font = new System.Drawing.Font("宋体", 12F);
            this.Sname.Location = new System.Drawing.Point(90, 59);
            this.Sname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(79, 33);
            this.Sname.TabIndex = 3;
            this.Sname.Text = "姓名";
            // 
            // Ssex
            // 
            this.Ssex.AutoSize = true;
            this.Ssex.Font = new System.Drawing.Font("宋体", 12F);
            this.Ssex.Location = new System.Drawing.Point(405, 59);
            this.Ssex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ssex.Name = "Ssex";
            this.Ssex.Size = new System.Drawing.Size(79, 33);
            this.Ssex.TabIndex = 4;
            this.Ssex.Text = "性别";
            // 
            // Sage
            // 
            this.Sage.AutoSize = true;
            this.Sage.Font = new System.Drawing.Font("宋体", 12F);
            this.Sage.Location = new System.Drawing.Point(778, 59);
            this.Sage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sage.Name = "Sage";
            this.Sage.Size = new System.Drawing.Size(79, 33);
            this.Sage.TabIndex = 5;
            this.Sage.Text = "年龄";
            this.Sage.Click += new System.EventHandler(this.label3_Click);
            // 
            // Snum
            // 
            this.Snum.AutoSize = true;
            this.Snum.Font = new System.Drawing.Font("宋体", 12F);
            this.Snum.Location = new System.Drawing.Point(90, 166);
            this.Snum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Snum.Name = "Snum";
            this.Snum.Size = new System.Drawing.Size(79, 33);
            this.Snum.TabIndex = 6;
            this.Snum.Text = "学号";
            // 
            // Sgrade
            // 
            this.Sgrade.AutoSize = true;
            this.Sgrade.Font = new System.Drawing.Font("宋体", 12F);
            this.Sgrade.Location = new System.Drawing.Point(778, 166);
            this.Sgrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sgrade.Name = "Sgrade";
            this.Sgrade.Size = new System.Drawing.Size(79, 33);
            this.Sgrade.TabIndex = 7;
            this.Sgrade.Text = "年级";
            // 
            // Sdept
            // 
            this.Sdept.AutoSize = true;
            this.Sdept.Font = new System.Drawing.Font("宋体", 12F);
            this.Sdept.Location = new System.Drawing.Point(90, 278);
            this.Sdept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sdept.Name = "Sdept";
            this.Sdept.Size = new System.Drawing.Size(79, 33);
            this.Sdept.TabIndex = 8;
            this.Sdept.Text = "系别";
            // 
            // Dormitory
            // 
            this.Dormitory.AutoSize = true;
            this.Dormitory.Font = new System.Drawing.Font("宋体", 12F);
            this.Dormitory.Location = new System.Drawing.Point(778, 280);
            this.Dormitory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dormitory.Name = "Dormitory";
            this.Dormitory.Size = new System.Drawing.Size(79, 33);
            this.Dormitory.TabIndex = 9;
            this.Dormitory.Text = "宿舍";
            // 
            // cla
            // 
            this.cla.Controls.Add(this.class_add);
            this.cla.Controls.Add(this.class_tea);
            this.cla.Controls.Add(this.class_sdept);
            this.cla.Controls.Add(this.class_snum);
            this.cla.Controls.Add(this.class_name);
            this.cla.Controls.Add(this.label_cteacher);
            this.cla.Controls.Add(this.label_sdept);
            this.cla.Controls.Add(this.label_csnum);
            this.cla.Controls.Add(this.label_cname);
            this.cla.Location = new System.Drawing.Point(8, 39);
            this.cla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cla.Name = "cla";
            this.cla.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cla.Size = new System.Drawing.Size(1148, 590);
            this.cla.TabIndex = 1;
            this.cla.Text = "班级信息";
            this.cla.UseVisualStyleBackColor = true;
            this.cla.Click += new System.EventHandler(this.cla_Click);
            // 
            // class_add
            // 
            this.class_add.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_add.Location = new System.Drawing.Point(699, 330);
            this.class_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.class_add.Name = "class_add";
            this.class_add.Size = new System.Drawing.Size(310, 86);
            this.class_add.TabIndex = 11;
            this.class_add.Text = "提交";
            this.class_add.UseVisualStyleBackColor = true;
            this.class_add.Click += new System.EventHandler(this.class_add_Click);
            // 
            // class_tea
            // 
            this.class_tea.Location = new System.Drawing.Point(699, 198);
            this.class_tea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.class_tea.Name = "class_tea";
            this.class_tea.Size = new System.Drawing.Size(217, 35);
            this.class_tea.TabIndex = 7;
            // 
            // class_sdept
            // 
            this.class_sdept.Location = new System.Drawing.Point(194, 198);
            this.class_sdept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.class_sdept.Name = "class_sdept";
            this.class_sdept.Size = new System.Drawing.Size(211, 35);
            this.class_sdept.TabIndex = 6;
            // 
            // class_snum
            // 
            this.class_snum.Location = new System.Drawing.Point(699, 59);
            this.class_snum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.class_snum.Name = "class_snum";
            this.class_snum.Size = new System.Drawing.Size(217, 35);
            this.class_snum.TabIndex = 5;
            // 
            // class_name
            // 
            this.class_name.Location = new System.Drawing.Point(194, 58);
            this.class_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.class_name.Name = "class_name";
            this.class_name.Size = new System.Drawing.Size(211, 35);
            this.class_name.TabIndex = 4;
            // 
            // label_cteacher
            // 
            this.label_cteacher.AutoSize = true;
            this.label_cteacher.Font = new System.Drawing.Font("宋体", 12F);
            this.label_cteacher.Location = new System.Drawing.Point(556, 206);
            this.label_cteacher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cteacher.Name = "label_cteacher";
            this.label_cteacher.Size = new System.Drawing.Size(143, 33);
            this.label_cteacher.TabIndex = 3;
            this.label_cteacher.Text = "辅导老师";
            // 
            // label_sdept
            // 
            this.label_sdept.AutoSize = true;
            this.label_sdept.Font = new System.Drawing.Font("宋体", 12F);
            this.label_sdept.Location = new System.Drawing.Point(51, 206);
            this.label_sdept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_sdept.Name = "label_sdept";
            this.label_sdept.Size = new System.Drawing.Size(143, 33);
            this.label_sdept.TabIndex = 2;
            this.label_sdept.Text = "所属系别";
            // 
            // label_csnum
            // 
            this.label_csnum.AutoSize = true;
            this.label_csnum.Font = new System.Drawing.Font("宋体", 12F);
            this.label_csnum.Location = new System.Drawing.Point(556, 58);
            this.label_csnum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_csnum.Name = "label_csnum";
            this.label_csnum.Size = new System.Drawing.Size(143, 33);
            this.label_csnum.TabIndex = 1;
            this.label_csnum.Text = "学生数量";
            // 
            // label_cname
            // 
            this.label_cname.AutoSize = true;
            this.label_cname.Font = new System.Drawing.Font("宋体", 12F);
            this.label_cname.Location = new System.Drawing.Point(51, 58);
            this.label_cname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cname.Name = "label_cname";
            this.label_cname.Size = new System.Drawing.Size(143, 33);
            this.label_cname.TabIndex = 0;
            this.label_cname.Text = "班级名称";
            // 
            // cou
            // 
            this.cou.Controls.Add(this.course_add);
            this.cou.Controls.Add(this.textBox5_cteacher);
            this.cou.Controls.Add(this.textBox_crad);
            this.cou.Controls.Add(this.textBox3_cpno);
            this.cou.Controls.Add(this.textBox_cname);
            this.cou.Controls.Add(this.textBox1_cno);
            this.cou.Controls.Add(this.teacher);
            this.cou.Controls.Add(this.caredit);
            this.cou.Controls.Add(this.cpno);
            this.cou.Controls.Add(this.cname);
            this.cou.Controls.Add(this.Cno);
            this.cou.Location = new System.Drawing.Point(8, 39);
            this.cou.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cou.Name = "cou";
            this.cou.Size = new System.Drawing.Size(1148, 590);
            this.cou.TabIndex = 2;
            this.cou.Text = "课程信息";
            this.cou.UseVisualStyleBackColor = true;
            // 
            // course_add
            // 
            this.course_add.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_add.Location = new System.Drawing.Point(694, 286);
            this.course_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.course_add.Name = "course_add";
            this.course_add.Size = new System.Drawing.Size(310, 86);
            this.course_add.TabIndex = 10;
            this.course_add.Text = "提交";
            this.course_add.UseVisualStyleBackColor = true;
            this.course_add.Click += new System.EventHandler(this.course_add_Click);
            // 
            // textBox5_cteacher
            // 
            this.textBox5_cteacher.Location = new System.Drawing.Point(782, 168);
            this.textBox5_cteacher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5_cteacher.Name = "textBox5_cteacher";
            this.textBox5_cteacher.Size = new System.Drawing.Size(222, 35);
            this.textBox5_cteacher.TabIndex = 9;
            // 
            // textBox_crad
            // 
            this.textBox_crad.Location = new System.Drawing.Point(782, 66);
            this.textBox_crad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_crad.Name = "textBox_crad";
            this.textBox_crad.Size = new System.Drawing.Size(222, 35);
            this.textBox_crad.TabIndex = 8;
            // 
            // textBox3_cpno
            // 
            this.textBox3_cpno.Location = new System.Drawing.Point(230, 314);
            this.textBox3_cpno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3_cpno.Name = "textBox3_cpno";
            this.textBox3_cpno.Size = new System.Drawing.Size(212, 35);
            this.textBox3_cpno.TabIndex = 7;
            // 
            // textBox_cname
            // 
            this.textBox_cname.Location = new System.Drawing.Point(230, 194);
            this.textBox_cname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_cname.Name = "textBox_cname";
            this.textBox_cname.Size = new System.Drawing.Size(212, 35);
            this.textBox_cname.TabIndex = 6;
            // 
            // textBox1_cno
            // 
            this.textBox1_cno.Location = new System.Drawing.Point(230, 61);
            this.textBox1_cno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1_cno.Name = "textBox1_cno";
            this.textBox1_cno.Size = new System.Drawing.Size(212, 35);
            this.textBox1_cno.TabIndex = 5;
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.Font = new System.Drawing.Font("宋体", 13F);
            this.teacher.Location = new System.Drawing.Point(626, 173);
            this.teacher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(155, 35);
            this.teacher.TabIndex = 4;
            this.teacher.Text = "授课教师";
            this.teacher.Click += new System.EventHandler(this.label9_Click);
            // 
            // caredit
            // 
            this.caredit.AutoSize = true;
            this.caredit.Font = new System.Drawing.Font("宋体", 13F);
            this.caredit.Location = new System.Drawing.Point(626, 66);
            this.caredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.caredit.Name = "caredit";
            this.caredit.Size = new System.Drawing.Size(85, 35);
            this.caredit.TabIndex = 3;
            this.caredit.Text = "学分";
            // 
            // cpno
            // 
            this.cpno.AutoSize = true;
            this.cpno.Font = new System.Drawing.Font("宋体", 13F);
            this.cpno.Location = new System.Drawing.Point(106, 318);
            this.cpno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpno.Name = "cpno";
            this.cpno.Size = new System.Drawing.Size(120, 35);
            this.cpno.TabIndex = 2;
            this.cpno.Text = "先修课";
            // 
            // cname
            // 
            this.cname.AutoSize = true;
            this.cname.Font = new System.Drawing.Font("宋体", 13F);
            this.cname.Location = new System.Drawing.Point(106, 194);
            this.cname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(120, 35);
            this.cname.TabIndex = 1;
            this.cname.Text = "课程名";
            // 
            // Cno
            // 
            this.Cno.AutoSize = true;
            this.Cno.Font = new System.Drawing.Font("宋体", 13F);
            this.Cno.Location = new System.Drawing.Point(106, 66);
            this.Cno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cno.Name = "Cno";
            this.Cno.Size = new System.Drawing.Size(120, 35);
            this.Cno.TabIndex = 0;
            this.Cno.Text = "课序号";
            // 
            // gra
            // 
            this.gra.Controls.Add(this.score_add);
            this.gra.Controls.Add(this.textBox_gro);
            this.gra.Controls.Add(this.textBox_cno);
            this.gra.Controls.Add(this.textBox_sum);
            this.gra.Controls.Add(this.g_gra);
            this.gra.Controls.Add(this.g_sno);
            this.gra.Controls.Add(this.g_cno);
            this.gra.Location = new System.Drawing.Point(8, 39);
            this.gra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gra.Name = "gra";
            this.gra.Size = new System.Drawing.Size(1148, 590);
            this.gra.TabIndex = 3;
            this.gra.Text = "成绩录入";
            this.gra.UseVisualStyleBackColor = true;
            // 
            // score_add
            // 
            this.score_add.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_add.Location = new System.Drawing.Point(524, 219);
            this.score_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.score_add.Name = "score_add";
            this.score_add.Size = new System.Drawing.Size(310, 86);
            this.score_add.TabIndex = 11;
            this.score_add.Text = "提交";
            this.score_add.UseVisualStyleBackColor = true;
            this.score_add.Click += new System.EventHandler(this.score_add_Click);
            // 
            // textBox_gro
            // 
            this.textBox_gro.Location = new System.Drawing.Point(152, 242);
            this.textBox_gro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_gro.Name = "textBox_gro";
            this.textBox_gro.Size = new System.Drawing.Size(148, 35);
            this.textBox_gro.TabIndex = 5;
            // 
            // textBox_cno
            // 
            this.textBox_cno.Location = new System.Drawing.Point(524, 40);
            this.textBox_cno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_cno.Name = "textBox_cno";
            this.textBox_cno.Size = new System.Drawing.Size(246, 35);
            this.textBox_cno.TabIndex = 4;
            // 
            // textBox_sum
            // 
            this.textBox_sum.Location = new System.Drawing.Point(152, 40);
            this.textBox_sum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_sum.Name = "textBox_sum";
            this.textBox_sum.Size = new System.Drawing.Size(208, 35);
            this.textBox_sum.TabIndex = 3;
            // 
            // g_gra
            // 
            this.g_gra.AutoSize = true;
            this.g_gra.Font = new System.Drawing.Font("宋体", 12F);
            this.g_gra.Location = new System.Drawing.Point(69, 250);
            this.g_gra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.g_gra.Name = "g_gra";
            this.g_gra.Size = new System.Drawing.Size(79, 33);
            this.g_gra.TabIndex = 2;
            this.g_gra.Text = "分数";
            // 
            // g_sno
            // 
            this.g_sno.AutoSize = true;
            this.g_sno.Font = new System.Drawing.Font("宋体", 12F);
            this.g_sno.Location = new System.Drawing.Point(69, 48);
            this.g_sno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.g_sno.Name = "g_sno";
            this.g_sno.Size = new System.Drawing.Size(79, 33);
            this.g_sno.TabIndex = 1;
            this.g_sno.Text = "学号";
            // 
            // g_cno
            // 
            this.g_cno.AutoSize = true;
            this.g_cno.Font = new System.Drawing.Font("宋体", 12F);
            this.g_cno.Location = new System.Drawing.Point(411, 48);
            this.g_cno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.g_cno.Name = "g_cno";
            this.g_cno.Size = new System.Drawing.Size(111, 33);
            this.g_cno.TabIndex = 0;
            this.g_cno.Text = "课序号";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.选项ToolStripMenuItem, this.设置ToolStripMenuItem, this.工具ToolStripMenuItem, this.帮助ToolStripMenuItem });
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(1200, 41);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.登录ToolStripMenuItem, this.退出登录ToolStripMenuItem, this.退出本系统ToolStripMenuItem });
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.选项ToolStripMenuItem.Text = "选项";
            // 
            // 登录ToolStripMenuItem
            // 
            this.登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            this.登录ToolStripMenuItem.Size = new System.Drawing.Size(208, 36);
            this.登录ToolStripMenuItem.Text = "登录";
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(208, 36);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            this.退出登录ToolStripMenuItem.Click += new System.EventHandler(this.退出登录ToolStripMenuItem_Click);
            // 
            // 退出本系统ToolStripMenuItem
            // 
            this.退出本系统ToolStripMenuItem.Name = "退出本系统ToolStripMenuItem";
            this.退出本系统ToolStripMenuItem.Size = new System.Drawing.Size(208, 36);
            this.退出本系统ToolStripMenuItem.Text = "退出本系统";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.关于我们ToolStripMenuItem });
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于我们ToolStripMenuItem
            // 
            this.关于我们ToolStripMenuItem.Name = "关于我们ToolStripMenuItem";
            this.关于我们ToolStripMenuItem.Size = new System.Drawing.Size(184, 36);
            this.关于我们ToolStripMenuItem.Text = "关于我们";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.stu.ResumeLayout(false);
            this.stu.PerformLayout();
            this.cla.ResumeLayout(false);
            this.cla.PerformLayout();
            this.cou.ResumeLayout(false);
            this.cou.PerformLayout();
            this.gra.ResumeLayout(false);
            this.gra.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage stu;
        private System.Windows.Forms.Label Sname;
        private System.Windows.Forms.Label Ssex;
        private System.Windows.Forms.Label Sage;
        private System.Windows.Forms.Label Snum;
        private System.Windows.Forms.Label Sgrade;
        private System.Windows.Forms.Label Sdept;
        private System.Windows.Forms.Label Dormitory;
        private System.Windows.Forms.TabPage cla;
        private System.Windows.Forms.TabPage cou;
        private System.Windows.Forms.TabPage gra;
        private System.Windows.Forms.TextBox textBox_class;
        private System.Windows.Forms.TextBox textBox_dom;
        private System.Windows.Forms.TextBox textBox_grade;
        private System.Windows.Forms.TextBox textBox_Snum;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_sex;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ComboBox comboBox_Sdept;
        private System.Windows.Forms.Label clas;
        private System.Windows.Forms.Button add_stu;
        private System.Windows.Forms.Label label_cteacher;
        private System.Windows.Forms.Label label_sdept;
        private System.Windows.Forms.Label label_csnum;
        private System.Windows.Forms.Label label_cname;
        private System.Windows.Forms.TextBox class_tea;
        private System.Windows.Forms.TextBox class_sdept;
        private System.Windows.Forms.TextBox class_snum;
        private System.Windows.Forms.TextBox class_name;
        private System.Windows.Forms.Label teacher;
        private System.Windows.Forms.Label caredit;
        private System.Windows.Forms.Label cpno;
        private System.Windows.Forms.Label cname;
        private System.Windows.Forms.Label Cno;
        private System.Windows.Forms.Button class_add;
        private System.Windows.Forms.Button course_add;
        private System.Windows.Forms.TextBox textBox5_cteacher;
        private System.Windows.Forms.TextBox textBox_crad;
        private System.Windows.Forms.TextBox textBox3_cpno;
        private System.Windows.Forms.TextBox textBox_cname;
        private System.Windows.Forms.TextBox textBox1_cno;
        private System.Windows.Forms.Button score_add;
        private System.Windows.Forms.TextBox textBox_gro;
        private System.Windows.Forms.TextBox textBox_cno;
        private System.Windows.Forms.TextBox textBox_sum;
        private System.Windows.Forms.Label g_gra;
        private System.Windows.Forms.Label g_sno;
        private System.Windows.Forms.Label g_cno;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出本系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于我们ToolStripMenuItem;
    }
}