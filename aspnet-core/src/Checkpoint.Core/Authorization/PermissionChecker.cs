using Abp.Authorization;
using Checkpoint.Authorization.Roles;
using Checkpoint.Authorization.Users;

namespace Checkpoint.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
