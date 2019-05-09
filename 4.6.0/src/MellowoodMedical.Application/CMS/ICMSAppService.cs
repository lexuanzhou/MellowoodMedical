using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MellowoodMedical.CMS.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MellowoodMedical.CMS
{
	public interface  ICMSAppservice: IApplicationService
	{
		Task<ListResultDto<CMScontentDto>> GetAllAsync();

		Task<CMScontentDto> GetAsync(GetCMScontentInput input);

		Task InsertOrUpdateAsync(InsertOrUpdateCMSInput input);
		
	}
}
