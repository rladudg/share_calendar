namespace Project_Maver.View
{
    partial class pnlDetail
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
            btnSang = new Button();
            btnClose = new Button();
            lbDetailTitle = new Label();
            lbDetailStartDate = new Label();
            lbDetailEndDate = new Label();
            lbDetailMemo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnSang
            // 
            btnSang.BackColor = Color.Transparent;
            btnSang.FlatAppearance.BorderColor = Color.SeaShell;
            btnSang.FlatAppearance.BorderSize = 0;
            btnSang.FlatStyle = FlatStyle.Flat;
            btnSang.Font = new Font("Noto Sans KR Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSang.ForeColor = SystemColors.ControlText;
            btnSang.Location = new Point(98, 119);
            btnSang.Name = "btnSang";
            btnSang.Size = new Size(95, 30);
            btnSang.TabIndex = 1;
            btnSang.Text = "상세정보확인";
            btnSang.UseVisualStyleBackColor = false;
            btnSang.Click += btnSang_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Noto Sans KR Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(248, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 25);
            btnClose.TabIndex = 2;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lbDetailTitle
            // 
            lbDetailTitle.AutoSize = true;
            lbDetailTitle.Font = new Font("Noto Sans KR Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDetailTitle.Location = new Point(14, 7);
            lbDetailTitle.Name = "lbDetailTitle";
            lbDetailTitle.Size = new Size(70, 24);
            lbDetailTitle.TabIndex = 3;
            lbDetailTitle.Text = "제목없음";
            // 
            // lbDetailStartDate
            // 
            lbDetailStartDate.AutoSize = true;
            lbDetailStartDate.Font = new Font("Noto Sans KR Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbDetailStartDate.Location = new Point(68, 49);
            lbDetailStartDate.Name = "lbDetailStartDate";
            lbDetailStartDate.Size = new Size(0, 20);
            lbDetailStartDate.TabIndex = 3;
            // 
            // lbDetailEndDate
            // 
            lbDetailEndDate.AutoSize = true;
            lbDetailEndDate.Font = new Font("Noto Sans KR Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbDetailEndDate.Location = new Point(179, 49);
            lbDetailEndDate.Name = "lbDetailEndDate";
            lbDetailEndDate.Size = new Size(0, 20);
            lbDetailEndDate.TabIndex = 3;
            // 
            // lbDetailMemo
            // 
            lbDetailMemo.AutoSize = true;
            lbDetailMemo.Font = new Font("Noto Sans KR Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbDetailMemo.ForeColor = SystemColors.ControlDarkDark;
            lbDetailMemo.Location = new Point(13, 81);
            lbDetailMemo.Name = "lbDetailMemo";
            lbDetailMemo.Size = new Size(35, 20);
            lbDetailMemo.TabIndex = 3;
            lbDetailMemo.Text = "메모";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans KR Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(153, 49);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 5;
            label1.Text = "~";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Noto Sans KR Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 49);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 6;
            label2.Text = "기간 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans KR Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(-4, 20);
            label3.Name = "label3";
            label3.Size = new Size(321, 20);
            label3.TabIndex = 3;
            label3.Text = "_______________________________________";
            // 
            // pnlDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            Controls.Add(label2);
            Controls.Add(lbDetailMemo);
            Controls.Add(lbDetailEndDate);
            Controls.Add(lbDetailStartDate);
            Controls.Add(lbDetailTitle);
            Controls.Add(btnSang);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(btnClose);
            Location = new Point(14, 10);
            Name = "pnlDetail";
            Size = new Size(300, 163);
            Load += pnlDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSang;
        private Button btnClose;
        private Label lbDetailTitle;
        private Label lbDetailStartDate;
        private Label lbDetailEndDate;
        private Label lbDetailMemo;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
