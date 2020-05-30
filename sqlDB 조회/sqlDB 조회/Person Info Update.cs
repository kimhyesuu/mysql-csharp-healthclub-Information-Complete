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
    public partial class PERSON_Info_update : Form
    {
        private string userIdv;//아이디 value 받기
        String Up_connStr;
        MySqlConnection Up_conn;
        MySqlCommand Up_cmd;

        String Up_userID, Up_name, Up_addr, Up_mobile1, Up_mobile2,Up_mdate;

        short Up_height;
        int Up_birth;

        public PERSON_Info_update(string para_ID)
        {
            InitializeComponent();
            userIdv = para_ID;
        }

        private void PERSON_Info_update_FormClosed(object sender, FormClosedEventArgs e)
        {
            Up_conn.Close();
            MessageBox.Show("DB 연결 해제~ 잘가삼");
        }

        private void PERSON_Info_update_Load(object sender, EventArgs e)
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
            String sql = "SELECT userID, name, birthYear,addr,mobile1,mobile2,height,mDate FROM userTbl WHERE userID =" + "'" + userIdv + "'";      
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
                    Up_addr = (String)reader["addr"];
                    Up_mobile1 = (String)reader["mobile1"];
                    Up_mobile2 = (String)reader["mobile2"];
                    Up_height = Convert.ToInt16(reader["height"]);
                    Up_mdate = (String)reader["mDate"];
                }
                catch
                {
                    Up_mobile1 = "-";
                    Up_mobile2 = "-";
                    Up_mdate = "-";
                    Up_height = 0;
                }
              
                tbuserID.Text = Up_userID;
                tbname.Text = Up_name;
                tbbirthyear.Text = Up_birth.ToString();
                tbAddr.Text = Up_addr;
                tbmobile1.Text = Up_mobile1;
                tbmobile2.Text = Up_mobile2;
                tbHeight.Text = Up_height.ToString();
                tbmDate.Text = Up_mdate;
            }
            Up_conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Up_conn = new MySqlConnection(Up_connStr);
            Up_conn.Open();

            Up_cmd = new MySqlCommand("", Up_conn);

            Up_userID = tbuserID.Text;
            Up_name = tbname.Text.ToString();
            Up_addr = tbAddr.Text.ToString();
            Up_mobile1 = tbmobile1.Text.ToString();
            Up_mobile2 = tbmobile2.Text.ToString();
            Up_height = Convert.ToInt16(tbHeight.Text);
            Up_mdate = tbAddr.Text.ToString();
    
            String sql = "UPDATE userTbl SET name='";
            sql += Up_name + "',mobile1= '" + Up_mobile1
                + "',mobile2='" + Up_mobile2 + "',height=" + Up_height + " WHERE userID ='" + userIdv +"'";
            //update userTbl SET name = '박박박' WHERE userID = 'KBS';
            Up_cmd.CommandText = sql;

            try
            {
                Up_cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("연결실패 sql 잘 되었는 지 확인 하세요");
            }

            tbname.Text = "";
            tbbirthyear.Text = "";
            tbAddr.Text = "";
            tbmobile1.Text = "";
            tbmobile2.Text = "";
            tbHeight.Text = "";
        
        }
    }
}
