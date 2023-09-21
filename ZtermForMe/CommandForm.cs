using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZtermForMe2
{
    public partial class CommandForm : Form
    {
        public CommandForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //뒤로가기 버튼
        {
            MainForm mainForm = new MainForm();

            // 현재 폼을 숨기고 첫 번째 폼을 표시
            this.Hide();
            mainForm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //파일 생성하는 명령어
        {
            if (checkBox1.Checked)
            {
                // 체크 박스가 체크되었을 때 Label에 텍스트를 설정합니다.
                label1.Text = "vi: (파일명).(파일형식)";
            }
            else
            {
                // 체크 박스가 체크 해제되었을 때 Label의 텍스트를 지웁니다.
                label1.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //파일 내 명령어
        {
            if (checkBox2.Checked)
            {
                // 체크 박스가 체크되었을 때 Label에 텍스트를 설정합니다.
                label1.Text = "i : 현재 커서가 위치하고 있는 바로 앞부터 삽입이 시작됨.\r\na : 현재 커서가 위치하고 있는 바로 뒤부터 삽입이 시작됨\r\no : 현재 커서가 위치하고 있는 줄의 바로 아래에 새로운 줄로 삽입이 시작됨.\r\nI : 현재 커서가 위치하고 있는 줄의 맨 앞부터 삽입이 시작됨.\r\nA : 현재 커서가 위치하고 있는 줄의 맨 뒤부터 삽입이 시작됨.\r\nO : 현재 커서가 위치하고 있는 줄의 바로 위에 새로운 줄로 삽입이 시작됨.\r\n\r\nw : 현재 편집 중인 문서를 vi를 실행할 때 명시한 파일에 저장함.\r\nw 경로명 : 현재 편집 중인 문서를 vi의 실행 형태에 관계 없이 여기서 지정한 경로명에 대응되는 파일에 저장함.\r\nq : 현재 진행 중인 편집을 중단하고 vi를 종료함, 수정된 내용 중 저장되지 않은 부분이 남아 있다면, 이 명령어는 실행될 수 없음\r\nq! : 수정된 내용 중 저장되지 않은 부분이 남아 있더라도 vi를 강제적으로 종료시킴\r\nwq : w 와 q의 기능을 차례로 실행함 ";
            }
            else
            {
                // 체크 박스가 체크 해제되었을 때 Label의 텍스트를 지웁니다.
                label1.Text = "";
            }
        }
    }

}
