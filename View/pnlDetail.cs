using maverCalender;
using Newtonsoft.Json;
using Project_Maver.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Maver.View
{
    public partial class pnlDetail : UserControl
    {
        PrivateFontCollection fonts = new PrivateFontCollection();
        public event Action OnUpdateParent;
        private int currentEventId;
        public pnlDetail()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pnlDetail_Load(object sender, EventArgs e)
        {
            string fontPath = Path.Combine(Application.StartupPath, "Fonts", "BMJUA_ttf.ttf");

            if (File.Exists(fontPath))
            {
                fonts.AddFontFile(fontPath);
               
                Font jua = new Font(fonts.Families[0], 12, FontStyle.Regular);

                lbDetailTitle.Font = jua;
                BorderHelper.SetRoundRegion(btnSang, 15);
                BorderHelper.ApplyDotBorder(btnSang);

            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int radius = 20;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            GraphicsPath roundPath = GetRoundRect(rect, radius);
            this.Region = new Region(roundPath);

            // 배경
            using (SolidBrush brush = new SolidBrush(this.BackColor))
                e.Graphics.FillPath(brush, roundPath);
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, roundPath);
            }

        }


        private static GraphicsPath GetRoundRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

            path.CloseFigure();

            return path;
        }
     


        // 승환(3/10)
        public void setData(int event_id, string title, string memo, string startDate, string endDate, string startTime, string endTime)
        {
            this.currentEventId = event_id;
            // MessageBox.Show($"데이터 확인: {title} / {memo}");
            lbDetailTitle.Text = title;
            lbDetailMemo.Text = memo;
            lbDetailStartDate.Text = startDate;
            lbDetailEndDate.Text = endDate;

            this.Invalidate();
            this.Update();
            this.Visible = true;
            this.BringToFront();
        }

        private void btnSang_Click(object sender, EventArgs e)
        {
            // 1. 상세 팝업 객체 생성
            detailPopup popup = new detailPopup();

            // 2. '보기' 모드로 설정 (수정/삭제 버튼 활성화)
            popup.setMode("View");
            popup.event_id = this.currentEventId;

            // 3. 현재 요약창에 떠 있는 텍스트들을 상세 팝업으로 전달 (매우 중요!)
            // 아래 레이블 이름(lbDetailTitle 등)은 실제 사용하시는 이름으로 확인하세요.
            popup.setDetailData(
                lbDetailTitle.Text,     // 제목
                lbDetailMemo.Text,      // 메모
                lbDetailStartDate.Text, // 시작일
                lbDetailEndDate.Text  // 종료일
            );

            if (popup.ShowDialog() == DialogResult.OK)
            {
                // 2. 부모에게 "새로고침해!"라고 신호 보냄
                OnUpdateParent?.Invoke();
                this.Hide(); // 수정 후 요약창은 닫아주는 게 깔끔합니다.
            }
        }
    }
}
