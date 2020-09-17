using System.Collections.Generic;
using ABPUnity01.Roles.Dto;

namespace ABPUnity01.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
