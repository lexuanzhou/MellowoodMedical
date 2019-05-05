using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MellowoodMedical.CMS.Dtos
{
	public class CreateCMSInput
	{
		[Required]
		public int pageId { get; set; }

		public string PageName { get; set; }

		public string PageContent { get; set; }
	}
}
