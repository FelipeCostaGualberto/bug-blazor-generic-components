using BlazorApp1.Models;

namespace BlazorApp1.Interfaces;

public interface IKpiController<TModel, TDto> : ICrudController<TModel, TDto>
        where TModel : CrudEntity, new()
        where TDto : CrudEntity, new()
{
}