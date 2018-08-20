using System;
using System.Collections.Generic;
using System.Text;

namespace Xhcp_Entity.Common.ResultModel
{
    public class OpreationResult<T> : OpreationResult where T : class {
        internal OpreationResult() {
        }
        /// <summary>
        /// 返回的操作数据
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// 初始化一个结果类
        /// </summary>
        /// <param name="type">操作类型</param>
        /// <param name="data">返回的对象</param>
        /// <param name="message">操作信息</param>
        /// <returns>操作结果</returns>
        public static OpreationResult<T> Init(OpreationResultType type, T data, string message = "操作成功")
        {
            return new OpreationResult<T>() { Data = data, Message = message, ResultType = type };
        }
    }
    public class OpreationResult
    {
        /// <summary>
        /// 只能使用Init初始化
        /// </summary>
        internal OpreationResult()
        {
        }
        /// <summary>
        /// 操作结果描述信息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 返回的操作结果类型
        /// </summary>
        public OpreationResultType ResultType { get; set; }
        public static OpreationResult Init(OpreationResultType type, string message = "操作成功")
        {
            return new OpreationResult() { Message = message, ResultType = type };
        }

        public static OpreationResult Init(object success)
        {
            throw new NotImplementedException();
        }
    }
    public enum OpreationResultType
    {
        /// <summary>
        /// 操作成功
        /// </summary>
        Success = 200,

        /// <summary>
        /// 服务器错误
        /// </summary>
        Error = 500,

        /// <summary>
        /// 信息验证失败
        /// </summary>
        ValidtorError = 403,

        /// <summary>
        /// 信息查询为空
        /// </summary>
        QueryNull = 404,

        /// <summary>
        /// 用户未登陆
        /// </summary>
        UnLogin = -403
    }
}
