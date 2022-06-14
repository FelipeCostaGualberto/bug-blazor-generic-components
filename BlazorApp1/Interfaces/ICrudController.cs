using BlazorApp1.Models;

namespace BlazorApp1.Interfaces;

public interface ICrudController<TModel, TDto>
        where TModel : CrudEntity, new()
        where TDto : CrudEntity, new()
{
}