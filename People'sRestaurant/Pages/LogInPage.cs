using System.Data.SqlClient;
using System.Net.Http.Headers;
using People_sRestaurant.Models;

namespace People_sRestaurant
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void LNButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=EMIRKATA\SQLEXPRESS; Initial Catalog=Restaurant; Integrated Security=True;"))
            {
                sqlCon.Open();
                string query = "SELECT COUNT(*) FROM users where username = @username AND password = @password";

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@username", usernameField.Text);
                cmd.Parameters.AddWithValue("@password", passwordField.Text);

                int rowCount = Convert.ToInt32(cmd.ExecuteScalar());
                bool a = rowCount == 1;

                if (a)
                {
                    SqlCommand fetchID = new SqlCommand("SELECT user_id FROM users where username = @username AND password = @password", sqlCon);
                    fetchID.Parameters.AddWithValue("@username", usernameField.Text);
                    fetchID.Parameters.AddWithValue("@password", passwordField.Text);

                    SqlCommand fetchTel = new SqlCommand("SELECT telephone FROM users where username = @username AND password = @password", sqlCon);
                    fetchTel.Parameters.AddWithValue("@username", usernameField.Text);
                    fetchTel.Parameters.AddWithValue("@password", passwordField.Text);

                    int id = Convert.ToInt32(fetchID.ExecuteScalar());
                    string telephone = fetchTel.ExecuteScalar().ToString();

                    User user = new User(id, usernameField.Text, telephone);

                    FindTablesPage home = new FindTablesPage(user);
                    home.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect passowrd and username");
                }
            }
        }
    }
}
