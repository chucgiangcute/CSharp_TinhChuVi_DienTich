using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_TinhChuVi_DienTich
{
    public partial class HINHCHUNHAT : Form
    {
        public HINHCHUNHAT()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chuvi_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(dai.Text);
            b = Convert.ToDouble(rong.Text);

            if (a<=0 || b<=0)
            {
                CV.Text = "Nhập lại số cho đúng".ToString();
            }
            else
            {
                CV.Text = TinhChuVi(a, b).ToString();
            }
            /*CV.Text = TinhChuVi(a,b).ToString();
*/
        }

        private void dientich_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(dai.Text);
            b = Convert.ToDouble(rong.Text);

            if(a<=0 || b<=0)
            {
                DT.Text = "Nhập lại số cho đúng".ToString();
            }
            else
            {
                DT.Text = TinhDienTich(a, b).ToString();
            }

            /*DT.Text = TinhDienTich(a,b).ToString();*/
        }


        private double TinhChuVi(double a, double b)
        {
            return (a + b) * 2;

        }


        private double TinhDienTich(double a, double b)
        {
            return (a * b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }

    
}
