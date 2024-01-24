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
    public partial class noobat_rezerw : Form
    {
        public noobat_rezerw()
        {
            InitializeComponent();
        }

        private void noobat_rezerw_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\lenovo\Desktop\modiryat resturan\modiryat resturan\Database1.mdf"";Integrated Security=True");

            connection.Open();
            string query = "SELECT time, date, code_moshtary, code_karmand FROM nobat";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string time = reader["time"].ToString();
                string date = reader["date"].ToString();
                string code_moshtary = reader["code_moshtary"].ToString();
                string code_karmand = reader["code_karmand"].ToString();
                listBox1.Items.Add(code_moshtary + "-   " + time + "   -   " + date + "   -   " + code_karmand);
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
            string query = "DELETE FROM nobat WHERE code_moshtary='" + name + "'";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("با موفقیت حذف شد.");
        }
    }
}
