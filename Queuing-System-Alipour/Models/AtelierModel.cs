namespace Queuing_System_Alipour.Models
{
    public class AtelierModel
    {
        private static int autoIncrement = 0;

        public int Id { get; set; }
        public string Author { get; set; }
        public string StartHour { get; set; }
        public string SpentTime { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Note { get; set; }
        public bool? Status { get; set; }

        public static int GetNextID()
        {
            return ++autoIncrement;
        }

        public static int UpdateIncrement(int id)
        {
            return autoIncrement = id;
        }
    }
}
