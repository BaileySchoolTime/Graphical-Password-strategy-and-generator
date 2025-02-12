using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace BJW_GraphicalPasswordGen
{

    public partial class Form1 : Form
    {

        string encryptionKey;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            encryptionKey = "SecretEncryptKey";
        }

        public static string Encrypt(string text, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[16];

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(text);
                        }
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = "";
        }


        private void nextButton_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (textBox1.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Please enter a Email or Password.");
            }
            else
            {
                Match match = regex.Match(email);
                if (match.Success)
                {
                    string encryptedText = Encrypt(passwordTextBox.Text, encryptionKey);
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSC-289\BJW_GraphicalPasswordGen\Database.mdf;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("insert into User_Table (UserName, Password) values ('" + textBox1.Text + "', '" + encryptedText + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    var myForm = new Form2();
                    myForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please Enter a Valid Email");
                }
            }
        }
        /*
            private void removeButton_Click(object sender, EventArgs e)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please enter a username.");
                }
                else {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSC-289\BJW_GraphicalPasswordGen\Database.mdf;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Delete From User_Table Where UserName=@UserName", con);
                    cmd.Parameters.AddWithValue("UserName", textBox1.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Succefully!");
                    }
            }
        */
        private void A1button_Click(object sender, EventArgs e)
        {
            string animal = "Dog";
            var passPart = "";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSC-289\BJW_GraphicalPasswordGen\Database.mdf;Integrated Security=True";
            string query = "Select Code From Image_Table Where Image = @animal";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@animal", animal);
                    passPart = cmd.ExecuteScalar()?.ToString();
                    passwordTextBox.Text += passPart;
                }
            }
        }
        private void A2button_Click(object sender, EventArgs e)
        {
            string animal = "Cat";
            var passPart = "";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSC-289\BJW_GraphicalPasswordGen\Database.mdf;Integrated Security=True";
            string query = "Select Code From Image_Table Where Image = @animal";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@animal", animal);
                    passPart = cmd.ExecuteScalar()?.ToString();
                    passwordTextBox.Text += passPart;
                }
            }
        }
        private void A3button_Click(object sender, EventArgs e)
        {
            string animal = "Kangaroo";
            var passPart = "";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSC-289\BJW_GraphicalPasswordGen\Database.mdf;Integrated Security=True";
            string query = "Select Code From Image_Table Where Image = @animal";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@animal", animal);
                    passPart = cmd.ExecuteScalar()?.ToString();
                    passwordTextBox.Text += passPart;
                }
            }
        }
        private void A4button_Click(object sender, EventArgs e)
        {
            string animal = "Gorilla";
            var passPart = "";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSC-289\BJW_GraphicalPasswordGen\Database.mdf;Integrated Security=True";
            string query = "Select Code From Image_Table Where Image = @animal";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@animal", animal);
                    passPart = cmd.ExecuteScalar()?.ToString();
                    passwordTextBox.Text += passPart;
                }
            }
        }
        private void B1button_Click(object sender, EventArgs e)
        {
            string animal = "Turtle";
            var passPart = "";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSC-289\BJW_GraphicalPasswordGen\Database.mdf;Integrated Security=True";
            string query = "Select Code From Image_Table Where Image = @animal";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@animal", animal);
                    passPart = cmd.ExecuteScalar()?.ToString();
                    passwordTextBox.Text += passPart;
                }
            }
        }
        private void B2button_Click(object sender, EventArgs e)
        {
            string animal = "PolarBear";
            var passPart = "";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSC-289\BJW_GraphicalPasswordGen\Database.mdf;Integrated Security=True";
            string query = "Select Code From Image_Table Where Image = @animal";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@animal", animal);
                    passPart = cmd.ExecuteScalar()?.ToString();
                    passwordTextBox.Text += passPart;
                }
            }
        }
        private void B3button_Click(object sender, EventArgs e)
        {
            string animal = "Zebra";
            var passPart = "";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSC-289\BJW_GraphicalPasswordGen\Database.mdf;Integrated Security=True";
            string query = "Select Code From Image_Table Where Image = @animal";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@animal", animal);
                    passPart = cmd.ExecuteScalar()?.ToString();
                    passwordTextBox.Text += passPart;
                }
            }
        }
        private void B4button_Click(object sender, EventArgs e)
        {
            string animal = "Whale";
            var passPart = "";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSC-289\BJW_GraphicalPasswordGen\Database.mdf;Integrated Security=True";
            string query = "Select Code From Image_Table Where Image = @animal";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@animal", animal);
                    passPart = cmd.ExecuteScalar()?.ToString();
                    passwordTextBox.Text += passPart;
                }
            }
        }
        private void C1button_Click(object sender, EventArgs e)
        {
            string animal = "Cheetah";
            var passPart = "";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSC-289\BJW_GraphicalPasswordGen\Database.mdf;Integrated Security=True";
            string query = "Select Code From Image_Table Where Image = @animal";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@animal", animal);
                    passPart = cmd.ExecuteScalar()?.ToString();
                    passwordTextBox.Text += passPart;
                }
            }
        }
        private void C2button_Click(object sender, EventArgs e)
        {
            string animal = "Owl";
            var passPart = "";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSC-289\BJW_GraphicalPasswordGen\Database.mdf;Integrated Security=True";
            string query = "Select Code From Image_Table Where Image = @animal";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@animal", animal);
                    passPart = cmd.ExecuteScalar()?.ToString();
                    passwordTextBox.Text += passPart;
                }
            }
        }
        private void C3button_Click(object sender, EventArgs e)
        {
            string animal = "Croc";
            var passPart = "";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSC-289\BJW_GraphicalPasswordGen\Database.mdf;Integrated Security=True";
            string query = "Select Code From Image_Table Where Image = @animal";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@animal", animal);
                    passPart = cmd.ExecuteScalar()?.ToString();
                    passwordTextBox.Text += passPart;
                }
            }
        }
        private void C4button_Click(object sender, EventArgs e)
        {
            string animal = "Peacock";
            var passPart = "";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSC-289\BJW_GraphicalPasswordGen\Database.mdf;Integrated Security=True";
            string query = "Select Code From Image_Table Where Image = @animal";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@animal", animal);
                    passPart = cmd.ExecuteScalar()?.ToString();
                    passwordTextBox.Text += passPart;
                }
            }
        }
        private void D1button_Click(object sender, EventArgs e)
        {
            string animal = "Perry";
            var passPart = "";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSC-289\BJW_GraphicalPasswordGen\Database.mdf;Integrated Security=True";
            string query = "Select Code From Image_Table Where Image = @animal";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@animal", animal);
                    passPart = cmd.ExecuteScalar()?.ToString();
                    passwordTextBox.Text += passPart;
                }
            }
        }
        private void D2button_Click(object sender, EventArgs e)
        {
            string animal = "Shark";
            var passPart = "";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSC-289\BJW_GraphicalPasswordGen\Database.mdf;Integrated Security=True";
            string query = "Select Code From Image_Table Where Image = @animal";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@animal", animal);
                    passPart = cmd.ExecuteScalar()?.ToString();
                    passwordTextBox.Text += passPart;
                }
            }
        }
        private void D3button_Click(object sender, EventArgs e)
        {
            string animal = "Bison";
            var passPart = "";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSC-289\BJW_GraphicalPasswordGen\Database.mdf;Integrated Security=True";
            string query = "Select Code From Image_Table Where Image = @animal";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@animal", animal);
                    passPart = cmd.ExecuteScalar()?.ToString();
                    passwordTextBox.Text += passPart;
                }
            }
        }
        private void D4button_Click(object sender, EventArgs e)
        {
            string animal = "Ape";
            var passPart = "";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSC-289\BJW_GraphicalPasswordGen\Database.mdf;Integrated Security=True";
            string query = "Select Code From Image_Table Where Image = @animal";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@animal", animal);
                    passPart = cmd.ExecuteScalar()?.ToString();
                    passwordTextBox.Text += passPart;
                }
            }
        }
    }

}
