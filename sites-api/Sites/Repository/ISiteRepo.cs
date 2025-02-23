using sites_api.Sites.Dtos;
using sites_api.Sites.Models;

namespace sites_api.Sites.Repository
{
    public interface ISiteRepo
    {
        Task<List<Site>> GetSitesAsync();

        Task<SiteResponse> CreateSiteAsync(SiteRequest siteReq);
    }
}
