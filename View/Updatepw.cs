using Project_Maver.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Maver.View
{
    public partial class Updatepw : Form
    {
        private string targetId;

        //  생성자를 통해 이전 창(Findpw)에서 아이디를 받아온다.
        public Updatepw(string id)
        {
            InitializeComponent();
            this.targetId = id; // 넘겨받은 아이디를 클래스 내부 변수에 저장
        }

        private void btnFindPW_Click(object sender, EventArgs e)
        {
            // 새 비밀번호와 다시 한번 입력한 새 비밀번호가 일치하는지 검사한다.
            if (txtNewPw.Text != txtCheckNewPw.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.");
                return;
            }

            // JoinMember클래스 안에 있는 UpdatePassword 로직을 실행한다.
            if (JoinMember.UpdatePassword(targetId, txtNewPw.Text))
            {
                MessageBox.Show("비밀번호가 성공적으로 변경되었습니다.");
                this.Close();
            }

            else
            {
                MessageBox.Show("변경에 실패했습니다. 다시 시도해주세요");
            }
        }
        // 서현 - 엔터를 누르면 다음 커서로 이동
        private void txtNewPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCheckNewPw.Focus(); // 비밀번호 확인 커서로 이동
                e.SuppressKeyPress = true;
            }
        }

        // 다 입력하고 엔터를 누르면 비밀번호 수정 버튼 이벤트 실행
        private void txtCheckNewPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFindPW_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}
