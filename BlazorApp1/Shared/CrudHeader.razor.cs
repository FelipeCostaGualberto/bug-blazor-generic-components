using BlazorApp1.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Shared;

public partial class CrudHeader<TModel, TDto> : ComponentBase
    where TModel : CrudEntity, new()
    where TDto : CrudEntity, new()
{
    [Parameter] public string Text { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
}