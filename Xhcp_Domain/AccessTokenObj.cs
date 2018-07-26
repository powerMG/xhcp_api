using System;
using System.Collections.Generic;

namespace Xhcp_Domain
{
    public class AccessTokenObj
    {
        /// <summary>
        /// <![CDATA[错误码]]>
        /// </summary>
        public int code { get; set; }

        /// <summary>
        ///<![CDATA[消息]]>
        /// </summary>
        public string message { get; set; }

        /// <summary>
        /// <![CDATA[内容]]>
        /// </summary>
        public string data { get; set; }
        public string AccessToken { get; set; }
        public string Expires { get; set; }
    }
}
