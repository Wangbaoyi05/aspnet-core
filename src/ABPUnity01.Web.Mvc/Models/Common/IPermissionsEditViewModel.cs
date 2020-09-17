using System.Collections.Generic;
using ABPUnity01.Roles.Dto;

namespace ABPUnity01.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}