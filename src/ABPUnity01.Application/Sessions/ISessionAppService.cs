using System.Threading.Tasks;
using Abp.Application.Services;
using ABPUnity01.Sessions.Dto;

namespace ABPUnity01.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
