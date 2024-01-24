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
    public partial class showkarmand : Form
    {
        public showkarmand()
        {
            InitializeComponent();
        }

        private void showkarmand_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\lenovo\Desktop\modiryat resturan\modiryat resturan\Database1.mdf"";Integrated Security=True");

            connection.Open();
            string query = "SELECT Name, National_Code, phone_number, address ,herfe FROM karmand";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["Name"].ToString();
                string number = reader["phone_number"].ToString();
                string address = reader["address"].ToString();
                string herfe = reader["herfe"].ToString();
                string National_Code = reader["National_Code"].ToString();
                listBox1.Items.Add(name + "-   " + National_Code + "   -   " + number + "   -   " + address + "   -   " + herfe);
            }
            connection.Close();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string na = listBox1.SelectedItem.ToString();
            int nam = na.IndexOf("-");
            string name = na.Substring(0, nam);
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mahdi\Desktop\modiryat resturan\Database1.mdf"";Integrated Security=True");
            connection.Open();
            string query = "DELETE FROM karmand WHERE Name='" + name + "'";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("با موفقیت حذف شد.");
        }
    }
}
