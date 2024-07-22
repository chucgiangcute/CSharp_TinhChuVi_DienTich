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
    public partial class HINHTRON : Form
    {
        public HINHTRON()
        {
            InitializeComponent();
        }

        private void CV_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncv_Click(object sender, EventArgs e)
        {
            double r;
            r = Convert.ToDouble(bankinhr.Text);
            if (r<=0)
            {
                kqcv.Text = "Hãy nhập số cho đúng".ToString();
            }
            else
            {
                kqcv.Text = TinhChuVi(r).ToString();
            }

            /*kqcv.Text = TinhChuVi(r).ToString();*/
        }

        private void btndt_Click(object sender, EventArgs e)
        {
            double r;
            r = Convert.ToDouble(bankinhr.Text);
            if (r<=0)
            {
                kqdt.Text = "Hãy nhập số cho đúng".ToString();
            }
            else
            {
                kqdt.Text = TinhDienTich(r).ToString();
            }

            /*kqdt.Text = TinhDienTich(r).ToString();*/
        }

        private double TinhChuVi (double r)
        {
            return r * 2 * Math.PI;
        }

        private double TinhDienTich (double r)
        {
            return Math.PI*Math.Pow(r, 2);
        }

        private void kqcv_TextChanged(object sender, EventArgs e)
        {

        }

        
    }

}
