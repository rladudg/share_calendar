using Project_Maver.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Maver_켈린더
{
    public partial class JoinMembership : Form
    {

        public JoinMembership()
        {
            InitializeComponent();
            InitializeComboBoxes(); //연도와 월 목록을 초기화하고 숫자를 채워 넣는 함수
        }

        // 생년월일 설정

        private void InitializeComboBoxes()
        {
            cbYear.Items.Clear();
            cbMonth.Items.Clear();
            cbDay.Items.Clear();

            //1. 연도 설정
            for (int year = 1940; year <= 2020; year++)
            {
                cbYear.Items.Add(year);
            }

            //2. 월 설정 : 1월~12월
            for (int month = 1; month <= 12; month++)
            {
                cbMonth.Items.Add(month);
            }

        }

        // 사용자가 선택한 달에 따라 일(day)목록을 동적으로 변경하는 날짜 관리 로직
        private void UpdateDays()
        {
            // 연도와 월이 모두 선택되었는지 확인
            if (cbYear.SelectedItem == null || cbMonth.SelectedItem == null)
                return;


            // 콤보박스에 들어있는 값을 숫자로 계산하거나
            // 날짜 함수에 넣기 위해 정수형으로 변환시킨다.   
            int year = (int)cbYear.SelectedItem;
            int month = (int)cbMonth.SelectedItem;


            // 현재 선택되어 있는 '일'을 기억해둔다 (나중에 다시 선택해주기 위함)
            //사용자가 이미 날짜를 선택했다면, 월을 바꿨을 때 그 숫자를 기억해 둔다.
            int? currentSelectedDay = (int?)cbDay.SelectedItem;

            cbDay.Items.Clear();

            // 선택된 연도(year)와 월(month)의 마지막 날이 며칠인지 계산하고
            // daysInMonth 변수에 저장한다.(윤년도 자동으로 계산한다)
            int daysInMonth = DateTime.DaysInMonth(year, month);

            for (int day = 1; day <= daysInMonth; day++)
            {
                cbDay.Items.Add(day);
            }

            // 이전에 선택했던 날이 여전히 유효하다면 다시 선택해주고, 
            // 아니라면 첫 번째 항목(1일)을 선택한다.
            if (currentSelectedDay.HasValue && currentSelectedDay <= daysInMonth)
            {
                cbDay.SelectedItem = currentSelectedDay;
            }
            else
            {
                cbDay.SelectedIndex = 0;
            }
        }

        //가입 버튼 이벤트
        private void btnJoin_Click(object sender, EventArgs e)
        {
            // 1.텍스트 박스 입력 확인(모든 텍스트 박스에 내용이 적혀 있는지 검사한다)
            if (string.IsNullOrEmpty(txtId.Text) ||
                string.IsNullOrEmpty(txtPassWord.Text) ||
                string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtPhone.Text))

            {
                MessageBox.Show("모든 정보를 입력해주세요.");
                return;
            }

            //2. 비밀번호 일치 여부 확인
            if (txtPassWord.Text != txtPwCheck.Text)
            {
                MessageBox.Show("비밀번호와 비밀번호 확인이 일치하지 않습니다.");
                return;
            }

            //3. 생년월일 확인
            if (cbYear.SelectedItem == null || cbMonth.SelectedItem == null || cbDay.SelectedItem == null)
            {
                MessageBox.Show("생년월일을 모두 선택해주세요");
                return;
            }

            //4.약관 동의 확인
            if (!chkInfo.Checked)
            {
                MessageBox.Show("이용약관 및 개인정보 수집에 동의해야 가입이 가능합니다.");
                return;
            }

            // 데이터 가공 및 저장   
            // 각각 떨어져 있는 연, 월, 일 데이터를 하나의 문자열로 합치는 과정이다.
            string birth = $"{cbYear.SelectedItem}-{cbMonth.SelectedItem}-{cbDay.SelectedItem}";


            // 화면에 입력된 아이디, 비밀번호, 이름, 이메일, 생년월일, 전화번호를
            // JoinMember라는 클래스의 저장 함수로 전달합니다.

            bool result = JoinMember.InsertUser( // DBtest를 project_Maver로 바꿔야 한다. 
                txtId.Text,
                txtPassWord.Text,
                txtName.Text,
                txtEmail.Text,
                birth,
                txtPhone.Text);

            // DB 저장에 성공하면 true, 실패하면 false를 반환한다.
            if (result)
            {
                MessageBox.Show("회원가입 완료");
                this.Close();
            }
            else
            {
                MessageBox.Show("회원가입 실패");
            }

        }


        // 사용자가 연도를 클릭해서 다른 연도로 바꾸는 순간 실행
        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDays(); // 연도가 바뀌면 (윤년일 수 있으니)
                          // 날짜 목록을 다시 계산하도록 UpdateDays()를 호출
        }

        // 사용자가 월을 클릭해서 다른 월로 바꾸는 순간 실행됨
        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDays(); // 월이 바뀌면 (28, 30, 31일 중 하나로) 날짜 목록을 갱신합니다.
        }

        // *********서현 3월 11일 텍스트 박스에 정보를 입력하고 엔터를 누르면 밑의 입력 칸으로 커서가 바뀌는 코드 

        private void txtId_KeyDown(object sender, KeyEventArgs e) // 아이디 입력을 다하고 다음 커서로 이동
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtName.Focus(); // 이메일 입력 칸으로 이동
                e.SuppressKeyPress = true;
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)// 이름 입력 다하고 다음 커서로 이동
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e) // 이메일 입력 다하고 다음 커서로 이동
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassWord.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e) // 비밀번호 입력 다하고 다음 커서로 이동
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPwCheck.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPwCheck_KeyDown(object sender, KeyEventArgs e) // 비밀번호 확인 입력 다하고 다음 커서로 이동
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus();
                e.SuppressKeyPress = true;
            }
        }

        // 생년월일과 개인정보 체크박스는 사용자가 직접 눌러도 무방함

        private void txtPhone_KeyDown(object sender, KeyEventArgs e) // 생년월일과 폰 번호까지 입력 다하고 엔터를 누르면 자동으로 버튼 클릭 이벤트가 실행된다. 
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnJoin_Click(sender, e); // 가입하기 버튼 이벤트
                e.SuppressKeyPress = true;
            }
        }

        // 폼 디자인
        private void pnlInputGroup_Paint(object sender, PaintEventArgs e)
        {
            Panel pnl = sender as Panel;
            if (pnl == null) return;

            int borderRadius = 20;
            Color borderColor = Color.FromArgb(200, 200, 200);
            float borderWidth = 1.5f;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // 2. 핵심 수정: 하단과 오른쪽이 잘리지 않도록 -4 정도로 여유를 줍니다.
            // 0.5f 대신 1f에서 시작하는 게 테두리가 더 선명합니다.
            RectangleF rect = new RectangleF(1f, 1f, pnl.Width - 4, pnl.Height - 4);

            using (GraphicsPath path = GetRoundedRectanglePath(rect, borderRadius))
            {
                // 3. Region은 선보다 1픽셀 더 크게 잡아야 선이 안 깎입니다.
                pnl.Region = new Region(new Rectangle(0, 0, pnl.Width, pnl.Height));

                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
        private void pnlInputName_Paint(object sender, PaintEventArgs e)
        {
            Panel pnl = sender as Panel;
            if (pnl == null) return;

            int borderRadius = 15;
            Color borderColor = Color.FromArgb(200, 200, 200);
            float borderWidth = 1.0f;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // pnlInputGroup.Width라고 되어있던 부분을 pnl.Width로 수정했습니다.
            RectangleF rect = new RectangleF(1f, 1f, pnl.Width - 4, pnl.Height - 4);

            using (GraphicsPath path = GetRoundedRectanglePath(rect, borderRadius))
            {
                pnl.Region = new Region(new Rectangle(0, 0, pnl.Width, pnl.Height));

                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private GraphicsPath GetRoundedRectanglePath(RectangleF rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float r = radius;
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }

        
    }
}
