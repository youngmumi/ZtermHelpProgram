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
    public partial class BinaryNunmerCalculation : Form
    {
        public BinaryNunmerCalculation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //뒤로 가기
        {
            MainForm mainForm = new MainForm();

            // 현재 폼을 숨기고 첫 번째 폼을 표시
            this.Hide();
            mainForm.Show();
        }

        private void 변환하기_Click(object sender, EventArgs e)
        {
            try
            {
                // 텍스트 상자에서 입력된 십진수를 읽어옵니다.
                int decimalNumber = int.Parse(label2.Text);

                // 십진수를 이진수로 변환하고 결과를 Label2에 표시합니다.
                string binaryNumber = DecimalToBinary(decimalNumber);
                label2.Text = binaryNumber;
            }
            catch (FormatException)
            {
                MessageBox.Show("올바른 십진수를 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string DecimalToBinary(int decimalNumber)
        {
            if (decimalNumber == 0)
                return "0";

            string binary = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;
                binary = remainder + binary;
                decimalNumber /= 2;
            }

            return binary;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

    
}
