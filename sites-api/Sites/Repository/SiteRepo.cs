using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using sites_api.Data.Migrations;
using sites_api.Sites.Models;

namespace sites_api.Sites.Repository
{
    public class SiteRepo : ISiteRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IActionResultTypeMapper _mapper;

        private SiteRepo(AppDbContext appDbContext, IActionResultTypeMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<List<Site>> GetSiteAsync()
        {
            return await _appDbContext.Sites.ToListAsync();
        }
    }
}
