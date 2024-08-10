using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using System.Net;

namespace Api.Controllers
{
	[ApiController]
	[Route("api/v1/[controller]")]
	public class ZipCodeController : ControllerBase
	{
		private readonly IZipCodeService _zipCodeService;

		public ZipCodeController(IZipCodeService zipCodeService)
		{
			_zipCodeService = zipCodeService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAddress([FromRoute] string zipCode)
		{
			var response = await _zipCodeService.GetAddress(zipCode);

			if (response.StatusCode == HttpStatusCode.OK) 
			{
				return Ok(response.DataReturn);
			}
			else
			{
				return StatusCode((int)response.StatusCode, response.ErrorReturn);
			}
		}
	}
}
