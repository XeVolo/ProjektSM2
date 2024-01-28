using SQLite;

namespace ProjektSM2.Models
{
    public class WriteModel
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Question { get; set; }
		public string Answer { get; set; }
		public string Incorrectans1 { get; set; }
		public string Incorrectans2 { get; set; }
		public string Incorrectans3 { get; set; }
	}
}
