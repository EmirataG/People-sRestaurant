namespace People_sRestaurant.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Telephone { get; set; }

        public User(int id, string username, string telephone)
        {
            Id = id;
            Username = username;
            Telephone = telephone;
        }
    }
}
