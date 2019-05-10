using System.ComponentModel.DataAnnotations;


namespace MellowoodMedical.CMSES.Dtos
{
	public class InsertOrUpdateCMSInput
	{
		[Required]
		public long PageId { get; set; }

		public string PageName { get; set; }

		public string PageContent { get; set; }
	}
}
