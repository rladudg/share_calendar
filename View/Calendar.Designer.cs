namespace Maver_켈린더
{
    partial class Calendar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            TreeNode treeNode1 = new TreeNode("개인 캘린더");
            TreeNode treeNode2 = new TreeNode("개인", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("공용");
            TreeNode treeNode4 = new TreeNode("캘린더", new TreeNode[] { treeNode2, treeNode3 });
            imageList1 = new ImageList(components);
            pnlMain = new Panel();
            pictureBox1 = new PictureBox();
            btnGoToday = new Button();
            pictureBox2 = new PictureBox();
            pnlCategori = new Panel();
            CalenderPlus = new PictureBox();
            treeView1 = new TreeView();
            cmsCalendar = new ContextMenuStrip(components);
            tsmDelete = new ToolStripMenuItem();
            tsmExit = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pnlHead = new Panel();
            lblDesc = new Label();
            pbWeather1 = new PictureBox();
            lbWeather = new Label();
            lblTemp = new Label();
            pbSearch = new PictureBox();
            pbProfile = new PictureBox();
            lbID = new Label();
            btnBeforeDate = new Button();
            btnAfterDate = new Button();
            lbThisDate = new Label();
            flpMain = new FlowLayoutPanel();
            btnUpdatepw = new Button();
            btnLogInOut = new Button();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlCategori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CalenderPlus).BeginInit();
            cmsCalendar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbWeather1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "menu_open.png");
            imageList1.Images.SetKeyName(1, "menu_close.png");
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pictureBox1);
            pnlMain.Controls.Add(btnGoToday);
            pnlMain.Controls.Add(pictureBox2);
            pnlMain.Controls.Add(pnlCategori);
            pnlMain.Controls.Add(tableLayoutPanel1);
            pnlMain.Controls.Add(pnlHead);
            pnlMain.Controls.Add(flpMain);
            pnlMain.Controls.Add(btnUpdatepw);
            pnlMain.Controls.Add(btnLogInOut);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1584, 1061);
            pnlMain.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(130, 218);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnGoToday
            // 
            btnGoToday.BackColor = Color.Plum;
            btnGoToday.FlatAppearance.BorderColor = SystemColors.Control;
            btnGoToday.FlatAppearance.BorderSize = 0;
            btnGoToday.FlatStyle = FlatStyle.Flat;
            btnGoToday.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoToday.ForeColor = Color.Black;
            btnGoToday.Location = new Point(909, 910);
            btnGoToday.Name = "btnGoToday";
            btnGoToday.Size = new Size(115, 44);
            btnGoToday.TabIndex = 13;
            btnGoToday.Text = "📆 오늘";
            btnGoToday.UseVisualStyleBackColor = false;
            btnGoToday.Click += btnGoToday_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pnlCategori
            // 
            pnlCategori.Controls.Add(CalenderPlus);
            pnlCategori.Controls.Add(treeView1);
            pnlCategori.Location = new Point(-300, 0);
            pnlCategori.Name = "pnlCategori";
            pnlCategori.Size = new Size(300, 862);
            pnlCategori.TabIndex = 1;
            // 
            // CalenderPlus
            // 
            CalenderPlus.BackColor = Color.Linen;
            CalenderPlus.Image = (Image)resources.GetObject("CalenderPlus.Image");
            CalenderPlus.Location = new Point(264, 13);
            CalenderPlus.Name = "CalenderPlus";
            CalenderPlus.Size = new Size(21, 23);
            CalenderPlus.SizeMode = PictureBoxSizeMode.Zoom;
            CalenderPlus.TabIndex = 2;
            CalenderPlus.TabStop = false;
            CalenderPlus.Click += CalenderPlus_Click;
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.Linen;
            treeView1.ContextMenuStrip = cmsCalendar;
            treeView1.Dock = DockStyle.Fill;
            treeView1.DrawMode = TreeViewDrawMode.OwnerDrawText;
            treeView1.Font = new Font("Noto Sans KR", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeNode1.Checked = true;
            treeNode1.Name = "ndPrivate1";
            treeNode1.Text = "개인 캘린더";
            treeNode2.Name = "ndPrivate";
            treeNode2.NodeFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            treeNode2.Text = "개인";
            treeNode3.Name = "ndPublic";
            treeNode3.NodeFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            treeNode3.Text = "공용";
            treeNode4.BackColor = Color.White;
            treeNode4.Name = "ndMain";
            treeNode4.NodeFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            treeNode4.Text = "캘린더";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode4 });
            treeView1.Size = new Size(300, 862);
            treeView1.TabIndex = 0;
            treeView1.DrawNode += treeView1_DrawNode;
            treeView1.NodeMouseClick += treeView1_NodeMouseClick;
            // 
            // cmsCalendar
            // 
            cmsCalendar.Items.AddRange(new ToolStripItem[] { tsmDelete, tsmExit });
            cmsCalendar.Name = "contextMenuStrip1";
            cmsCalendar.Size = new Size(99, 48);
            cmsCalendar.Opening += cmsCalendar_Opening;
            // 
            // tsmDelete
            // 
            tsmDelete.Name = "tsmDelete";
            tsmDelete.Size = new Size(98, 22);
            tsmDelete.Text = "제거";
            tsmDelete.Click += tsmDelete_Click;
            // 
            // tsmExit
            // 
            tsmExit.Name = "tsmExit";
            tsmExit.Size = new Size(98, 22);
            tsmExit.Text = "탈퇴";
            tsmExit.Click += tsmExit_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2881613F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(label5, 3, 0);
            tableLayoutPanel1.Controls.Add(label6, 4, 0);
            tableLayoutPanel1.Controls.Add(label7, 5, 0);
            tableLayoutPanel1.Controls.Add(label8, 6, 0);
            tableLayoutPanel1.Location = new Point(29, 170);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1511, 36);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Pink;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(209, 36);
            label2.TabIndex = 0;
            label2.Text = "☀️ 일요일";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Linen;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(218, 0);
            label3.Name = "label3";
            label3.Size = new Size(209, 36);
            label3.TabIndex = 1;
            label3.Text = "🌙 월요일";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Linen;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(433, 0);
            label4.Name = "label4";
            label4.Size = new Size(209, 36);
            label4.TabIndex = 1;
            label4.Text = "🔥 화요일";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Linen;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(648, 0);
            label5.Name = "label5";
            label5.Size = new Size(209, 36);
            label5.TabIndex = 1;
            label5.Text = "💧 수요일";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Linen;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.MediumSeaGreen;
            label6.Location = new Point(863, 0);
            label6.Name = "label6";
            label6.Size = new Size(209, 36);
            label6.TabIndex = 1;
            label6.Text = "🌳 목요일";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Linen;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.MediumPurple;
            label7.Location = new Point(1078, 0);
            label7.Name = "label7";
            label7.Size = new Size(209, 36);
            label7.TabIndex = 1;
            label7.Text = "❤️ 금요일";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightBlue;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(1293, 0);
            label8.Name = "label8";
            label8.Size = new Size(215, 36);
            label8.TabIndex = 1;
            label8.Text = "🎈 토요일";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHead
            // 
            pnlHead.Anchor = AnchorStyles.Top;
            pnlHead.Controls.Add(lblDesc);
            pnlHead.Controls.Add(pbWeather1);
            pnlHead.Controls.Add(lbWeather);
            pnlHead.Controls.Add(lblTemp);
            pnlHead.Controls.Add(pbSearch);
            pnlHead.Controls.Add(pbProfile);
            pnlHead.Controls.Add(lbID);
            pnlHead.Controls.Add(btnBeforeDate);
            pnlHead.Controls.Add(btnAfterDate);
            pnlHead.Controls.Add(lbThisDate);
            pnlHead.Location = new Point(39, 0);
            pnlHead.Name = "pnlHead";
            pnlHead.Size = new Size(1488, 138);
            pnlHead.TabIndex = 2;
            // 
            // lblDesc
            // 
            lblDesc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Noto Sans KR Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDesc.ForeColor = Color.Gray;
            lblDesc.Location = new Point(128, 101);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(42, 21);
            lblDesc.TabIndex = 16;
            lblDesc.Text = "desc";
            // 
            // pbWeather1
            // 
            pbWeather1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbWeather1.Location = new Point(130, 64);
            pbWeather1.Name = "pbWeather1";
            pbWeather1.Size = new Size(36, 34);
            pbWeather1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbWeather1.TabIndex = 17;
            pbWeather1.TabStop = false;
            // 
            // lbWeather
            // 
            lbWeather.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbWeather.AutoSize = true;
            lbWeather.Font = new Font("Noto Sans KR Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbWeather.ForeColor = Color.DimGray;
            lbWeather.Location = new Point(12, 69);
            lbWeather.Name = "lbWeather";
            lbWeather.Size = new Size(116, 24);
            lbWeather.TabIndex = 14;
            lbWeather.Text = "✔️ 오늘의 날씨";
            // 
            // lblTemp
            // 
            lblTemp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTemp.AutoSize = true;
            lblTemp.Font = new Font("Noto Sans KR Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTemp.ForeColor = Color.Gray;
            lblTemp.Location = new Point(51, 101);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(47, 21);
            lblTemp.TabIndex = 14;
            lblTemp.Text = "temp";
            // 
            // pbSearch
            // 
            pbSearch.Image = (Image)resources.GetObject("pbSearch.Image");
            pbSearch.Location = new Point(1367, 100);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(118, 38);
            pbSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSearch.TabIndex = 13;
            pbSearch.TabStop = false;
            pbSearch.Click += pbSearch_Click;
            // 
            // pbProfile
            // 
            pbProfile.Image = (Image)resources.GetObject("pbProfile.Image");
            pbProfile.Location = new Point(1276, 29);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(44, 36);
            pbProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfile.TabIndex = 7;
            pbProfile.TabStop = false;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbID.Location = new Point(1326, 39);
            lbID.Name = "lbID";
            lbID.Size = new Size(94, 21);
            lbID.TabIndex = 5;
            lbID.Text = "환영합니다.";
            // 
            // btnBeforeDate
            // 
            btnBeforeDate.Anchor = AnchorStyles.Top;
            btnBeforeDate.BackColor = Color.Transparent;
            btnBeforeDate.FlatAppearance.BorderSize = 0;
            btnBeforeDate.FlatStyle = FlatStyle.Flat;
            btnBeforeDate.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnBeforeDate.ForeColor = Color.FromArgb(64, 64, 64);
            btnBeforeDate.Location = new Point(581, 48);
            btnBeforeDate.Name = "btnBeforeDate";
            btnBeforeDate.Size = new Size(37, 59);
            btnBeforeDate.TabIndex = 1;
            btnBeforeDate.Text = "◀";
            btnBeforeDate.UseVisualStyleBackColor = false;
            btnBeforeDate.Click += btnBeforeDate_Click;
            // 
            // btnAfterDate
            // 
            btnAfterDate.Anchor = AnchorStyles.Top;
            btnAfterDate.BackColor = Color.Transparent;
            btnAfterDate.FlatAppearance.BorderSize = 0;
            btnAfterDate.FlatStyle = FlatStyle.Flat;
            btnAfterDate.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnAfterDate.ForeColor = Color.FromArgb(64, 64, 64);
            btnAfterDate.Location = new Point(870, 48);
            btnAfterDate.Name = "btnAfterDate";
            btnAfterDate.Size = new Size(37, 59);
            btnAfterDate.TabIndex = 1;
            btnAfterDate.Text = "▶";
            btnAfterDate.UseVisualStyleBackColor = false;
            btnAfterDate.Click += btnAfterDate_Click;
            // 
            // lbThisDate
            // 
            lbThisDate.Anchor = AnchorStyles.Top;
            lbThisDate.AutoSize = true;
            lbThisDate.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbThisDate.ForeColor = Color.FromArgb(64, 64, 64);
            lbThisDate.Location = new Point(652, 43);
            lbThisDate.Name = "lbThisDate";
            lbThisDate.Size = new Size(195, 67);
            lbThisDate.TabIndex = 0;
            lbThisDate.Text = "2026.3";
            // 
            // flpMain
            // 
            flpMain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flpMain.AutoScroll = true;
            flpMain.BackColor = Color.Transparent;
            flpMain.Location = new Point(201, 218);
            flpMain.Name = "flpMain";
            flpMain.Size = new Size(1278, 681);
            flpMain.TabIndex = 0;
            // 
            // btnUpdatepw
            // 
            btnUpdatepw.BackColor = Color.FloralWhite;
            btnUpdatepw.FlatAppearance.BorderSize = 0;
            btnUpdatepw.FlatStyle = FlatStyle.Flat;
            btnUpdatepw.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdatepw.Location = new Point(1477, 916);
            btnUpdatepw.Name = "btnUpdatepw";
            btnUpdatepw.Size = new Size(127, 42);
            btnUpdatepw.TabIndex = 12;
            btnUpdatepw.Text = "회원정보수정";
            btnUpdatepw.UseVisualStyleBackColor = false;
            btnUpdatepw.Click += btnUpdatepw_Click;
            // 
            // btnLogInOut
            // 
            btnLogInOut.FlatAppearance.BorderColor = Color.Gray;
            btnLogInOut.FlatAppearance.BorderSize = 0;
            btnLogInOut.FlatStyle = FlatStyle.Flat;
            btnLogInOut.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogInOut.Location = new Point(1620, 916);
            btnLogInOut.Name = "btnLogInOut";
            btnLogInOut.Size = new Size(97, 43);
            btnLogInOut.TabIndex = 3;
            btnLogInOut.Text = "로그인";
            btnLogInOut.UseVisualStyleBackColor = true;
            btnLogInOut.Click += btnLogInOut_Click;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1584, 1061);
            Controls.Add(pnlMain);
            Name = "Calendar";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Calendar_Load;
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlCategori.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CalenderPlus).EndInit();
            cmsCalendar.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlHead.ResumeLayout(false);
            pnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbWeather1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private Panel pnlMain;
        private FlowLayoutPanel flpMain;
        private Panel pnlCategori;
        private Panel pnlHead;
        private Label lbThisDate;
        private Button btnAfterDate;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnLogInOut;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnBeforeDate;
        private Label lbID;
        private PictureBox pictureBox2;
        private PictureBox pbProfile;
        private TreeView treeView1;
        private PictureBox CalenderPlus;
        private ContextMenuStrip cmsCalendar;
        private ToolStripMenuItem tsmDelete;
        private ToolStripMenuItem tsmExit;
        private Button btnUpdatepw;
        private PictureBox pbSearch;
        private Button btnGoToday;
        private PictureBox pictureBox1;
        private Label lblTemp;
        private Label lblDesc;
        private PictureBox pbWeather1;
        private Label lbWeather;
    }
}
