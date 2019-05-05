using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace MellowoodMedical.CMS
{
	[Table("CMSContent")]
	public class CMS : FullAuditedEntity<Guid>
	{
		public virtual string PageName { get; set; }

		public virtual string PageContent { get; set; }

	}

	protected CMS()
	{

	}

	public static CMS Create(string pageName, string pageContent)
	{
		var @cms = new CMS
		{
			Id = Guid.NewGuid(),
			PageName = pageName,
			PageContent = pageContent
		};

		return @cms;
}
