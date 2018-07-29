using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Xhcp_Entity.Core;

namespace Xhcp_Entity.Table
{
    public class FoodIngredient : BaseEntity<long>
    {
        /// <summary>
        /// 原料名称
        /// </summary>
        [Required]
        public string IngredientName { get; set; }
        /// <summary>
        /// 原料用量
        /// </summary>
        [Required]
        public string IngredientDosage { get; set; }
        /// <summary>
        /// 原料标签
        /// </summary>
        public int IngredientTagId { get; set; }
        /// <summary>
        /// 原料类别
        /// </summary>
        public int IngredientType { get; set; }
    }
}
