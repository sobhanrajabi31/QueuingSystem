namespace Queuing_System_Alipour.Tool.Models
{
    public class PersonnelTempModel
    {
        private static int autoIncrement = 0;

        public int Id { get; set; }
        public string FullName { get; set; }

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
