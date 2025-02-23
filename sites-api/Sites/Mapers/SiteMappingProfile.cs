using AutoMapper;
using sites_api.Sites.Dtos;
using sites_api.Sites.Models;


namespace sites_api.Sites.Mapers
{
    public class SiteMappingProfile:Profile
    {
        public SiteMappingProfile()
        {
            CreateMap<SiteRequest, Site>();
            CreateMap<Site, SiteResponse>();
        }
    }
}
