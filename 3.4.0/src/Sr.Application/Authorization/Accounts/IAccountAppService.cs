using System.Threading.Tasks;
using Abp.Application.Services;
using Sr.Authorization.Accounts.Dto;

namespace Sr.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
