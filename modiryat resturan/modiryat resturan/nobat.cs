using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modiryat_resturan
{
    public partial class nobat : Form
    {
        public nobat()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code_moshtari = textBox2.Text;
            string code_karmand = textBox1.Text;
            string time = textBox3.Text;
            string date = textBox4.Text;

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\lenovo\Desktop\modiryat resturan\modiryat resturan\Database1.mdf"";Integrated Security=True");

            connection.Open();
            string query = "INSERT INTO nobat (time,date,code_moshtary,code_karmand) VALUES ('" + time + "','" + date + "','" + code_moshtari + "','" + code_karmand + "')";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("نوبت ثبت شد.");
        }
    }
}
