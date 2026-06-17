using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Util.Store;
using Maver_켈린더;
using Project_Maver.Common;
using Project_Maver.View;
using System.Drawing.Drawing2D;


namespace maverCalender
{
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
        }

        //로그인 클릭 이벤트
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtIdEmail2.Text; // 텍스트 박스에 아이디와 비밀번호를 입력하면 id와 pw에 저장한다.
            string pw = txtPassword2.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(pw))
            {
                MessageBox.Show("아이디와 비밀번호를 모두 입력해주세요.");
                return;
            }

            bool isSuccess = JoinMember.LoginCheck(id, pw);
            //JoinMember 로직을 호출해서 DB에 일치하는 회원이 있는지 확인한다. 

            if (isSuccess)
            {

                // 전역 변수 처럼 유저 아이디 값 입력 후 유저 정보를 저장한다.
                // 로그인에 성공하면 현재 사용자의 아이디를 UserSession을 통해 전역 변수로 저장된다.
                // 이러면 다른 화면에서도 누가 로그인 했는지 알 수 있다.
                UserSession.UserId = id;

                if (string.IsNullOrEmpty(UserSession.UserName))
                {
                    UserSession.UserName = id;
                }
                MessageBox.Show($"{UserSession.UserName}님, 환영합니다!");


                // 현재 로그인 창을 닫으면서 성공신호를 보낸다.
                this.DialogResult = DialogResult.OK;
                this.Close();
                //****************

                // 비밀번호 필드 초기화 (다시 돌아왔을 때 보안을 위해)
                txtPassword2.Clear();
            }

            else
            {
                // 5. 실패 시 메시지 처리
                MessageBox.Show("아이디(이메일) 또는 비밀번호를 다시 확인해주세요.", "로그인 실패");

                // 로그인 성공 후 로그아웃해서 다시 돌아오거나, 로그인에 실패했을 때 비밀번호 칸을 비워
                txtPassword2.Clear(); // 비번 칸 비워주기

                txtPassword2.Focus(); // 비번 칸에 커서 두기
            }
        }

        // 회원 가입 화면 이동
        // 회원 가입 링크버튼을 눌러서 실행한다.
        private void lklMember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1. 회원가입 폼 객체 생성
            JoinMembership joinForm = new JoinMembership();

            // 2. 창 띄우기
            // ShowDialog()는 가입 창이 닫힐 때까지 로그인 창을 조작할 수 없게 만듭니다.
            joinForm.ShowDialog();

            // 만약 가입 창을 띄우면서 로그인 창을 아예 숨기고 싶다면:
            // this.Hide();
            // joinForm.ShowDialog();
            // this.Show();
        }

        //아이디 찾기 화면 이동
        // 아이디 찾기 링크 버튼을 눌러서 실행한다.
        private void lklId_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1.아이디 찾기 폼 객체를 생성
            FindId fi = new FindId();

            // 창 띄우기
            fi.ShowDialog();
        }

        //비번 찾기 화면 이동
        // 비번 찾기 링크버튼을 눌러서 실행한다.
        private void lklPW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1.비번 찾기 폼 객체를 생성
            Findpw fpw = new Findpw();

            // 창 띄우기
            fpw.ShowDialog();
        }


        // 서현 - 3월 11일 아이디 입력 후 엔터 키를 눌러서 비밀번호 입력 칸으로 커서가 이동한다.
        private void txtIdEmail2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword2.Focus(); // 비밀번호 칸으로 커서 이동
                e.SuppressKeyPress = true;
            }

        }

        private void txtPassword2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e); // 로그인 버튼 클릭 호출
                e.SuppressKeyPress = true;
            }

        }

        private async void btnGoogle_Click(object sender, EventArgs e)
        {
            //구글 로그인(수영)
            /*토큰이 로컬에 저장되기 때문에 다음에는 자동인증되는걸 방지하기 위해
            삭제하고 다시 로그인하는 부분 추기*/
            string tokenDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "token");

            if (Directory.Exists(tokenDir))
            {
                Directory.Delete(tokenDir, true);
            }

            //구글 로그인 발급되는 인증정보를 토큰에 저장하는 객체
            UserCredential credential;
            //파일 경로를 합쳐준다(Common안에 있는걸 합쳐주는 함수)
            string path = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Common",
                "client_secrets.json");

            // 프로젝트 폴더에 넣어둔 'client_secrets.json' 파일을 읽어옵니다.
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                string[] scopes = { CalendarService.Scope.Calendar };

                // 구글 인증 브라우저를 띄웁니다.
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore("token.json", true));
            }

            MessageBox.Show("로그인 성공!");
        }

        /// 폼디자인
        private void pnlLogIn_Paint(object sender, PaintEventArgs e)
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

        private void btnLogIn_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            int borderRadius = 20;

            // 부드러운 선 설정
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(btn.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(btn.Width - borderRadius, btn.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, btn.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                path.CloseAllFigures();

                // 버튼 영역 제한
                btn.Region = new Region(path);

                // 배경색 채우기 (이미지처럼 회색빛 버튼을 원하시면 BackColor를 조정하세요)
                using (SolidBrush brush = new SolidBrush(btn.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 텍스트 그리기
                TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, btn.ClientRectangle, btn.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }
    }
}

