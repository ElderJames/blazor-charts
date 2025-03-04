﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlazorCharts
{
    public abstract class ElementAxes<TData> : Element<TData>
    {
        /// <summary>
        /// 轴组
        /// </summary>
        public BcAxisGroup<TData> AxisGroup { get; set; }

    }
}
