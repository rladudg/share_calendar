using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Project_Maver.Common
{
    internal class btnCircle
    {
    }
    public class CircularButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            // 1. 모양을 동그랗게 만들기 위한 그래픽 경로 설정
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            // 2. 버튼의 영역을 타원형으로 지정
            this.Region = new System.Drawing.Region(grPath);

            // 3. 기본 버튼 그리기 (배경색 적용)
            base.OnPaint(pevent);
        }
    }

 }


