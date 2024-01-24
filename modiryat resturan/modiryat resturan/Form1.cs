using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modiryat_resturan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sabt_moshtary sabt = new sabt_moshtary();
            sabt.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            sabt_karmand kar = new sabt_karmand();
            kar.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            food fo = new food();
            fo.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            nobat nob = new nobat();
            nob.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            food fod = new food();
            fod.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showcs showcs = new showcs();
            showcs.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showkarmand shk = new showkarmand();
            shk.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            noobat_rezerw nor = new noobat_rezerw();
            nor.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            foodlist foli = new foodlist();
            foli.Show();
        }
    }
}
