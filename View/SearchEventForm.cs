using Maver_켈린더;
using Project_Maver.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_Maver.View
{
    /*
        2026.03.10 은비 화면 생성
     */

    public partial class SearchEventForm : Form
    {
        PrivateFontCollection fonts = new PrivateFontCollection();
        public SearchEventForm()
        {
            init();
        }

        private void init()
        {
            InitializeComponent();
            // 시작날짜 디폴트 선택
            rbStartDate.Checked = true;
            dgvEvents.AllowUserToAddRows = false;
        }

        // 검색 버튼
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchData();
        }

        private void searchData(string titleParam = null)
        {

            string title = "";
            string fromDate = dtpFromDate.Text;
            string toDate = dtpToDate.Text;

            Dictionary<string, Object> param = new Dictionary<string, Object>();

            string sql = " select event_id, title, start_date, end_date, DATE_FORMAT(start_time, '%H:%i') as start_time, DATE_FORMAT(end_time, '%H:%i') as end_time, b.share_name "
                       + " from events a left join share_group b on a.share_id = b.share_id"
                       + " where 1=1 and user_id = @userId";

            //param.Add("userId", "0000");
            param.Add("userId", UserSession.UserId);


            // 일정명 입력했을경우 
            if (txtSearchTitle.Text != null && !(txtSearchTitle.Text.Equals("")))
            {
                title = "%" + txtSearchTitle.Text + "%";
                sql += " and title like @title";

                param.Add("title", title);

            }

            if (fromDate != null || toDate != null)
            {
                // 시작날짜를 선택
                if (rbStartDate.Checked)
                {
                    sql += " and start_date between @fromDate and @toDate order by start_date ";
                }
                // 종료날짜를 선택
                else if (rbEndDate.Checked)
                {
                    sql += " and end_date between @fromDate and @toDate order by end_date ";
                }
            }
            else
            {
                toDate = DateTime.Today.ToShortDateString();
                fromDate = DateTime.Today.AddDays(-3).ToShortDateString();
            }
            param.Add("fromDate", fromDate);
            param.Add("toDate", toDate);


            DataTable dt = DbManager.select_Query(sql, param);

            if (dt != null || dt.Rows.Count > 0)
            {
                makeTable(dt);
            }
            else
            {
                MessageBox.Show("검색 된 결과가 없습니다.");
                dgvEvents.DataSource = null;
            }
        }

        // 테이블 만들기
        private void makeTable(DataTable dt)
        {
            dgvEvents.DataSource = dt;
            dgvEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvEvents.Columns["title"].HeaderText = "일정명";
            dgvEvents.Columns["start_date"].HeaderText = "시작날짜";
            dgvEvents.Columns["end_date"].HeaderText = "종료날짜";
            dgvEvents.Columns["start_time"].HeaderText = "시작시간";
            dgvEvents.Columns["end_time"].HeaderText = "종료시간";
            dgvEvents.Columns["share_name"].HeaderText = "공유캘린더명";

            // 일정아이디 일단 받아놓고 숨겨둠
            if (dgvEvents.Columns.Contains("event_id"))
            {
                dgvEvents.Columns["event_id"].Visible = false;
            }

        }

        // 닫기버튼
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // 클릭한 일정의 캘린더로
        private void dgvEvents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0) return; // 헤더 클릭 안되게

            //string cellNm = "";
            //// 시작날짜를 선택
            //if (rbStartDate.Checked)
            //{
            //    cellNm = "start_date";
            //}
            //// 종료날짜를 선택
            //else if (rbEndDate.Checked)
            //{
            //    cellNm = "end_date";
            //}

            //string dateStr = dgvEvents.Rows[e.RowIndex].Cells[cellNm].Value.ToString();

            //DateTime targetDate = Convert.ToDateTime(dateStr);

            //// 2. 메인 캘린더 폼 인스턴스 찾기
            //if (Application.OpenForms["Calendar"] is Calendar mainCal)
            //{
            //    mainCal.focusSearchEvents(targetDate); // 메인 폼에 만든 메서드 호출
            //}

        }

        private void SearchEventForm_Load(object sender, EventArgs e)
        {
            string fontPath = Path.Combine(Application.StartupPath, "Fonts", "BMJUA_ttf.ttf");

            if (File.Exists(fontPath))
            {
                fonts.AddFontFile(fontPath);
                Font jua1 = new Font(fonts.Families[0], 16, FontStyle.Regular);
                Font jua2 = new Font(fonts.Families[0], 12, FontStyle.Regular);


                //btnSearch.Font = jua2;
                btnClose.Font = jua2;
                BorderHelper.SetRoundRegion(btnSearch, 18);
                BorderHelper.ApplyDotBorder(btnSearch); 
                BorderHelper.SetRoundRegion(btnClose, 18);
                BorderHelper.ApplyDotBorder(btnClose);
            }
        }
    }
}
