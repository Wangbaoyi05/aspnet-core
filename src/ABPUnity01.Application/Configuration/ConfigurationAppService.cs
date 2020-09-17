using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABPUnity01.Configuration.Dto;

namespace ABPUnity01.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPUnity01AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
