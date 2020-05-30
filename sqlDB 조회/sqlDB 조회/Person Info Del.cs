using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sqlDB_조회
{
    public partial class Person_info_del : Form
    {
        private string userIdv;//아이디 value 받기
        String Up_connStr;
        MySqlConnection Up_conn;
        MySqlCommand Up_cmd;

        String Up_userID, Up_name, Up_addr, Up_mobile1, Up_mobile2, Up_mdate;



        short Up_height;
        int Up_birth;

        public Person_info_del(string para_ID)
        {
            InitializeComponent();
            userIdv = para_ID;
        }
        private void Person_info_del_Load(object sender, EventArgs e)
        {
            Up_connStr = "server=127.0.0.1; Uid=root; pwd=1234; Database=sqlDB;CHARSET=UTF8";

            try
            {
                Up_conn = new MySqlConnection(Up_connStr);
                Up_conn.Open();
                MessageBox.Show("GOOD 프로젝트 다하면 지우기");
            }
            catch
            {
                MessageBox.Show("연결실패 - 아이디 비번 확인 요망");
            }

            Up_cmd = new MySqlCommand("", Up_conn);
            // String Up_userID, Up_name, Up_addr, Up_mobile1, Up_mobile2,,Up_mdate;
            String sql = "SELECT userID, name, birthYear FROM userTbl WHERE userID =" + "'" + userIdv + "'";
            Up_cmd.CommandText = sql; // 트럭에 짐 싣기
            MySqlDataReader reader; // 다시 가져올 짐을 연결할 끈...
            reader = Up_cmd.ExecuteReader(); // 짐을 서버에 부어서 준비하고, 끈만 가져옴....
            // 끈 톡하고 당기기
            while (reader.Read())
            {
                try
                {
                    Up_userID = (String)reader["userID"];
                    Up_name = (String)reader["name"];
                    Up_birth = (int)reader["birthYear"];                
                }
                catch
                {
                    Up_height = 0;
                }

                tbuserID.Text = Up_userID;
                tbname.Text = Up_name;
                tbBirthyear.Text = Up_birth.ToString();
              
            }
            Up_conn.Close();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            Up_conn = new MySqlConnection(Up_connStr);
            Up_conn.Open();

            Up_cmd = new MySqlCommand("", Up_conn);

            Up_userID = tbuserID.Text;
            Up_name = tbname.Text.ToString();
            Up_birth = Convert.ToInt32(tbBirthyear.Text);

            String sql = "DELETE FROM userTbl" +" WHERE  ='" + userIdv + "'";
            //update userTbl SET name = '박박박' WHERE userID = 'KBS';
            Up_cmd.CommandText = sql;
            Up_cmd.ExecuteNonQuery();
            //try
            //{
            //    Up_cmd.ExecuteNonQuery();
            //}
            //catch
            //{
            //    MessageBox.Show("연결실패 sql 잘 되었는 지 확인 하세요");
            //}

      
        }
    }
}
