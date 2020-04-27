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
    
    
    public partial class Form2 : Form
    {
        Matrix A = new Matrix();
        Matrix B = new Matrix();
        Matrix C = new Matrix();
        double num = 0;
        public Form2()
        {
            InitializeComponent();
        }
        
        private void textBox111_TextChanged(object sender, EventArgs e)
        {
            A.write(1, 1, Convert.ToDouble(textBox111.Text));
        }

        private void textBoxm1_TextChanged(object sender, EventArgs e)
        {
            A.setm(Convert.ToInt32(textBoxm1.Text));
            A.init_matrix(A.m, A.n);
        }

        private void textBoxn1_TextChanged(object sender, EventArgs e)
        {
            A.setn(Convert.ToInt32(textBoxn1.Text));
            A.init_matrix(A.m, A.n);
        }

        private void textBoxm2_TextChanged(object sender, EventArgs e)
        {
            B.setm(Convert.ToInt32(textBoxm2.Text));
            B.init_matrix(B.m, B.n);
        }

        private void textBoxn2_TextChanged(object sender, EventArgs e)
        {
            B.setn(Convert.ToInt32(textBoxn2.Text));
            B.init_matrix(B.m, B.n);
        }

        private void textBox112_TextChanged(object sender, EventArgs e)
        {
            A.write(1, 2, Convert.ToDouble(textBox112.Text));
        }

        private void textBox113_TextChanged(object sender, EventArgs e)
        {
            A.write(1, 2, Convert.ToDouble(textBox113.Text));
        }

        private void textBox114_TextChanged(object sender, EventArgs e)
        {
            A.write(1, 4, Convert.ToDouble(textBox114.Text));
        }

        private void textBox115_TextChanged(object sender, EventArgs e)
        {
            A.write(1, 5, Convert.ToDouble(textBox115.Text));
        }

        private void textBox121_TextChanged(object sender, EventArgs e)
        {
            A.write(2, 1, Convert.ToDouble(textBox121.Text));
        }

        private void textBox122_TextChanged(object sender, EventArgs e)
        {
            A.write(2, 2, Convert.ToDouble(textBox122.Text));
        }

        private void textBox123_TextChanged(object sender, EventArgs e)
        {
            A.write(2, 3, Convert.ToDouble(textBox123.Text));
        }

        private void textBox124_TextChanged(object sender, EventArgs e)
        {
            A.write(2, 4, Convert.ToDouble(textBox124.Text));
        }

        private void textBox125_TextChanged(object sender, EventArgs e)
        {
            A.write(2, 5, Convert.ToDouble(textBox125.Text));
        }

        private void textBox131_TextChanged(object sender, EventArgs e)
        {
            A.write(3, 1, Convert.ToDouble(textBox131.Text));
        }

        private void textBox132_TextChanged(object sender, EventArgs e)
        {
            A.write(3, 2, Convert.ToDouble(textBox132.Text));
        }

        private void textBox133_TextChanged(object sender, EventArgs e)
        {
            A.write(3, 3, Convert.ToDouble(textBox133.Text));
        }

        private void textBox134_TextChanged(object sender, EventArgs e)
        {
            A.write(3, 4, Convert.ToDouble(textBox134.Text));
        }

        private void textBox135_TextChanged(object sender, EventArgs e)
        {
            A.write(3, 5, Convert.ToDouble(textBox135.Text));
        }

        private void textBox141_TextChanged(object sender, EventArgs e)
        {
            A.write(4, 1, Convert.ToDouble(textBox141.Text));
        }

        private void textBox142_TextChanged(object sender, EventArgs e)
        {
            A.write(4, 2, Convert.ToDouble(textBox142.Text));
        }

        private void textBox143_TextChanged(object sender, EventArgs e)
        {
            A.write(4, 3, Convert.ToDouble(textBox143.Text));
        }

        private void textBox144_TextChanged(object sender, EventArgs e)
        {
            A.write(4, 4, Convert.ToDouble(textBox144.Text));
        }

        private void textBox145_TextChanged(object sender, EventArgs e)
        {
            A.write(4, 5, Convert.ToDouble(textBox145.Text));
        }

        private void textBox151_TextChanged(object sender, EventArgs e)
        {
            A.write(5, 1, Convert.ToDouble(textBox151.Text));
        }

        private void textBox152_TextChanged(object sender, EventArgs e)
        {
            A.write(5, 2, Convert.ToDouble(textBox152.Text));
        }

        private void textBox153_TextChanged(object sender, EventArgs e)
        {
            A.write(5, 3, Convert.ToDouble(textBox153.Text));
        }

        private void textBox154_TextChanged(object sender, EventArgs e)
        {
            A.write(5, 4, Convert.ToDouble(textBox154.Text));
        }

        private void textBox155_TextChanged(object sender, EventArgs e)
        {
            A.write(5, 5, Convert.ToDouble(textBox155.Text));
        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "数乘")
            {
                num = Convert.ToDouble(textBox50.Text);
            }
            else
            { B.write(1, 1, Convert.ToDouble(textBox50.Text)); }
        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            B.write(1, 2, Convert.ToDouble(textBox49.Text));
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {
            B.write(1, 3, Convert.ToDouble(textBox48.Text));
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            B.write(1, 4, Convert.ToDouble(textBox47.Text));
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            B.write(1, 5, Convert.ToDouble(textBox46.Text));
        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            B.write(2, 1, Convert.ToDouble(textBox45.Text));
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            B.write(2, 2, Convert.ToDouble(textBox44.Text));
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            B.write(2, 3, Convert.ToDouble(textBox43.Text));
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            B.write(2, 4, Convert.ToDouble(textBox42.Text));
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            B.write(2, 5, Convert.ToDouble(textBox41.Text));
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            B.write(3, 1, Convert.ToDouble(textBox40.Text));
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            B.write(3, 2, Convert.ToDouble(textBox39.Text));
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            B.write(3, 3, Convert.ToDouble(textBox38.Text));
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            B.write(3, 4, Convert.ToDouble(textBox37.Text));
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            B.write(3, 5, Convert.ToDouble(textBox36.Text));
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            B.write(4, 1, Convert.ToDouble(textBox35.Text));
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            B.write(4, 2, Convert.ToDouble(textBox34.Text));
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            B.write(4, 3, Convert.ToDouble(textBox35.Text));
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            B.write(4, 4, Convert.ToDouble(textBox32.Text));
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            B.write(4, 5, Convert.ToDouble(textBox31.Text));
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            B.write(5, 1, Convert.ToDouble(textBox30.Text));
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            B.write(5, 2, Convert.ToDouble(textBox29.Text));
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            B.write(5, 3, Convert.ToDouble(textBox28.Text));
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            B.write(5, 4, Convert.ToDouble(textBox27.Text));
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            B.write(5, 5, Convert.ToDouble(textBox26.Text));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "+":
                    
                    if(A.m != B.m || A.n!= B.n)
                    {
                        laberro.Text = "强输入正确的行数和列数！";
                    }
                    else
                    {
                        C.setm(A.m);
                        C.setn(A.n);
                        C.init_matrix(C.m, C.n);
                        for (int i = 1; i <= C.m; i++)
                        {
                            for(int j = 1; j <= C.n; j++)
                            {
                                C.write(i, j, A.read(i, j) + B.read(i, j));
                            }
                        }
                    }
                    textBox79.Text = C.read(1, 1).ToString();
                    textBox78.Text = C.read(1, 2).ToString();
                    textBox77.Text = C.read(1, 3).ToString();
                    textBox76.Text = C.read(1, 4).ToString();
                    textBox75.Text = C.read(1, 5).ToString();
                    textBox74.Text = C.read(2, 1).ToString();
                    textBox73.Text = C.read(2, 2).ToString();
                    textBox72.Text = C.read(2, 3).ToString();
                    textBox71.Text = C.read(2, 4).ToString();
                    textBox70.Text = C.read(2, 5).ToString();
                    textBox69.Text = C.read(3, 1).ToString();
                    textBox68.Text = C.read(3, 2).ToString();
                    textBox67.Text = C.read(3, 3).ToString();
                    textBox66.Text = C.read(3, 4).ToString();
                    textBox65.Text = C.read(3, 5).ToString();
                    textBox64.Text = C.read(4, 1).ToString();
                    textBox63.Text = C.read(4, 2).ToString();
                    textBox62.Text = C.read(4, 3).ToString();
                    textBox61.Text = C.read(4, 4).ToString();
                    textBox60.Text = C.read(4, 5).ToString();
                    textBox59.Text = C.read(5, 1).ToString();
                    textBox58.Text = C.read(5, 2).ToString();
                    textBox57.Text = C.read(5, 3).ToString();
                    textBox56.Text = C.read(5, 4).ToString();
                    textBox55.Text = C.read(5, 5).ToString();
                    break;
                case "-":

                    if (A.m != B.m || A.n != B.n)
                    {
                        laberro.Text = "强输入正确的行数和列数！";
                    }
                    else
                    {
                        C.setm(A.m);
                        C.setn(A.n);
                        C.init_matrix(C.m, C.n);
                        for (int i = 1; i <= C.m; i++)
                        {
                            for (int j = 1; j <= C.n; j++)
                            {
                                C.write(i, j, A.read(i, j) - B.read(i, j));
                            }
                        }
                    }
                    textBox79.Text = C.read(1, 1).ToString();
                    textBox78.Text = C.read(1, 2).ToString();
                    textBox77.Text = C.read(1, 3).ToString();
                    textBox76.Text = C.read(1, 4).ToString();
                    textBox75.Text = C.read(1, 5).ToString();
                    textBox74.Text = C.read(2, 1).ToString();
                    textBox73.Text = C.read(2, 2).ToString();
                    textBox72.Text = C.read(2, 3).ToString();
                    textBox71.Text = C.read(2, 4).ToString();
                    textBox70.Text = C.read(2, 5).ToString();
                    textBox69.Text = C.read(3, 1).ToString();
                    textBox68.Text = C.read(3, 2).ToString();
                    textBox67.Text = C.read(3, 3).ToString();
                    textBox66.Text = C.read(3, 4).ToString();
                    textBox65.Text = C.read(3, 5).ToString();
                    textBox64.Text = C.read(4, 1).ToString();
                    textBox63.Text = C.read(4, 2).ToString();
                    textBox62.Text = C.read(4, 3).ToString();
                    textBox61.Text = C.read(4, 4).ToString();
                    textBox60.Text = C.read(4, 5).ToString();
                    textBox59.Text = C.read(5, 1).ToString();
                    textBox58.Text = C.read(5, 2).ToString();
                    textBox57.Text = C.read(5, 3).ToString();
                    textBox56.Text = C.read(5, 4).ToString();
                    textBox55.Text = C.read(5, 5).ToString();
                    break;
                case "数乘":

                    
                    
                        C.setm(A.m);
                        C.setn(A.n);
                        C.init_matrix(C.m, C.n);
                        for (int i = 1; i <= C.m; i++)
                        {
                        for (int j = 1; j <= C.n; j++)
                        {
                            C.write(i, j, A.read(i, j) * num);
                        }
                            
                        }
                    textBox79.Text = C.read(1, 1).ToString();
                    textBox78.Text = C.read(1, 2).ToString();
                    textBox77.Text = C.read(1, 3).ToString();
                    textBox76.Text = C.read(1, 4).ToString();
                    textBox75.Text = C.read(1, 5).ToString();
                    textBox74.Text = C.read(2, 1).ToString();
                    textBox73.Text = C.read(2, 2).ToString();
                    textBox72.Text = C.read(2, 3).ToString();
                    textBox71.Text = C.read(2, 4).ToString();
                    textBox70.Text = C.read(2, 5).ToString();
                    textBox69.Text = C.read(3, 1).ToString();
                    textBox68.Text = C.read(3, 2).ToString();
                    textBox67.Text = C.read(3, 3).ToString();
                    textBox66.Text = C.read(3, 4).ToString();
                    textBox65.Text = C.read(3, 5).ToString();
                    textBox64.Text = C.read(4, 1).ToString();
                    textBox63.Text = C.read(4, 2).ToString();
                    textBox62.Text = C.read(4, 3).ToString();
                    textBox61.Text = C.read(4, 4).ToString();
                    textBox60.Text = C.read(4, 5).ToString();
                    textBox59.Text = C.read(5, 1).ToString();
                    textBox58.Text = C.read(5, 2).ToString();
                    textBox57.Text = C.read(5, 3).ToString();
                    textBox56.Text = C.read(5, 4).ToString();
                    textBox55.Text = C.read(5, 5).ToString();
                    break;
                case "×":

                    if (A.n != B.m )
                    {
                        laberro.Text = "强输入正确的行数和列数！";
                    }
                    else
                    {
                        C.setm(A.m);
                        C.setn(B.n);
                        C.init_matrix(C.m, C.n);
                        for (int i = 1; i <= C.m; i++)
                        {
                            for (int j = 1; j <= C.n; j++)
                            {
                                C.write(i, j, A.read(i, j) * B.read(j, i));
                            }
                        }
                    }
                    textBox79.Text = C.read(1, 1).ToString();
                    textBox78.Text = C.read(1, 2).ToString();
                    textBox77.Text = C.read(1, 3).ToString();
                    textBox76.Text = C.read(1, 4).ToString();
                    textBox75.Text = C.read(1, 5).ToString();
                    textBox74.Text = C.read(2, 1).ToString();
                    textBox73.Text = C.read(2, 2).ToString();
                    textBox72.Text = C.read(2, 3).ToString();
                    textBox71.Text = C.read(2, 4).ToString();
                    textBox70.Text = C.read(2, 5).ToString();
                    textBox69.Text = C.read(3, 1).ToString();
                    textBox68.Text = C.read(3, 2).ToString();
                    textBox67.Text = C.read(3, 3).ToString();
                    textBox66.Text = C.read(3, 4).ToString();
                    textBox65.Text = C.read(3, 5).ToString();
                    textBox64.Text = C.read(4, 1).ToString();
                    textBox63.Text = C.read(4, 2).ToString();
                    textBox62.Text = C.read(4, 3).ToString();
                    textBox61.Text = C.read(4, 4).ToString();
                    textBox60.Text = C.read(4, 5).ToString();
                    textBox59.Text = C.read(5, 1).ToString();
                    textBox58.Text = C.read(5, 2).ToString();
                    textBox57.Text = C.read(5, 3).ToString();
                    textBox56.Text = C.read(5, 4).ToString();
                    textBox55.Text = C.read(5, 5).ToString();
                    break;
                case "求转置":
                    if (A.m != A.n)
                    {
                        laberro.Text = "强输入正确的行数和列数！";
                    }

                    else
                    {
                        C.setm(A.m);
                        C.setn(A.n);
                        C.init_matrix(C.m, C.n);
                        for (int i = 1; i <= C.m; i++)
                        {
                            for (int j = 1; j <= C.n; j++)
                            {
                                
                                C.write(j, i, A.read(i, j));
                                C.write(i, j, A.read(j,i));
                            }
                        }
                    }
                    textBox79.Text = C.read(1, 1).ToString();
                    textBox78.Text = C.read(1, 2).ToString();
                    textBox77.Text = C.read(1, 3).ToString();
                    textBox76.Text = C.read(1, 4).ToString();
                    textBox75.Text = C.read(1, 5).ToString();
                    textBox74.Text = C.read(2, 1).ToString();
                    textBox73.Text = C.read(2, 2).ToString();
                    textBox72.Text = C.read(2, 3).ToString();
                    textBox71.Text = C.read(2, 4).ToString();
                    textBox70.Text = C.read(2, 5).ToString();
                    textBox69.Text = C.read(3, 1).ToString();
                    textBox68.Text = C.read(3, 2).ToString();
                    textBox67.Text = C.read(3, 3).ToString();
                    textBox66.Text = C.read(3, 4).ToString();
                    textBox65.Text = C.read(3, 5).ToString();
                    textBox64.Text = C.read(4, 1).ToString();
                    textBox63.Text = C.read(4, 2).ToString();
                    textBox62.Text = C.read(4, 3).ToString();
                    textBox61.Text = C.read(4, 4).ToString();
                    textBox60.Text = C.read(4, 5).ToString();
                    textBox59.Text = C.read(5, 1).ToString();
                    textBox58.Text = C.read(5, 2).ToString();
                    textBox57.Text = C.read(5, 3).ToString();
                    textBox56.Text = C.read(5, 4).ToString();
                    textBox55.Text = C.read(5, 5).ToString();
                    break;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox79_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox78_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox77_TextChanged(object sender, EventArgs e)
        {
            textBox77.Text = C.read(1, 3).ToString();
        }

        private void textBox76_TextChanged(object sender, EventArgs e)
        {
            textBox76.Text = C.read(1, 4).ToString();
        }

        
        private void textBox69_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox111.Text = "";
            textBox112.Text = "";
            textBox113.Text = "";
            textBox114.Text = "";
            textBox115.Text = "";
            textBox121.Text = "";
            textBox122.Text = "";
            textBox123.Text = "";
            textBox124.Text = "";
            textBox125.Text = "";
            textBox131.Text = "";
            textBox132.Text = "";
            textBox133.Text = "";
            textBox134.Text = "";
            textBox135.Text = "";
            textBox141.Text = "";
            textBox142.Text = "";
            textBox143.Text = "";
            textBox144.Text = "";
            textBox145.Text = "";
            textBox151.Text = "";
            textBox152.Text = "";
            textBox153.Text = "";
            textBox154.Text = "";
            textBox155.Text = "";
            textBoxm1.Text = "";
            textBoxn1.Text = "";
            textBoxn2.Text = "";
            textBoxm2.Text = "";
            textBox50.Text = "";
            textBox49.Text = "";
            textBox48.Text = "";
            textBox47.Text = "";
            textBox46.Text = "";
            textBox45.Text = "";
            textBox44.Text = "";
            textBox43.Text = "";
            textBox42.Text = "";
            textBox41.Text = "";
            textBox40.Text = "";
            textBox39.Text = "";
            textBox38.Text = "";
            textBox37.Text = "";
            textBox36.Text = "";
            textBox35.Text = "";
            textBox34.Text = "";
            textBox33.Text = "";
            textBox32.Text = "";
            textBox31.Text = "";
            textBox30.Text = "";
            textBox29.Text = "";
            textBox28.Text = "";
            textBox27.Text = "";
            textBox26.Text = "";
            textBox79.Text = "";
            textBox78.Text = "";
            textBox77.Text = "";
            textBox76.Text = "";
            textBox75.Text = "";
            textBox74.Text = "";
            textBox73.Text = "";
            textBox72.Text = "";
            textBox71.Text = "";
            textBox70.Text = "";
            textBox69.Text = "";
            textBox68.Text = "";
            textBox67.Text = "";
            textBox66.Text = "";
            textBox65.Text = "";
            textBox64.Text = "";
            textBox63.Text = "";
            textBox62.Text = "";
            textBox61.Text = "";
            textBox60.Text = "";
            textBox59.Text = "";
            textBox58.Text = "";
            textBox57.Text = "";
            textBox56.Text = "";
            textBox55.Text = "";

        }
    }
    public partial class Matrix
    {
        public int m = 1;
        public int n = 1;
        public double[] arr;
        public void csh(int m, int n)//初始化
        {
            m = 0;
            n = 0;
        }
        //设置m
        public void setm(int mm)
        {
            m = mm;
        }
        //设置n
        public void setn(int nn)
        {
            n = nn;
        }
        //初始化矩阵
        public void init_matrix(int m, int n)
        {
            arr = new double[m * n];
        }
        public void write(int i, int j, double a)
        {
            if (i <= m && j <= n)
            {
                arr[(i-1) * n + j-1] = a;
            }
        }
        public double read(int i, int j)
        {
            if (i <= m && j <= n)
            {
                return arr[(i - 1) * n + j - 1];
            }
            else
            {
                return 0;
            }
             
            
        }
    }
}
