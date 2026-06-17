namespace Project_Maver.View
{
    partial class Updatepw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updatepw));
            btnFindPW = new Button();
            txtNewPw = new TextBox();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtCheckNewPw = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnFindPW
            // 
            btnFindPW.BackColor = Color.LimeGreen;
            btnFindPW.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFindPW.Location = new Point(306, 343);
            btnFindPW.Name = "btnFindPW";
            btnFindPW.Size = new Size(181, 52);
            btnFindPW.TabIndex = 21;
            btnFindPW.Text = "비밀번호 수정하기";
            btnFindPW.UseVisualStyleBackColor = false;
            btnFindPW.Click += btnFindPW_Click;
            // 
            // txtNewPw
            // 
            txtNewPw.Location = new Point(251, 214);
            txtNewPw.Name = "txtNewPw";
            txtNewPw.Size = new Size(324, 23);
            txtNewPw.TabIndex = 20;
            txtNewPw.KeyDown += txtNewPw_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 192);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 19;
            label3.Text = "새 비밀번호 : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(247, 150);
            label1.Name = "label1";
            label1.Size = new Size(307, 30);
            label1.TabIndex = 17;
            label1.Text = "새로운 비밀번호를 입력하세요 ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(251, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 255);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 19;
            label2.Text = "비밀번호 확인 : ";
            // 
            // txtCheckNewPw
            // 
            txtCheckNewPw.Location = new Point(251, 277);
            txtCheckNewPw.Name = "txtCheckNewPw";
            txtCheckNewPw.Size = new Size(324, 23);
            txtCheckNewPw.TabIndex = 20;
            txtCheckNewPw.KeyDown += txtCheckNewPw_KeyDown;
            // 
            // Updatepw
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFindPW);
            Controls.Add(txtCheckNewPw);
            Controls.Add(txtNewPw);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Updatepw";
            Text = "Updatepw";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFindPW;
        private TextBox txtNewPw;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtCheckNewPw;
    }
}