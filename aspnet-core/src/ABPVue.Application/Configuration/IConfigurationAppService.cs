using System.Threading.Tasks;
using ABPVue.Configuration.Dto;

namespace ABPVue.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
