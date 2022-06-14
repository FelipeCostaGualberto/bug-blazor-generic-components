using BlazorApp1.Interfaces;
using BlazorApp1.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorApp1.Pages;

[CascadingTypeParameter(nameof(TModel))]
[CascadingTypeParameter(nameof(TDto))]
[CascadingTypeParameter(nameof(TController))]
public partial class CrudContainer<TModel, TDto, TController> : ComponentBase
    where TModel : CrudEntity, new()
    where TDto : CrudEntity, new()
    where TController : ICrudController<TModel, TDto>
{
    [Parameter] public RenderFragment ChildContent { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        base.BuildRenderTree(builder);
        builder.AddContent(0, ChildContent);
    }
}