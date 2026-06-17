using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Maver.Common
{
    internal class WeatherInfo
    {  
        public string Name { get; set; }        // 도시 이름
        public MainData Main { get; set; }      // 온도 정보
        public Weather[] Weather { get; set; }  // 날씨 상태 (흐림, 맑음 등)
    }

    public class MainData
    {
        public double Temp { get; set; }        // 현재 온도
    }

    public class Weather
    {
        public string Description { get; set; } // 날씨 설명 (예: "튼구름")
        public string Icon { get; set; }        // 날씨 아이콘 코드
    }
}
