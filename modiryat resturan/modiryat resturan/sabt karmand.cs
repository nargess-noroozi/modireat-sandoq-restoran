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
    public partial class sabt_karmand : Form
    {
        public sabt_karmand()
        {
            InitializeComponent();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void sabt_karmand_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("garson");
            comboBox1.Items.Add("ashpaz");
            comboBox1.Items.Add("sandog dar");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string number = textBox2.Text;
            string NationalـCode = textBox3.Text;
            string Address = textBox4.Text;
            string herfe = comboBox1.SelectedItem.ToString();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\lenovo\Desktop\modiryat resturan\modiryat resturan\Database1.mdf"";Integrated Security=True");

            connection.Open();
            string query = "INSERT INTO karmand (Name,phone_number,Address,National_Code,herfe) VALUES ('" + name + "','" + number + "','" + Address + "','" + NationalـCode + "','" + herfe + "')";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show($"کاربر ( {name} ) به لیست کارمندان اضافه شد.");


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
