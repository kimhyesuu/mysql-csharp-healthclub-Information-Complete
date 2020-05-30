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
    public partial class Resultdata : Form
    {
        //DB 전역변수  
        String Re_connStr;
        MySqlConnection Re_conn;
        MySqlCommand Re_cmd;

        String Re_userID, Re_name, Re_addr, Re_mobile1, Re_mobile2, Re_mdate;

        short Re_height;
        int Re_birth;

        public Resultdata()
        {
            InitializeComponent();
        }

        private void Resultdata_FormClosed(object sender, FormClosedEventArgs e)
        {
            Re_conn.Close();
            MessageBox.Show("DB 연결 해제~ 잘가삼");
        }

        private void Resultdata_Load(object sender, EventArgs e)
        {
            Re_connStr = "server=127.0.0.1; Uid=root; pwd=1234; Database=sqlDB;CHARSET=UTF8";
            try
            {
                Re_conn = new MySqlConnection(Re_connStr);
                Re_conn.Open();
                MessageBox.Show("GOOD 프로젝트 다하면 지우기");
            }
            catch
            {
                MessageBox.Show("연결실패 - 아이디 비번 확인 요망");
            }
        }
        private void btn_Result_Click(object sender, EventArgs e)
        {
            Re_cmd = new MySqlCommand("", Re_conn);
            // String Up_userID, Up_name, Up_addr, Up_mobile1, Up_mobile2,,Up_mdate;
            String sql = "SELECT userID, name, birthYear,addr,mobile1,mobile2,height,mDate FROM userTbl";
            Re_cmd.CommandText = sql; // 트럭에 짐 싣기
            MySqlDataReader reader; // 다시 가져올 짐을 연결할 끈...
            reader = Re_cmd.ExecuteReader(); // 짐을 서버에 부어서 준비하고, 끈만 가져옴....

            // 끈 톡하고 당기기
            while (reader.Read())
            {
                try
                {
                    Re_userID = (String)reader["userID"];
                    Re_name = (String)reader["name"];
                    Re_birth = (int)reader["birthYear"];
                    Re_addr = (String)reader["addr"];
                    Re_mobile1 = (String)reader["mobile1"];
                    Re_mobile2 = (String)reader["mobile2"];
                    Re_height = Convert.ToInt16(reader["height"]);
                    Re_mdate = (String)reader["mDate"];
                }
                catch
                {
                    Re_mobile1 = "-";
                    Re_mobile2 = "-";
                    Re_mdate = "-";
                    Re_height = 0;
                }

                ListViewItem lvi = new ListViewItem(new string[] { Re_userID, Re_name, Re_birth.ToString(),
                Re_addr, Re_mobile1, Re_mobile2, Re_height.ToString(), Re_mdate });
                this.lvData.Items.Add(lvi);
            }

        }

    }
}
