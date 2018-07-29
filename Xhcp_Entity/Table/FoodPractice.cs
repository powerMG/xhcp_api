using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Xhcp_Entity.Core;

namespace Xhcp_Entity.Table
{
    public class FoodPractice:BaseEntity<long>
    {
        /// <summary>
        /// 步骤图片
        /// </summary>
        [Required]
        public string PracticeImg { get; set; }
        /// <summary>
        /// 步骤名称
        /// </summary>
        [Required]
        public string PracticeName { get; set; }
        /// <summary>
        /// 步骤描述
        /// </summary>
        public string PracticeDoc { get; set; }
        /// <summary>
        /// 步骤编号
        /// </summary>
        [Required]
        public string PracticeNum { get; set; }
        /// <summary>
        /// 步骤类别
        /// </summary>
        [Required]
        public int PracticeType { get; set; }
    }
}
