namespace Queuing_System_Alipour.Tool.Models
{
    public class PersonnelModel
    {
        private static int autoIncrement = 0;

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Author { get; set; }

        public static int GetNextID()
        {
            return ++autoIncrement;
        }

        public static void UpdateIncrement(int id)
        {
            autoIncrement = id;
        }
    }
}