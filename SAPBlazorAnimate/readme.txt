1.Include relevant stylesheet either in your _host.cshtml (server-side blazor) or index.html (client-side blazor) :

<link href="_content/SAPBlazorAnimate/animate.min.css" rel="stylesheet" />



2.Add This Line in _imports.razor :

@using SAPBlazorAnimate


3.Make elements animatable :

<SAPAnimate>
<h1> My Element</h1>
</SAPAnimate>


4.Define a refrence in @code section : 

@code{

SAPAnimate element1;

}


5.Set Refrence to SAPAnimate and map refrence class to element(add Animator to element class) :

<SAPAnimate @ref="element1" > 

<h1 class="@element1.Animator"> My Element</h1>

</SAPAnimate>


6.Animate element whenEver you want , with buttn click or AfterRenderAsync :


void btn1Click()
{

element1.Animate(AnimateBook.AttentionSeekers.HeartBeat);

}


----------------------------------

Direct Use For Elements On afetr page render (sample)

<h1 class="@AnimateBook.Flippers.Flip"> Hello World</h1>

More Info At


https://github.com/codesoroush/SAPBlazorAnimate





