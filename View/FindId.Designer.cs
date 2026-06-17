namespace Project_Maver.View
{
    partial class FindId
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindId));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            btnFindID = new Button();
            txtPhone = new TextBox();
            pnlIdFound = new Panel();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlIdFound.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans KR", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(199, 59);
            label1.Name = "label1";
            label1.Size = new Size(114, 30);
            label1.TabIndex = 1;
            label1.Text = "아이디 찾기";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Noto Sans KR Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(199, 94);
            label2.Name = "label2";
            label2.Size = new Size(204, 21);
            label2.TabIndex = 2;
            label2.Text = "아래 양식에 맞게 입력해주세요";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Noto Sans KR", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(5, 4);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "이름";
            txtName.Size = new Size(390, 40);
            txtName.TabIndex = 4;
            txtName.KeyDown += txtName_KeyDown;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Noto Sans KR", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(5, 45);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "이메일";
            txtEmail.Size = new Size(390, 40);
            txtEmail.TabIndex = 4;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // btnFindID
            // 
            btnFindID.BackColor = Color.MediumSeaGreen;
            btnFindID.FlatAppearance.BorderSize = 0;
            btnFindID.FlatStyle = FlatStyle.Flat;
            btnFindID.Font = new Font("Noto Sans KR Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFindID.ForeColor = Color.White;
            btnFindID.Location = new Point(188, 292);
            btnFindID.Name = "btnFindID";
            btnFindID.Size = new Size(420, 55);
            btnFindID.TabIndex = 5;
            btnFindID.Text = "아이디 찾기";
            btnFindID.UseVisualStyleBackColor = false;
            btnFindID.Click += btnFindID_Click;
            btnFindID.Paint += btnFindID_Paint;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Noto Sans KR", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(5, 86);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "전화번호";
            txtPhone.Size = new Size(390, 40);
            txtPhone.TabIndex = 4;
            txtPhone.KeyDown += txtPhone_KeyDown;
            // 
            // pnlIdFound
            // 
            pnlIdFound.Controls.Add(label4);
            pnlIdFound.Controls.Add(label3);
            pnlIdFound.Controls.Add(txtName);
            pnlIdFound.Controls.Add(txtPhone);
            pnlIdFound.Controls.Add(txtEmail);
            pnlIdFound.Location = new Point(199, 133);
            pnlIdFound.Name = "pnlIdFound";
            pnlIdFound.Size = new Size(398, 130);
            pnlIdFound.TabIndex = 6;
            pnlIdFound.Paint += pnlIdFound_Paint;
            // 
            // label4
            // 
            label4.BackColor = Color.LightGray;
            label4.FlatStyle = FlatStyle.System;
            label4.Location = new Point(5, 86);
            label4.Name = "label4";
            label4.Size = new Size(390, 1);
            label4.TabIndex = 8;
            // 
            // label3
            // 
            label3.BackColor = Color.LightGray;
            label3.FlatStyle = FlatStyle.System;
            label3.Location = new Point(5, 45);
            label3.Name = "label3";
            label3.Size = new Size(390, 1);
            label3.TabIndex = 7;
            // 
            // FindId
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(799, 451);
            Controls.Add(pnlIdFound);
            Controls.Add(btnFindID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FindId";
            Text = "FindId";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlIdFound.ResumeLayout(false);
            pnlIdFound.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtEmail;
        private Button btnFindID;
        private TextBox txtPhone;
        private Panel pnlIdFound;
        private Label label4;
        private Label label3;
    }
}