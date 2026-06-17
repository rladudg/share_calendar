using MySql.Data.MySqlClient; // DB연결을 위해 필요하다
using Project_Maver.Common;
using Project_Maver.Common;  // DbManager, 전역변수 UserSession사용
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail; // 메일 발송에 필요한 문구
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Project_Maver.View
{
    public partial class Findpw : Form
    {
        public Findpw()
        {
            InitializeComponent();
        }

        private void btnFindPW_Click(object sender, EventArgs e)
        {
            // 서현 수정함 이번엔 JoinMember클래스를 사용하지 않고 여기서 직접 데이터베이스를 불러옴

            // 아이디, 이메일 입력 확인
            string inputID = txtId1.Text.Trim();
            string inputEmail = txtEmail1.Text.Trim();
            // Trim(): 사용자가 아이디 앞뒤에 실수로 넣은 공백을 자동으로 제거해준다.

            // @가 없을 때 메세지 알림(이거 3월 10일 오후 4시에 수정함)
            if (!inputEmail.Contains("@"))
            {
                MessageBox.Show("이메일 형식을 올바르게 입력해주세요.\n예: example@gmail.com");
                return;
            }

            // 1. 입력 검증
            if (string.IsNullOrEmpty(inputID) || string.IsNullOrEmpty(inputEmail))
            {
                MessageBox.Show("아이디와 이메일을 모두 입력해주세요");
                return;
            }

            // DB 조회
            string checkSql = "SELECT * FROM user WHERE id = @id AND email = @email";
            Dictionary<string, object> checkParams = new Dictionary<string, object>
            {
                {"@id", inputID},
                {"@email", inputEmail}
            };

            DataTable dt = DbManager.select_Query(checkSql, checkParams);


            if (dt.Rows.Count > 0)
            {
                // 2.임시 비밀번호 생성(6자리 숫자 + 문자)
                string tempPw = CreateRandomPassword(6);

                // 3. 비밀번호 업데이트

                string updateSql = "UPDATE user SET pw = @pw WHERE id = @id";
                Dictionary<string, object> updateParams = new Dictionary<string, object>
                {
                    {"@pw", tempPw},
                    {"@id", inputID}
                };

                int result = DbManager.void_query(updateSql, updateParams);


                // 이메일 발송 연동 로직
                if (result > 0)
                {
                    // 실제 메일을 보내는 함수를 호출
                    if (SendEmail(inputEmail, tempPw))
                    {
                        //성공 시
                        MessageBox.Show($"{inputEmail} 메일로 임시 비밀번호를 발송했습니다.\n 확인 후 로그인 해 주세요.", "발송 성공");
                        this.Close();
                    }

                    else
                    {
                        //실패 시
                        MessageBox.Show($"메일 발송에 실패했습니다. \n 화면에 임시 비밀번호를 띄우겠습니다. 메모해주세요. \n\n 임시 비번 : [{tempPw}]", "알림");
                        this.Close();
                    }
                }
            }
        }

        private bool SendEmail(string toEmail, string tempPw)
        {
            try
            {
                //네이버 메일
                SmtpClient smtp = new SmtpClient("smtp.naver.com", 587); // 587은 네이버 포트 번호이다.
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;

                //직접 만든 임시 메일, 그리고 내정보 → 보안설정 -> 2단계 인증 들어가기-> 아이디의 비번 입력 -> 앱 비밀번호 생성으로 12자리 앱 비번을 만들었다. 
                //종류 입력에서 MaverSMTP라고 설정했다.
                smtp.Credentials = new NetworkCredential("jdhem334", "1HRQB7JCJLJV");


                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("jdhem334@naver.com", "Maver 관리자");
                mail.To.Add(toEmail);
                mail.Subject = "[Project Maver] 임시 비밀번호 발급 안내";
                mail.Body = $"안녕하세요. {toEmail}님.\n요청하신 임시 비밀번호는 [{tempPw}] 입니다.\n보안을 위해 로그인 후 즉시 비밀번호를 변경해주세요.";

                smtp.Send(mail);
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message + "\n" + ex.StackTrace);
                return false;
            }

        }


        // 랜덤 비밀번호 생성기
        private string CreateRandomPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder result = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                result.Append(chars[rnd.Next(chars.Length)]);
            }

            return result.ToString();
        }

        // 서현 - 3월 11일.
        private void txtId1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail1.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtEmail1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFindPW_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }


        /// 폼 디자인 부분
        private void pnlFindpw_Paint(object sender, PaintEventArgs e)
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
