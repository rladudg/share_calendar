namespace Project_Maver.View
{
    partial class pnlRepeat
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
            lbRepeatTitle = new Label();
            label2 = new Label();
            lbType = new Label();
            lbChoice = new Label();
            lbNum = new Label();
            lbChange = new Label();
            cbSun = new CheckBox();
            cbMon = new CheckBox();
            cbTue = new CheckBox();
            cbWed = new CheckBox();
            cbThu = new CheckBox();
            cbFri = new CheckBox();
            cbSat = new CheckBox();
            lbEnd = new Label();
            rbNon = new RadioButton();
            rbDate = new RadioButton();
            dtpReStartTime = new DateTimePicker();
            dtpReEndTime = new DateTimePicker();
            btnOk = new Button();
            btnCancel = new Button();
            numInterval = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numInterval).BeginInit();
            SuspendLayout();
            // 
            // lbRepeatTitle
            // 
            lbRepeatTitle.AutoSize = true;
            lbRepeatTitle.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbRepeatTitle.Location = new Point(13, 9);
            lbRepeatTitle.Name = "lbRepeatTitle";
            lbRepeatTitle.Size = new Size(34, 17);
            lbRepeatTitle.TabIndex = 0;
            lbRepeatTitle.Text = "반복";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(-11, 17);
            label2.Name = "label2";
            label2.Size = new Size(464, 17);
            label2.TabIndex = 0;
            label2.Text = "____________________________________________________________________________";
            
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new Point(13, 45);
            lbType.Name = "lbType";
            lbType.Size = new Size(55, 15);
            lbType.TabIndex = 1;
            lbType.Text = "반복주기";
            // 
            // lbChoice
            // 
            lbChoice.AutoSize = true;
            lbChoice.Location = new Point(70, 45);
            lbChoice.Name = "lbChoice";
            lbChoice.Size = new Size(12, 15);
            lbChoice.TabIndex = 1;
            lbChoice.Text = "-";
            // 
            // lbNum
            // 
            lbNum.AutoSize = true;
            lbNum.Location = new Point(13, 73);
            lbNum.Name = "lbNum";
            lbNum.Size = new Size(31, 15);
            lbNum.TabIndex = 1;
            lbNum.Text = "주기";
            // 
            // lbChange
            // 
            lbChange.AutoSize = true;
            lbChange.Location = new Point(111, 73);
            lbChange.Name = "lbChange";
            lbChange.Size = new Size(19, 15);
            lbChange.TabIndex = 1;
            lbChange.Text = "주";
            // 
            // cbSun
            // 
            cbSun.AutoSize = true;
            cbSun.Location = new Point(74, 94);
            cbSun.Name = "cbSun";
            cbSun.Size = new Size(38, 19);
            cbSun.TabIndex = 2;
            cbSun.Tag = "Sun";
            cbSun.Text = "일";
            cbSun.UseVisualStyleBackColor = true;
            // 
            // cbMon
            // 
            cbMon.AutoSize = true;
            cbMon.Location = new Point(118, 94);
            cbMon.Name = "cbMon";
            cbMon.Size = new Size(38, 19);
            cbMon.TabIndex = 2;
            cbMon.Tag = "Mon";
            cbMon.Text = "월";
            cbMon.UseVisualStyleBackColor = true;
            // 
            // cbTue
            // 
            cbTue.AutoSize = true;
            cbTue.Location = new Point(162, 94);
            cbTue.Name = "cbTue";
            cbTue.Size = new Size(38, 19);
            cbTue.TabIndex = 2;
            cbTue.Tag = "Tue";
            cbTue.Text = "화";
            cbTue.UseVisualStyleBackColor = true;
            // 
            // cbWed
            // 
            cbWed.AutoSize = true;
            cbWed.Location = new Point(206, 94);
            cbWed.Name = "cbWed";
            cbWed.Size = new Size(38, 19);
            cbWed.TabIndex = 2;
            cbWed.Tag = "Wed";
            cbWed.Text = "수";
            cbWed.UseVisualStyleBackColor = true;
            // 
            // cbThu
            // 
            cbThu.AutoSize = true;
            cbThu.Location = new Point(250, 94);
            cbThu.Name = "cbThu";
            cbThu.Size = new Size(38, 19);
            cbThu.TabIndex = 2;
            cbThu.Tag = "Thu";
            cbThu.Text = "목";
            cbThu.UseVisualStyleBackColor = true;
            // 
            // cbFri
            // 
            cbFri.AutoSize = true;
            cbFri.Location = new Point(294, 94);
            cbFri.Name = "cbFri";
            cbFri.Size = new Size(38, 19);
            cbFri.TabIndex = 2;
            cbFri.Tag = "Fri";
            cbFri.Text = "금";
            cbFri.UseVisualStyleBackColor = true;
            // 
            // cbSat
            // 
            cbSat.AutoSize = true;
            cbSat.Location = new Point(338, 94);
            cbSat.Name = "cbSat";
            cbSat.Size = new Size(38, 19);
            cbSat.TabIndex = 2;
            cbSat.Tag = "Sat";
            cbSat.Text = "토";
            cbSat.UseVisualStyleBackColor = true;
            // 
            // lbEnd
            // 
            lbEnd.AutoSize = true;
            lbEnd.Location = new Point(15, 132);
            lbEnd.Name = "lbEnd";
            lbEnd.Size = new Size(31, 15);
            lbEnd.TabIndex = 1;
            lbEnd.Text = "종료";
            // 
            // rbNon
            // 
            rbNon.AutoSize = true;
            rbNon.Location = new Point(74, 129);
            rbNon.Name = "rbNon";
            rbNon.Size = new Size(49, 19);
            rbNon.TabIndex = 5;
            rbNon.TabStop = true;
            rbNon.Text = "없음";
            rbNon.UseVisualStyleBackColor = true;
            rbNon.CheckedChanged += rbNon_CheckedChanged;
            // 
            // rbDate
            // 
            rbDate.AutoSize = true;
            rbDate.Location = new Point(140, 130);
            rbDate.Name = "rbDate";
            rbDate.Size = new Size(49, 19);
            rbDate.TabIndex = 5;
            rbDate.TabStop = true;
            rbDate.Text = "날짜";
            rbDate.UseVisualStyleBackColor = true;
            rbDate.CheckedChanged += rbDate_CheckedChanged;
            // 
            // dtpReStartTime
            // 
            dtpReStartTime.Format = DateTimePickerFormat.Short;
            dtpReStartTime.Location = new Point(72, 156);
            dtpReStartTime.Name = "dtpReStartTime";
            dtpReStartTime.ShowUpDown = true;
            dtpReStartTime.Size = new Size(99, 23);
            dtpReStartTime.TabIndex = 4;
            // 
            // dtpReEndTime
            // 
            dtpReEndTime.Format = DateTimePickerFormat.Short;
            dtpReEndTime.Location = new Point(177, 156);
            dtpReEndTime.Name = "dtpReEndTime";
            dtpReEndTime.ShowUpDown = true;
            dtpReEndTime.Size = new Size(99, 23);
            dtpReEndTime.TabIndex = 4;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(213, 219);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 6;
            btnOk.Text = "설정";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(301, 219);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "취소";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // numInterval
            // 
            numInterval.Location = new Point(73, 68);
            numInterval.Name = "numInterval";
            numInterval.Size = new Size(39, 23);
            numInterval.TabIndex = 7;
            // 
            // pnlRepeat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(numInterval);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(rbDate);
            Controls.Add(rbNon);
            Controls.Add(dtpReEndTime);
            Controls.Add(dtpReStartTime);
            Controls.Add(cbSat);
            Controls.Add(cbFri);
            Controls.Add(cbThu);
            Controls.Add(cbWed);
            Controls.Add(cbTue);
            Controls.Add(cbMon);
            Controls.Add(cbSun);
            Controls.Add(lbChoice);
            Controls.Add(lbChange);
            Controls.Add(lbEnd);
            Controls.Add(lbNum);
            Controls.Add(lbType);
            Controls.Add(lbRepeatTitle);
            Controls.Add(label2);
            Location = new Point(108, 267);
            Name = "pnlRepeat";
            Size = new Size(394, 265);
            Load += pnlRepeat_Load;
            ((System.ComponentModel.ISupportInitialize)numInterval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbRepeatTitle;
        private Label label2;
        private Label lbType;
        private Label lbNum;
        private Label lbEnd;
        private RadioButton rbNon;
        private RadioButton rbDate;
        private DateTimePicker dtpReStartTime;
        private DateTimePicker dtpReEndTime;
        private Button btnOk;
        public Label lbChoice;
        public Label lbChange;
        public CheckBox cbSun;
        public CheckBox cbMon;
        public CheckBox cbTue;
        public CheckBox cbWed;
        public CheckBox cbTur;
        public CheckBox cbFri;
        public CheckBox cbSat;
        public Button btnCancel;
        public CheckBox cbThu;
        public NumericUpDown numInterval;
    }
}
