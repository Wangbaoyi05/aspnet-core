using Abp.Application.Services.Dto;

namespace ABPUnity01.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

