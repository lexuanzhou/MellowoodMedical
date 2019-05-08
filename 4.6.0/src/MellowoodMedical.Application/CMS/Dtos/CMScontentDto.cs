using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MellowoodMedical.CMS.Dtos
{
	[AutoMapFrom(typeof(CMS))]
	public class CMScontentDto : FullAuditedEntityDto<Guid>
	{
		public int PageId { get; set; }
		public string PageName { get; set; }

		public string PageContent { get; set; }
	}
}
