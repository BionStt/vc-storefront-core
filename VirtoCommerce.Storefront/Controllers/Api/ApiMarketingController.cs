using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VirtoCommerce.Storefront.Infrastructure;
using VirtoCommerce.Storefront.Model;
using VirtoCommerce.Storefront.Model.Common;
using VirtoCommerce.Storefront.Model.Services;

namespace VirtoCommerce.Storefront.Controllers.Api
{
    [StorefrontApiRoute("marketing")]
    public class ApiMarketingController : StorefrontControllerBase
    {
        private readonly IMarketingService _marketingService;
        public ApiMarketingController(IWorkContextAccessor workContextAccessor, IStorefrontUrlBuilder urlBuilder, IMarketingService marketingService)
            : base(workContextAccessor, urlBuilder)
        {
            _marketingService = marketingService;
        }

        // GET: storefrontapi/marketing/dynamiccontent/{placeName}
        [HttpGet("dynamiccontent/{placeName}")]
        public async Task<ActionResult<string>> GetDynamicContent(string placeName)
        {
            var htmlContent = await _marketingService.GetDynamicContentHtmlAsync(WorkContext.CurrentStore.Id, placeName);

            return htmlContent;
        }
    }
}
