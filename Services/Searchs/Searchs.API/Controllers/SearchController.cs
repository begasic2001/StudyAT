using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Entities;
using Searchs.API.Models;

namespace Searchs.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Item>>> SearchItems(string searchParams)
        {
            var query = DB.Find<Item>();
            query.Sort(x => x.Ascending(a => a.Make));
            if(!string.IsNullOrEmpty(searchParams))
            {
                query.Match(Search.Full, searchParams).SortByTextScore();
            }
            var res = await query.ExecuteAsync();
            return res;

            //if (!string.IsNullOrEmpty(searchParams.SearchTerm))
            //{
            //    query.Match(Search.Full, searchParams.SearchTerm).SortByTextScore();
            //}

            //query = searchParams.OrderBy switch
            //{
            //    "make" => query.Sort(x => x.Ascending(a => a.Make))
            //        .Sort(x => x.Ascending(a => a.Model)),
            //    "new" => query.Sort(x => x.Descending(a => a.CreatedAt)),
            //    _ => query.Sort(x => x.Ascending(a => a.AuctionEnd))
            //};

            //query = searchParams.FilterBy switch
            //{
            //    "finished" => query.Match(x => x.AuctionEnd < DateTime.UtcNow),
            //    "endingSoon" => query.Match(x => x.AuctionEnd < DateTime.UtcNow.AddHours(6)
            //        && x.AuctionEnd > DateTime.UtcNow),
            //    _ => query.Match(x => x.AuctionEnd > DateTime.UtcNow)
            //};

            //if (!string.IsNullOrEmpty(searchParams.Seller))
            //{
            //    query.Match(x => x.Seller == searchParams.Seller);
            //}

            //if (!string.IsNullOrEmpty(searchParams.Winner))
            //{
            //    query.Match(x => x.Winner == searchParams.Winner);
            //}

            //query.PageNumber(searchParams.PageNumber);
            //query.PageSize(searchParams.PageSize);

            //var result = await query.ExecuteAsync();

            //return Ok(new
            //{
            //    results = result.Results,
            //    pageCount = result.PageCount,
            //    totalCount = result.TotalCount
            //});
        }
    }
}
