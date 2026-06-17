using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Project_Maver.Common
{
    internal class Holidays
    {

        public Dictionary<DateTime, string> getHolidays(int year)
        {
            // 양력 공휴일
            Dictionary<DateTime, string> holidayList = new Dictionary<DateTime, string>();

            // [수정] .Add 대신 [key] = value 방식을 사용하면 중복 날짜 발생 시에도 에러가 나지 않습니다.
            holidayList[new DateTime(year, 1, 1)] = "신정"; // (1월 1일은 설날이 아니라 신정이죠!)
            holidayList[new DateTime(year, 3, 1)] = "삼일절";
            holidayList[new DateTime(year, 5, 5)] = "어린이날";
            holidayList[new DateTime(year, 6, 6)] = "현충일";
            holidayList[new DateTime(year, 8, 15)] = "광복절";
            holidayList[new DateTime(year, 10, 3)] = "개천절";
            holidayList[new DateTime(year, 10, 9)] = "한글날";
            holidayList[new DateTime(year, 12, 25)] = "성탄절";

            KoreanLunisolarCalendar korLunDate = new KoreanLunisolarCalendar();

            // 설날 (음력 1월 1일) 및 전후일
            DateTime lunarNewYear = GetSolarFromLunar(year, 1, 1);
            holidayList[lunarNewYear.AddDays(-1)] = "설날 연휴";
            holidayList[lunarNewYear] = "설날";
            holidayList[lunarNewYear.AddDays(1)] = "설날 연휴";

            // 부처님 오신 날 (음력 4월 8일)
            holidayList[GetSolarFromLunar(year, 4, 8)] = "석가탄신일";

            // 추석 (음력 8월 15일) 및 전후일
            DateTime lunarThanksgiving = GetSolarFromLunar(year, 8, 15);
            holidayList[lunarThanksgiving.AddDays(-1)] = "추석 연휴";
            holidayList[lunarThanksgiving] = "추석";
            holidayList[lunarThanksgiving.AddDays(1)] = "추석 연휴";

            return holidayList;
        }
        

        private DateTime GetSolarFromLunar(int year, int month, int day)
        {
            KoreanLunisolarCalendar lunar = new KoreanLunisolarCalendar();

            // 해당 연도의 음력 달 내에 해당 일자가 존재하는지 확인 (윤달 등 예외 처리)
            if (day > lunar.GetDaysInMonth(year, month))
            {
                day = lunar.GetDaysInMonth(year, month);
            }

            return lunar.ToDateTime(year, month, day, 0, 0, 0, 0);
        }

}
}
