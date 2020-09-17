using System.Collections.Generic;
using ABPUnity01.Roles.Dto;

namespace ABPUnity01.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
