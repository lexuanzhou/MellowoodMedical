using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;

namespace MellowoodMedical.CMSES.Dtos
{
	[AutoMapFrom(typeof(CMS))]
	public class CMScontentDto : FullAuditedEntity<long>
	{
		public long PageId { get; set; }

		public string PageName { get; set; }

		public string PageContent { get; set; }
	}
}
