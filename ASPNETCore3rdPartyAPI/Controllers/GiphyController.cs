using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Giphy.Libs.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore3rdPartyAPI.Controllers
{
    public class GiphyController : ControllerBase
    {
        private readonly IGiphyService _giphyService;

        public GiphyController(IGiphyService giphyService)
        {
            _giphyService = giphyService;
        }

        [HttpGet]
        [Route("v1/giphy/random/{searchCritera}")]
        public async Task<IActionResult> GetRandomGif(string searchCritera)
        {
            var result = await _giphyService.GetRandomGifBasedOnSearchCritera(searchCritera);
            return Ok(result);
        }
    }
}