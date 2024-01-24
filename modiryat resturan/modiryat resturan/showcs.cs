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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace modiryat_resturan
{
    public partial class showcs : Form
    {
        public showcs()
        {
            InitializeComponent();
        }

        private void showcs_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\lenovo\Desktop\modiryat resturan\modiryat resturan\Database1.mdf"";Integrated Security=True");

            connection.Open();
            string query = "SELECT name, number, address, cod_gaza FROM sabt_moshtary";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["name"].ToString();
                string number = reader["number"].ToString();
                string address = reader["address"].ToString();
                string cod_gaza = reader["cod_gaza"].ToString();
                listBox1.Items.Add(name + "-   " + cod_gaza + "   -   " + number + "   -   " + address);
            }
            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string na = listBox1.SelectedItem.ToString();
            int nam = na.IndexOf("-");
            string name = na.Substring(0, nam);
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\lenovo\Desktop\modiryat resturan\modiryat resturan\Database1.mdf"";Integrated Security=True");
            connection.Open();
            string query = "DELETE FROM sabt_moshtary WHERE name='" + name + "'";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("با موفقیت حذف شد.");
        }
    }
}
