using Abp.Authorization;
using ABPVue.Authorization.Roles;
using ABPVue.Authorization.Users;

namespace ABPVue.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
