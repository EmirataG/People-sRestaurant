using People_sRestaurant.Models;
using System.Data.SqlClient;

namespace People_sRestaurant.Pages
{
    public partial class BookingPage : Form
    {
        private Reservation reservation;
        public BookingPage(Reservation res)
        {
            InitializeComponent();

            reservation = res;

            tableLabel.Text = "Table number: " + reservation.TableId;
            fromLabel.Text = "From: " + reservation.Start;
            toLabel.Text = "To: " + reservation.End;
            nameBox.Text = reservation.UserName;
            telBox.Text = reservation.Telephone;
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            if (Reservation.IsPhoneNumber(telBox.Text))
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=EMIRKATA\SQLEXPRESS; Initial Catalog=Restaurant; Integrated Security=True;"))
                {
                    sqlCon.Open();

                    string query = "INSERT INTO reservations (table_id, reservation_start, reservation_end, user_id, name, telephone) VALUES (@table_id, @reservation_start, @reservation_end, @user_id, @name, @telephone)";
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@table_id", reservation.TableId);
                    cmd.Parameters.AddWithValue("@reservation_start", reservation.Start);
                    cmd.Parameters.AddWithValue("@reservation_end", reservation.End);
                    cmd.Parameters.AddWithValue("@user_id", reservation.UserId);
                    cmd.Parameters.AddWithValue("@name", nameBox.Text);
                    cmd.Parameters.AddWithValue("@telephone", telBox.Text);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Reservation successfully booked!");
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error: Reservation could not be booked.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid phone number!");
            }
        }
    }
}