namespace Maver_켈린더
{
    partial class JoinMembership
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinMembership));
            label1 = new Label();
            txtName = new TextBox();
            txtPassWord = new TextBox();
            txtPwCheck = new TextBox();
            chkInfo = new CheckBox();
            btnJoin = new Button();
            pictureBox1 = new PictureBox();
            txtId = new TextBox();
            label8 = new Label();
            cbMonth = new ComboBox();
            cbYear = new ComboBox();
            cbDay = new ComboBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            pnlInputGroup = new Panel();
            label4 = new Label();
            label3 = new Label();
            pnlInputName = new Panel();
            label5 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlInputGroup.SuspendLayout();
            pnlInputName.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans KR Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(368, 90);
            label1.Name = "label1";
            label1.Size = new Size(85, 27);
            label1.TabIndex = 0;
            label1.Text = "회원 가입";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Noto Sans KR", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(5, 3);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "이름";
            txtName.Size = new Size(390, 40);
            txtName.TabIndex = 3;
            txtName.KeyDown += txtName_KeyDown;
            // 
            // txtPassWord
            // 
            txtPassWord.BorderStyle = BorderStyle.None;
            txtPassWord.Font = new Font("Noto Sans KR", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassWord.Location = new Point(4, 45);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.PlaceholderText = "비밀번호";
            txtPassWord.Size = new Size(390, 26);
            txtPassWord.TabIndex = 3;
            txtPassWord.UseSystemPasswordChar = true;
            txtPassWord.KeyDown += txtPassWord_KeyDown;
            // 
            // txtPwCheck
            // 
            txtPwCheck.BorderStyle = BorderStyle.None;
            txtPwCheck.Font = new Font("Noto Sans KR", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPwCheck.Location = new Point(4, 86);
            txtPwCheck.Name = "txtPwCheck";
            txtPwCheck.PasswordChar = '*';
            txtPwCheck.PlaceholderText = "비밀번호 확인";
            txtPwCheck.Size = new Size(390, 26);
            txtPwCheck.TabIndex = 3;
            txtPwCheck.UseSystemPasswordChar = true;
            txtPwCheck.KeyDown += txtPwCheck_KeyDown;
            // 
            // chkInfo
            // 
            chkInfo.Font = new Font("Noto Sans KR Medium", 8F, FontStyle.Regular, GraphicsUnit.Point);
            chkInfo.Location = new Point(36, 508);
            chkInfo.Name = "chkInfo";
            chkInfo.Size = new Size(372, 40);
            chkInfo.TabIndex = 5;
            chkInfo.Text = "이용약관 개인정보 수집 및 이용, 마케팅 활용 선택에 모두 동의합니다.";
            chkInfo.UseVisualStyleBackColor = true;
            // 
            // btnJoin
            // 
            btnJoin.BackColor = Color.MediumSeaGreen;
            btnJoin.FlatAppearance.BorderSize = 0;
            btnJoin.FlatStyle = FlatStyle.Flat;
            btnJoin.Font = new Font("Noto Sans KR Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnJoin.ForeColor = Color.White;
            btnJoin.Location = new Point(128, 563);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(280, 50);
            btnJoin.TabIndex = 6;
            btnJoin.Text = "가입하기";
            btnJoin.UseVisualStyleBackColor = false;
            btnJoin.Click += btnJoin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.None;
            txtId.Font = new Font("Noto Sans KR", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(4, 4);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.PlaceholderText = "아이디";
            txtId.Size = new Size(390, 40);
            txtId.TabIndex = 3;
            txtId.KeyDown += txtId_KeyDown;
            // 
            // label8
            // 
            label8.BackColor = Color.LightGray;
            label8.Font = new Font("Noto Sans KR Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(4, 41);
            label8.Name = "label8";
            label8.Size = new Size(390, 1);
            label8.TabIndex = 8;
            // 
            // cbMonth
            // 
            cbMonth.FormattingEnabled = true;
            cbMonth.Items.AddRange(new object[] { "1월", "2월", "3월", "4월", "5월", "6월", "7월", "8월", "9월", "10월", "11월", "12월" });
            cbMonth.Location = new Point(177, 454);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(72, 23);
            cbMonth.TabIndex = 10;
            cbMonth.SelectedIndexChanged += cbMonth_SelectedIndexChanged;
            // 
            // cbYear
            // 
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(66, 454);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(72, 23);
            cbYear.TabIndex = 13;
            cbYear.SelectedIndexChanged += cbYear_SelectedIndexChanged;
            // 
            // cbDay
            // 
            cbDay.FormattingEnabled = true;
            cbDay.Location = new Point(284, 454);
            cbDay.Name = "cbDay";
            cbDay.Size = new Size(72, 23);
            cbDay.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Noto Sans KR", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(4, 127);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "이메일";
            txtEmail.Size = new Size(390, 40);
            txtEmail.TabIndex = 3;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Noto Sans KR", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(5, 44);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "핸드폰";
            txtPhone.Size = new Size(390, 40);
            txtPhone.TabIndex = 3;
            txtPhone.KeyDown += txtPhone_KeyDown;
            // 
            // pnlInputGroup
            // 
            pnlInputGroup.Controls.Add(label4);
            pnlInputGroup.Controls.Add(label3);
            pnlInputGroup.Controls.Add(label8);
            pnlInputGroup.Controls.Add(txtId);
            pnlInputGroup.Controls.Add(txtPassWord);
            pnlInputGroup.Controls.Add(txtEmail);
            pnlInputGroup.Controls.Add(txtPwCheck);
            pnlInputGroup.Location = new Point(58, 129);
            pnlInputGroup.Name = "pnlInputGroup";
            pnlInputGroup.Padding = new Padding(1);
            pnlInputGroup.Size = new Size(398, 170);
            pnlInputGroup.TabIndex = 15;
            pnlInputGroup.Paint += pnlInputGroup_Paint;
            // 
            // label4
            // 
            label4.BackColor = Color.LightGray;
            label4.Font = new Font("Noto Sans KR Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(4, 125);
            label4.Name = "label4";
            label4.Size = new Size(390, 1);
            label4.TabIndex = 10;
            // 
            // label3
            // 
            label3.BackColor = Color.LightGray;
            label3.Font = new Font("Noto Sans KR Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(4, 85);
            label3.Name = "label3";
            label3.Size = new Size(390, 1);
            label3.TabIndex = 9;
            // 
            // pnlInputName
            // 
            pnlInputName.Controls.Add(label5);
            pnlInputName.Controls.Add(txtName);
            pnlInputName.Controls.Add(txtPhone);
            pnlInputName.Location = new Point(58, 320);
            pnlInputName.Name = "pnlInputName";
            pnlInputName.Padding = new Padding(0, 0, 0, 5);
            pnlInputName.Size = new Size(398, 91);
            pnlInputName.TabIndex = 16;
            pnlInputName.Paint += pnlInputName_Paint;
            // 
            // label5
            // 
            label5.BackColor = Color.LightGray;
            label5.Font = new Font("Noto Sans KR Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(4, 42);
            label5.Name = "label5";
            label5.Size = new Size(390, 1);
            label5.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Noto Sans KR Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(58, 425);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 17;
            label2.Text = "* 생년월일";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Noto Sans KR Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(140, 457);
            label6.Name = "label6";
            label6.Size = new Size(19, 17);
            label6.TabIndex = 17;
            label6.Text = "년";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Noto Sans KR Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(358, 457);
            label7.Name = "label7";
            label7.Size = new Size(19, 17);
            label7.TabIndex = 17;
            label7.Text = "일";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Noto Sans KR Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(250, 457);
            label9.Name = "label9";
            label9.Size = new Size(19, 17);
            label9.TabIndex = 17;
            label9.Text = "월";
            // 
            // JoinMembership
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(532, 698);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(pnlInputName);
            Controls.Add(pnlInputGroup);
            Controls.Add(cbDay);
            Controls.Add(cbYear);
            Controls.Add(cbMonth);
            Controls.Add(pictureBox1);
            Controls.Add(btnJoin);
            Controls.Add(chkInfo);
            Controls.Add(label1);
            Name = "JoinMembership";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JoinMembership";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlInputGroup.ResumeLayout(false);
            pnlInputGroup.PerformLayout();
            pnlInputName.ResumeLayout(false);
            pnlInputName.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtPassWord;
        private TextBox txtPwCheck;
        private CheckBox chkInfo;
        private Button btnJoin;
        private PictureBox pictureBox1;
        private TextBox txtId;
        private Label label8;
        private ComboBox cbMonth;
        private TextBox txtDay;
        private ComboBox cbYear;
        private ComboBox cbDay;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Panel pnlInputGroup;
        private Label label4;
        private Label label3;
        private Panel pnlInputName;
        private Label label5;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label9;
    }
}