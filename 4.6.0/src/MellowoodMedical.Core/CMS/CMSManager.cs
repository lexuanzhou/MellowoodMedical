using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Events.Bus;

namespace MellowoodMedical.CMS
{
	public class CMSManager : ICMSManager
	{

		private readonly IRepository<CMS, Guid> _cmsRepository;

		public CMSManager(IRepository<CMS,Guid> cmsRepository)
		{
			_cmsRepository = cmsRepository;
		}
		

		public async Task<CMS> GetAsync(Guid id)
		{
			var @cms = await _cmsRepository.FirstOrDefaultAsync(id);
			if (@cms == null)
			{
				throw new Abp.UI.UserFriendlyException("Could not found the event, maybe it's deleted!");
			}
			return cms;
		}

		public async Task CreateAsync(CMS @cms)
		{
			await _cmsRepository.InsertAsync(@cms);
		}
	}
}
