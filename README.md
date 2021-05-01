# blazor-charts

![无标题](https://user-images.githubusercontent.com/7581981/116421071-1b6f9380-a871-11eb-88a6-9abb8e1b165f.png)

基于blazor技术，使用C#编写的charts组件。

DemoSite: [https://victorious-meadow-0c2078000.azurestaticapps.net/](https://victorious-meadow-0c2078000.azurestaticapps.net/)


| Build | NuGet |
|--|--|
|![](https://github.com/TimChen44/blazor-charts/workflows/.NET/badge.svg)|[![](https://img.shields.io/nuget/v/BlazorCharts.svg)](https://www.nuget.org/packages/BlazorCharts)|

### 使用方法

1. 安装组件包

2. 修改`_Imports.razor`文件，添加引用`@using BlazorCharts`

3. 页面中使用

```html
<BcChart Height="400" Width="600" Data="githubs" CategoryField="x=>x.Year.ToString()">
    <BcTitle Title="@title" TData="Github"></BcTitle>
    <BcBarSeries TData="Github" ValueFunc="x=>x.Sum(y=>y.View)" Group="View"></BcBarSeries>
    <BcBarSeries TData="Github" ValueFunc="x=>x.Sum(y=>y.Start)" Group="Start"></BcBarSeries>
    <BcLineSeries TData="Github" ValueFunc="x=>x.Sum(y=>y.Fork)" Group="Fork"></BcLineSeries>
    <BcLegend TData="Github" BorderWidth="1" Position="@LegendPosition.Bottom"></BcLegend>
</BcChart>
```

```csharp
string title = "不在意现在有多糟糕，看好将来有多精彩。";

List<Github> githubs = new List<Github>()
{
    new Github(){Year=2017,View =2500,Start=800,Fork=400},
    new Github(){Year=2018,View =2200,Start=900,Fork=800},
    new Github(){Year=2019,View =2800,Start=1100,Fork=700},
    new Github(){Year=2020,View =2600,Start=1400,Fork=900},
};


public class Github
{
    public int Year { get; set; }
    public int View { get; set; }
    public int Start { get; set; }
    public int Fork { get; set; }
}
```

4. 执行查看效果

![image](https://user-images.githubusercontent.com/7581981/116768715-5b01cf80-aa6b-11eb-940f-c0a2145f9a3d.png)

