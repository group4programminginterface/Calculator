using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Process;

namespace Interface
{
    public partial class Calulator : Form
    {
        
        public Calulator()
        {
            InitializeComponent();
        }

        private void Calulator_Load(object sender, EventArgs e)
        {
            radio_degrees.Checked = true;
            hienthi();
        }
       
        //
        string chuoi1, chuoi2, pheptinh,kq;
        bool kiemtra=false,phimbang=false;

        //
        void hienthi()
        {
            if (chuoi1 == null)
            {
                ScreenTop.Text = null;
                ScreenButtom.Text = "0";
            }
            else
            {
                if (pheptinh == null) ScreenButtom.Text = chuoi1;
                else
                {
                    if (chuoi2 != null) ScreenButtom.Text = chuoi1 + pheptinh + chuoi2;
                    if (phimbang) { ScreenTop.Text = chuoi1 + pheptinh + chuoi2 + "="; ScreenButtom.Text = kq; }
                }
            }
        }

        void them(string str)
        {
            if (phimbang==true)
            {
                xoa();

            }
            if (!kiemtra)
                chuoi1 += str;
            else
            {
                if (str == "+" || str == "-" || str == "*" || str == "/")//nếu trường hợp nhập các phím cộng trừ nhân chia, thì không ghi vào chu
                    goto lap;
                chuoi2 += str;
            }
            lap:
            hienthi();
        }
        void xoa1()
        {
           /*
           if (!kiemtra)
            {
                if (chuoi1==null) {ScreenButtom.Text = "0"; }
                else
                    chuoi1.Remove((chuoi1.Length - 1),1);
            }
            else
            {
                if (chuoi2==null) {ScreenButtom.Text = "0"; }
                else
                    chuoi2.Remove((chuoi2.Length - 1),1);
            }
            if (phimbang) xoa();
            hienthi();
             */
            
            if (!kiemtra)
            {
                if (chuoi1 == null) { ScreenButtom.Text = "0"; }
                else
                {
                    string str = chuoi1;
                    int n = str.Length;
                    chuoi1 = (str.Substring(0, n - 1));
                    if (chuoi1.Length == 0) { chuoi1 = "0"; }
                    
                }
                   
                    
                    //chuoi1.Remove(chuoi1.Length - 1, 1);
                

            }
            else
            {
                if (chuoi2 == null) { ScreenButtom.Text = "0"; }
                else
                {
                    string str = chuoi2;
                    int n = str.Length;
                    chuoi2 = (str.Substring(0, n - 1));
                    if (chuoi2.Length == 0) { chuoi2 = "0"; }
                    //chuoi2.Remove(chuoi2.Length - 1, 1);
                }
            }
            if (phimbang) xoa();
            hienthi();
            
        }
        void xoa()
        {
            phimbang = false;
            chuoi1 = chuoi2 = pheptinh = null;
            kiemtra = false;
            hienthi();
        }
        private void button_0_Click(object sender, EventArgs e)
        {

            if ((chuoi1 == "0"))
            {
                if (pheptinh == null)
                {
                    chuoi1 = null;
                }
                else if (pheptinh != null)
                {
                    if (chuoi2=="0")
                    {
                        chuoi2 = "0";
                    }
                    else if (chuoi2 != "0")
                    {
                        them("0");
                    }
                    
                }
            }
            else if ((chuoi1 != "0"))
            {
                them("0");
            }


           
           /*     if (chuoi1 == "0")
                {
                    xoa();
                    kiemtra = false;

                }
                else if (chuoi2 == null)
                {
                    xoa();
                    kiemtra = false;
                }
                them("0");
            */
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            them("1");
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            them("2");
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            them("3");
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            them("4");
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            them("5");
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            them("6");
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            them("7");
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            them("8");
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            them("9");
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            if(! ((chuoi1.Contains(",")) ))
            {
            them(",");
            }
            if(pheptinh!=null)
            {
                if(!(chuoi2.Contains(",")))
                    them(",");
            }
            
        }
        void congdon()
        {
            if (phimbang == true)
            {
                chuoi1 = kq;
                kq = chuoi2 = null;
                phimbang = false;
            }
            ScreenTop.Text = null;
            hienthi();
        }
        private void button_plus_Click(object sender, EventArgs e)
        {
            congdon();
            kiemtra = true;
            pheptinh = "+";
            ScreenButtom.Text+= pheptinh;
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            congdon();
            kiemtra = true;
            pheptinh = "-";
            ScreenButtom.Text += pheptinh;
        }

        private void button_multiplied_Click(object sender, EventArgs e)
        {
            congdon();
            kiemtra = true;
            pheptinh = "*";
            ScreenButtom.Text += pheptinh;
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            congdon();
            kiemtra = true;
            pheptinh = "/";
            ScreenButtom.Text += pheptinh;
        }

        private void button_plus_or_minus_Click(object sender, EventArgs e)
        {
            if (!kiemtra)
            {
                chuoi1 = PlusOrMinus.plusorminus(chuoi1);
            }
            else
            {
                chuoi2 = PlusOrMinus.plusorminus(chuoi2);
            }
            hienthi();
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            xoa1();
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            phimbang = true;
            kq = TinhToan.Tinh(chuoi1, pheptinh, chuoi2).ToString();
            hienthi();
        }

        private void button_square_root_Click(object sender, EventArgs e)
        {
            if (chuoi1!=null || chuoi2!=null)
            {
                if (!kiemtra)
                    chuoi1 = TinhToan.canbac(float.Parse(chuoi1)).ToString();
                else
                    chuoi2 = TinhToan.canbac(float.Parse(chuoi2)).ToString();
                hienthi();
            }
        }

        private void button_percent_Click(object sender, EventArgs e)
        {
            ScreenButtom.Text = TinhToan.phantram(double.Parse(chuoi1.ToString())).ToString();
            chuoi1.Replace(chuoi1.ToString(), ScreenButtom.Text);
        }

        private void button_1_divided_x_Click(object sender, EventArgs e)
        {
            ScreenButtom.Text = TinhToan.motchiax(double.Parse(chuoi1.ToString())).ToString();
            chuoi1.Replace(chuoi1.ToString(),ScreenButtom.Text);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (chuoi1 != null)
                chuoi1 = ToanHoc.binhphuong(double.Parse(chuoi1), 2).ToString();
            hienthi();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (chuoi1!=null)
                chuoi1 = ToanHoc.binhphuong(double.Parse(chuoi1), 3).ToString();
            hienthi();
        }

        private void button_n_factorial_Click(object sender, EventArgs e)
        {
            if (chuoi1 != null)
                chuoi1 = ToanHoc.giaithua(int.Parse(chuoi1)).ToString();
            hienthi();
        }

        private void Calulator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0: button_0.PerformClick(); break;
                case Keys.D1: button_1.PerformClick(); break;
                case Keys.D2: button_2.PerformClick(); break;
                case Keys.D3: button_3.PerformClick(); break;
                case Keys.D4: button_4.PerformClick(); break;
                case Keys.D5: button_5.PerformClick(); break;
                case Keys.D6: button_6.PerformClick(); break;
                case Keys.D7: button_7.PerformClick(); break;
                case Keys.D8: button_8.PerformClick(); break;
                case Keys.D9: button_9.PerformClick(); break;
                case Keys.Back: button_backspace.PerformClick(); break;
                case Keys.Oemplus:
                    if (!e.Shift) button_equal.PerformClick();
                    else button_plus.PerformClick();
                    break;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
        }

        private void button_sinh_Click(object sender, EventArgs e)
        {
            if (chuoi1 != null)
                chuoi1 = LuongGiac.sinh(double.Parse(chuoi1)).ToString();
            hienthi();
        }

        private void button_cosh_Click(object sender, EventArgs e)
        {
            if (chuoi1 != null)
                chuoi1 = LuongGiac.cosh(double.Parse(chuoi1)).ToString();
            hienthi();
        }

        private void button_tanh_Click(object sender, EventArgs e)
        {
            if (chuoi1 != null)
                chuoi1 = LuongGiac.tanh(double.Parse(chuoi1)).ToString();
            hienthi();
        }

        private void button_tan_Click(object sender, EventArgs e)
        {
            if (chuoi1 != null)
                chuoi1 = LuongGiac.tan(double.Parse(chuoi1)).ToString();
            hienthi();
        }

        private void button_cos_Click(object sender, EventArgs e)
        {
            if (chuoi1 != null)
                chuoi1 = LuongGiac.cos(double.Parse(chuoi1)).ToString();
            hienthi();
        }

        private void button_sin_Click(object sender, EventArgs e)
        {
            if (chuoi1 != null)
                chuoi1 = LuongGiac.sin(double.Parse(chuoi1)).ToString();
            hienthi();
        }

        private void button_int_Click(object sender, EventArgs e)
        {
            if (chuoi1 != null)
            {
                chuoi1 = ((int)double.Parse(chuoi1)).ToString();
            }
            hienthi();
        }

        private void button_pi_Click(object sender, EventArgs e)
        {
            chuoi1 = ToanHoc.pi().ToString();
            hienthi();
            kiemtra = true;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (chuoi1 != null)
                chuoi1 = ToanHoc.binhphuong(10, double.Parse(chuoi1)).ToString();
            hienthi();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (chuoi1 != null)
                chuoi1 = ToanHoc.canbac(double.Parse(chuoi1),3).ToString();
            hienthi();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            them("(");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            them(")");
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            if (chuoi1 == null)
            {
                chuoi1 = null;
                ScreenTop.Text = null;
                ScreenButtom.Text = "0";
            }
            else
            {
                if (pheptinh == null)
                {
                    chuoi1 = null;
                    ScreenTop.Text = null;
                    ScreenButtom.Text = "0";
                }
                else
                {
                ScreenTop.Text = chuoi1+pheptinh;
                ScreenButtom.Text = "0";
                }
            }
            if(chuoi2!=null)
            {
                chuoi2 = null;
                ScreenTop.Text = chuoi1 + pheptinh;
                ScreenButtom.Text = "0";
            }
        }

    }
}
