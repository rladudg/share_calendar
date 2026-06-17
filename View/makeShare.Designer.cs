namespace Project_Maver.View
{
    partial class makeShare
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
            components = new System.ComponentModel.Container();
            cbCalendarSelect = new ComboBox();
            txtCalName = new TextBox();
            label1 = new Label();
            _panel = new Panel();
            lbShareUser = new Label();
            txtShareUser = new TextBox();
            lvShareUser = new ListView();
            contextMenuStripDelete = new ContextMenuStrip(components);
            제거ToolStripMenuItem = new ToolStripMenuItem();
            btnUserPlus = new Button();
            rbColor = new Project_Maver.Common.RoundButton();
            btnSharePlus = new Button();
            label3 = new Label();
            panel1 = new Panel();
            contextMenuStripDelete.SuspendLayout();
            SuspendLayout();
            // 
            // cbCalendarSelect
            // 
            cbCalendarSelect.Enabled = false;
            cbCalendarSelect.FlatStyle = FlatStyle.Flat;
            cbCalendarSelect.Font = new Font("Noto Sans KR Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbCalendarSelect.FormattingEnabled = true;
            cbCalendarSelect.Items.AddRange(new object[] { "개인", "공용" });
            cbCalendarSelect.Location = new Point(127, 193);
            cbCalendarSelect.Name = "cbCalendarSelect";
            cbCalendarSelect.Size = new Size(121, 27);
            cbCalendarSelect.TabIndex = 8;
            // 
            // txtCalName
            // 
            txtCalName.BackColor = Color.White;
            txtCalName.Font = new Font("Noto Sans KR Medium", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtCalName.Location = new Point(12, 40);
            txtCalName.Multiline = true;
            txtCalName.Name = "txtCalName";
            txtCalName.PlaceholderText = "캘린더명을 입력하세요";
            txtCalName.Size = new Size(480, 47);
            txtCalName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans KR Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 110);
            label1.Name = "label1";
            label1.Size = new Size(102, 27);
            label1.TabIndex = 1;
            label1.Text = "캘린더 색상";
            // 
            // _panel
            // 
            _panel.BackColor = Color.Silver;
            _panel.Location = new Point(12, 159);
            _panel.Name = "_panel";
            _panel.Size = new Size(480, 1);
            _panel.TabIndex = 2;
            // 
            // lbShareUser
            // 
            lbShareUser.AutoSize = true;
            lbShareUser.Font = new Font("Noto Sans KR Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbShareUser.Location = new Point(12, 274);
            lbShareUser.Name = "lbShareUser";
            lbShareUser.Size = new Size(85, 27);
            lbShareUser.TabIndex = 1;
            lbShareUser.Text = "유저 추가";
            // 
            // txtShareUser
            // 
            txtShareUser.Location = new Point(127, 279);
            txtShareUser.Name = "txtShareUser";
            txtShareUser.Size = new Size(308, 25);
            txtShareUser.TabIndex = 3;
            // 
            // lvShareUser
            // 
            lvShareUser.ContextMenuStrip = contextMenuStripDelete;
            lvShareUser.Location = new Point(127, 312);
            lvShareUser.Name = "lvShareUser";
            lvShareUser.Size = new Size(308, 67);
            lvShareUser.TabIndex = 4;
            lvShareUser.UseCompatibleStateImageBehavior = false;
            lvShareUser.View = System.Windows.Forms.View.List;
            // 
            // contextMenuStripDelete
            // 
            contextMenuStripDelete.Items.AddRange(new ToolStripItem[] { 제거ToolStripMenuItem });
            contextMenuStripDelete.Name = "contextMenuStrip1";
            contextMenuStripDelete.Size = new Size(99, 26);
            // 
            // 제거ToolStripMenuItem
            // 
            제거ToolStripMenuItem.Name = "제거ToolStripMenuItem";
            제거ToolStripMenuItem.Size = new Size(98, 22);
            제거ToolStripMenuItem.Text = "제거";
            // 
            // btnUserPlus
            // 
            btnUserPlus.BackColor = Color.Transparent;
            btnUserPlus.FlatAppearance.BorderSize = 0;
            btnUserPlus.FlatStyle = FlatStyle.Flat;
            btnUserPlus.Font = new Font("함초롬돋움", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnUserPlus.ForeColor = Color.DimGray;
            btnUserPlus.Location = new Point(451, 253);
            btnUserPlus.Name = "btnUserPlus";
            btnUserPlus.Size = new Size(32, 57);
            btnUserPlus.TabIndex = 5;
            btnUserPlus.Text = "+";
            btnUserPlus.TextAlign = ContentAlignment.BottomCenter;
            btnUserPlus.UseVisualStyleBackColor = false;
            btnUserPlus.Click += btnUserPlus_Click;
            // 
            // rbColor
            // 
            rbColor.BackColor = Color.RosyBrown;
            rbColor.FlatAppearance.BorderSize = 0;
            rbColor.FlatStyle = FlatStyle.Flat;
            rbColor.Font = new Font("Noto Sans KR Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbColor.Location = new Point(458, 114);
            rbColor.Name = "rbColor";
            rbColor.Size = new Size(25, 25);
            rbColor.TabIndex = 6;
            rbColor.UseVisualStyleBackColor = false;
            rbColor.Click += rbColor_Click;
            // 
            // btnSharePlus
            // 
            btnSharePlus.BackColor = Color.DimGray;
            btnSharePlus.FlatAppearance.BorderSize = 0;
            btnSharePlus.FlatStyle = FlatStyle.Flat;
            btnSharePlus.Font = new Font("Noto Sans KR Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSharePlus.ForeColor = Color.Snow;
            btnSharePlus.Location = new Point(192, 472);
            btnSharePlus.Name = "btnSharePlus";
            btnSharePlus.Size = new Size(118, 41);
            btnSharePlus.TabIndex = 7;
            btnSharePlus.Text = "생성하기";
            btnSharePlus.UseVisualStyleBackColor = false;
            btnSharePlus.Click += btnSharePlus_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans KR Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 189);
            label3.Name = "label3";
            label3.Size = new Size(102, 27);
            label3.TabIndex = 1;
            label3.Text = "캘린더 선택";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(12, 246);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 1);
            panel1.TabIndex = 2;
            // 
            // makeShare
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(502, 627);
            Controls.Add(cbCalendarSelect);
            Controls.Add(btnSharePlus);
            Controls.Add(rbColor);
            Controls.Add(btnUserPlus);
            Controls.Add(lvShareUser);
            Controls.Add(txtShareUser);
            Controls.Add(panel1);
            Controls.Add(_panel);
            Controls.Add(label3);
            Controls.Add(lbShareUser);
            Controls.Add(label1);
            Controls.Add(txtCalName);
            Font = new Font("Noto Sans KR Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "makeShare";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "공유 캘린더";
            Load += makeShare_Load;
            contextMenuStripDelete.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCalName;
        private Label label1;
        private Panel _panel;
        private Label lbShareUser;
        private TextBox txtShareUser;
        private ListView lvShareUser;
        private Button btnUserPlus;
        private ContextMenuStrip contextMenuStripDelete;
        private ToolStripMenuItem 제거ToolStripMenuItem;
        private Common.RoundButton rbColor;
        private Button btnSharePlus;
        private Label label3;
        private Panel panel1;
        private ComboBox cbCalendarSelect;
    }
}