# SAPBlazorAnimate

Animate.css Library for Blazor

Demo : 

try demo [SAPBlazorAnimateDemo!](http://soroushasadi.com)

###### Usage
1. Add SAPBlazorAnimate To Yout Project
```
Install-Package SAPBlazorAnimate -Version 1.1.0
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
<SAPBlazorAnimate.SAPAnimate>
<h1> My Element</h1>
</SAPBlazorAnimate.SAPAnimate>
```
###### Define a refrence in @code section

```Razor
@code{

SAPAnimate element1;

}
```
###### Set Refrence to SAPAnimate and map refrence class to element

```Razor
<SAPBlazorAnimate.SAPAnimate @ref="element1"> 

<h1 class="@element1.Animator""> My Element</h1>

</SAPBlazorAnimate.SAPAnimate>
```
###### Animate element whenEver you want , with buttn click or AfterRenderAsync 

```Razor
void btn1Click()
{

element1.Animate(AnimateBook.AttentionSeekers.HeartBeat);

}
```




<hr />

### Related projects


this project used [Animate.css](https://github.com/daneden/animate.css)

