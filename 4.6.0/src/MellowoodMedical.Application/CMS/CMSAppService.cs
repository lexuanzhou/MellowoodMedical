using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using MellowoodMedical.CMS.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MellowoodMedical.CMS
{
	public class CMSAppService : MellowoodMedicalAppServiceBase, ICMSAppservice
	{
		private readonly ICMSManager _cmsManager;
		private readonly IRepository<CMS, Guid> _cmsRepository;

		public CMSAppService(ICMSManager cmsManager, IRepository<CMS, Guid> cmsRepository)
		{
			_cmsManager = cmsManager;
			_cmsRepository = cmsRepository;
		}

		public async Task<ListResultDto<CMSListDto>> GetListAsync(GetCMSListInput input)
		{
			var cms = await _cmsRepository
				.GetAll()
				.ToListAsync();
			return new ListResultDto<CMSListDto>(cms.MapTo<List<CMSListDto>>());
		}

		public async Task CreateAsync(CreateCMSInput input)
		{
			var @cms = CMS.Create(input.pageId, input.PageName, input.PageContent);
			await _cmsManager.CreateAsync(@cms);
		}


	}
}
