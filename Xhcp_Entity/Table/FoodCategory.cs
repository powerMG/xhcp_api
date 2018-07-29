using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Xhcp_Entity.Core;

namespace Xhcp_Entity.Table
{
    public class FoodCategory : BaseEntity<long>
    {
        /// <summary>
        /// 分类图片
        /// </summary>
        [Required]
        public string CategoryImg { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary>
        [Required]
        public string CategoryName { get; set; }
        /// <summary>
        /// 分类类型
        /// </summary>
        [Required]
        public int CategoryType { get; set; }
        /// <summary>
        /// 分类父级id
        /// </summary>
        [Required, DefaultValue(0)]
        public int CategoryPid { get; set; }
        /// <summary>
        /// 分类跳转url
        /// </summary>
        public string CategoryUrl { get; set; }
        /// <summary>
        /// 分类描述
        /// </summary>
        public string CategoryDoc { get; set; }
    }
}
