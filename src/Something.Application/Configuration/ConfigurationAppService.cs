using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Something.Configuration.Dto;

namespace Something.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SomethingAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
