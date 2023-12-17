using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Core
{
    public class PagedList<T> : List<T>
    {
        public PagedList(IEnumerable<T>items, int count, int pageNumber, int pageSize)
        {
            currentPage = pageNumber;
            TotalPages =(int)Math.Ceiling(count / (double)pageSize);
            PageSize = pageSize;
            TotalCount = count;
            AddRange(items);
        }

        public int currentPage {  get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }

        public static async Task<PagedList<T>> CreateAsync(IQueryable<T> sources, int pageNumber, int pageSize)
        {
            var count = await sources.CountAsync();
            var items = await sources.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PagedList<T>(items, count, pageNumber, pageSize);
        }
      
    }
}
