using maverCalender;
using Newtonsoft.Json;
using Project_Maver.Common;
using Project_Maver.View;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace Maver_켈린더
{
    public partial class Calendar : Form
    {

        PrivateFontCollection fonts = new PrivateFontCollection(); //폰트

        private int currentYear;        // 현재년도
        private int currentMonth;       // 현재 달
        private Color currentBgColor = Color.White;
        public Calendar()
        {
            InitializeComponent();

            tableLayoutPanel1.BringToFront();
            pnlCategori.BringToFront();
            flpMain.SendToBack();
            flpMain.Dock = DockStyle.None;

            currentYear = DateTime.Now.Year;
            currentMonth = DateTime.Now.Month;

            // 승환
            lbThisDate.Text = currentYear.ToString() + "." + currentMonth.ToString();
            if (pnlDt != null)
            {
                pnlDt.Visible = false;
            }
            pnlDt.OnUpdateParent += () =>
            {
                DisplayDays(currentYear, currentMonth);
                ApplySeasonColors(currentMonth);// 캘린더 새로고침
            };
        }


        private void Calendar_Load(object sender, EventArgs e)
        {

             GetWeather();
                      
            // 전역 변수 UserSession에서 아이디를 가져와 라벨에 표시
            if (UserSession.UserId != null)
            {
                lbID.Text = UserSession.UserId + "님 접속 중";
               
            }

            //영현
            RefreshTreeView();

            string checkSql = @"SELECT g.share_id
                                FROM share_group g
                                JOIN share_member m ON g.share_id = m.share_id
                                WHERE m.user_id = @id
                                GROUP BY g.share_id
                                HAVING COUNT(m.user_id) = 1";

            var param = new Dictionary<string, object> { { "@id", UserSession.UserId } };
            DataTable dtCheck = DbManager.select_Query(checkSql, param);

            if (dtCheck == null || dtCheck.Rows.Count == 0)
            {
                CreateDefaultCalendar();
            }

            // 은비 - 캘린더 그리기
            //lbThisDate.Text = "🌼 " + currentYear.ToString() + "." + currentMonth.ToString() + " 🌼";
            DisplayDays(currentYear, currentMonth);
             ApplySeasonColors(currentMonth);

            //수영 폰트 디자인
            string fontPath = Path.Combine(Application.StartupPath, "Fonts", "BMJUA_ttf.ttf");

            if (File.Exists(fontPath))
            {
                fonts.AddFontFile(fontPath);
                Font jua1 = new Font(fonts.Families[0], 16, FontStyle.Regular);
                Font jua2 = new Font(fonts.Families[0], 14, FontStyle.Regular);

                Label[] weekLabels = {
                    label2, label3, label4, label5, label6, label7, label8
                };

                foreach (Label lbl in weekLabels)
                {
                    BorderHelper.SetRoundRegion(lbl, 10);
                    lbl.Font = jua1;
                    lbl.Padding = new Padding(10, 5, 10, 5);
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                }                              

                btnLogInOut.Font = jua2;
                BorderHelper.SetRoundRegion(btnLogInOut, 18);
                BorderHelper.ApplyDotBorder(btnLogInOut);
                //btnLogInOut.Tag = Color.Silver;

                lbID.Font = jua2;

                btnUpdatepw.Font = jua2;
                BorderHelper.SetRoundRegion(btnUpdatepw, 18);
                BorderHelper.ApplyDotBorder(btnUpdatepw);
                //btnUpdatepw.Tag = Color.Silver;

                btnGoToday.Font = jua2;
                BorderHelper.SetRoundRegion (btnGoToday, 18);
                BorderHelper.ApplyDotBorder (btnGoToday);
                btnGoToday.Tag = new Tuple<Color, Color>(Color.Purple, Color.White);             
                
            }

        }
        public async Task GetWeather()
        {
            string apiKey = "c7772d91da4472af145add9c179343de";
            string cityName = "Cheonan";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=metric&lang=kr";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // API에 데이터 요청
                    string response = await client.GetStringAsync(url);

                    // JSON 데이터를 클래스 객체로 변환
                    WeatherInfo data = JsonConvert.DeserializeObject<WeatherInfo>(response);

                    // 화면에 표시 (레이블 등)
                    //lblCity.Text = data.Name;
                    lblTemp.Text = $"{Math.Round(data.Main.Temp, 1)} °C";
                    lblDesc.Text = data.Weather[0].Description;

                    string icon = data.Weather[0].Icon;
                    // 아이콘 이미지 불러오기 (이미지 URL 활용)
                    string iconUrl = $"https://openweathermap.org/img/wn/{data.Weather[0].Icon}@2x.png";
                    var stream = await client.GetStreamAsync(iconUrl);
                    pbWeather1.Image = Image.FromStream(stream);
                    pbWeather1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("날씨 정보를 가져오지 못했습니다: " + ex.Message);
                }
            }
        }


        private void CreateDefaultCalendar()
        {
            // 로그인 정보가 없으면 캘린더 데이터 생성 X
            if (string.IsNullOrEmpty(UserSession.UserId)) return;

            try
            {
                // 해당 유저의 캘린더가 있는지 확인
                string checkSql = "SELECT COUNT(*) FROM share_member WHERE user_id = @id";
                var checkParam = new Dictionary<string, object> { { "@id", UserSession.UserId } };

                DataTable dtCheck = DbManager.select_Query(checkSql, checkParam);

                if (dtCheck != null && dtCheck.Rows.Count > 0)
                {
                    if (Convert.ToInt32(dtCheck.Rows[0][0]) > 0)
                    {
                        // 존재하면 개인 캘린더 생성 중단
                        return;
                    }
                }

                //share_group 캘린더 생성
                string groupSql = "INSERT INTO share_group (share_name, color) VALUES (@name, @color); Select LAST_INSERT_ID(); ";
                var groupParam = new Dictionary<string, object>
                {
                //여기 만들면 두개 생김.
                    {"@name", "개인 캘린더" },
                    {"@color","#A0A0A0" }// 기본 회색 설정
                };
                DbManager.void_query(groupSql, groupParam);

                // 생성된 그룹 ID 가져오기
                string idSql = "SELECT LAST_INSERT_ID()";
                DataTable dtId = DbManager.select_Query(idSql, null);

                if (dtId != null && dtId.Rows.Count > 0)
                {
                    int newId = Convert.ToInt32(dtId.Rows[0][0]);

                    // share_member 추가
                    string memberSql = "INSERT INTO share_member(share_id, user_id, role) VALUES (@sid, @id, @role)";
                    var memberParam = new Dictionary<string, object>
                {
                    {"@sid", newId },
                    {"@id", UserSession.UserId },
                    {"@role", 1 } // 관리자
                };
                    DbManager.void_query(memberSql, memberParam);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("캘린더 생성 중 오류가 발생했습니다: " + ex.Message);
            }
        }



        //------------------------------------------------------------------------------------
        // 2026-03-09 영현 추가
        //------------------------------------------------------------------------------------
        bool isMenuOpen = false;
        private List<TreeNode> SelectedCalendars = new List<TreeNode>();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // 오버레이 패널과 사이드바 제어 시작
            if (!isMenuOpen)
            {
                pnlCategori.Left = 10;
                pnlCategori.Top = 70;
                isMenuOpen = true;
            }
            else
            {
                CloseMenu();
            }

            // tmrSideMenu.Start(); // 타이머 시작 (애니메이션 구동)
        }
        private void CloseMenu()
        {
            pnlCategori.Left = -300;
            isMenuOpen = false;
        }

        private void PictureBox2_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(215, 217, 219), 2))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, pictureBox2.Width, pictureBox2.Height);
            }
        }

        //makeShare랑 연결
        private void CalenderPlus_Click(object sender, EventArgs e)
        {
            // 캘린더 추가할때 로그인 여부 (로그인 안하면 캘린더 추가x)
            if (string.IsNullOrEmpty(UserSession.UserId))
            {
                MessageBox.Show("로그인이 필요합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 로그인된 경우 선택 가능
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("공용 캘린더 추가", null, (s, ev) => openMakeShareForm("공용"));
            menu.Show(CalenderPlus, new Point(0, CalenderPlus.Height));
            menu.Font = nodeFont;
            menu.ForeColor = Color.DimGray;

        }
        private void openMakeShareForm(string mode)
        {
            makeShare frm = new makeShare(mode);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                RefreshTreeView();
            }
        }

        // RefreshTreeView() >> 카테고리에 목록 집어넣음. 중요함!!!!!!!!!!!
        public void RefreshTreeView()
        {
            // 트리뷰 노드 찾기
            TreeNode privateRoot = treeView1.Nodes.Find("ndPrivate", true).FirstOrDefault();
            TreeNode publicRoot = treeView1.Nodes.Find("ndPublic", true).FirstOrDefault();
            if (privateRoot == null || publicRoot == null) return;

            privateRoot.Nodes.Clear();
            publicRoot.Nodes.Clear();

            // 로그인 되어있으면 '개인 캘린더' 추가
            if (!string.IsNullOrEmpty(UserSession.UserId))
            {
                TreeNode privateNode = new TreeNode("개인 캘린더");
                privateNode.ForeColor = Color.Linen;
                privateNode.Tag = "FIXED_PRIVATE" + UserSession.UserId; //고정 노드임을 식별 위한 태그
                privateRoot.Nodes.Add(privateNode);
            }

            // DB에서 내가 속한 캘린더 목록 가져오기
            string sql = @"
                SELECT 
                    g.share_id, 
                    g.share_name, 
                    g.color,
                    (SELECT COUNT(*) FROM share_member WHERE share_id = g.share_id) as member_count
                FROM share_group g
                JOIN share_member m ON g.share_id = m.share_id
                WHERE m.user_id = @id
                AND g.share_name != '개인 캘린더'"; // AND >> DB에 저장된 '개인 캘린더'는 무시

            var param = new Dictionary<string, object> { { "@id", UserSession.UserId } };
            try
            {
                DataTable dt = DbManager.select_Query(sql, param);

                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        int memberCount = Convert.ToInt32(row["member_count"]);
                        string hexColor = row["color"]?.ToString()?.Trim() ?? "#000000"; ////DB에서 색상 코드 가져옴

                        TreeNode sharedNode = new TreeNode(row["share_name"].ToString());

                        // 나중에 일정 조회할 때 필요
                        sharedNode.Tag = row["share_id"];

                        // DB에 저장된 HEX문자열을 Color객체로 변환하여 적용
                        try
                        {
                            if (!hexColor.StartsWith("#") && hexColor.Length == 6 && IsHexString(hexColor))
                                hexColor = "#" + hexColor;
                            sharedNode.ForeColor = ColorTranslator.FromHtml(hexColor);
                        }
                        catch
                        {
                            sharedNode.ForeColor = Color.DimGray; //예외 발생시 기본색
                        }
                        // 멤버가 나 포함 2명 이상일때만 '공용'목록에 추가
                        if (memberCount > 1)
                        {
                            publicRoot.Nodes.Add(sharedNode);
                        }
                        else
                        {
                            privateRoot.Nodes.Add(sharedNode);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("RefreshTreeView 에러: " + ex.Message);
            }
            treeView1.ExpandAll();
        }
        private bool IsHexString(string str)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str, @"\A\b[0-9a-fA-F]+\b\Z");
        }
        private Font nodeFont = new Font("Noto Sans KR", 15, FontStyle.Bold);
        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (e.Node == null || e.Bounds.IsEmpty) return;
            Color backColor = Color.Linen;
            Color textColor = Color.DimGray;
           

            // 텍스트 그리기
            e.Graphics.DrawString(e.Node.Text, nodeFont, Brushes.Black, e.Bounds.Left, e.Bounds.Top);

            // 리스트에 포함되어 있는지 확인
            
            bool isCustomBrush = false;

            if (SelectedCalendars.Contains(e.Node) && e.Node.Level == 2)
            {
                string parentText = e.Node.Parent?.Text ?? "";
                if (parentText == "개인")
                {
                    backColor = Color.SkyBlue;
                    isCustomBrush = true;
                }
                else if (parentText == "공용")
                {
                    Color dbColor = e.Node.ForeColor;
                    // 공용 캘린더 생성시 지정햇던 ForeColor를 배경색으로 사용
                    if (dbColor != Color.Empty && dbColor != Color.Transparent)
                    {
                        backColor = dbColor;

                    }
                }

                if (backColor.GetBrightness() < 0.4)
                {
                    textColor = Color.White;
                }
            }

            using (SolidBrush brush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            Rectangle textBounds = e.Bounds;
            textBounds.Offset(2, 0);
            TextRenderer.DrawText(e.Graphics, e.Node.Text, nodeFont ?? treeView1.Font, e.Bounds, textColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
        }
        private void cmsCalendar_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // 현재 선택된 노드 확인
            TreeNode selectedNode = treeView1.SelectedNode;

            if (selectedNode == null || selectedNode.Tag == null)
            {
                e.Cancel = true;
                return;
            }

            if (selectedNode.Text == "개인 캘린더")
            {
                e.Cancel = true;
                return;
            }

            int shareId = Convert.ToInt32(selectedNode.Tag);
            string currentUserId = UserSession.UserId;

            string sql = "SELECT role FROM share_member WHERE share_id = @sid AND user_id = @id";
            var param = new Dictionary<string, object>
            {
                {"@sid", shareId },
                {"@id", currentUserId }
            };

            DataTable dt = DbManager.select_Query(sql, param);

            if (dt != null && dt.Rows.Count > 0)
            {
                int role = Convert.ToInt32(dt.Rows[0]["role"]);

                if (role == 1)
                {
                    tsmDelete.Visible = true;
                    tsmExit.Visible = false;
                }
                else
                {
                    tsmDelete.Visible = false;
                    tsmExit.Visible = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeView1.SelectedNode = e.Node;
            }

            if (e.Node.Level < 2) return;
            // 선택 or 해제 캘린더
            if (e.Button == MouseButtons.Left)
            {
                if (SelectedCalendars.Contains(e.Node))
                {
                    // 이미 선택된 노드 클릭 >>> 선택 해제
                    SelectedCalendars.Remove(e.Node);
                }
                else
                {
                    // 새로운 노드 클릭 >> 선택
                    SelectedCalendars.Add(e.Node);
                }
                treeView1.Invalidate();

                // 선택된 캘린더들의 일정을 새로 불러오는 함수 호출
                // ex)) DispalyDays (currentYear, currentMonth); 
            }

        }
        // 그룹 제거
        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null || treeView1.SelectedNode.Tag == null) return;

            int shareId = Convert.ToInt32(treeView1.SelectedNode.Tag);
            string shareName = treeView1.SelectedNode.Text;

            if (MessageBox.Show($"[{shareName}] 캘린더를 삭제하시겠습니까?" +
                "\n*모든 멤버의 목록에서 사라집니다.", "캘린더 제거", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //자식 테이블 먼저 삭제
                    string delMemberSql = "DELETE FROM share_member WHERE share_id = @sid";
                    //부모 테이블 데이터 삭제
                    string delGroupSql = "DELETE FROM share_group WHERE share_id = @sid";

                    var param = new Dictionary<string, object> { { "@sid", shareId } };
                    DbManager.void_query(delMemberSql, param);
                    DbManager.void_query(delGroupSql, param);

                    MessageBox.Show("캘린더가 성공적으로 제거되었습니다.");

                    RefreshTreeView(); // 트리뷰 갱신
                }
                catch (Exception ex)
                {
                    MessageBox.Show("삭제 중 오류가 발생했습니다: " );
                }
            }
        }
        //그룹 탈퇴
        private void tsmExit_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null || treeView1.SelectedNode.Tag == null) return;

            int shareId = Convert.ToInt32(treeView1.SelectedNode.Tag);
            string shareName = treeView1.SelectedNode.Text;

            if (MessageBox.Show($"[{shareName}] 캘린더에서 탈퇴하시겠습니까?", "캘린더 탈퇴", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string exitSql = "DELETE FROM share_member WHERE share_id = @sid AND user_id = @id";
                    var param = new Dictionary<string, object>
                    {
                        {"@sid", shareId },
                        {"@id", UserSession.UserId }
                    };

                    DbManager.void_query(exitSql, param);

                    MessageBox.Show("탈퇴하였습니다.");

                    RefreshTreeView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("탈퇴 처리 중 오류가 발생했습니다: " + ex.Message);
                }
            }
        }

        //---------------------------------------------------
        // 2026-03-09 은비 - 캘린더 화면구현
        // 2026-03-10 은비 - 공휴일 추가
        //---------------------------------------------------

        private void DisplayDays(int year, int month)
        {

            flpMain.SuspendLayout();
            flpMain.Controls.Clear();

            DateTime startOfMonth = new DateTime(year, month, 1);
            int startDayOfWeek = (int)startOfMonth.DayOfWeek;
            int lastDay = DateTime.DaysInMonth(year, month);

            // 데이터 로딩
            Holidays holidays = new Holidays();
            var holidayDict = holidays.getHolidays(year);

            DataTable userEvents = null;
            if (UserSession.UserId != null)
            {
                pbProfile.Visible = true;
                lbID.Visible = true;
                btnUpdatepw.Visible = true;
                userEvents = select_events(UserSession.UserId);
                pbSearch.Visible = true;
            }
            else
            {
                pbProfile.Visible = false;
                lbID.Visible = false;
                btnUpdatepw.Visible = false;
                pbSearch.Visible = false;
            }
            // 1. 달력 시작 전 빈칸 추가
            for (int i = 0; i < startDayOfWeek; i++)
            {
                UserControl day = new DayUserControl();
                day.Margin = new Padding(0);
                day.Padding = new Padding(3);
                flpMain.Controls.Add(day);
                day.BorderStyle = BorderStyle.None;
            }

            //수영 0312추가--------------------------------------------------------
            Dictionary<string, int> multiDaySlots = new Dictionary<string, int>();
            int nextSlot = 0;
            //----------------------------------------------------------

            // 2. 실제 날짜 칸 생성
            for (int i = 1; i <= lastDay; i++)
            {
                DateTime currDate = new DateTime(year, month, i);
                DayUserControl duc = new DayUserControl(i, currDate);
                duc.Tag = currDate;

                // 휴일 및 주말 색상 설정
                if (holidayDict.ContainsKey(currDate)) duc.SetHoliday(holidayDict[currDate]);
                else if (currDate.DayOfWeek == DayOfWeek.Sunday) duc.SetColorRed();
                else if (currDate.DayOfWeek == DayOfWeek.Saturday) duc.SetColorBlue();

                // 현재 날짜에 해당하는 일정만 메모리에서 필터링
                if (userEvents != null && userEvents.Rows.Count > 0)
                {
                    var todayEvents = userEvents.AsEnumerable().Where(r =>
                    {
                        DateTime start = Convert.ToDateTime(r["start_date"]).Date;
                        DateTime end = Convert.ToDateTime(r["end_date"]).Date;
                        string repeatType = r["repeat_type"]?.ToString();

                        bool isInRange = currDate.Date >= start && currDate.Date <= end;
                        bool isReapeatDay = !string.IsNullOrEmpty(repeatType) && IsRepeatEvent(r, currDate);

                        return isInRange || isReapeatDay;


                    });
                    //수영 0312추가---------------------------------------------------------------
                    
                    foreach (var row in todayEvents)
                    {
                        string title = row["title"].ToString();
                        Color eventColor = StringToColor(row["color"].ToString());
                        DateTime start = Convert.ToDateTime(row["start_date"]).Date;
                        DateTime end = Convert.ToDateTime(row["end_date"]).Date;
                        string repeatType = row["repeat_type"]?.ToString();
                        bool hasRepeat = !string.IsNullOrEmpty(repeatType);
                        bool isSingleDay = hasRepeat ? true : (start == end);

                        if (!isSingleDay)
                        {
                            // 처음 등장하는 연속일정이면 슬롯 번호 부여
                            if (!multiDaySlots.ContainsKey(title))
                                multiDaySlots[title] = nextSlot++;

                            int slot = multiDaySlots[title];

                            // 이 칸에 slot번째 줄까지 placeholder 채우기
                            while (duc.GetMultiSlotCount() < slot)
                                duc.addPlaceholder();
                        }

                        bool isStartDay = (currDate.Date == start) || (hasRepeat && IsRepeatEvent(row, currDate));
                        duc.addTitleLabel(isStartDay ? title : "", eventColor, isSingleDay);
                    }
                    //-----------------------------------------------------------------

                }

                if(UserSession.UserId != null)
                {
                    // 클릭 이벤트 연결
                    duc.Click += (s, e) =>
                    {
                        detailPopup popup = new detailPopup { selectedDate = currDate };
                        popup.ThemeColor = currentBgColor;
                        popup.setMode("Add");
                        
                        if (popup.ShowDialog() == DialogResult.OK) DisplayDays(currentYear, currentMonth);
                    };

                    // 승환 - 상세정보 이벤트
                    duc.TitleLabelClicked += (title) =>
                    {
                        DataTable dt = GetScheduleDetail(title, currDate);
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            DataRow r = dt.Rows[0];
                            pnlDt.setData(Convert.ToInt32(r["event_id"]), r["title"].ToString(), r["memo"].ToString(),
                                Convert.ToDateTime(r["start_date"]).ToString("yyyy-MM-dd"),
                                Convert.ToDateTime(r["end_date"]).ToString("yyyy-MM-dd"),
                                r["start_time"].ToString(), r["end_time"].ToString());
                            ShowDetailPanel(duc, title);
                        }
                    };
                }


                flpMain.Controls.Add(duc);
            }

            flpMain.ResumeLayout();
            lbThisDate.Text = $"{year}.{month}";


        }

        //==========================================================================[
        //수영 추가
        private bool IsRepeatEvent(DataRow row, DateTime currDate)
        {
            if (row["repeat_type"] == DBNull.Value || row["repeat_type"].ToString() == "")
                return false;

            string type = row["repeat_type"].ToString();

            DateTime start = Convert.ToDateTime(row["start_date"]);

            DateTime end = DateTime.MaxValue;
            if (row["repeat_end_date"] != DBNull.Value)
                end = Convert.ToDateTime(row["repeat_end_date"]);

            if (currDate < start || currDate > end)
                return false;

            // 매주 반복
            if (type == "매주")
            {
                // 매주 반복
                if (type == "매주")
                {
                    int interval = row["repeat_interval"] == DBNull.Value ? 1 : Convert.ToInt32(row["repeat_interval"]);
                    int repeatDays = Convert.ToInt32(row["repeat_days"]);

                    // 2. 오늘이 해당 요일인지 확인
                    bool isCorrectDay = (repeatDays & (1 << (int)currDate.DayOfWeek)) != 0;

                    // 3. start 날짜가 아직 안 되었으면 false
                    if (currDate < start) return false;

                    // 4. 주(week) 차이 계산
                    // 두 날짜 사이의 전체 일수를 7로 나누어 몇 주가 지났는지 계산
                    int weeksDiff = (int)(currDate.Date - start.Date).TotalDays / 7;

                    // 5. 간격(interval) 확인
                    bool isCorrectInterval = (weeksDiff % interval == 0);

                    return isCorrectDay && isCorrectInterval;
                }
            }

            // 매월 반복
            if (type == "매월")
            {
                int interval = row["repeat_interval"] == DBNull.Value ? 1 : Convert.ToInt32(row["repeat_interval"]);

                if (currDate < start) return false;

                bool isSameDay = currDate.Day == start.Day;

                int monthsDiff = ((currDate.Year - start.Year) * 12) + currDate.Month - start.Month;
                bool isCorrectInterval = (monthsDiff % interval == 0);

                return isSameDay && isCorrectInterval;
            }

            // 매년 반복
            if (type == "매년")
            {
                return currDate.Month == start.Month &&
                      currDate.Day == start.Day &&
                       currDate >= start;
            }

            return false;
        }
        private DataTable select_events(string id)
        {
            string sql = " select * from events where user_id = @id or share_id in(select share_id from share_member where user_id = @id) ";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("id", UserSession.UserId);

            return DbManager.select_Query(sql, param);
        }

        public Color StringToColor(string colorString)
        {
            if (string.IsNullOrEmpty(colorString)) return Color.Coral;

            try
            {
                // 1. "Color [SkyBlue]" 같은 이름 형식 처리
                if (!colorString.Contains("=") && colorString.Contains("["))
                {
                    string colorName = colorString.Split('[', ']')[1];
                    return Color.FromName(colorName);
                }

                // 2. "Color [A=255, R=255, G=128, B=128]" 같은 ARGB 형식 처리
                // 정규식으로 숫자만 추출합니다.
                MatchCollection matches = Regex.Matches(colorString, @"\d+");
                if (matches.Count >= 3)
                {
                    int a = matches.Count == 4 ? int.Parse(matches[0].Value) : 255;
                    int r = matches[matches.Count - 3].Value.GetHashCode(); // 안전하게 뒤에서부터 참조
                    int g = matches[matches.Count - 2].Value.GetHashCode();
                    int b = matches[matches.Count - 1].Value.GetHashCode();

                    // 실제 숫자로 변환
                    int finalA = matches.Count == 4 ? int.Parse(matches[0].Value) : 255;
                    int finalR = int.Parse(matches[matches.Count - 3].Value);
                    int finalG = int.Parse(matches[matches.Count - 2].Value);
                    int finalB = int.Parse(matches[matches.Count - 1].Value);

                    return Color.FromArgb(finalA, finalR, finalG, finalB);
                }
            }
            catch
            {
                // 파싱 실패 시 기본색
                return Color.Coral;
            }

            return Color.Coral;
        }


        //==========================================================================[


        // 승환 aaa
        private DataTable GetScheduleDetail(string title, DateTime date)
        {
            string sql = @"SELECT event_id, title, memo, start_date, end_date, start_time, end_time, 
                   repeat_type, repeat_start_date, repeat_end_date, repeat_days, repeat_interval, color
                   FROM events 
                   WHERE TRIM(title) = @title 
                   ORDER By event_id DESC";

            var param = new Dictionary<string, object> { { "@title", title.Trim() } };
            DataTable dt = DbManager.select_Query(sql, param);

            string debugInfo = ""; // 디버깅용 텍스트 저장

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string rType = row["repeat_type"]?.ToString().Trim().ToLower() ?? "";
                    DateTime dbStartDate = Convert.ToDateTime(row["start_date"]);

                    string dbDateStr = dbStartDate.ToString("yyyy-MM-dd");
                    string clickDateStr = date.ToString("yyyy-MM-dd");

                    // 디버깅 정보 쌓기
                    debugInfo += $"- DB날짜: [{dbDateStr}], 반복타입: [{rType}]\n";

                    // 1. 일반 일정 (타입이 없거나, none이거나, 공백일 때)
                    if (string.IsNullOrEmpty(rType) || rType == "none" || rType == "-") // [수정됨: "-" 추가]
                    {
                        if (dbDateStr == clickDateStr)
                        {
                            return CreateSingleRowTable(row);
                        }
                    }
                    // 2. 반복 일정
                    else if (IsRepeatEvent(row, date))
                    {
                        DataTable copyTable = row.Table.Clone();
                        DataRow newRow = copyTable.NewRow();
                        newRow.ItemArray = row.ItemArray.Clone() as object[];
                        newRow["start_date"] = date.Date;
                        newRow["end_date"] = date.Date;
                        copyTable.Rows.Add(newRow);
                        return copyTable;
                    }
                }
            }

            // [중요] 여기까지 왔다는 건 루프를 다 돌았는데 if문에 한 번도 안 걸렸다는 뜻!
            MessageBox.Show(
                $"조회된 {dt?.Rows.Count ?? 0}건 중 일치하는 항목 없음\n\n" +
                $"[사용자가 클릭한 정보]\n제목: [{title}]\n날짜: [{date:yyyy-MM-dd}]\n\n" +
                $"[DB에서 가져온 실제 데이터들]\n{debugInfo}",
                "디버깅 모드", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return null;
        }

        //수영_______________________________________________________
        // 찾은 Row 하나만 담은 DataTable을 반환하는 헬퍼 함수
        private DataTable CreateSingleRowTable(DataRow row)
        {
            DataTable copyDt = row.Table.Clone();
            copyDt.ImportRow(row);
            return copyDt;
        }
        //--------------------------------------------------------------]
        // 은비 - 추가
        // 오늘 날짜로 찾아가는 버튼
        private void btnGoToday_Click_1(object sender, EventArgs e)
        {
            int todayYear = DateTime.Today.Year;
            int todayMonth = DateTime.Today.Month;

            currentYear = todayYear;
            currentMonth = todayMonth;

            DisplayDays(currentYear, currentMonth);
            ApplySeasonColors(currentMonth);

        }

        // 전 달로 가는버튼 <
        private void btnBeforeDate_Click(object sender, EventArgs e)
        {
            currentMonth--;
            if (currentMonth < 1)
            {
                currentMonth = 12;
                currentYear--;
            }
            //lbThisDate.Text = "🌼 " + currentYear.ToString() + "." + currentMonth.ToString() + " 🌼";
            DisplayDays(currentYear, currentMonth);
            ApplySeasonColors(currentMonth);
        }

        // 다음 달로 가는버튼 >
        private void btnAfterDate_Click(object sender, EventArgs e)
        {
            currentMonth++;
            if (currentMonth > 12)
            {
                currentMonth = 1;
                currentYear++;
            }
            //lbThisDate.Text = "🌼 " + currentYear.ToString() + "." + currentMonth.ToString() + " 🌼";

            DisplayDays(currentYear, currentMonth);
            ApplySeasonColors(currentMonth);
        }
        // 수영 0313 추가
        private void ApplySeasonColors(int month)
        {
            Color bgColor, ducColor1, todayColor,daysColor;

            switch (currentMonth)
            {
                case 12: case 1: case 2:
                    bgColor = Color.White;
                    ducColor1 = Color.LightGray;
                    todayColor = Color.DimGray;
                    daysColor = Color.WhiteSmoke;
                    break;
                case 3:
                case 4:
                case 5: // 봄
                    bgColor = Color.Snow;          // 연한 분홍
                    ducColor1 = Color.MistyRose;
                    todayColor = Color.Pink;
                    daysColor = Color.Linen;
                    break;
                case 6:
                case 7:
                case 8: // 여름
                    bgColor = Color.Azure;              // 연한 하늘
                    ducColor1 = Color.PowderBlue;
                    todayColor = Color.DeepSkyBlue;
                    daysColor = Color.PaleTurquoise; 
                    break;
                case 9:
                case 10:
                case 11: // 가을
                    bgColor = Color.OldLace;                // 베이지 계열
                    ducColor1 = Color.Wheat;
                    todayColor = Color.Tan;
                    daysColor = Color.PeachPuff;
                    break;
                default:
                    bgColor = Color.White;
                    ducColor1 = Color.LightGray;
                    todayColor= Color.Gray;
                    daysColor = Color.Silver;
                    break;
            }
            this.BackColor= bgColor;
            currentBgColor= bgColor;
            
            Label[] weekLabels = {
                     label3, label4, label5, label6, label7
                };

            foreach (Label lbl in weekLabels)
            {
                lbl.BackColor = daysColor;
            }

            foreach (Control ctrl in flpMain.Controls)
            {
                if(ctrl is DayUserControl dayCtrl)
                {
                    dayCtrl.ColorChange(ducColor1,todayColor);
                }
            }

        }

        // 서현 - 로그인, 로그아웃 추가
        // 현재 UserSession에 저장된 아이디가 있는지 확인하여 화면의 글자들을 바꿔주는 역할을 한다.
        private void UpdateLoginLogout()
        {

            if (string.IsNullOrEmpty(UserSession.UserId))
            {
                // 1. 로그아웃 상태
                lbID.Text = "로그인 해주세요";
                btnLogInOut.Text = "로그인";

                RefreshTreeView();
            }
            else
            {
                lbID.Text = $"{UserSession.UserName}님 환영합니다!";
                btnLogInOut.Text = "로그아웃";

                RefreshTreeView(); //영현
            }


            // 은비 - 로그인 로그아웃시에 캘린더 다시 불러오기
            int todayYear = DateTime.Today.Year;
            int todayMonth = DateTime.Today.Month;

            currentYear = todayYear;
            currentMonth = todayMonth;
           //lbThisDate.Text = "🌼" + currentYear.ToString() + "." + currentMonth.ToString() + "🌼";
            DisplayDays(currentYear, currentMonth);
            ApplySeasonColors(currentMonth);
        }


        //시작하고 로그인 버튼 누를 시 발생하는 이벤트, 로그인 화면 이동
        private void btnLogInOut_Click(object sender, EventArgs e)
        {
            if (btnLogInOut.Text == "로그인")
            {
                // 로그인 창 띄우기
                logIn lin = new logIn();
                lin.ShowDialog();

                //로그인 창이 닫히면(성공/실패 여부 상관없이) 새로고침
                //UI 새로고침
                UpdateLoginLogout();
                
            }

            else
            {
                //로그아웃 확인 창 띄우기
                if (MessageBox.Show("로그아웃 하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // 세션 정보 초기화 및 UI복구
                    UserSession.UserId = null;


                    UpdateLoginLogout();
                    MessageBox.Show("성공적으로 로그아웃되었습니다.");
                }

            }
        }
        pnlDetail pnlDt = new pnlDetail();
        //수영
        public void ShowDetailPanel(DayUserControl day, string title)
        {
            if (!this.Controls.Contains(pnlDt)) { this.Controls.Add(pnlDt); }
            // DayUserControl 위치를 Form 기준 좌표로 변환
            Point pos = day.Parent.PointToScreen(day.Location);
            pos = this.PointToClient(pos);

            // 패널 위치 (오른쪽 아래)
            pnlDt.Location = new Point(
                pos.X + day.Width / 2,
                pos.Y + day.Height / 2
            );

            // 상세정보 표시
            //lblDetailTitle.Text = title;

            pnlDt.Visible = true;
            pnlDt.BringToFront();
        }

        ////// 영현이가 검색버튼 햇서여
        private void pbSearch_Click(object sender, EventArgs e)
        {
            SearchEventForm searchForm = new SearchEventForm();
            searchForm.ShowDialog();
        }

        // 일정 검색해서 찾은 날 포커싱
        public void focusSearchEvents(DateTime targetDate)
        {
            // 1. 해당 연/월로 이동
            currentYear = targetDate.Year;
            currentMonth = targetDate.Month;

            // 2. 화면 다시 그리기
            //lbThisDate.Text = "🌼" + currentYear.ToString() + "." + currentMonth.ToString() + "🌼";
            DisplayDays(currentYear, currentMonth);
            ApplySeasonColors(currentMonth);

            // 3. 생성된 날짜 칸(DayUserControl)들 중에서 해당 날짜 찾아서 포커스
            foreach (Control control in flpMain.Controls)
            {
                if (control is DayUserControl duc && duc.Tag != null)
                {
                    // 각 날짜에 태그값 추가
                    DateTime ducDate = (DateTime)duc.Tag;

                    if (ducDate.Date == targetDate.Date)
                    {
                        //duc.BorderStyle = Color.LightSteelBlue;
                        duc.Focus(); // 컨트롤에 포커스 주기
                        break;
                    }
                }
            }
        }
        // 서현 - 비밀번호 변경화면으로 이동
        private void btnUpdatepw_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserSession.UserId))
            {
                MessageBox.Show("로그인이 필요합니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Updatepw upw = new Updatepw(UserSession.UserId);
            upw.ShowDialog();
        }


        public class ScheduleData
        {
            public string title { get; set; }
            public string memo { get; set; }
            public DateTime startDate { get; set; }
            public DateTime endDate { get; set; }
            public DateTime startTime { get; set; }
            public DateTime endTime { get; set; }
            public DateTime ScheduleDate { get; set; }
        }
 
    }
    
}
