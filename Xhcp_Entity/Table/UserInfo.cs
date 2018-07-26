using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Xhcp_Entity.Core;

namespace Xhcp_Entity.Table
{
    public class UserInfo : BaseEntity<long>
    {
        /// <summary>
        /// 名称
        /// </summary>
        [StringLength(20)]
        [Required]
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        public string Password { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [StringLength(500)]
        [Required]
        public string Description { get; set; }
        /// <summary>
        /// 类别
        /// </summary>
        [Range(1, int.MaxValue)]
        public int Category { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        [Range(1, int.MaxValue)]
        public int Role { get; set; }
    }
}
