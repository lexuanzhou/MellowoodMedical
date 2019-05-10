using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Events.Bus;

namespace MellowoodMedical.CMSES
{
	public class CMSManager : ICMSManager
	{

		private readonly IRepository<CMS,long> _cmsRepository;

		public CMSManager(IRepository<CMS,long> cmsRepository)
		{
			_cmsRepository = cmsRepository;
		}
		

		public async Task<CMS> GetAsync(long PageId)
		{
			var @cms = await _cmsRepository.FirstOrDefaultAsync(PageId);
			if (@cms == null)
			{
				throw new Abp.UI.UserFriendlyException("Could not found the event, maybe it's deleted!");
			}
			return cms;
		}

		public async Task InsertOrUpdateAsync(CMS @cms)
		{
			await _cmsRepository.InsertOrUpdateAndGetIdAsync(@cms);
		}
	}
}
