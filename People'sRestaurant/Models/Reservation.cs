using System.Text.RegularExpressions;

namespace People_sRestaurant.Models
{
    public class Reservation
    {
        public int TableId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Telephone { get; set; }

        public string Start { get; set; }
        public string End { get; set; }

        public Reservation(int tableId, User user, string reservationStart, string reservationEnd)
        {
            TableId = tableId;
            UserId = user.Id;
            UserName = user.Username;
            Telephone = user.Telephone;
            Start = reservationStart;
            End = reservationEnd;
        }

        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(0|\+[0-9]{1,3})[0-9]{8,11}$").Success;
        }
    }
}
