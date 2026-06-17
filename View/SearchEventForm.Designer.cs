namespace Project_Maver.View
{
    partial class SearchEventForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            rbEndDate = new RadioButton();
            rbStartDate = new RadioButton();
            btnSearch = new Button();
            label3 = new Label();
            dtpToDate = new DateTimePicker();
            dtpFromDate = new DateTimePicker();
            txtSearchTitle = new TextBox();
            label1 = new Label();
            dgvEvents = new DataGridView();
            btnClose = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbEndDate);
            groupBox1.Controls.Add(rbStartDate);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpToDate);
            groupBox1.Controls.Add(dtpFromDate);
            groupBox1.Controls.Add(txtSearchTitle);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 94);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // rbEndDate
            // 
            rbEndDate.AutoSize = true;
            rbEndDate.Font = new Font("Noto Sans KR Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rbEndDate.Location = new Point(334, 39);
            rbEndDate.Name = "rbEndDate";
            rbEndDate.Size = new Size(79, 24);
            rbEndDate.TabIndex = 3;
            rbEndDate.TabStop = true;
            rbEndDate.Text = "종료날짜";
            rbEndDate.UseVisualStyleBackColor = true;
            // 
            // rbStartDate
            // 
            rbStartDate.AutoSize = true;
            rbStartDate.Font = new Font("Noto Sans KR Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rbStartDate.Location = new Point(249, 39);
            rbStartDate.Name = "rbStartDate";
            rbStartDate.Size = new Size(79, 24);
            rbStartDate.TabIndex = 3;
            rbStartDate.TabStop = true;
            rbStartDate.Text = "시작날짜";
            rbStartDate.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderColor = Color.FloralWhite;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Noto Sans KR Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(677, 34);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 35);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "검색";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(533, 43);
            label3.Name = "label3";
            label3.Size = new Size(15, 17);
            label3.TabIndex = 3;
            label3.Text = "~";
            // 
            // dtpToDate
            // 
            dtpToDate.Format = DateTimePickerFormat.Short;
            dtpToDate.Location = new Point(554, 39);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(108, 25);
            dtpToDate.TabIndex = 2;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Format = DateTimePickerFormat.Short;
            dtpFromDate.Location = new Point(419, 39);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(108, 25);
            dtpFromDate.TabIndex = 2;
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Location = new Point(84, 38);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(153, 25);
            txtSearchTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Noto Sans KR Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 33);
            label1.Name = "label1";
            label1.Size = new Size(58, 30);
            label1.TabIndex = 0;
            label1.Text = "일정명";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvEvents
            // 
            dgvEvents.BackgroundColor = Color.Linen;
            dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvents.Location = new Point(12, 134);
            dgvEvents.Name = "dgvEvents";
            dgvEvents.ReadOnly = true;
            dgvEvents.RowTemplate.Height = 25;
            dgvEvents.Size = new Size(803, 579);
            dgvEvents.TabIndex = 1;
            dgvEvents.CellDoubleClick += dgvEvents_CellDoubleClick;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(368, 723);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(101, 35);
            btnClose.TabIndex = 2;
            btnClose.Text = "닫기";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // SearchEventForm
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(827, 768);
            Controls.Add(btnClose);
            Controls.Add(dgvEvents);
            Controls.Add(groupBox1);
            Font = new Font("Noto Sans KR Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Name = "SearchEventForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchEventForm";
            Load += SearchEventForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpToDate;
        private DateTimePicker dtpFromDate;
        private TextBox txtSearchTitle;
        private Label label1;
        private Label label3;
        private DataGridView dgvEvents;
        private Button btnSearch;
        private Button btnClose;
        private RadioButton rbEndDate;
        private RadioButton rbStartDate;
    }
}