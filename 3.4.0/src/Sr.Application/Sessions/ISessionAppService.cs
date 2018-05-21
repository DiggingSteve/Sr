using System.Threading.Tasks;
using Abp.Application.Services;
using Sr.Sessions.Dto;

namespace Sr.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
