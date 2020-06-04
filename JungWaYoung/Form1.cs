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
    public partial class Form1 : Form  // 상속받음 계속 만들 수 있다. 화면이 끝나면 작업이 종료
    {
        public Form1() // form1에 대한 생성자
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e) // 로딩뙬 때 뜨는 이벤트를 정해주기
        {
            
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // 버튼 클릭했을 때 하는 작업
        {
            // 얘는 모달 대화상자
            var result = MessageBox.Show("THis is Message Box!!", "Title", MessageBoxButtons.YesNo);  // message box는 이미 객체!
            if(result == DialogResult.Yes)
            {
                MessageBox.Show("You Say Yes!");
            }
            else
            {
                MessageBox.Show("cansle");
            }
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 파일클로즈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 이 곳을 모달리스 대화상자로 만들어볼겁니다. Form2인 modaless를 불ㄹ름니다.
            Modaless modaless = new Modaless(); // modaless 객체 선언
            modaless.Show();  // modaless 객체를 화면에 보이게 하는것 

        }

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 글꼴을 바꿀 수 있도록 하는 공용 대화상자 메소드를 해볼겁니다.
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;  // color에 대한 부분 활성화
            fontDialog.Color = label1.ForeColor; // label1의 전경색이라는 특성을 가져옴 배경색 : backgroundcolor
            fontDialog.Font = label1.Font;  // 폰트 가져옴
            DialogResult dialogResult = fontDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                // 다이어로그 메뉴에서 오케이했다면?
                label1.Font = fontDialog.Font; // fontdialog에서 label1 폰트로 적용해라
                label1.ForeColor = fontDialog.Color;  // 컬러 적용하기
            }

        }

        private void 색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 색을 바꿀 수 있는 공용 대화상자 메소드를 해볼겁니다. 
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = label1.ForeColor;
            DialogResult result = colorDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                label1.ForeColor = colorDialog.Color;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // 키를 누르고 있을 떄
            label3.Text = "Alt + " + (e.Alt ? "YESS ALT" : "NOOOOOOO") +"\n" + "shift?? " + (e.Shift? "YEs" : "no..") + "\n" 
                + "Ctrl?? " + (e.Control ? "YEs" : "no..") + "\n" + "키코드? " + e.KeyCode + "\n" 
                + "키 데이터 : " + e.KeyData; // @@@? ###: !!! 는@가 true면 #, false면 !
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) // 눌린 키에 대한 정보를 가져오는 e
        {
            // 키를 눌렀을 때?
            label2.Text = "키가 눌렸습니다  " + e.KeyChar;  // 레이블의 글자를 바꾸기)
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // 키를 뗏을 때
            label2.Text = ""; // 내용을 다 빼버리는. null
            label3.Text = "";
        }
    }
}
