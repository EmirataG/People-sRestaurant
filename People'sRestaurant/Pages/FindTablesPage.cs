using People_sRestaurant.Models;
using People_sRestaurant.Pages;
using System.Data;
using System.Data.SqlClient;

namespace People_sRestaurant
{
    public partial class FindTablesPage : Form
    {
        private User user;
        private bool locationCondition = false;
        private bool capacityCondition = false;
        public FindTablesPage(User user)
        {
            InitializeComponent();
            this.user = user;
            welcomeGreeting.Text = $"Welcome, {user.Username}! Make your reservation here: ";
            DataGridViewButtonColumn bookButtonColumn = new DataGridViewButtonColumn();
            bookButtonColumn.Name = "BookButton";
            bookButtonColumn.Text = "Book";
            bookButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(bookButtonColumn);

            dataGridView1.CellClick += (sender, e) =>
            {
                try
                {
                    if (e.ColumnIndex == dataGridView1.Columns["BookButton"].Index && e.RowIndex >= 0)
                    {
                        int tableId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["table number"].Value);

                        string reservationStart = pickTime.Value.ToShortDateString() + " " + from.Text;
                        string reservationEnd = pickTime.Value.ToShortDateString() + " " + to.Text;
                        Reservation reservation = new Reservation(tableId, user, reservationStart, reservationEnd);

                        using (BookingPage bookingForm = new BookingPage(reservation))
                        {
                            DialogResult result = bookingForm.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                MessageBox.Show("Table booked successfully!");
                            }
                            Clear();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Enter fields first!");
                }
            };
        }

        private void results_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=EMIRKATA\SQLEXPRESS; Initial Catalog=Restaurant; Integrated Security=True;"))
            {
                dataGridView1.DataSource = null;
                sqlCon.Open();

                string query = "SELECT DISTINCT t.id as 'table number', capacity, location FROM tables t LEFT JOIN reservations r ON t.id = r.table_id WHERE 1=1 ";
                string date = "";
                string availabilityCheck = "";

                List<string> conditions = new List<string>();

                if (ValidateTimeFormat(from.Text) && ValidateTimeFormat(to.Text))
                {
                    if (DateTime.ParseExact(from.Text, "HH:mm", System.Globalization.CultureInfo.InvariantCulture) < DateTime.ParseExact(to.Text, "HH:mm", System.Globalization.CultureInfo.InvariantCulture))
                    {
                        availabilityCheck = "((r.reservation_start IS NULL OR r.reservation_end <= @from) OR (r.reservation_start >= @to OR r.reservation_end IS NULL)) AND NOT EXISTS (SELECT 1 FROM reservations r2 WHERE r2.table_id = t.id AND (r2.reservation_start BETWEEN @from AND @to OR r2.reservation_end BETWEEN @from AND @to))";
                        conditions.Add(availabilityCheck);

                        if (location.SelectedItem != null)
                            locationCondition = true;
                        else locationCondition = false;

                        if (pickTime.Value.ToShortDateString() != null)
                            date = pickTime.Value.ToShortDateString();

                        if (capacity.SelectedItem != null)
                            capacityCondition = true;
                        else capacityCondition = false;

                        if (locationCondition)
                            conditions.Add("location = @location");

                        if (capacityCondition)
                            conditions.Add("capacity = @capacity");

                        query = query + "AND " + string.Join(" AND ", conditions);

                        SqlCommand cmd = new SqlCommand(query, sqlCon);

                        string a = date + " " + from.Text;

                        cmd.Parameters.AddWithValue("@from", date + " " + from.Text);
                        cmd.Parameters.AddWithValue("@to", date + " " + to.Text);

                        if (locationCondition)
                            cmd.Parameters.AddWithValue("@location", location.SelectedItem.ToString());

                        if (capacityCondition)
                        {
                            cmd.Parameters.AddWithValue("@capacity", capacity.SelectedItem);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("The start of the reservation has to be earlier than the end... obviously");
                    }
                }
                    
                else
                {
                    MessageBox.Show("Please specify the time period of the reservation, and make sure tu use the following format XX:XX!");
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            dataGridView1.DataSource = null;
            location.SelectedIndex = -1;
            location.Text = "Location";
            pickTime.Value = DateTime.Today;
            from.Text = String.Empty;
            to.Text = String.Empty;
            capacity.SelectedIndex = -1;
            capacity.Text = "Capacity";
        }

        private void reservationsButton_Click(object sender, EventArgs e)
        {
            ReservationPage reservations = new ReservationPage(user, this);
            reservations.Show();
            Hide();
        }
        public static bool ValidateTimeFormat(string input)
        {
            try
            {
                string[] parts = input.Split(':');

                if (parts.Length != 2)
                    return false;

                int hours = int.Parse(parts[0]);
                int minutes = int.Parse(parts[1]);

                if (hours >= 0 && hours < 24 && minutes >= 0 && minutes < 60)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
    }
}