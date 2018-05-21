using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Sr.Configuration.Dto;

namespace Sr.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SrAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
