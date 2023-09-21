using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZtermForMe2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //명령어 정리
        {
            CommandForm secondForm = new CommandForm();

            // 현재 폼을 숨기고 명령어 정리 폼을 표시
            this.Hide();
            secondForm.Show();
        }

        private void button2_Click(object sender, EventArgs e) //2진수 계산
        {
            BinaryNunmerCalculation thirdForm = new BinaryNunmerCalculation();

            // 현재 폼을 숨기고 2진수 계산 폼을 표시
            this.Hide();
            thirdForm.Show();
        }
    }
}
