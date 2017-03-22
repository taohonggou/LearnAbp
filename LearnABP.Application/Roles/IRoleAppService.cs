using System.Threading.Tasks;
using Abp.Application.Services;
using LearnABP.Roles.Dto;

namespace LearnABP.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
