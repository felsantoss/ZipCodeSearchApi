using System.Net;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace Api.Controllers
{
	[ApiController]
	[Route("api/v1/[controller]")]
	public class ZipCodeController : ControllerBase
	{
		public readonly IZipCodeService _zipCodeService;

		public ZipCodeController(IZipCodeService zipCodeService)
		{
			_zipCodeService = zipCodeService;
		}

		[HttpGet("get/{zipCode}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> GetAddress([FromRoute] string zipCode)
		{
			var response = await _zipCodeService.GetAddress(zipCode);

			if (response.StatusCode == HttpStatusCode.OK)
			{
				return Ok(response.Value);
			}
			else
			{
				return StatusCode((int)response.StatusCode, response.ReturnError);
			}
		}
	}
}
