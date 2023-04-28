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
using System.Collections;
using System.Xml.Linq;

namespace DatabaseFinalProject
{
    public partial class Form1 : Form
    {
        public SqlConnection connection = new SqlConnection("Data Source=sqldatabasefinal.database.windows.net;Initial Catalog=Database_Final;Persist Security Info=True;User ID=*************;Password=**********");
        public SqlCommand cm;
        public Form1()
        {

            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                listView1.Items.Clear();

                cm = new SqlCommand("SELECT Players_Name.First_Name, Players_Name.Last_Name, Player_Details.Position FROM dbo.Players_Name JOIN dbo.Player_Details ON Players_Name.Last_Name = Player_Details.Last_Name ORDER BY Player_Details.Position DESC", connection);

                try
                {
                    SqlDataReader dr = cm.ExecuteReader();

                    while (dr.Read())
                    {
                        listBox1.Items.Add(dr["Last_Name"].ToString());

                        ListViewItem item = new ListViewItem(dr["First_Name"].ToString());
                        item.SubItems.Add(dr["Last_Name"].ToString());
                        item.SubItems.Add(dr["Position"].ToString());

                        listView1.Items.Add(item);

                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listBox1.Items.Clear();

            cm = new SqlCommand("SELECT Players_Name.First_Name, Players_Name.Last_Name, Player_Details.Position FROM dbo.Players_Name JOIN dbo.Player_Details ON Players_Name.Last_Name = Player_Details.Last_Name WHERE Position = 'GK' ORDER BY Player_Details.Position DESC", connection);
            try
            {
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add(dr["Last_Name"].ToString());

                    ListViewItem item = new ListViewItem(dr["First_Name"].ToString());
                    item.SubItems.Add(dr["Last_Name"].ToString());
                    item.SubItems.Add(dr["Position"].ToString());

                    listView1.Items.Add(item);

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listBox1.Items.Clear();
            
            cm = new SqlCommand("SELECT Players_Name.First_Name, Players_Name.Last_Name, Player_Details.Position FROM dbo.Players_Name JOIN dbo.Player_Details ON Players_Name.Last_Name = Player_Details.Last_Name WHERE Position = 'D' ORDER BY Player_Details.Position DESC", connection);
            try
            {
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add(dr["Last_Name"].ToString());

                    ListViewItem item = new ListViewItem(dr["First_Name"].ToString());
                    item.SubItems.Add(dr["Last_Name"].ToString());
                    item.SubItems.Add(dr["Position"].ToString());

                    listView1.Items.Add(item);

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listBox1.Items.Clear();

            cm = new SqlCommand("SELECT Players_Name.First_Name, Players_Name.Last_Name, Player_Details.Position FROM dbo.Players_Name JOIN dbo.Player_Details ON Players_Name.Last_Name = Player_Details.Last_Name WHERE Position = 'M' ORDER BY Player_Details.Position DESC", connection);
            try
            {
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add(dr["Last_Name"].ToString());

                    ListViewItem item = new ListViewItem(dr["First_Name"].ToString());
                    item.SubItems.Add(dr["Last_Name"].ToString());
                    item.SubItems.Add(dr["Position"].ToString());

                    listView1.Items.Add(item);

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listBox1.Items.Clear();

            cm = new SqlCommand("SELECT Players_Name.First_Name, Players_Name.Last_Name, Player_Details.Position FROM dbo.Players_Name JOIN dbo.Player_Details ON Players_Name.Last_Name = Player_Details.Last_Name WHERE Position = 'F' ORDER BY Player_Details.Position DESC", connection);
            try
            {
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add(dr["Last_Name"].ToString());

                    ListViewItem item = new ListViewItem(dr["First_Name"].ToString());
                    item.SubItems.Add(dr["Last_Name"].ToString());
                    item.SubItems.Add(dr["Position"].ToString());

                    listView1.Items.Add(item);

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listBox1.Items.Clear();

            cm = new SqlCommand("SELECT Players_Name.First_Name, Players_Name.Last_Name, Player_Details.Position FROM dbo.Players_Name JOIN dbo.Player_Details ON Players_Name.Last_Name = Player_Details.Last_Name ORDER BY Player_Details.Position DESC", connection);
            try
            {
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add(dr["Last_Name"].ToString());

                    ListViewItem item = new ListViewItem(dr["First_Name"].ToString());
                    item.SubItems.Add(dr["Last_Name"].ToString());
                    item.SubItems.Add(dr["Position"].ToString());

                    listView1.Items.Add(item);

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string output = text.Substring(0, 1).ToUpper() + text.Substring(1).ToLower();
            string query = "SELECT * FROM dbo.Players_Name WHERE Last_name = @name";

            using (cm = new SqlCommand(query, connection))
            {
                cm.Parameters.AddWithValue("@name", output);


                using (SqlDataReader reader = cm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        Form2 f2 = new Form2();
                        f2.Form1Text(output);
                        f2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Name not found in the table.");
                    }
                }
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            Form2 f2 = new Form2();
            f2.Form1Text(text);
            f2.ShowDialog();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }


        private void Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string text = textBox1.Text;
                string output = text.Substring(0, 1).ToUpper() + text.Substring(1).ToLower();
                string query = "SELECT * FROM dbo.Players_Name WHERE Last_name = @name";

                using (cm = new SqlCommand(query, connection))
                {
                    cm.Parameters.AddWithValue("@name", output);


                    using (SqlDataReader reader = cm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            Form2 f2 = new Form2();
                            f2.Form1Text(output);
                            f2.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Name not found in the table.");
                        }
                    }
                }
            }
        }
    }
}
