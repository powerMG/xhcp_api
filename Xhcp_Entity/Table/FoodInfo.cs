using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Xhcp_Entity.Core;

namespace Xhcp_Entity.Table
{
    public class FoodInfo : BaseEntity<long>
    {
        /// <summary>
        /// 食物图片
        /// </summary>
        [Required]
        public string FoodImg { get; set; }
        /// <summary>
        /// 食物标题
        /// </summary>
        [Required]
        public string FoodTitle { get; set; }
        /// <summary>
        /// 食物特别说明
        /// </summary>
        public string FoodNotice { get; set; }
        /// <summary>
        /// 食物描述
        /// </summary>
        [Required]
        public string FoodDoc { get; set; }
        /// <summary>
        /// 食物作者
        /// </summary>
        [Required]
        public string FoodAuthor { get; set; }
        /// <summary>
        /// 食物功效
        /// </summary>
        [Required]
        public string FoodEffect { get; set; }
        /// <summary>
        /// 食物用料id
        /// </summary>
        [Required]
        public string FoodIngredientId { get; set; }
        /// <summary>
        /// 食物做法id
        /// </summary>
        [Required]
        public string FoodPracticeId { get; set; }
    }
}
