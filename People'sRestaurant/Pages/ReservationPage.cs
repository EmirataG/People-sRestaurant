using People_sRestaurant.Models;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace People_sRestaurant.Pages
{
    public partial class ReservationPage : Form
    {
        private User user;
        public FindTablesPage tablesPage;
        public ReservationPage(User user, FindTablesPage pageBack)
        {
            tablesPage = pageBack;
            InitializeComponent();
            this.user = user;

            welcomeGreeting.Text = $"Welcome {user.Username}! These are all reservations booked from your profile:";

            DataGridViewButtonColumn cancelButtonColumn = new DataGridViewButtonColumn();
            cancelButtonColumn.Name = "Cancel Reservation";
            cancelButtonColumn.Text = "Cancel";
            cancelButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(cancelButtonColumn);
            dataGridView.Columns["Cancel Reservation"].Width = 90;
            UpdateGrid();

            dataGridView.CellClick += (sender, e) =>
            {
                try
                {
                    if (e.ColumnIndex == dataGridView.Columns["Cancel Reservation"].Index && e.RowIndex >= 0)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to cancel this reservation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            using (SqlConnection sqlCon2 = new SqlConnection(@"Data Source=EMIRKATA\SQLEXPRESS; Initial Catalog=Restaurant; Integrated Security=True;"))
                            {
                                sqlCon2.Open();
                                string delete = "DELETE FROM reservations WHERE id = @id";
                                SqlCommand cmd2 = new SqlCommand(delete, sqlCon2);
                                int reservationId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["reservation id"].Value);
                                cmd2.Parameters.AddWithValue("@id", reservationId);
                                cmd2.ExecuteNonQuery();
                                UpdateGrid();
                            }
                            MessageBox.Show("Reservation canceled successfully!");
                        }
                    }
                    else if (e.ColumnIndex == dataGridView.Columns["telephone"].Index && e.RowIndex >= 0)
                    {
                        string phoneNumber = dataGridView.Rows[e.RowIndex].Cells["telephone"].Value.ToString();
                        string input = Microsoft.VisualBasic.Interaction.InputBox("Enter new phone number", "Update Phone Number", phoneNumber);
                        if (Reservation.IsPhoneNumber(input))
                        {
                            using (SqlConnection sqlCon2 = new SqlConnection(@"Data Source=EMIRKATA\SQLEXPRESS; Initial Catalog=Restaurant; Integrated Security=True;"))
                            {
                                sqlCon2.Open();
                                string update = "UPDATE reservations SET telephone = @phone WHERE id = @id";
                                SqlCommand cmd2 = new SqlCommand(update, sqlCon2);
                                int reservationId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["reservation id"].Value);
                                cmd2.Parameters.AddWithValue("@id", reservationId);
                                cmd2.Parameters.AddWithValue("@phone", input);
                                cmd2.ExecuteNonQuery();
                                UpdateGrid();
                            }
                            MessageBox.Show("Phone number updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Invalid phone number!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong. " + ex.Message);
                }
            };
        }
        private void UpdateGrid()
        {
            dataGridView.DataSource = null;
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=EMIRKATA\SQLEXPRESS; Initial Catalog=Restaurant; Integrated Security=True;"))
            {
                sqlCon.Open();
                string query = "SELECT r.id as 'reservation id', table_id as 'table number', reservation_start as 'starts at:', reservation_end as 'ends at:', name, telephone, location FROM reservations r JOIN tables t ON r.table_id = t.id WHERE user_id = @id";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@id", user.Id);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
                dataGridView.Columns["reservation id"].Visible = false;
                dataGridView.Columns["table number"].Width = 70;
                dataGridView.Columns["starts at:"].Width = 170;
                dataGridView.Columns["ends at:"].Width = 170;
                dataGridView.Columns["name"].Width = 90;
                dataGridView.Columns["location"].Width = 100;
                dataGridView.Columns["telephone"].Width = 120;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            tablesPage.Show();
            Hide();
        }
        
    }
}
