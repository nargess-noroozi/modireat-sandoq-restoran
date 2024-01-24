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
    public partial class foodlist : Form
    {
        public foodlist()
        {
            InitializeComponent();
        }

        private void foodlist_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\lenovo\Desktop\modiryat resturan\modiryat resturan\Database1.mdf"";Integrated Security=True");

            connection.Open();
            string query = "SELECT name, qamat, daste FROM food";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["name"].ToString();
                string qamat = reader["qamat"].ToString();
                string daste = reader["daste"].ToString();
                listBox1.Items.Add(name + "-   " + qamat + "   -   " + daste);
            }
            connection.Close();
        }

        private void butten1_Click(object sender, EventArgs e)
        {
            string na = listBox1.SelectedItem.ToString();
            int nam = na.IndexOf("-");
            string name = na.Substring(0, nam);
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\lenovo\Desktop\modiryat resturan\modiryat resturan\Database1.mdf"";Integrated Security=True");
            connection.Open();
            string query = "DELETE FROM food WHERE name='" + name + "'";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("با موفقیت حذف شد.");
        }
    }
}
