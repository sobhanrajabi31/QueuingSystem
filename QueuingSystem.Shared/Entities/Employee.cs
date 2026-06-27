namespace QueuingSystem.Shared.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Role { get; set; }
        public bool AccessLevel { get; set; }

        public List<Personnel> Personnels { get; set; }
        public List<Atelier> Ateliers { get; set; }
    }
}
