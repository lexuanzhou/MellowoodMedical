﻿using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.UI;
using MellowoodMedical.CMSES.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace MellowoodMedical.CMSES
{
	[AbpAuthorize]
	public class CMSAppService : MellowoodMedicalAppServiceBase, ICMSAppservice
	{
		private readonly ICMSManager _cmsManager;
		private readonly IRepository<CMS, long> _cmsRepository;

		public CMSAppService(ICMSManager cmsManager, IRepository<CMS, long> cmsRepository)
		{
			_cmsManager = cmsManager;
			_cmsRepository = cmsRepository;
		}

		public async Task<ListResultDto<CMScontentDto>> GetAll()
		{
			var cmses = await _cmsRepository
				.GetAll()
				.GroupBy(p => p.PageId)
				.Select(g => g.LastOrDefault())
				.ToListAsync();

			if (@cmses == null)
			{
				throw new UserFriendlyException("Could not found these cmses, maybe it's deleted.");
			}

			return new ListResultDto<CMScontentDto>(cmses.MapTo<List<CMScontentDto>>());
		}

		public async Task<CMScontentDto> GetCMSContent(GetCMScontentInput input)
		{
			var cms = await _cmsRepository
				.GetAll()
				.Where(e => e.PageId == input.PageId)
				.LastOrDefaultAsync();

			if (@cms == null)
			{
				throw new UserFriendlyException("Could not found the cms, maybe it's deleted.");
			}
			return @cms.MapTo<CMScontentDto>();
		}

		public async Task InsertOrUpdateCMSContent(InsertOrUpdateCMSInput input)
		{
			var @cms = CMS.InsertOrUpdateAsync(input.PageId, input.PageName, input.PageContent);
			await _cmsManager.InsertOrUpdateAsync(@cms);
		}


	}
}
