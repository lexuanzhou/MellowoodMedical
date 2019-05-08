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
		Task<ListResultDto<CMScontentDto>> GetListAsync(GetCMScontentInput input);

		Task CreateAsync(CreateCMSInput input);
		
	}
}
