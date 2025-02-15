using sites_api.Sites.Models;

namespace sites_api.Sites.Repository
{
    public interface ISiteRepo
    {
        Task<List<Site>> GetSiteAsync();
    }
}
