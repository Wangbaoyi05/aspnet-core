using Abp.Authorization;
using ABPUnity01.Authorization.Roles;
using ABPUnity01.Authorization.Users;

namespace ABPUnity01.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
