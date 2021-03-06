﻿using System;

namespace SmartSql.DyRepository
{
    /// <summary>
    /// 函数参数特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public class ParamAttribute : Attribute
    {
        public ParamAttribute(string name = "")
        {
            Name = name;
        }
        /// <summary>
        /// DbDataParameter.Name
        /// </summary>
        public String Name { get; set; }
    }
}