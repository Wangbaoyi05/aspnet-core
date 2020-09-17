using System.Threading.Tasks;
using Abp.Application.Services;
using ABPUnity01.Authorization.Accounts.Dto;

namespace ABPUnity01.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
