using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LearnABP.MultiTenancy.Dto;

namespace LearnABP.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
