using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JWY2
{
    public partial class Modaless : Form
    {
        // 마우스의 좌표에 대한 변수 설정
        Point mousefirstposition;
        Boolean FirstMove = true; 

        public Modaless()
        {
            InitializeComponent();
        }

        private void Modaless_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // 마우스에 대한 이벤트를 만들고자 합니다.

        private void Modaless_MouseMove(object sender, MouseEventArgs e)
        {
            // 마우스가 움직일 때 윈도우는 마우스의 좌표를 잡아서 반환해준다. (클릭 유무에는 상관이 없었다..!)
            if (FirstMove)
            {
                mousefirstposition = new Point(e.X, e.Y); // x좌표, y 좌표 받기
                FirstMove = false; // 출발점만 True로 남겨놔야 출발점을 인식할 수 있겠지? 


            }
            else
            {
                // 그래픽적 요소를 사용할것
                Graphics g = CreateGraphics();
                Point nowposiion = new Point(e.X, e.Y);  // 현재 좌표를 넣어줍니다.
                g.DrawLine(new Pen(Color.Red), mousefirstposition, nowposiion);  // 선을 그리기
                g.Dispose();  // 사용한 것은 해제시켜주기
                mousefirstposition = nowposiion; // 과거 위치를 현재 위치로 바꿔주기
            }
        }

        

    }
}
