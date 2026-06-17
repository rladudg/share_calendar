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

namespace Project_Maver.View
{
    public partial class FindId : Form
    {
        public FindId()
        {
            InitializeComponent();
        }

        private void btnFindID_Click(object sender, EventArgs e)
        {
            // 1. 입력값 누락 확인
            if (String.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("이름과 이메일, 전화번호 모두 입력해주세요.");
                return;
            }

            // 2. JoinMember 클래스의 메서드 호출

            String foundId = JoinMember.FindUserId(txtName.Text, txtEmail.Text, txtPhone.Text);
            // JoinMember 클래스의 FindUserId 메서드에 텍스트 박스에 입력된 값들을 전달
            {
                // 3. 결과 처리
                if (foundId != null)
                {
                    MessageBox.Show($"{txtName.Text}님의 아이디는 [{foundId}] 입니다.");

                    //*****************서현****************************//
                    this.Close();
                    //************************************************//
                }

                else
                {
                    MessageBox.Show("일치하는 회원 정보가 없습니다.");
                }

            }

        }

        // 서현 - 3월 11일.
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFindID_Click(sender, e); // 이메일 찾기 버튼 기능 수행
                e.SuppressKeyPress = true;

            }
        }

        private void pnlIdFound_Paint(object sender, PaintEventArgs e)
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

        private void btnFindID_Paint(object sender, PaintEventArgs e)
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