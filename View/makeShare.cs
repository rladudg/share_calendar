using Project_Maver.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace Project_Maver.View
{
    public partial class makeShare : Form
    {
        PrivateFontCollection fonts = new PrivateFontCollection();
        public makeShare()
        {
            InitializeComponent();
        }
        private string _mode;
        public makeShare(string mode)
        {
            InitializeComponent();
            this._mode = mode; // 개인 또는 공용 선택 저장
        }
        private void btnSharePlus_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. 유효성 검사
                if (_mode == "공용" && lvShareUser.Items.Count == 0)
                {
                    MessageBox.Show("공유할 유저를 최소 한 명 이상 선택해주세요");
                    return;
                }

                string calName = txtCalName.Text.Trim();
                if (string.IsNullOrEmpty(calName))
                {
                    MessageBox.Show("캘린더 이름을 입력해주세요");
                    return;
                }

                // 2. 데이터 준비
                Color selectedColor = Color.Black;
                if (rbColor.Tag is Color c)
                {
                    selectedColor = c;
                }
                else
                {
                    selectedColor = rbColor.BackColor;
                }
                string color = ColorTranslator.ToHtml(selectedColor);
                string currentUserId = UserSession.UserId;

                // 3. share_group 데이터 삽입 (INSERT만 먼저 실행)
                string insertGroupSql = "INSERT INTO share_group(share_name, color) VALUES (@name, @color)";
                var groupParam = new Dictionary<string, object> {
            { "@name", calName },
            { "@color", color }
        };

                // void_query로 먼저 확실하게 저장
                DbManager.void_query(insertGroupSql, groupParam);

                // 4. 생성된 ID 가져오기 (분리해서 실행)
                string idSql = "SELECT LAST_INSERT_ID()";
                DataTable dtGroup = DbManager.select_Query(idSql, null);

                if (dtGroup == null || dtGroup.Rows.Count == 0)
                {
                    MessageBox.Show("데이터 저장 후 ID를 가져오는데 실패했습니다.");
                    return;
                }

                int newShareId = Convert.ToInt32(dtGroup.Rows[0][0]);

                // 5. share_member 데이터 삽입 (방장 추가)
                string memberSql = "INSERT INTO share_member(share_id, user_id, role) VALUES (@sid, @id, @role)";
                var ownerParam = new Dictionary<string, object>
        {
            {"@sid", newShareId },
            {"@id", currentUserId },
            {"@role", 1 } // 1을 방장으로 가정
        };
                DbManager.void_query(memberSql, ownerParam);

                // 6. 공용일 경우 멤버들 추가
                if (_mode == "공용")
                {
                    foreach (ListViewItem item in lvShareUser.Items)
                    {
                        if (item.Tag == null) continue;

                        string targetUserId = item.Tag.ToString();
                        var mParam = new Dictionary<string, object>
                {
                    { "@sid", newShareId },
                    { "@id", targetUserId },
                    { "@role", 0 } // 0을 일반 멤버로 가정
                };
                        DbManager.void_query(memberSql, mParam);
                    }
                }

                MessageBox.Show("캘린더가 성공적으로 생성되었습니다!"); // 성공 메시지 추가
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // 에러가 발생하면 여기서 멈추고 이유를 알려줍니다.
                MessageBox.Show($"오류 발생: {ex.Message}\n\n상세 정보: {ex.StackTrace}");
            }
        }

        private void makeShare_Load(object sender, EventArgs e)
        {
            cbCalendarSelect.SelectedItem = _mode;
            UpdateLayoutByMode();

            string fontPath = Path.Combine(Application.StartupPath, "Fonts", "BMJUA_ttf.ttf");

            if (File.Exists(fontPath))
            {
                fonts.AddFontFile(fontPath);
                Font jua1 = new Font(fonts.Families[0], 16, FontStyle.Regular);
                Font jua2 = new Font(fonts.Families[0], 12, FontStyle.Regular);


                btnSharePlus.Font = jua2;
                BorderHelper.SetRoundRegion(btnSharePlus, 18);
                BorderHelper.ApplyDotBorder(btnSharePlus);
            }
        }
        private void UpdateLayoutByMode()
        {
            if (_mode == "개인")
            {
                lbShareUser.Visible = false;
                txtShareUser.Visible = false;
                btnUserPlus.Visible = false;
                lvShareUser.Visible = false;
            }
            else
            {
                lbShareUser.Visible = true;
                txtShareUser.Visible = true;
                btnUserPlus.Visible = true;
                lvShareUser.Visible = true;
            }
        }

        private void btnUserPlus_Click(object sender, EventArgs e)
        {
            string targetId = txtShareUser.Text.Trim();
            if (string.IsNullOrEmpty(targetId)) return;

            if (targetId == UserSession.UserId)
            {
                MessageBox.Show("본인은 추가할 수 없습니다.");
                return;
            }

            string checkSql = "SELECT id, name FROM user WHERE id = @id";
            var param = new Dictionary<string, object> { { "@id", targetId } };
            DataTable dtCheck = DbManager.select_Query(checkSql, param); ////변수명 중복 방지

            if (dtCheck != null && dtCheck.Rows.Count > 0)
            {
                string userName = dtCheck.Rows[0]["name"].ToString();
                string userId = dtCheck.Rows[0]["id"].ToString();

                foreach (ListViewItem existingItem in lvShareUser.Items)
                {
                    if (existingItem.Tag != null && existingItem.Tag.ToString() == userId)
                    {
                        MessageBox.Show("이미 추가된 유저입니다.");
                        return;
                    }
                }

                ListViewItem item = new ListViewItem(userName);
                item.Tag = userId;

                lvShareUser.Items.Add(item);
                txtShareUser.Clear();
            }
            else
            {
                MessageBox.Show("존재하지 않는 유저입니다.");
            }


        }
        private void rbColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                cd.FullOpen = true;
                cd.Color = rbColor.BackColor;

                if (cd.ShowDialog() == DialogResult.OK)
                {
                    rbColor.BackColor = cd.Color;
                    rbColor.Tag = cd.Color;
                }
            }

        }


    }
}
