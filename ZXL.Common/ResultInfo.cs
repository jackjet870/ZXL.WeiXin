﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZXL.Common
{
    public class ResultInfo
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }
    }

    /// <summary>
    /// 操作结果类
    /// </summary>
    /// <typeparam name="T">所携带数据类型</typeparam>
    public class ResultInfo<T>
    {
        public ResultInfo()
        {
            IsSuccess = false;
            Data = default(T);
        }

        /// <summary>
        /// 操作是否成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 结果说明信息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        public T Data { get; set; }
    }
}
