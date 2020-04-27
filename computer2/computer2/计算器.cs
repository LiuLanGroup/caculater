using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computer2
{
    public partial class 计算器 : Form
    {
        private double num1 = 0;//第一操作数
        private double num2;//第二操作数
        private string sign;//运算符号
        private double num3;//结果
        private double pi = System.Math.PI;
        private double E = System.Math.E;
        private bool c = true;//判断是否为第一操作数
        private bool music = false;
        int tab = 0;
        //记录指针
        int Precord = 0;
        //记录数
        int RecordNum = 0;
        public String text = "";
        //存储记录
        public String[] record = new String[10];
        //存储表达式
        public String[] texts = new String[10000];
        //加载js引擎
        Microsoft.JScript.Vsa.VsaEngine ve = Microsoft.JScript.Vsa.VsaEngine.CreateEngine();
        public 计算器()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = " "; //计算器屏幕初始显示值
            textBox1.TextAlign = HorizontalAlignment.Right;//计算器屏幕文字输出向右对齐
        }
        public void MusicPlayer(int i)
        {
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.SoundLocation = Directory.GetCurrentDirectory() + @"\music\" + i.ToString() + ".WAV";
            sp.Load();
            sp.Play();

        }

        public void NumClick(string mynumber)
        {
            if (c)
            {
                this.text += mynumber;
                this.texts[tab] = mynumber;
                textBox1.Text = this.text;
                tab++;
            }
            else
            {
                textBox1.Text = " ";
                this.text += mynumber;
                this.texts[tab] = mynumber;
                textBox1.Text = this.text;
                tab++;
                c = true;

            }
        }
        
        private void abc(double a, double b, double c)
        {
            double dt = b * b - 4 * a * c;
            if(dt>0)
            {
                double x1 = (-b + System.Math.Sqrt(dt)) / (2 * a);
                double x2 = (-b - System.Math.Sqrt(dt)) / (2 * a);
                textBoxx1.Text = x1.ToString();
                textBoxx2.Text = x2.ToString();

            }
            else if(dt==0)
            {
                double x = (-b) / (2 * a);
                textBoxx1.Text = x.ToString();
                textBoxx2.Text = x.ToString();
            }
            else if(dt<0)
            {
                laberro.Text = "此题无解！！";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (music)
            {
                MusicPlayer(1);
            }
            else
            {
                NumClick("1");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (music)
            {
                MusicPlayer(5);
            }
            else
            {
                NumClick("5");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (music)
            {
                MusicPlayer(2);
            }
            else
            {
                NumClick("2");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (music)
            {
                MusicPlayer(3);
            }
            else
            {
                NumClick("3");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (music)
            {
                MusicPlayer(4);
            }
            else
            {
                NumClick("4");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (music)
            {
                MusicPlayer(6);
            }
            else
            {
                NumClick("6");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (music)
            {
                MusicPlayer(7);
            }
            else
            {
                NumClick("7");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (music)
            {
                MusicPlayer(8);
            }
            else
            {
                NumClick("8");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (music)
            {
                MusicPlayer(9);
            }
            else
            {
                NumClick("9");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NumClick("0");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            NumClick(".");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //sign = "+";
            //num1 = Convert.ToDouble(textBox1.Text);
            //textBox1.Text = " ";
            NumClick("+");

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //sign = "-";
            //num1 = Convert.ToDouble(textBox1.Text);
            //textBox1.Text = " ";
            NumClick("-");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //sign = "*";
            //num1 = Convert.ToDouble(textBox1.Text);
            //textBox1.Text = " ";
            NumClick("*");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //sign = "/";
            //num1 = Convert.ToDouble(textBox1.Text);
            //textBox1.Text = " ";
            NumClick("/");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            switch(sign)
            {
             
                case "10":
                    num2 = Convert.ToDouble(textBox1.Text);
                    num3 = num1 * System.Math.Pow(10, num2);
                    this.text = num3.ToString();
                    textBox1.Text = this.text;
                    break;
                case "^":
                    num2 = Convert.ToDouble(textBox1.Text);
                    num3 = System.Math.Pow(num1, num2);
                    this.text = num3.ToString();
                    textBox1.Text = this.text;
                    break;
                case "√":
                    num2 = Convert.ToDouble(textBox1.Text);
                    num3 = System.Math.Pow(num1, 1.0 / num2);
                    this.text = num3.ToString();
                    textBox1.Text = this.text;
                    break;

            }
            
            try
            {
                this.text = this.text.Replace(")(", ")*(");
                String result = Microsoft.JScript.Eval.JScriptEvaluate(this.text, ve).ToString();

                textBox1.Text = result;
                this.record[RecordNum] = this.text;
                this.text = result;
                
                this.RecordNum++;

                this.Precord = this.RecordNum;
            }
            catch (Exception)
            {
                textBox1.Text = "输入错误！";
                this.text = "";
                tab = 0;
            }
            c = false;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = pi.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Math.Pow(E, num1).ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            sign = "10";
            
            num1 = Convert.ToDouble(this.text);
            this.text = "";
            textBox1.Text = this.text;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.text = "";
            textBox1.Text = this.text;

        }

        private void button31_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            double a = 1 / num1;
            textBox1.Text = a.ToString();
            c = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Math.Pow(num1, 2).ToString();
            c = false;

        }

        private void button23_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Math.Pow(num1, 3).ToString();
            c = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            sign = "^";
            num1 = Convert.ToDouble(this.text);
            this.text = "";
            textBox1.Text = this.text;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            double b = 1;
            for(int i = 0;i<num1-1;i++)
            {
                b = b * (num1 - i);
            }
            textBox1.Text = b.ToString();
            c = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Math.Sqrt(num1).ToString();
            c = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Math.Pow(num1, 1.0 / 3.0).ToString();
            c = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            sign = "√";
            num1 = Convert.ToDouble(this.text);
            this.text = "";
            textBox1.Text = this.text;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Math.Sin(num1).ToString();
            c = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Math.Cos(num1).ToString();
            c = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Math.Tan(num1).ToString();
            c = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Math.Log10(num1).ToString();
            c = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Math.Sinh(num1).ToString();
            c = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Math.Cosh(num1).ToString();
            c = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Math.Tanh(num1).ToString();
            c = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Math.Log(num1).ToString();
            c = false;
        }

        private void bMI计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            BMI计算 f = new BMI计算();
            f.Show();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            _24点 fm = new _24点();
            fm.Show();

        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (tab > 0)
            {
                tab -= 1;
            }
            this.text = "";
            for (int i = 0; i < tab; i++)
            {
                this.text += this.texts[i];
            }
            textBox1.Text = this.text;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            进制换算 jz = new 进制换算();
            jz.Show();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            NumClick("(");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            NumClick(")");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Form1 hl = new Form1();
            hl.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button44_Click(object sender, EventArgs e)
        {
            abc(Convert.ToDouble(textBoxa.Text), Convert.ToDouble(textBoxb.Text), Convert.ToDouble(textBoxc.Text));
        }

        private void button45_Click(object sender, EventArgs e)
        {
            textBoxa.Text = "";
            textBoxb.Text = "";
            textBoxc.Text = "";
            textBoxx1.Text = "";
            textBoxx2.Text = "";
            laberro.Text = "";

        }

        private void button46_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            music = true;
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
            button6.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            button8.BackColor = Color.Red;
            button9.BackColor = Color.Red;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            music = false;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;

        }

        private void button49_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int num = rd.Next(1,57);
            switch (num)

            {
                case 1:
                    textBoxstory.Text = "4396  2016年，LOL选手世界第一打野Clearlove由于状态下滑还坚持选择盲僧，一直被小花生奥拉夫压制，打出伤害量总数为4396";
                    
                    break;
                case 2:
                    textBoxstory.Text = "777   由于厂长人气极高并且在s7赛季改名为Clearlove7，现在在他出场的时候弹幕都在刷77777";
                    break;
                case 3:
                    textBoxstory.Text = "443 :lpl ig.Kids的VN在一场常规赛中 只打了443 的输出";
                    break;
                case 4:
                    textBoxstory.Text = "2760889966649&2760889966651  出自《质数的孤独》孪生质数，他们是离得很近的一对质数，几乎是彼此相邻。但它们之间只有一个偶数，阻隔了它们真正的亲密接触。";
                    break;
                case 5:
                    textBoxstory.Text = "0   Syamu的OFF会人数。";
                    break;
                case 6:
                    textBoxstory.Text = "4：阿森纳的排名。争四狂魔阿森纳"+"\n"+"...ps:米4达！";                    break;
                case 7:
                    textBoxstory.Text = "5：《龙珠》中，战斗力检测仪认为地球人的战斗力数值只有5。战五渣。。。。)";
                    break;
                case 8:
                    textBoxstory.Text = "8：作曲家米津玄师在创作VOCALOID曲目时使用的名字（ハチ）。";
                    break;
                case 9:
                    textBoxstory.Text = "7：七酱：源于著名《英雄联盟》选手，曾将ID改为clearlove7。\n\n\n\n\n\n\n北京时间七点钟，两个队伍的比分是7：7。那就会发生一些神奇的事";
                    break;
                case 10:
                    textBoxstory.Text = "130：指《炉石传说》中的精神控制技师";
                    break;
                case 11:
                    textBoxstory.Text = "233：来源于猫扑论坛旧系列表情符号的第233号，是一张捶地大笑的表情，因此不少网友就喜爱在论坛发帖的时候加上一句“233”。亦可在233后面加上无数的3，表示自己笑的很厉害，如“2333333”。也代表B站看板娘。";
                    break;
                case 12:
                    textBoxstory.Text = "40：2018年《守望先锋》OWL赛事中上海龙之队屡战屡败，最终大分0胜40负";
                    break;
                case 13:
                    textBoxstory.Text = "648：许多手游的一次氪金最大值，即“一单”。当然也有以248或其他数值为一单的。";
                    break;
                case 14:
                    textBoxstory.Text = "2800：2019年LPL春季赛，RNG著名选手uzi在和iG的比赛中仅仅打出了两千八的伤害量，被网友恶搞为“简二八”（现在刷2800和刷4396一样有引战嫌疑）";
                    break;
                case 15:
                    textBoxstory.Text = "9527：源自《唐伯虎点秋香》的网络流行语。当时周星驰扮演的唐伯虎是华府中的9527号佣人，后被多部影视作品引用致敬";
                    break;
                case 16:
                    textBoxstory.Text = "1433223: 王者荣耀英雄元歌的连招梗\n\n\n\n\n33212,211A3,2A1A3A……";
                    break;
                case 17:
                    textBoxstory.Text = "14000605：出自《复仇者联盟3：无限战争》，奇异博士通过时间原石看了一千四百万（准确数14000605）次与灭霸紫薯精战斗的结局，并且只有一次胜利，最终被灭霸打败。但是在《复仇者联盟4：终局之战》中，复仇者联盟穿越回过去，取来无限原石，打败了灭霸，就是奇异博士所说的唯一一次胜利。所以奇异博士看了14000605次复联4结局，都没有剧透过";
                    break;
                case 18:
                    textBoxstory.Text = "6  六学家，两开花！";
                    break;
                case 19:
                    textBoxstory.Text = "10000：中国电信。";
                    break;
                case 20:
                    textBoxstory.Text = "10010：中国联通。";
                    break;
                case 21:
                    textBoxstory.Text = "10086：中国移动的服务号码";
                    break;
                case 22:
                    textBoxstory.Text = "12306：是中国铁道部网络购票网址";
                    break;
                case 23:
                    textBoxstory.Text = "8848：8848钛金手机。";
                    break;
                case 24:
                    textBoxstory.Text = "01：特摄剧《假面骑士Zero-One》主骑";
                    break;
                case 25:
                    textBoxstory.Text = "02：日本动漫《Darling in the FRANXX》（俗称“国家队”）的女主角";
                    break;
                case 26:
                    textBoxstory.Text = "404：网页或文件未找到\n\n\n\n\n\n 平生最讨厌的数字之一";
                    break;
                case 27:
                    textBoxstory.Text = "25252：LoveLive!矢泽妮可口癖 “Nico nico ni～” 的谐音。日语中数字2读音“に”、数字5读音“ご”，即25252与にこにこに谐音。常见于sif中控分截图";
                    break;
                case 28:
                    textBoxstory.Text = "9876547210.33(98e)：2233娘手办2017号拍卖的价格。当然最后流拍了。";
                    break;
                case 29:
                    textBoxstory.Text = "114：查号台";
                    break;
                case 30:
                    textBoxstory.Text = "99977：用手机九宫格键盘输入99977第一个候选项为“珍惜眼前人”。2019年5月起开始流行。";
                    break;
                case 31:
                    textBoxstory.Text = "89757：源自林俊杰歌曲《编号89757》，后常用于机器人的默认编号，或者机器人身份的象征";
                    break;
                case 32:
                    textBoxstory.Text = "19120623：艾伦·麦席森·图灵的生日";
                    break;
                case 33:
                    textBoxstory.Text = "16430104：艾萨克·牛顿的生日";
                    break;
                case 34:
                    textBoxstory.Text = "1972：C语言诞生啦！";
                    break;
                case 35:
                    textBoxstory.Text = "1557：发生MSI季中冠军赛上的一个数字梗，在小组赛之中久负盛名的SKT撞上了咱们LPL赛区的IG战队，本来以为该是一场龙争虎斗的，结果令人哭笑不得的一幕发生了。SKT仅仅挣扎了15分57秒就被IG击溃了，这也打破了LOL史上比赛结束的最短时长！\n \n\n欢迎来到德莱联盟！！！";
                    break;
                case 36:
                    textBoxstory.Text = "991022  一个伟人的生日";
                    break;
                case 37:
                    textBoxstory.Text = "990506  力豪的生日";
                    break;
                case 38:
                    textBoxstory.Text = "990629  凯成的破壳日";
                    break;
                case 39:
                    textBoxstory.Text = "1116：  高渊浩的生日";
                    break;
                case 40:
                    textBoxstory.Text = "990703  儿子的生日(天宇写的)";
                    break;
                case 41:
                    textBoxstory.Text = "0324：  VV的生日";
                    break;
                case 42:
                    textBoxstory.Text = "0601：  NK的生日";
                    break;
                case 43:
                    textBoxstory.Text = "1026：  王睿鑫的生日";
                    break;
                case 44:
                    textBoxstory.Text = "0313：  吴嘉禄的生日";
                    break;
                case 45:
                    textBoxstory.Text = "0401：  胡雅婷的生日";
                    break;
                case 46:
                    textBoxstory.Text = "0118：  陈氢的生日";
                    break;
                case 47:
                    textBoxstory.Text = "0818：  胡文彬的生日";
                    break;
                case 48:
                    textBoxstory.Text = "0518：  彭志远的生日";
                    break;
                case 49:
                    textBoxstory.Text = "0204：  王浩旭的生日";
                    break;
                case 50:
                    textBoxstory.Text = "0713：  乔创奇的生日";
                    break;
                case 51:
                    textBoxstory.Text = "1995：  JAVA问世";
                    break;
                case 52:
                    textBoxstory.Text = "20170607-20170608：这是属于你自己的故事";
                    break;
                case 53:
                    textBoxstory.Text = "20170910：这（大概）是我们相遇的故事";
                    break;
                case 54:
                    textBoxstory.Text = "20171118：shufe 100";
                    break;
                case 55:
                    textBoxstory.Text = "520，1314，1920，1930，20184，517230，8023……";
                    break;
                case 56:
                    textBoxstory.Text = "19491010：“中华人民共和国，今天，成立了！”";
                    break;
                case 57:
                    textBoxstory.Text = "66： 美国66号公路\n66号公路在20世纪初期，不仅提供了美国东西向运输的便捷，它响亮的名气也成为了当时美国流行文化的元素。当中最有名的例子，就是作家约翰·史坦贝克（John Steinbeck）于1939年出版的巨作《愤怒的葡萄》（The Grapes of Wrath）。里头的主角一路从奥克拉荷马州搬到加州，路上所经历的种种，有辛酸也充满温情，皆发生在这条66号公路上。";
                    break;
                


            }
        }
    }
}
