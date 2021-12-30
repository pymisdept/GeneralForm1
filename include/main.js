/// <reference name="MicrosoftAjax.js"/>
function ismaxlength(t)
{
	var e=t.getAttribute?parseInt(t.getAttribute("maxlength")):"";
	t.getAttribute&&t.value.length>e&&(t.value=t.value.substring(0,e))
}

  
$(function()
{
	$(this).bind("contextmenu",function(t){t.preventDefault()})
});