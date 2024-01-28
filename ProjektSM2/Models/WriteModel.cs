using SQLite;

namespace ProjektSM2.Models
{
    public class WriteModel
	{
		[PrimaryKey, AutoIncrement]
		public int id { get; set; }
		public string question { get; set; }
		public string answer { get; set; }
		public string incorrectans1 { get; set; }
		public string incorrectans2 { get; set; }
		public string incorrectans3 { get; set; }
	}
}
