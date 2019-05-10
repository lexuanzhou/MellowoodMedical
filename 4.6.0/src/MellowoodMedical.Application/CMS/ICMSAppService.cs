using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MellowoodMedical.CMSES.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MellowoodMedical.CMSES
{
	public interface  ICMSAppservice: IApplicationService
	{
		Task<ListResultDto<CMScontentDto>> GetAll();

		Task<CMScontentDto> GetCMSContent(GetCMScontentInput input);

		Task InsertOrUpdateCMSContent(InsertOrUpdateCMSInput input);
		
	}
}
