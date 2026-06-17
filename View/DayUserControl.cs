using Project_Maver.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Maver.View
{
    public partial class DayUserControl : UserControl
    {
        
        public enum ScheduleType
        {
            Single, Start, Middle, End
        }

        public ScheduleType scheduleType = ScheduleType.Single;


        // 이 칸의 날짜
        public DateTime _date;

        public DayUserControl()
        {
            InitializeComponent();
            flpEvent.Click += ForwardClick;
            lbDay.Click += ForwardClick;
        }
        private void ForwardClick(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        public FlowLayoutPanel EventPanel
        {
            get { return flpEvent; }
        }
        // day = 요일, thisDate = 이 칸에 들어올 날짜
        public DayUserControl(int day, DateTime thisDate)
        {
            InitializeComponent();
            flpEvent.Click += ForwardClick;
            lbDay.Click += ForwardClick;
            lbDay.Font = new Font("Noto Sans KR", 10, FontStyle.Bold);

            this.Margin = new Padding(0,1,0,1);
            this.Padding = new Padding(8);
            _date = thisDate;
            lbDay.Text = day.ToString();
            this.BorderStyle = BorderStyle.None;

          
        }


        public void ColorChange(Color backgroundColor, Color todayColor)
        {
            flpEvent.BackColor= backgroundColor;
            this.BackColor = backgroundColor;

            if (_date.Date == DateTime.Today)
            {
                this.BackColor =todayColor;
                flpEvent.BackColor = todayColor;
                lbToday.Text = "TODAY 🐻";

            }
        }


        public event Action<string> TitleLabelClicked;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int radius = 20;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            GraphicsPath roundPath = BorderHelper.GetRoundRect(rect, radius);
            this.Region = new Region(roundPath);

            // 배경
            using (SolidBrush brush = new SolidBrush(this.BackColor))
                e.Graphics.FillPath(brush, roundPath);      
        }


        public int GetMultiSlotCount() =>
        flpEvent.Controls.Cast<Control>()
            .Count(c => c.Tag?.ToString().Contains("연속") == true ||
                        c.Tag?.ToString() == "_placeholder");

        public void addPlaceholder()
        {
            flpEvent.Controls.Add(new Label
            {
                Height = 23,
                Width = flpEvent.Width,
                Margin = new Padding(0, 0, 0, 0),
                BackColor = Color.Transparent,
                Tag = "_placeholder"
            });
        }


        // 승환(3/10) + 수영 (색상, 연속색상)
        public void setDetailPopupText(string text)
        {
            //lbText.Text = text;
        }
        public void addTitleLabel(string text, Color color, bool isSingleDay)
        {

            Label label = new Label();
            label.Text = text;
            label.AutoSize = false;
            label.Width = this.flpEvent.Width+2;
            label.Height = 23;
            label.MaximumSize = new Size(flpEvent.Width, 100);
            label.BackColor = color;
            label.Margin = new Padding(0, 0, 0, 0);
            label.Font = new Font("Noto Sans KR", 10, FontStyle.Bold);
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Padding = new Padding(6, 0, 0, 0);

            if (!isSingleDay)
            {
                int slotIndex = this.flpEvent.Controls.Cast<Control>()
                    .Count(c => c.Tag != null &&
                    (c.Tag.ToString().Contains("연속") || c.Tag.ToString() == "_placeholder"));

                // Start/Middle/End는 같은 title이 이미 있는지로 판단
                bool alreadyExists = this.flpEvent.Controls.Cast<Control>()
                    .Any(c => c.Tag != null && c.Tag.ToString().StartsWith(text + "_연속"));

                if (!alreadyExists)
                    label.Tag = text + "_연속Start";
                else if (text == "")  // 중간 빈 칸
                    label.Tag = text + "_연속Middle";
                else
                    label.Tag = text + "_연속End";

                label.Width = this.flpEvent.Width;
                this.flpEvent.Controls.Add(label);
            }
            else
            {
                label.Tag = text + "_단일";
                this.flpEvent.Controls.Add(label);           
            }


            label.Click += (s, e) =>
            {
                // 승환 ////////////////////////////
                TitleLabelClicked?.Invoke(text);
                ////////////////////////////////////
                Maver_켈린더.Calendar calendar = this.FindForm() as Maver_켈린더.Calendar;

                if (calendar != null)
                {
                    string clickedTitle = (string)((Label)s).Tag;
                    calendar.ShowDetailPanel(this, clickedTitle);

                }
            };


        }

        // 은비 추가
        public void SetHoliday(string holidayName)
        {
            // 1. 날짜 색상을 빨간색으로 변경
            if (lbDay != null) lbDay.ForeColor = Color.Red;

            // 2. 공휴일 이름 라벨에 텍스트 넣기
            // (디자인 창에서 lblHolidayName이라는 라벨을 미리 만들어두세요!)
            if (lbHolidayName != null)
            {
                lbHolidayName.Text = holidayName;
                lbHolidayName.ForeColor = Color.Red; // 이름도 빨간색으로
                lbHolidayName.Font = new Font("Noto Sans KR", 9, FontStyle.Bold);
                lbHolidayName.ImageAlign = ContentAlignment.TopLeft;
            }
        }

        // 빨간글씨 (일요일이나 공휴일)
        public void SetColorRed()
        {
            if (lbDay != null) // 날짜 숫자가 써있는 라벨 이름
            {
                lbDay.ForeColor = Color.Red;
            }
        }

        // 토요일 파란글씨
        public void SetColorBlue()
        {
            if (lbDay != null)
            {
                // 텍스트 색상을 파란색으로 변경
                lbDay.ForeColor = Color.Blue;
            }
        }

        private void DayUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
