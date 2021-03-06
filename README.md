# SAPBlazorAnimate

Animate.css Library for Blazor

Demo : 

[![Demo CountPages alpha](https://raw.githubusercontent.com/codesoroush/SAPBlazorAnimate/master/SAPBlazorAnimateDemo/wwwroot/demo/demo.gif)](https://raw.githubusercontent.com/codesoroush/SAPBlazorAnimate/master/SAPBlazorAnimateDemo/wwwroot/demo/demo.gif)

###### Usage
1. Add SAPBlazorAnimate To Your Project
```
PM> Install-Package SAPBlazorAnimate -Version 1.2.6
```
2. Include relevant stylesheet either in your _host.cshtml (server-side blazor) or index.html (client-side blazor)
```
<link href="_content/SAPBlazorAnimate/animate.min.css" rel="stylesheet" />
```
3. Add This Line in _imports.razor
```
@using SAPBlazorAnimate
```
<hr />

###### Make elements animatable:

```Razor
<SAPAnimate>
<h1> My Element</h1>
</SAPAnimate>
```
###### Define a refrence in @code section

```Razor
@code{

SAPAnimate element1;

}
```
###### Set Refrence to SAPAnimate and map refrence class to element

```Razor

<SAPAnimate @ref="element1" > 

<h1 class="@element1.Animator"> My Element</h1>

</SAPAnimate>
```
###### Animate element whenever you want , with buttn click or AfterRenderAsync 

```Razor
void btn1Click()
{

element1.Animate(AnimateBook.AttentionSeekers.HeartBeat);

}
```


###### Control Start Animation Speed With This Modes : Fast , Faster , Slow , Slower
```Razor
void btn1Click()
{

element1.Animate(AnimateBook.AttentionSeekers.HeartBeat.Faster());

}
```


###### Direct Use For Elements On after page render (sample)

```Razor
<h1 class="@AnimateBook.Flippers.Flip"> Hello World</h1>
```

OR with slow speed

```Razor
<h1 class="@AnimateBook.Flippers.Flip.Slow()"> Hello World</h1>
```

<hr />

### License


Copyright (c) 2020 Soroush Asadi [MIT](https://github.com/codesoroush/SAPBlazorAnimate/blob/master/LICENSE) License



### Related projects


this project used [Animate.css](https://github.com/daneden/animate.css)

