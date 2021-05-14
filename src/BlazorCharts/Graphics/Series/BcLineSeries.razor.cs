﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlazorCharts
{
    public partial class BcLineSeries<TData> : ElementSeries<TData>
    {
        public BcLineSeries() : base(SeriesType.Line)
        {

        }

        internal override int GroupKeepRatio => 0;

    }
}