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
    public partial class food : Form
    {
        public food()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string gaza = textBox1.Text;
            string qamat = textBox1.Text;
            string datebandi = comboBox1.SelectedItem.ToString();



            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\lenovo\Desktop\modiryat resturan\modiryat resturan\Database1.mdf"";Integrated Security=True");

            connection.Open();
            string query = "INSERT INTO food (name,qamat,daste) VALUES ('" + gaza + "','" + qamat + "','" + datebandi + "')";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("با موفقیت به لیست غذا ها اضافه شد");
        }

        private void food_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("noshidani");
            comboBox1.Items.Add("sobhane");
            comboBox1.Items.Add("sham");
            comboBox1.Items.Add("nahar");





        }
    }
}
