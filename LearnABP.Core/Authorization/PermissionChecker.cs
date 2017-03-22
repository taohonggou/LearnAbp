using Abp.Authorization;
using LearnABP.Authorization.Roles;
using LearnABP.MultiTenancy;
using LearnABP.Users;

namespace LearnABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
