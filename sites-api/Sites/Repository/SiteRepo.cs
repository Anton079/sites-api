using sites_api.Sites.Dtos;
using sites_api.Sites.Models;
using sites_api.Data.Migrations;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace sites_api.Sites.Repository
{
    public class SiteRepo : ISiteRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public SiteRepo(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<List<Site>> GetSitesAsync()
        {
            return await _appDbContext.Sites.ToListAsync();
        }

        public async Task<SiteResponse> CreateSiteAsync (SiteRequest siteReq)
        {
            Site site = _mapper.Map<Site>(siteReq);

            _appDbContext.Sites.Add(site);

            await _appDbContext.SaveChangesAsync();

            SiteResponse response = _mapper.Map<SiteResponse>(site);

            return response;
        }
    }
}
