using Project_Maver.Common;
using System.Drawing.Text;

namespace maverCalender
{
    partial class detailPopup
    {

        PrivateFontCollection fonts = new PrivateFontCollection();
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        ///<param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detailPopup));
            btnClose = new Button();
            lbTitle = new Label();
            cbChoice = new ComboBox();
            lbLine = new Label();
            lbLine5 = new Label();
            lbToday = new Label();
            lbStart = new Label();
            lbEnd = new Label();
            pbWatch = new PictureBox();
            pbOff = new PictureBox();
            pbWorld = new PictureBox();
            lbLine1 = new Label();
            lbLine2 = new Label();
            lbReply = new Label();
            lbLine6 = new Label();
            lbExplanation = new Label();
            pbReply = new PictureBox();
            pbExplanation = new PictureBox();
            btnSave = new Button();
            pbOn = new PictureBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            dtpStartTime = new DateTimePicker();
            dtpEndTime = new DateTimePicker();
            txtTitle = new TextBox();
            cbWorldTime = new ComboBox();
            txtMemo = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            cbRepeat = new ComboBox();
            btnColor = new RoundButton();
            lbPlan = new Label();
            lbWorldTime = new Label();
            lbStandardTime = new Label();
            ((System.ComponentModel.ISupportInitialize)pbWatch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbWorld).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbReply).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbExplanation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOn).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(7, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(29, 0);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Noto Sans KR", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(229, 16);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(51, 30);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "일정";
            // 
            // cbChoice
            // 
            cbChoice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChoice.ForeColor = Color.Black;
            cbChoice.FormattingEnabled = true;
            cbChoice.Items.AddRange(new object[] { "내 캘린더" });
            cbChoice.Location = new Point(57, 69);
            cbChoice.Name = "cbChoice";
            cbChoice.Size = new Size(120, 23);
            cbChoice.TabIndex = 2;
            // 
            // lbLine
            // 
            lbLine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbLine.AutoSize = true;
            lbLine.ForeColor = Color.LightGray;
            lbLine.Location = new Point(57, 141);
            lbLine.Name = "lbLine";
            lbLine.Size = new Size(427, 15);
            lbLine.TabIndex = 3;
            lbLine.Text = "____________________________________________________________________________________\r\n";
            // 
            // lbLine5
            // 
            lbLine5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbLine5.AutoSize = true;
            lbLine5.ForeColor = Color.LightGray;
            lbLine5.Location = new Point(57, 270);
            lbLine5.Name = "lbLine5";
            lbLine5.Size = new Size(427, 15);
            lbLine5.TabIndex = 3;
            lbLine5.Text = "____________________________________________________________________________________\r\n";
            // 
            // lbToday
            // 
            lbToday.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbToday.AutoSize = true;
            lbToday.Font = new Font("Noto Sans KR", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbToday.ForeColor = Color.Gray;
            lbToday.Location = new Point(93, 166);
            lbToday.Name = "lbToday";
            lbToday.Size = new Size(80, 21);
            lbToday.TabIndex = 4;
            lbToday.Text = "시작종료일";
            // 
            // lbStart
            // 
            lbStart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbStart.AutoSize = true;
            lbStart.Font = new Font("Noto Sans KR", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbStart.ForeColor = Color.Black;
            lbStart.Location = new Point(93, 204);
            lbStart.Name = "lbStart";
            lbStart.Size = new Size(38, 21);
            lbStart.TabIndex = 4;
            lbStart.Text = "시작";
            // 
            // lbEnd
            // 
            lbEnd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbEnd.AutoSize = true;
            lbEnd.Font = new Font("Noto Sans KR", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbEnd.ForeColor = Color.Black;
            lbEnd.Location = new Point(93, 236);
            lbEnd.Name = "lbEnd";
            lbEnd.Size = new Size(38, 21);
            lbEnd.TabIndex = 4;
            lbEnd.Text = "종료";
            // 
            // pbWatch
            // 
            pbWatch.Image = (Image)resources.GetObject("pbWatch.Image");
            pbWatch.Location = new Point(60, 164);
            pbWatch.Name = "pbWatch";
            pbWatch.Size = new Size(22, 22);
            pbWatch.SizeMode = PictureBoxSizeMode.Zoom;
            pbWatch.TabIndex = 5;
            pbWatch.TabStop = false;
            // 
            // pbOff
            // 
            pbOff.Image = (Image)resources.GetObject("pbOff.Image");
            pbOff.Location = new Point(400, 168);
            pbOff.Name = "pbOff";
            pbOff.Size = new Size(35, 28);
            pbOff.SizeMode = PictureBoxSizeMode.Zoom;
            pbOff.TabIndex = 5;
            pbOff.TabStop = false;
            pbOff.Click += pbOff_Click;
            // 
            // pbWorld
            // 
            pbWorld.Image = (Image)resources.GetObject("pbWorld.Image");
            pbWorld.Location = new Point(60, 294);
            pbWorld.Name = "pbWorld";
            pbWorld.Size = new Size(22, 22);
            pbWorld.SizeMode = PictureBoxSizeMode.Zoom;
            pbWorld.TabIndex = 5;
            pbWorld.TabStop = false;
            // 
            // lbLine1
            // 
            lbLine1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbLine1.AutoSize = true;
            lbLine1.ForeColor = Color.LightGray;
            lbLine1.Location = new Point(57, 353);
            lbLine1.Name = "lbLine1";
            lbLine1.Size = new Size(427, 15);
            lbLine1.TabIndex = 3;
            lbLine1.Text = "____________________________________________________________________________________\r\n";
            // 
            // lbLine2
            // 
            lbLine2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbLine2.AutoSize = true;
            lbLine2.ForeColor = Color.LightGray;
            lbLine2.Location = new Point(57, 421);
            lbLine2.Name = "lbLine2";
            lbLine2.Size = new Size(427, 15);
            lbLine2.TabIndex = 3;
            lbLine2.Text = "____________________________________________________________________________________\r\n";
            // 
            // lbReply
            // 
            lbReply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbReply.AutoSize = true;
            lbReply.Font = new Font("Noto Sans KR", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbReply.ForeColor = Color.Gray;
            lbReply.Location = new Point(93, 380);
            lbReply.Name = "lbReply";
            lbReply.Size = new Size(38, 21);
            lbReply.TabIndex = 4;
            lbReply.Text = "반복";
            // 
            // lbLine6
            // 
            lbLine6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbLine6.AutoSize = true;
            lbLine6.ForeColor = Color.LightGray;
            lbLine6.Location = new Point(57, 505);
            lbLine6.Name = "lbLine6";
            lbLine6.Size = new Size(427, 15);
            lbLine6.TabIndex = 3;
            lbLine6.Text = "____________________________________________________________________________________\r\n";
            // 
            // lbExplanation
            // 
            lbExplanation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbExplanation.AutoSize = true;
            lbExplanation.Font = new Font("Noto Sans KR", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbExplanation.ForeColor = Color.Gray;
            lbExplanation.Location = new Point(93, 446);
            lbExplanation.Name = "lbExplanation";
            lbExplanation.Size = new Size(38, 21);
            lbExplanation.TabIndex = 4;
            lbExplanation.Text = "메모";
            // 
            // pbReply
            // 
            pbReply.Image = (Image)resources.GetObject("pbReply.Image");
            pbReply.Location = new Point(60, 379);
            pbReply.Name = "pbReply";
            pbReply.Size = new Size(22, 22);
            pbReply.SizeMode = PictureBoxSizeMode.Zoom;
            pbReply.TabIndex = 5;
            pbReply.TabStop = false;
            // 
            // pbExplanation
            // 
            pbExplanation.Image = (Image)resources.GetObject("pbExplanation.Image");
            pbExplanation.Location = new Point(60, 445);
            pbExplanation.Name = "pbExplanation";
            pbExplanation.Size = new Size(22, 22);
            pbExplanation.SizeMode = PictureBoxSizeMode.Zoom;
            pbExplanation.TabIndex = 5;
            pbExplanation.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderColor = Color.Gainsboro;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(425, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(59, 36);
            btnSave.TabIndex = 0;
            btnSave.Text = "저장";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pbOn
            // 
            pbOn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbOn.Image = (Image)resources.GetObject("pbOn.Image");
            pbOn.Location = new Point(400, 168);
            pbOn.Name = "pbOn";
            pbOn.Size = new Size(35, 0);
            pbOn.SizeMode = PictureBoxSizeMode.Zoom;
            pbOn.TabIndex = 5;
            pbOn.TabStop = false;
            pbOn.Click += pbOn_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpStartDate.CalendarFont = new Font("Noto Sans KR Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dtpStartDate.Location = new Point(137, 202);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(179, 23);
            dtpStartDate.TabIndex = 9;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpEndDate.CalendarFont = new Font("Noto Sans KR Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dtpEndDate.Location = new Point(137, 236);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(179, 23);
            dtpEndDate.TabIndex = 9;
            // 
            // dtpStartTime
            // 
            dtpStartTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpStartTime.CalendarFont = new Font("Noto Sans KR Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(338, 202);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(97, 23);
            dtpStartTime.TabIndex = 9;
            // 
            // dtpEndTime
            // 
            dtpEndTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpEndTime.CalendarFont = new Font("Noto Sans KR Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.Location = new Point(338, 236);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(97, 23);
            dtpEndTime.TabIndex = 9;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.Location = new Point(152, 117);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(332, 23);
            txtTitle.TabIndex = 14;
            // 
            // cbWorldTime
            // 
            cbWorldTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbWorldTime.FormattingEnabled = true;
            cbWorldTime.Location = new Point(93, 327);
            cbWorldTime.Name = "cbWorldTime";
            cbWorldTime.Size = new Size(179, 23);
            cbWorldTime.TabIndex = 15;
            cbWorldTime.SelectedIndexChanged += cbWorldTime_SelectedIndexChanged;
            // 
            // txtMemo
            // 
            txtMemo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMemo.Location = new Point(93, 470);
            txtMemo.Name = "txtMemo";
            txtMemo.Size = new Size(352, 23);
            txtMemo.TabIndex = 16;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.FlatAppearance.BorderColor = Color.Gainsboro;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(425, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(59, 36);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.FlatAppearance.BorderColor = Color.Gainsboro;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(349, 10);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(59, 36);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "수정";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbRepeat
            // 
            cbRepeat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbRepeat.FormattingEnabled = true;
            cbRepeat.Items.AddRange(new object[] { "매주", "매월", "매년" });
            cbRepeat.Location = new Point(93, 404);
            cbRepeat.Name = "cbRepeat";
            cbRepeat.Size = new Size(354, 23);
            cbRepeat.TabIndex = 20;
            cbRepeat.SelectedIndexChanged += cbRepeat_SelectedIndexChanged_1;
            // 
            // btnColor
            // 
            btnColor.BackColor = Color.SkyBlue;
            btnColor.FlatAppearance.BorderSize = 0;
            btnColor.FlatStyle = FlatStyle.Flat;
            btnColor.Location = new Point(60, 117);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(18, 19);
            btnColor.TabIndex = 21;
            btnColor.UseVisualStyleBackColor = false;
            btnColor.Click += btnColor_Click;
            // 
            // lbPlan
            // 
            lbPlan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbPlan.AutoSize = true;
            lbPlan.BackColor = Color.Transparent;
            lbPlan.Font = new Font("Noto Sans KR", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbPlan.ForeColor = Color.Gray;
            lbPlan.Location = new Point(93, 117);
            lbPlan.Name = "lbPlan";
            lbPlan.Size = new Size(52, 21);
            lbPlan.TabIndex = 4;
            lbPlan.Text = "일정명";
            // 
            // lbWorldTime
            // 
            lbWorldTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbWorldTime.AutoSize = true;
            lbWorldTime.Font = new Font("Noto Sans KR", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbWorldTime.ForeColor = Color.Gray;
            lbWorldTime.Location = new Point(93, 295);
            lbWorldTime.Name = "lbWorldTime";
            lbWorldTime.Size = new Size(66, 21);
            lbWorldTime.TabIndex = 4;
            lbWorldTime.Text = "표준시간";
            // 
            // lbStandardTime
            // 
            lbStandardTime.BackColor = Color.Transparent;
            lbStandardTime.Location = new Point(290, 327);
            lbStandardTime.Name = "lbStandardTime";
            lbStandardTime.Size = new Size(179, 23);
            lbStandardTime.TabIndex = 23;
            // 
            // detailPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(534, 601);
            Controls.Add(lbStandardTime);
            Controls.Add(btnColor);
            Controls.Add(cbRepeat);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(txtMemo);
            Controls.Add(cbWorldTime);
            Controls.Add(dtpEndTime);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartTime);
            Controls.Add(dtpStartDate);
            Controls.Add(pbOff);
            Controls.Add(pbExplanation);
            Controls.Add(pbReply);
            Controls.Add(pbWorld);
            Controls.Add(pbWatch);
            Controls.Add(lbEnd);
            Controls.Add(lbStart);
            Controls.Add(lbExplanation);
            Controls.Add(lbWorldTime);
            Controls.Add(lbReply);
            Controls.Add(lbToday);
            Controls.Add(lbPlan);
            Controls.Add(lbLine6);
            Controls.Add(lbLine2);
            Controls.Add(lbLine1);
            Controls.Add(lbLine5);
            Controls.Add(cbChoice);
            Controls.Add(lbTitle);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(txtTitle);
            Controls.Add(pbOn);
            Controls.Add(lbLine);
            Name = "detailPopup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "detailPopup";
            Load += detailPopup_Load;
            ((System.ComponentModel.ISupportInitialize)pbWatch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOff).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbWorld).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbReply).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbExplanation).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label lbTitle;
        private ComboBox cbChoice;
        private Label lbLine;
        private Label lbPlan;
        private Label lbLine5;
        private Label lbToday;
        private Label lbStart;
        private Label lbEnd;
        private PictureBox pbWatch;
        private PictureBox pbOff;
        private PictureBox pbWorld;
        private Label lbLine1;
        private Label lbLine2;
        private Label lbReply;
        private Label lbLine6;
        private Label lbExplanation;
        private PictureBox pbReply;
        private PictureBox pbExplanation;
        private Button btnSave;
        private PictureBox pbOn;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartTime;
        private DateTimePicker dtpEndTime;
        private RoundButton btnSelectColor;
        private ComboBox cbWorldTime;
        private TextBox txtMemo;
        private Button btnDelete;
        private Button btnUpdate;
        private RoundButton btnColor;
        private Label lbWorldTime;
        public ComboBox cbRepeat;
        private Label lbStandardTime;
        public TextBox txtTitle;
        //private RoundButton btnSelectColor;
    }
}