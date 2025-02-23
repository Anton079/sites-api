using sites_api.Sites.Dtos;
using sites_api.Sites.Models;
using sites_api.Sites.Repository;
using Microsoft.AspNetCore.Mvc;

namespace sites_api.Sites.SiteController
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SiteController:ControllerBase
    {
        private ISiteRepo _siteRepo;

        public SiteController(ISiteRepo siteRepo)
        {
            this._siteRepo = siteRepo;
        }

        [HttpGet("all")]

        public async Task<ActionResult<List<Site>>> GetSitesAsync()
        {
            var sites = await _siteRepo.GetSitesAsync();

            return Ok(sites);
        }
        [HttpPost("add")]

        public async Task<ActionResult<SiteResponse>> CreateAsync([FromBody] SiteRequest siteReq)
        {
            SiteResponse siteSaved = await _siteRepo.CreateSiteAsync(siteReq);

            return Ok(siteSaved);
        }
    }
}
