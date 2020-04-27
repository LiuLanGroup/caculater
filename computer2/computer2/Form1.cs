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
    public partial class Form1 : Form
    {
        long  num1;
        double result;
        public Form1()
        {
            InitializeComponent();
        }
        private void huilv(string input)
        {
            num1 = Convert.ToInt64(input);
            switch (comboBox1.Text)
            {
                case "人民币CNY":
                    switch(comboBox2.Text)
                    {
                        case "美元USD":
                            result = num1 * 0.1414;
                            textBox2.Text = result.ToString();
                            break;
                        case "日元JPY":
                            result = num1 * 15.2041;
                            textBox2.Text = result.ToString();
                            break;
                        case "欧元EUR":
                            result = num1 * 0.1300;
                            textBox2.Text = result.ToString();
                            break;
                        case "英镑GBP":
                            result = num1 * 0.1131;
                            textBox2.Text = result.ToString();
                            break;
                        case "韩元KRW":
                            result = num1 * 171.986;
                            textBox2.Text = result.ToString();
                            break;
                        case "港元HKD":
                            result = num1 * 1.096;
                            textBox2.Text = result.ToString();
                            break;
                        case "澳元AUD":
                            result = num1 * 0.2222;
                            textBox2.Text = result.ToString();
                            break;
                        case "加元CAD":
                            result = num1 * 0.1980;
                            textBox2.Text = result.ToString();
                            break;
                        case "":
                            labresult.Text = "请选择正确的目标货币!!";
                            break;
                        case "人民币CNY":
                            labresult.Text = "请选择正确的目标货币!!";
                            break;
                    }
                    break;
                case "美元USD":
                    switch (comboBox2.Text)
                    {
                        case "人民币CNY":
                            result = num1 * 7.0711;
                            textBox2.Text = result.ToString();
                            break;
                        case "日元JPY":
                            result = num1 * 107.51;
                            textBox2.Text = result.ToString();
                            break;
                        case "欧元EUR":
                            result = num1 * 0.9195;
                            textBox2.Text = result.ToString();
                            break;
                        case "英镑GBP":
                            result = num1 * 0.7995;
                            textBox2.Text = result.ToString();
                            break;
                        case "韩元KRW":
                            result = num1 * 1216.13;
                            textBox2.Text = result.ToString();
                            break;
                        case "港元HKD":
                            result = num1 * 7.7499;
                            textBox2.Text = result.ToString();
                            break;
                        case "澳元AUD":
                            result = num1 * 1.5713;
                            textBox2.Text = result.ToString();
                            break;
                        case "加元CAD":
                            result = num1 * 1.3998;
                            textBox2.Text = result.ToString();
                            break;
                        case "":
                            labresult.Text = "请选择正确的目标货币!!";
                            break;
                        case "美元USD":
                            labresult.Text = "请选择正确的目标货币!!";
                            break;
                    }
                    break;
                case "日元JPY":
                    switch (comboBox2.Text)
                    {
                        case "人民币CNY":
                            result = num1 * 0.06577;
                            textBox2.Text = result.ToString();
                            break;
                        case "美元USD":
                            result = num1 * 0.009301;
                            textBox2.Text = result.ToString();
                            break;
                        case "欧元EUR":
                            result = num1 * 0.008552;
                            textBox2.Text = result.ToString();
                            break;
                        case "英镑GBP":
                            result = num1 * 0.007436;
                            textBox2.Text = result.ToString();
                            break;
                        case "韩元KRW":
                            result = num1 * 11.3118;
                            textBox2.Text = result.ToString();
                            break;
                        case "港元HKD":
                            result = num1 * 0.07209;
                            textBox2.Text = result.ToString();
                            break;
                        case "澳元AUD":
                            result = num1 * 0.01462;
                            textBox2.Text = result.ToString();
                            break;
                        case "加元CAD":
                            result = num1 * 0.01302;
                            textBox2.Text = result.ToString();
                            break;
                        case "":
                            labresult.Text = "请选择正确的目标货币!!";
                            break;
                        case "日元JPY":
                            labresult.Text = "请选择正确的目标货币!!";
                            break;
                    }
                    break;
                case "欧元EUR":
                    switch (comboBox2.Text)
                    {
                        case "人民币CNY":
                            result = num1 * 7.6905;
                            textBox2.Text = result.ToString();
                            break;
                        case "美元USD":
                            result = num1 * 1.0876;
                            textBox2.Text = result.ToString();
                            break;
                        case "日元JPY":
                            result = num1 * 116.9279;
                            textBox2.Text = result.ToString();
                            break;
                        case "英镑GBP":
                            result = num1 * 0.8695;
                            textBox2.Text = result.ToString();
                            break;
                        case "韩元KRW":
                            result = num1 * 1322.663;
                            textBox2.Text = result.ToString();
                            break;
                        case "港元HKD":
                            result = num1 * 8.4288;
                            textBox2.Text = result.ToString();
                            break;
                        case "澳元AUD":
                            result = num1 * 1.709;
                            textBox2.Text = result.ToString();
                            break;
                        case "加元CAD":
                            result = num1 * 1.5224;
                            textBox2.Text = result.ToString();
                            break;
                        case "":
                            labresult.Text = "请选择正确的目标货币!!";
                            break;
                        case "欧元EUR":
                            labresult.Text = "请选择正确的目标货币!!";
                            break;
                    }
                    break;
                case "英镑GBP":
                    switch (comboBox2.Text)
                    {
                        case "人民币CNY":
                            result = num1 * 8.8445;
                            textBox2.Text = result.ToString();
                            break;
                        case "美元USD":
                            result = num1 * 1.2508;
                            textBox2.Text = result.ToString();
                            break;
                        case "日元JPY":
                            result = num1 * 134.4735;
                            textBox2.Text = result.ToString();
                            break;
                        case "欧元EUR":
                            result = num1 * 1.1501;
                            textBox2.Text = result.ToString();
                            break;
                        case "韩元KRW":
                            result = num1 * 1521.1354;
                            textBox2.Text = result.ToString();
                            break;
                        case "港元HKD":
                            result = num1 * 9.6936;
                            textBox2.Text = result.ToString();
                            break;
                        case "澳元AUD":
                            result = num1 * 1.9654;
                            textBox2.Text = result.ToString();
                            break;
                        case "加元CAD":
                            result = num1 * 1.7509;
                            textBox2.Text = result.ToString();
                            break;
                        case "":
                            labresult.Text = "请选择正确的目标货币!!";
                            break;
                        case "英镑GBP":
                            labresult.Text = "请选择正确的目标货币!!";
                            break;
                    }
                    break;
                case "韩元KRW":
                    switch (comboBox2.Text)
                    {
                        case "人民币CNY":
                            result = num1 * 0.005814;
                            textBox2.Text = result.ToString();
                            break;
                        case "美元USD":
                            result = num1 * 0.0008223;
                            textBox2.Text = result.ToString();
                            break;
                        case "日元JPY":
                            result = num1 * 0.08840;
                            textBox2.Text = result.ToString();
                            break;
                        case "欧元EUR":
                            result = num1 * 0.0007561;
                            textBox2.Text = result.ToString();
                            break;
                        case "英镑GBP":
                            result = num1 * 0.0006574;
                            textBox2.Text = result.ToString();
                            break;
                        case "港元HKD":
                            result = num1 * 0.006373;
                            textBox2.Text = result.ToString();
                            break;
                        case "澳元AUD":
                            result = num1 * 0.001292;
                            textBox2.Text = result.ToString();
                            break;
                        case "加元CAD":
                            result = num1 * 0.001151;
                            textBox2.Text = result.ToString();
                            break;
                        case "":
                            labresult.Text = "请选择正确的目标货币!!";
                            break;
                        case "韩元KRW":
                            labresult.Text = "请选择正确的目标货币!!";
                            break;
                    }
                    break;
                case "港元HKD":
                    switch (comboBox2.Text)
                    {
                        case "人民币CNY":
                            result = num1 * 0.9124;
                            textBox2.Text = result.ToString();
                            break;
                        case "美元USD":
                            result = num1 * 0.1290;
                            textBox2.Text = result.ToString();
                            break;
                        case "日元JPY":
                            result = num1 * 13.8724;
                            textBox2.Text = result.ToString();
                            break;
                        case "欧元EUR":
                            result = num1 * 0.1186;
                            textBox2.Text = result.ToString();
                            break;
                        case "英镑GBP":
                            result = num1 * 0.1032;
                            textBox2.Text = result.ToString();
                            break;
                        case "韩元KRW":
                            result = num1 * 156.922;
                            textBox2.Text = result.ToString();
                            break;
                        case "澳元AUD":
                            result = num1 * 0.2028;
                            textBox2.Text = result.ToString();
                            break;
                        case "加元CAD":
                            result = num1 * 0.1806;
                            textBox2.Text = result.ToString();
                            break;
                        case "":
                            labresult.Text = "请选择正确的目标货币!!";
                            break;
                        case "港元HKD":
                            labresult.Text = "请选择正确的目标货币!!";
                            break;
                    }
                    break;
                case "澳元AUD":
                    switch (comboBox2.Text)
                    {
                        case "人民币CNY":
                            result = num1 * 4.5;
                            textBox2.Text = result.ToString();
                            break;
                        case "美元USD":
                            result = num1 * 0.6364;
                            textBox2.Text = result.ToString();
                            break;
                        case "日元JPY":
                            result = num1 * 68.4194;
                            textBox2.Text = result.ToString();
                            break;
                        case "欧元EUR":
                            result = num1 * 0.5851;
                            textBox2.Text = result.ToString();
                            break;
                        case "英镑GBP":
                            result = num1 * 0.5088;
                            textBox2.Text = result.ToString();
                            break;
                        case "韩元KRW":
                            result = num1 * 773.9451;
                            textBox2.Text = result.ToString();
                            break;
                        case "港元HKD":
                            result = num1 * 4.932;
                            textBox2.Text = result.ToString();
                            break;
                        case "加元CAD":
                            result = num1 * 0.8909;
                            textBox2.Text = result.ToString();
                            break;
                        case "":
                            labresult.Text = "请选择正确的目标货币!!";
                            break;
                        case "澳元AUD":
                            labresult.Text = "请选择正确的目标货币!!";
                            break;
                    }
                    break;
                case "加元CAD":
                    switch (comboBox2.Text)
                    {
                        case "人民币CNY":
                            result = num1 * 5.0515;
                            textBox2.Text = result.ToString();
                            break;
                        case "美元USD":
                            result = num1 * 0.7144;
                            textBox2.Text = result.ToString();
                            break;
                        case "日元JPY":
                            result = num1 * 76.8038;
                            textBox2.Text = result.ToString();
                            break;
                        case "欧元EUR":
                            result = num1 * 0.6569;
                            textBox2.Text = result.ToString();
                            break;
                        case "英镑GBP":
                            result = num1 * 0.5711;
                            textBox2.Text = result.ToString();
                            break;
                        case "韩元KRW":
                            result = num1 * 868.7884;
                            textBox2.Text = result.ToString();
                            break;
                        case "港元HKD":
                            result = num1 * 5.5364;
                            textBox2.Text = result.ToString();
                            break;
                        case "澳元AUD":
                            result = num1 * 1.1225;
                            textBox2.Text = result.ToString();
                            break;
                        case "":
                            labresult.Text = "请选择正确的目标货币!!";
                            break;
                        case "加元CAD":
                            labresult.Text = "请选择正确的目标货币!!";
                            break;
                    }
                    break;
                case "":
                    labresult.Text = "请选择正确的货币！！";
                    break;
            }

        }
            
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            huilv(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

        }
    }
}
