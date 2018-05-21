using Abp.Authorization;
using Sr.Authorization.Roles;
using Sr.Authorization.Users;

namespace Sr.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
