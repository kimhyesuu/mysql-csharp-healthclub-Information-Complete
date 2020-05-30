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
    public partial class MainForm : Form
    {
        //DB 전역변수  
        String connStr;
        MySqlConnection conn;
        MySqlCommand cmd;

        String _userID, _name, _addr, _birth, _mobile1, _mobile2, _mDate;
        int _birthYear;
        short _height;

        //DB활용 범위를 정해줘서 사용하는 것입니다.

        //userID CHAR(8) NOT NULL PRIMARY KEY, -- 사용자 아이디(PK)
        //name VARCHAR(10) NOT NULL, -- 이름
        //birthYear   INT NOT NULL,  -- 출생년도
        //addr    CHAR(2) NOT NULL, -- 지역(경기, 서울, 경남 식으로 2글자만입력)
        //mobile1 CHAR(3), -- 휴대폰의 국번(011, 016, 017, 018, 019, 010 등)
        //mobile2 CHAR(8), -- 휴대폰의 나머지 전화번호(하이픈제외)
        //height SMALLINT,  -- 키
        //mDate     DATE  -- 회원 가입일

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        //SIDE MENU EVENT 

        //회원 등록
        private void btnResitM_Click(object sender, EventArgs e)
        {
            NEW_PERSON_MGT npm = new NEW_PERSON_MGT();
            npm.ShowDialog();
        }

        //회원 조회
        private void btnRefM_Click(object sender, EventArgs e)
        {
            Resultdata rd = new Resultdata();
            rd.ShowDialog();
        }
        //버튼 클릭하면 오른쪽 하단 회원 수정 (수정)textbox + button visible on
        private void btnUpdateM_Click(object sender, EventArgs e)
        {
            //회원 수정 부분 나오게 하기
            lblID_Update.Visible = true;
            tbUpUserID.Visible = true;
            btnUdate.Visible = true; 
        }

        //버튼 클릭하면 오른쪽 하단 회원 수정 (삭제)textbox + button visible on
        private void btnDelM_Click(object sender, EventArgs e)
        {
            lblID_Del.Visible = true;
            tbDelUserID.Visible = true;
            btnDel.Visible = true;
        }

        //SIDE MENU EVENT 

        //BOTTOM MENU EVENT

        //회원 수정
        private void btnUdate_Click(object sender, EventArgs e)
        {
            string data = tbUpUserID.Text.ToString();
            PERSON_Info_update piu = new PERSON_Info_update(data);
            piu.ShowDialog();
        }

        //회원 탈퇴
        private void btnDel_Click(object sender, EventArgs e)
        {
            string data = tbDelUserID.Text.ToString();
            Person_info_del Pid = new Person_info_del(data);
            Pid.ShowDialog();
        }
        //BOTTOM MENU EVENT

    }
}
