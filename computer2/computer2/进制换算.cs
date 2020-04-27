using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computer2
{
    public partial class 进制换算 : Form
    {
        int num1;
        private void jzzh()
        {
            if(comboBox1.Text == "十进制→二进制")
            {
                num1 = Convert.ToInt32(textBox1.Text);
                string num2 = Convert.ToString(num1, 2);
                textBox2.Text = num2;
            }
            else if(comboBox1.Text == "二进制→十进制")
            {
                num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(num1.ToString(), 2);
                textBox2.Text = num2.ToString();
            }
            else if(comboBox1.Text == "十进制→十六进制")
            {
                num1 = Convert.ToInt32(textBox1.Text);
                String strA = num1.ToString("x8");
                textBox2.Text = strA;
            }
            else if (comboBox1.Text == "十六进制→十进制")
            {
                int b = Int32.Parse(textBox1.Text, System.Globalization.NumberStyles.HexNumber);
            }
            else if (comboBox1.Text == "二进制→十六进制")
            {
                textBox2.Text = string.Format("{0:X}", System.Convert.ToInt32(textBox1.Text, 2));
            }
            else if (comboBox1.Text == "十六进制→二进制")
            {
                long num3 = Convert.ToInt64(textBox1.Text);
                string b = System.Convert.ToString(num3, 2);
                textBox2.Text = b;
            }
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            //Families 是类 FontFamily 的一个静态属性，得到操作系统中所使用的所有字体名
            FontFamily[] families = FontFamily.Families;// 静态属性没有类的对象也可使用
            foreach (FontFamily family in families)
            comboBox1.Items.Add(family.Name);// 注意 Add 方法的使用
        }

        public 进制换算()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jzzh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

        }
    }
}
