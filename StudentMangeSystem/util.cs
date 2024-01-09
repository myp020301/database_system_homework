using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMangeSystem
{
    class util
    {
        MySqlConnection conn = null;
        string sql;

        public util(MySqlConnection conn)
        {
            this.conn = conn;
        }

        public MySqlDataReader selectLevel(string id)
        {
            sql = "select user_level from admin where user_id=@para1";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("para1", id);
            return cmd.ExecuteReader();
        }

        public Boolean register(string id, string password)
        {
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                string reg = $"create user '{id}'@'%' identified by '{password}'"; //增加用户
                string quanxian = $"grant select on *.* to {id} @'%'"; //分配权限
                string update = $"insert into admin(user_id,user_password,user_level) values('{id}','{password}','2')";
                MySqlCommand com1 = new MySqlCommand(reg, conn); //增加用户
                com1.ExecuteNonQuery();
                MySqlCommand com2 = new MySqlCommand(quanxian, conn); //分配权限
                com2.ExecuteNonQuery();
                MySqlCommand com3 = new MySqlCommand(update, conn); //写表
                com3.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                transaction.Rollback(); //事务ExecuteNonQuery()执行失败报错，username被设置unique
                return false;
            }
        }

        public Boolean addstu(string name, string snum, string ssex, string age, string grade, string sdept, string dom,
            string clasS)
        {
            string sql =
                $"insert into student(Sname,snum,ssex,sage,sgarde,sdept,dormitory,class) values('{name}','{snum}','{ssex}','{age}','{grade}','{sdept}','{dom}','{clasS}')";
            MySqlCommand com = new MySqlCommand(sql, conn);
            try
            {
                int p = com.ExecuteNonQuery();
                if (p == 1)
                {
                    return true;
                }

                return false;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public Boolean addclass(string cname, string stunum, string sdept, string cteacher)
        {
            string sql =
                $"insert into class(cname,stunum,sdept,cteacher) values('{cname}','{stunum}','{sdept}','{cteacher}')";
            MySqlCommand com = new MySqlCommand(sql, conn);
            try
            {
                int p = com.ExecuteNonQuery();
                if (p == 1)
                {
                    return true;
                }

                return false;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public Boolean addcourse(string cno, string cname, string cpno, string ccredit, string cteacher)
        {
            string sql =
                $"insert into course(cno,cname,cpno,ccredit,cteacher) values('{cno}','{cname}','{cpno}','{ccredit}','{cteacher}')";
            MySqlCommand com = new MySqlCommand(sql, conn);
            try
            {
                int p = com.ExecuteNonQuery();
                if (p == 1)
                {
                    return true;
                }

                return false;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public Boolean addgrade(string sno, string cno, string grade)
        {
            string sql = $"insert into sc(sno,cno,grade) values('{sno}','{cno}','{grade}')";
            MySqlCommand com = new MySqlCommand(sql, conn);
            try
            {
                int p = com.ExecuteNonQuery();
                if (p == 1)
                {
                    return true;
                }

                return false;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public Boolean deletestu(string sno)
        {
            string sql = $"delete from student where snum={sno}";
            MySqlCommand com = new MySqlCommand(sql, conn);
            try
            {
                int p = com.ExecuteNonQuery();
                if (p == 1)
                {
                    return true;
                }

                return false;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public Boolean deletecourse(string cno)
        {
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                string sql1 = $"delete from sc where cno={cno}";
                string sql2 = $"delete from course where cno={cno}";
                MySqlCommand com = new MySqlCommand(sql1, conn);
                MySqlCommand com2 = new MySqlCommand(sql2, conn);
                com.ExecuteNonQuery();
                com2.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                transaction.Rollback(); //事务ExecuteNonQuery()执行失败报错，username被设置unique
                return false;
            }
        }

        public Boolean deleteclass(string cname)
        {
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                string sql1 = $"delete from student where class={cname}";
                string sql2 = $"delete from class where cname={cname}";
                MySqlCommand com = new MySqlCommand(sql1, conn);
                MySqlCommand com2 = new MySqlCommand(sql2, conn);
                com.ExecuteNonQuery();
                com2.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                transaction.Rollback(); //事务ExecuteNonQuery()执行失败报错，username被设置unique
                return false;
            }
        }

        public Boolean changestusdept(string sno, string sdept)
        {
            string sql = $"UPDATE student SET sdept = '{sdept}' WHERE snum = '{sno}' ";
            MySqlCommand com = new MySqlCommand(sql, conn);
            try
            {
                int p = com.ExecuteNonQuery();
                if (p == 1)
                {
                    return true;
                }

                return false;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        internal bool changestuname(string snum, string name)
        {
            string sql = $"UPDATE student SET sname = '{name}' WHERE snum = '{snum}' ";
            MySqlCommand com = new MySqlCommand(sql, conn);
            try
            {
                int p = com.ExecuteNonQuery();
                if (p == 1)
                {
                    return true;
                }

                return false;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        internal bool changestuall(string snum, string name, string sdept)
        {
            string sql = $"UPDATE student SET sname = '{name}',sdept='{sdept}' WHERE snum = '{snum}' ";
            MySqlCommand com = new MySqlCommand(sql, conn);
            try
            {
                int p = com.ExecuteNonQuery();
                if (p == 1)
                {
                    return true;
                }

                return false;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public MySqlDataReader SelectStu(string snum)
        {
            sql = "select * from student where snum=@para1";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("para1", snum);
            return cmd.ExecuteReader();
        }

        public MySqlDataReader Selectcla(string cname)
        {
            sql = "select * from student where class=@para1";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("para1", cname);
            return cmd.ExecuteReader();
        }

        public MySqlDataReader SelectCou(string cno)
        {
            sql = "select * from course where cno=@para1";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("para1", cno);
            return cmd.ExecuteReader();
        }

        public MySqlDataReader SelectGra(string sno)
        {
            sql = "select cname,grade from sc,course where sc.sno=@para1 and sc.Cno=course.Cno";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("para1", sno);
            return cmd.ExecuteReader();
        }
    }
}