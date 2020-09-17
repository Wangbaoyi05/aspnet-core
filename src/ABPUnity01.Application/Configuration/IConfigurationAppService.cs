using System.Threading.Tasks;
using ABPUnity01.Configuration.Dto;

namespace ABPUnity01.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
