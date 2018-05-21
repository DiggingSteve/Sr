using System.Threading.Tasks;
using Abp.Application.Services;
using Sr.Configuration.Dto;

namespace Sr.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}