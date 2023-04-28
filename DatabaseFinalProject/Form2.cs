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

namespace DatabaseFinalProject
{
    public partial class Form2 : Form
    {
        public SqlConnection connection = new SqlConnection("Data Source=sqldatabasefinal.database.windows.net;Initial Catalog=Database_Final;Persist Security Info=True;User ID=Teddy;Password=Derrz2017!");
        public SqlCommand cd;
        public string x;
        public Form2()
        {
            InitializeComponent();
        }

        public void Form1Text(string text)
        {
            x = "SELECT Players_Name.First_Name, Players_Name.Last_Name, Player_Details.*, Player_Contributions.* " +
                "FROM dbo.Players_Name " +
                "JOIN dbo.Player_Details " +
                "ON Players_Name.Last_Name = Player_Details.Last_Name " +
                "JOIN dbo.Player_Contributions " +
                "ON Players_Name.Last_Name = Player_Contributions.Last_Name " +
                "WHERE Players_Name.Last_Name = '" + text + "'";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                listView1.Items.Clear();

                cd = new SqlCommand(x, connection);

                try
                {
                    SqlDataReader dr = cd.ExecuteReader();

                    while (dr.Read())
                    {

                        ListViewItem item = new ListViewItem(dr["First_Name"].ToString());
                        item.SubItems.Add(dr["Last_Name"].ToString());
                        item.SubItems.Add(dr["Position"].ToString());
                        item.SubItems.Add(dr["Country"].ToString());
                        item.SubItems.Add(dr["Age"].ToString());
                        item.SubItems.Add(dr["Preferred_Foot"].ToString());
                        item.SubItems.Add(dr["Jersey_Number"].ToString());
                        item.SubItems.Add(dr["Market_Value"].ToString());
                        item.SubItems.Add(dr["Matches"].ToString());
                        item.SubItems.Add(dr["Goals"].ToString());
                        item.SubItems.Add(dr["Assists"].ToString());
                        item.SubItems.Add(dr["Yellow_Cards"].ToString());
                        item.SubItems.Add(dr["Red_Cards"].ToString());

                        listView1.Items.Add(item);

                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }

        }
    }
}
