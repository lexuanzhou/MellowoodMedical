using System;
using Abp.Domain.Services;
using System.Threading.Tasks;

namespace MellowoodMedical.CMS
{
	public interface ICMSManager : IDomainService
	{
		Task<CMS> GetAsync(long PageId);

		Task InsertOrUpdateAsync(CMS @cms);

	}
}
