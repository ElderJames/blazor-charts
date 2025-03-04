﻿using BlazorCharts;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlazorCharts
{
    public partial class BcAxesX<TData> : ElementAxes<TData>
    {
        /// <summary>
        /// 标签位置
        /// </summary>
        [Parameter] public AxesLabelPosition LabelPosition { get; set; } = AxesLabelPosition.Axis;

        private int? _DistanceAxis;
        /// <summary>
        /// 与坐标轴的距离
        /// </summary>
        [Display(Name = "标签与坐标轴的距离")]
        [Parameter] public int? DistanceAxis { get => _DistanceAxis ?? 5; set => _DistanceAxis = value; }

        /// <summary>
        /// 显示主要网格线
        /// </summary>
        [Display(Name = "显示主要网格线")]
        [Parameter] public bool GridLineMajor { get; set; } = false;

        /// <summary>
        /// 是否可见
        /// </summary>
        [Display(Name = "可见的")]
        [Parameter] public bool Visible { get; set; } = true;

        public override void Drawing()
        {
            if (Visible == true)
            {
                Rect.H = LabelPosition switch
                {
                    AxesLabelPosition.Axis => DistanceAxis.Value + FontSizeHeight + 10,
                    AxesLabelPosition.None => 1,
                    _ => throw new NotImplementedException(),
                };
            }else
            {
                Rect.H = 0;
            }
            Rect.X = AxisGroup.Rect.X;
            Rect.W = AxisGroup.Rect.W;
            Rect.B = AxisGroup.Rect.B;

            base.Drawing();
        }
    }

}
