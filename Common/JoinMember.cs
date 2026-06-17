using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Project_Maver.Common
{
    internal class JoinMember
    {
        //회원가입 폼(화면에서 입력한 정보를 DB에 자장한다)
        public static bool InsertUser(string id, string pw, string name, string email, string birth, string phone)
            {


            //INSERT INTO 문을 사용하여 user 테이블에 아이디, 이름, 비번 등 6가지 정보를 입력한다.
            string sql = @"INSERT INTO maverdb.user 
                              (id, name, email, pw, birth, phone)
                              VALUES
                              (@id, @name, @email, @pw, @birth, @phone)";
            // @ 기호를 쓴 매개변수는 'SQL 인젝션'이라는 해킹 공격을 막는 아주 안전하고 올바른 방법


            //이건 사용자가 입력한 여러 정보를 하나로 묶어서 DB에 보낸다.
            Dictionary<string, object> param = new Dictionary<string,object>()
                {
                    {"id", id},
                    {"pw", pw},
                    {"name", name},
                    {"email", email},
                    {"birth", birth},
                    {"phone", phone}
                };

                int result = DbManager.void_query(sql, param);
            //result는 몇 명의 정보가 처리했는지 숫자로 알려주고 가입에 성공하면 1로 반환한다.

                return result > 0;

            }

        //로그인 로직
        // 입력한 아이디와 비밀번호가 있는지 확인한다
        public static bool LoginCheck(string id, string pw)
        {
            // DB에서 해당 아이디와 비밀번호가 일치하는 행이 있는지 개수를 센다.
            // SELECT COUNT(*)를 통해 입력받은 ID와 PW가 동시에 일치하는 데이터가 몇 개
            string sql = "SELECT id,name FROM maverdb.user WHERE id = @id AND pw = @pw";
            

            Dictionary<string, object> param = new Dictionary<string, object>()
            {
                {"@id", id},
                {"@pw", pw}
            };


            // select_Query를 사용하여 결과를 가져옵니다.
            // DB에서 데이터 가져오기
            DataTable dt = DbManager.select_Query(sql, param);

            if (dt != null && dt.Rows.Count > 0)
            {
                //서현  : 3월 10일 로그인 성공시 아이디가 아닌 이름으로 환영합니다 라고 나오게 수정함
                UserSession.UserName = dt.Rows[0]["name"].ToString();
                return true;
            }

            return false;
        }


        //아이디 찾기 로직
        public static string FindUserId(string name, string email, string phone)
        {

            // 입력된 id와 일치하는 행의 pw컬럼을 조회한다.
            // WHERE 절에 AND를 사용하여 세 가지 조건이 모두 맞아야만
            // 데이터를 가져오도록 설계되어있다.
            string sql = "SELECT id FROM maverdb.user WHERE name = @name AND email = @email AND phone = @phone";
            Dictionary<string, object> param = new Dictionary<string, object>()
            {
                {"@name", name},
                {"@email", email},
                {"@phone", phone}
            };

            // 조회 결과가 담긴 DataTable을 가져온다.
            DataTable dt = DbManager.select_Query(sql, param);

            // 결과가 존재하면 첫 번째 행의 pw 값을 반환한다.
            if (dt != null && dt.Rows.Count > 0)
            {
                //DB에서 찾은 아이디 값을 문자열 형태로 변환하여 호출한 곳으로 보내준다. 
                return dt.Rows[0]["id"].ToString();
            }

            return null; // 일치하는 아이디가 없을 경우
        }


        // 비밀번호 찾기 로직
        public static string FindUserPassword(string id)
        {
            // DB에서 아이디가 똑같은 사람의 비밀번호를 골라서 보여준다.
            string sql = "SELECT pw FROM maverdb.user WHERE id = @id";

            //아이디의 비밀번호를 가져오라고 명령하는 것과 같다.
            Dictionary<string, object> param = new Dictionary<string, object>()
            {
                {"@id",id}
            };

            DataTable dt = DbManager.select_Query(sql, param);

            if (dt != null && dt.Rows.Count > 0)
            {
                // 나온 결과 표에서 첫 번째 줄(0번 행)의 "pw" 칸에 적힌 내용을 가져온다
                return dt.Rows[0]["pw"].ToString();
            }

            return null;
        }

        // 비밀번호 수정 로직
        public static bool UpdatePassword(string id, string newPw)
        {
            // DB에서 특정 아이디인 사람을 찾아서 그 사람의 비밀번호(pw)를 새로운 값으로 변경하는 코드
            string sql = "UPDATE maverdb.user SET pw = @pw WHERE id = @id";

            Dictionary<string, object> param = new Dictionary<string, object>()
            {
                {"@pw", newPw}, // 새로 바꿀 비밀번호(newPw)
                {"@id",id} // 아이디(id)
            };

            // DBManager의 void_query를 사용하여 실행 결과가 1이상(성공)인지 확인
            int result = DbManager.void_query(sql, param);
            return result > 0;
        }
    }
}
