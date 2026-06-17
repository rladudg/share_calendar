namespace Project_Maver.View
{
    partial class DayUserControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            lbDay = new Label();
            lbHolidayName = new Label();
            flpEvent = new FlowLayoutPanel();
            lbToday = new Label();
            SuspendLayout();
            // 
            // lbDay
            // 
            lbDay.AutoSize = true;
            lbDay.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDay.Location = new Point(0, 0);
            lbDay.Name = "lbDay";
            lbDay.Size = new Size(0, 21);
            lbDay.TabIndex = 0;
            // 
            // lbHolidayName
            // 
            lbHolidayName.AutoSize = true;
            lbHolidayName.Location = new Point(29, 2);
            lbHolidayName.Name = "lbHolidayName";
            lbHolidayName.Size = new Size(0, 15);
            lbHolidayName.TabIndex = 1;
            // 
            // flpEvent
            // 
            flpEvent.AutoScroll = true;
            flpEvent.BackColor = Color.MistyRose;
            flpEvent.FlowDirection = FlowDirection.TopDown;
            flpEvent.Location = new Point(1, 28);
            flpEvent.Margin = new Padding(0);
            flpEvent.Name = "flpEvent";
            flpEvent.Size = new Size(215, 105);
            flpEvent.TabIndex = 2;
            flpEvent.WrapContents = false;
            // 
            // lbToday
            // 
            lbToday.AutoSize = true;
            lbToday.Font = new Font("Noto Sans KR", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbToday.Location = new Point(134, 0);
            lbToday.Name = "lbToday";
            lbToday.Size = new Size(0, 17);
            lbToday.TabIndex = 3;
            // 
            // DayUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lbToday);
            Controls.Add(flpEvent);
            Controls.Add(lbHolidayName);
            Controls.Add(lbDay);
            Name = "DayUserControl";
            Size = new Size(215, 131);
            Load += DayUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDay;
        private Label lbHolidayName;
        private FlowLayoutPanel flpEvent;
        private Label lbToday;
    }
}
