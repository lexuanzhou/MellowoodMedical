using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace MellowoodMedical.CMSES
{
	[Table("AppCmses")]
	public class CMS : FullAuditedEntity<long>
	{
		public virtual long PageId { get; set; }

		public virtual string PageName { get; protected set; }

		public virtual string PageContent { get; protected set; }

		/// <summary>
		/// We don't make constructor public and forcing to create events using <see cref="Create"/> method.
		/// But constructor can not be private since it's used by EntityFramework.
		/// Thats why we did it protected.
		/// </summary>
		protected CMS()
		{

		}

		public static CMS InsertOrUpdateAsync(long pageId, string pageName, string pageContent)
		{
			var @cms = new CMS
			{
				PageId = pageId,
				PageName = pageName,
				PageContent = pageContent
			};

			return @cms;
		}

	}

}
