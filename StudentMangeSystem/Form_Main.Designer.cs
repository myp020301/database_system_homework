
namespace StudentMangeSystem
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出本系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Login_state = new System.Windows.Forms.ToolStripStatusLabel();
            this.Login_panel = new System.Windows.Forms.Panel();
            this.register = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_pw = new System.Windows.Forms.TextBox();
            this.label3_pw = new System.Windows.Forms.Label();
            this.label2_id = new System.Windows.Forms.Label();
            this.label1_hello = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.panel_Mian = new System.Windows.Forms.Panel();
            this.Select = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.Login_panel.SuspendLayout();
            this.panel_Mian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.选项ToolStripMenuItem, this.设置ToolStripMenuItem, this.工具ToolStripMenuItem, this.帮助ToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.登录ToolStripMenuItem, this.退出登录ToolStripMenuItem, this.退出本系统ToolStripMenuItem });
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.选项ToolStripMenuItem.Text = "选项";
            // 
            // 登录ToolStripMenuItem
            // 
            this.登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            this.登录ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.登录ToolStripMenuItem.Text = "登录";
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            this.退出登录ToolStripMenuItem.Click += new System.EventHandler(this.退出登录ToolStripMenuItem_Click);
            // 
            // 退出本系统ToolStripMenuItem
            // 
            this.退出本系统ToolStripMenuItem.Name = "退出本系统ToolStripMenuItem";
            this.退出本系统ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.退出本系统ToolStripMenuItem.Text = "退出本系统";
            this.退出本系统ToolStripMenuItem.Click += new System.EventHandler(this.退出本系统ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.关于我们ToolStripMenuItem });
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于我们ToolStripMenuItem
            // 
            this.关于我们ToolStripMenuItem.Name = "关于我们ToolStripMenuItem";
            this.关于我们ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于我们ToolStripMenuItem.Text = "关于我们";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.Login_state });
            this.statusStrip1.Location = new System.Drawing.Point(0, 338);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(600, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Login_state
            // 
            this.Login_state.Name = "Login_state";
            this.Login_state.Size = new System.Drawing.Size(44, 17);
            this.Login_state.Text = "未登录";
            // 
            // Login_panel
            // 
            this.Login_panel.Controls.Add(this.register);
            this.Login_panel.Controls.Add(this.textBox_id);
            this.Login_panel.Controls.Add(this.textBox_pw);
            this.Login_panel.Controls.Add(this.label3_pw);
            this.Login_panel.Controls.Add(this.label2_id);
            this.Login_panel.Controls.Add(this.label1_hello);
            this.Login_panel.Controls.Add(this.login_button);
            this.Login_panel.Location = new System.Drawing.Point(9, 34);
            this.Login_panel.Margin = new System.Windows.Forms.Padding(2);
            this.Login_panel.Name = "Login_panel";
            this.Login_panel.Size = new System.Drawing.Size(582, 303);
            this.Login_panel.TabIndex = 2;
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(309, 226);
            this.register.Margin = new System.Windows.Forms.Padding(2);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(103, 38);
            this.register.TabIndex = 6;
            this.register.Text = "注册";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(216, 127);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(197, 21);
            this.textBox_id.TabIndex = 5;
            // 
            // textBox_pw
            // 
            this.textBox_pw.Location = new System.Drawing.Point(216, 182);
            this.textBox_pw.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.PasswordChar = '*';
            this.textBox_pw.Size = new System.Drawing.Size(197, 21);
            this.textBox_pw.TabIndex = 4;
            // 
            // label3_pw
            // 
            this.label3_pw.AutoSize = true;
            this.label3_pw.Font = new System.Drawing.Font("宋体", 13F);
            this.label3_pw.Location = new System.Drawing.Point(147, 184);
            this.label3_pw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3_pw.Name = "label3_pw";
            this.label3_pw.Size = new System.Drawing.Size(53, 18);
            this.label3_pw.TabIndex = 3;
            this.label3_pw.Text = "密码:";
            // 
            // label2_id
            // 
            this.label2_id.AutoSize = true;
            this.label2_id.Font = new System.Drawing.Font("宋体", 13F);
            this.label2_id.Location = new System.Drawing.Point(146, 130);
            this.label2_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2_id.Name = "label2_id";
            this.label2_id.Size = new System.Drawing.Size(71, 18);
            this.label2_id.TabIndex = 2;
            this.label2_id.Text = "用户名:";
            // 
            // label1_hello
            // 
            this.label1_hello.AutoSize = true;
            this.label1_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1_hello.Location = new System.Drawing.Point(170, 42);
            this.label1_hello.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1_hello.Name = "label1_hello";
            this.label1_hello.Size = new System.Drawing.Size(260, 46);
            this.label1_hello.TabIndex = 1;
            this.label1_hello.Text = "学生管理系统";
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(150, 226);
            this.login_button.Margin = new System.Windows.Forms.Padding(2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(103, 38);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "登录";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // panel_Mian
            // 
            this.panel_Mian.Controls.Add(this.Select);
            this.panel_Mian.Controls.Add(this.Change);
            this.panel_Mian.Controls.Add(this.Delete);
            this.panel_Mian.Controls.Add(this.Add);
            this.panel_Mian.Controls.Add(this.pictureBox1);
            this.panel_Mian.Location = new System.Drawing.Point(9, 34);
            this.panel_Mian.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Mian.Name = "panel_Mian";
            this.panel_Mian.Size = new System.Drawing.Size(582, 303);
            this.panel_Mian.TabIndex = 7;
            this.panel_Mian.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Mian_Paint);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(12, 238);
            this.Select.Margin = new System.Windows.Forms.Padding(2);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(103, 39);
            this.Select.TabIndex = 4;
            this.Select.Text = "查询信息";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(12, 162);
            this.Change.Margin = new System.Windows.Forms.Padding(2);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(103, 39);
            this.Change.TabIndex = 3;
            this.Change.Text = "更改信息";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(12, 92);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(103, 39);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "删除信息";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 14);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(103, 39);
            this.Add.TabIndex = 1;
            this.Add.Text = "录入信息";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(284, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 298);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.panel_Mian);
            this.Controls.Add(this.Login_panel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生管理系统";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Login_panel.ResumeLayout(false);
            this.Login_panel.PerformLayout();
            this.panel_Mian.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出本系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于我们ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel Login_state;
        internal System.Windows.Forms.Panel Login_panel;
        private System.Windows.Forms.Button login_button;
        internal System.Windows.Forms.Panel panel_Mian;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.Label label3_pw;
        private System.Windows.Forms.Label label2_id;
        private System.Windows.Forms.Label label1_hello;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

