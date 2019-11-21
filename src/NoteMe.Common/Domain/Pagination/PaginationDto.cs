using System.Collections.Generic;

namespace NoteMe.Common.Domain.Pagination
{
    public class PaginationDto<TModel>
    {
        public ICollection<TModel> Data { get; set; } = new List<TModel>();
        public int TotalCount { get; set; }
    }
}