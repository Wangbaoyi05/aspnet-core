
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ABPUnity01.Entitys
{
    [Table("UserInfo")]
   public class UserInfo:Entity<int>,IHasCreationTime
    {
        public UserInfo()
        {
            this.UserId = 0;
            this.UserName = string.Empty;
            this.UserPwd = string.Empty;
            this.UserAge = 0;
            this.CreationTime = Clock.Now;
        }
        [Key]
        public int UserId { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string UserPwd { get; set; }
        public int UserAge { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
