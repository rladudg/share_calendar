using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Maver.Common
{
    // UserSession 클래스는 프로젝트 내의 어떤 폼에서든 접근할 수 있는 독립적인 공간에 있어야 합니다.
    internal class UserSession
    {
        // 로그인한 사용자의 아이디를 담아둘 전역 변수
        public static string UserId { get; set; }
        public static string UserName { get; set; }
        
        // 로그아웃 시 정보를 초기화하는 메서드
        public static void Logout()
        {
            UserId = null;
            UserName = null;
        }
    }
}
