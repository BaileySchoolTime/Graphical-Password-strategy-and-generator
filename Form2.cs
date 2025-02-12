using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Text.RegularExpressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BJW_GraphicalPasswordGen
{
    public partial class Form2 : Form
    {
        string encryptionKey;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
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

        private void backButton_Click(object sender, EventArgs e)
        {
            var myForm = new Form1();
            myForm.Show();
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Please enter a Email or Password.");

            }
            else
            {
                string encryptedText = Encrypt(passwordTextBox.Text, encryptionKey);
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSC-289\BJW_GraphicalPasswordGen\Database.mdf;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("Select Count(*) From User_Table where UserName='" + userTextBox.Text + "' and Password = '" + encryptedText + "'", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Login Succesful!");
                }
                else
                {
                    MessageBox.Show("Username or Password Incorrect!");
                }
            }
        }

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

        private void clearButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
