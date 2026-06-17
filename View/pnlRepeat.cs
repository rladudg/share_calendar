using maverCalender;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Maver.View
{
    //
    //
    public partial class pnlRepeat : UserControl
    {

        public pnlRepeat()
        {
            InitializeComponent();

        }

        //열거형으로 요일별 비트연산 값지정
        [Flags]
        enum Days
        {
            None = 0,
            Sun = 1,
            Mon = 2,
            Tue = 4,
            Wed = 8,
            Thu = 16,
            Fri = 32,
            Sat = 64
        }

        //요일 선택시 값 합치기
        private int GetSelectedDays()
        {
            Days days = Days.None;

            if (cbSun.Checked) days |= Days.Sun;   //비트연산 사용해서 여러 요일의 값을 하나로 합침
            if (cbMon.Checked) days |= Days.Mon;
            if (cbTue.Checked) days |= Days.Tue;
            if (cbWed.Checked) days |= Days.Wed;
            if (cbThu.Checked) days |= Days.Thu;
            if (cbFri.Checked) days |= Days.Fri;
            if (cbSat.Checked) days |= Days.Sat;

            return (int)days;
        }
        private void SetSelectedDays(int daysValue)
        {
            Days days = (Days)daysValue;

            // 각 요일 비트가 포함되어 있는지 확인 (& 연산 결과가 0이 아니면 체크된 것)
            cbSun.Checked = (days & Days.Sun) != 0;
            cbMon.Checked = (days & Days.Mon) != 0;
            cbTue.Checked = (days & Days.Tue) != 0;
            cbWed.Checked = (days & Days.Wed) != 0;
            cbThu.Checked = (days & Days.Thu) != 0;
            cbFri.Checked = (days & Days.Fri) != 0;
            cbSat.Checked = (days & Days.Sat) != 0;
        }
        //취소버튼 클릭
        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        //종료의 없음 클릭
        private void rbNon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNon.Checked)
            {
                dtpReStartTime.Visible = false;
                dtpReEndTime.Visible = false;
            }

        }
        //종료의 날짜 클락
        private void rbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDate.Checked)
            {
                dtpReStartTime.Visible = true;
                dtpReEndTime.Visible = true;
            }
        }

        public string RepeatType
        {
            get
            {
                return lbChoice.Text;
            }
            set
            {
                lbChoice.Text = value;
            }
        }
        public int RepeatInterval
        {
            get { return (int)numInterval.Value; }
            set { numInterval.Value = value; }
        }
        public DateTime RepeatStartDate
        {
            get { return dtpReStartTime.Value; }
            set { dtpReStartTime.Value = value; }
        }

        public DateTime RepeatEndDate
        {
            get { return dtpReEndTime.Value; }
            set { dtpReEndTime.Value = value; }
        }
        public int RepeatDays
        {
            get { return GetSelectedDays(); }
            set { SetSelectedDays(value); }
        }




        public event EventHandler RepeatSaved;
        private void btnOk_Click(object sender, EventArgs e)
        {
            RepeatSaved?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

        private void pnlRepeat_Load(object sender, EventArgs e)
        {
            dtpReStartTime.Visible = false;
            dtpReEndTime.Visible = false;
        }
    }
}
