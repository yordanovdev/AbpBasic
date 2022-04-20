using Abp.Authorization;
using Something.Authorization.Roles;
using Something.Authorization.Users;

namespace Something.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
