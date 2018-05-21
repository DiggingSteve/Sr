using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Sr.MultiTenancy.Dto;

namespace Sr.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
