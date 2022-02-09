using System;
using System.Collections.Generic;

namespace WebSupplier.WebApp.Models
{    
    public class PaginationViewModel<T> : IPageViewModel where T : class
    {
        public string ReferenceAction { get; set; }
        public IEnumerable<T> List { get; set; } = new List<T>();
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string Query { get; set; }
        public int TotalResult { get; set; }
        public double TotalPages => Math.Ceiling((double)TotalResult / PageSize);

    }

    public interface IPageViewModel
    {
        public string ReferenceAction { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string Query { get; set; }
        public int TotalResult { get; set; }
        public double TotalPages { get; }
    }
}
