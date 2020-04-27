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
    public partial class BMI计算 : Form
    {
        private double height;
        private double weight;

        public BMI计算()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            height = Convert.ToDouble(textBox1.Text);
            weight = Convert.ToDouble(textBox2.Text);
            double a = weight / (height * height);
            if (a <= 18.4)
            {
                textBox3.Text = "偏瘦。";
            }
            else if (a > 18.4 && a <= 23.9)
            {
                textBox3.Text = "非常健康！";
            }
            else if (a > 23.9 && a <= 27.9)
            {
                textBox3.Text = "超重了呀。";
            }
            else
            {
                textBox3.Text = "已经肥胖了呢！";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
