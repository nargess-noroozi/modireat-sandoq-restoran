using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace modiryat_resturan
{
    public partial class sabt_moshtary : Form
    {
        public sabt_moshtary()
        {
            InitializeComponent();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sabt_moshtary_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string number = textBox2.Text;
            string address = textBox3.Text;
            string codegaza = textBox4.Text;

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\lenovo\Desktop\modiryat resturan\modiryat resturan\Database1.mdf"";Integrated Security=True");

            connection.Open();
            string query = "INSERT INTO sabt_moshtary (Name,Number,Address,cod_gaza) VALUES ('" + name + "','" + number + "','" + address + "','" + codegaza + "')";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Changes have been saved!!!!");





        }
    }
}
