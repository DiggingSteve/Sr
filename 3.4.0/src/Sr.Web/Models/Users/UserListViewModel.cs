using System.Collections.Generic;
using Sr.Roles.Dto;
using Sr.Users.Dto;

namespace Sr.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}