namespace Project_Maver.View
{
    partial class Findpw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Findpw));
            btnFindPW = new Button();
            txtId1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtEmail1 = new TextBox();
            pnlFindpw = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlFindpw.SuspendLayout();
            SuspendLayout();
            // 
            // btnFindPW
            // 
            btnFindPW.BackColor = Color.MediumSeaGreen;
            btnFindPW.FlatAppearance.BorderSize = 0;
            btnFindPW.FlatStyle = FlatStyle.Flat;
            btnFindPW.Font = new Font("Noto Sans KR Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFindPW.ForeColor = Color.White;
            btnFindPW.Location = new Point(184, 284);
            btnFindPW.Name = "btnFindPW";
            btnFindPW.Size = new Size(420, 55);
            btnFindPW.TabIndex = 15;
            btnFindPW.Text = "임시 비밀번호 발급";
            btnFindPW.UseVisualStyleBackColor = false;
            btnFindPW.Click += btnFindPW_Click;
            // 
            // txtId1
            // 
            txtId1.BorderStyle = BorderStyle.None;
            txtId1.Font = new Font("맑은 고딕", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtId1.Location = new Point(3, 3);
            txtId1.Multiline = true;
            txtId1.Name = "txtId1";
            txtId1.PlaceholderText = "아이디";
            txtId1.Size = new Size(390, 40);
            txtId1.TabIndex = 14;
            txtId1.KeyDown += txtId1_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Noto Sans KR Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(195, 118);
            label2.Name = "label2";
            label2.Size = new Size(228, 24);
            label2.TabIndex = 8;
            label2.Text = "아이디와 이메일을 입력해주세요";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans KR Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(195, 83);
            label1.Name = "label1";
            label1.Size = new Size(154, 35);
            label1.TabIndex = 7;
            label1.Text = "비밀번호 찾기";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txtEmail1
            // 
            txtEmail1.BorderStyle = BorderStyle.None;
            txtEmail1.Font = new Font("맑은 고딕", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail1.Location = new Point(3, 45);
            txtEmail1.Multiline = true;
            txtEmail1.Name = "txtEmail1";
            txtEmail1.PlaceholderText = "이메일";
            txtEmail1.Size = new Size(390, 40);
            txtEmail1.TabIndex = 14;
            txtEmail1.KeyDown += txtEmail1_KeyDown;
            // 
            // pnlFindpw
            // 
            pnlFindpw.Controls.Add(label3);
            pnlFindpw.Controls.Add(txtId1);
            pnlFindpw.Controls.Add(txtEmail1);
            pnlFindpw.Location = new Point(195, 155);
            pnlFindpw.Name = "pnlFindpw";
            pnlFindpw.Size = new Size(398, 97);
            pnlFindpw.TabIndex = 16;
            pnlFindpw.Paint += pnlFindpw_Paint;
            // 
            // label3
            // 
            label3.BackColor = Color.LightGray;
            label3.Location = new Point(6, 42);
            label3.Name = "label3";
            label3.Size = new Size(390, 1);
            label3.TabIndex = 17;
            // 
            // Findpw
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(799, 451);
            Controls.Add(pnlFindpw);
            Controls.Add(btnFindPW);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Findpw";
            Text = "Findpw";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlFindpw.ResumeLayout(false);
            pnlFindpw.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFindPW;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtId1;
        private Label label4;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtEmail1;
        private Panel pnlFindpw;
        private Label label3;
    }
}