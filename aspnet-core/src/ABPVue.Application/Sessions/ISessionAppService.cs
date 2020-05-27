using System.Threading.Tasks;
using Abp.Application.Services;
using ABPVue.Sessions.Dto;

namespace ABPVue.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
