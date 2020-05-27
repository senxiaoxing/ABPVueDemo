using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABPVue.Configuration.Dto;

namespace ABPVue.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPVueAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
