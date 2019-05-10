using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MellowoodMedical.CMS.Dtos
{
	public class InsertOrUpdateCMSInput
	{
		[Required]
		public long PageId { get; set; }

		public string PageName { get; set; }

		public string PageContent { get; set; }
	}
}
