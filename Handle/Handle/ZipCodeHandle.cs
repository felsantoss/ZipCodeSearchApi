using Models.ZipCode;
using Service.Dtos;
using Service.Interface;
using System.Dynamic;
using System.Runtime.ConstrainedExecution;
using System.Text.Json;

namespace Handle.Handle
{
	public class ZipCodeHandle : IZipCodeService
	{
		public async Task<GenericResponse<ZipCodeResponse>> GetAddress(string zipCode)
		{
			var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{zipCode}");

			var response = new GenericResponse<ZipCodeResponse>();

			using (var client = new HttpClient())
			{
				var responseZipCode = await client.SendAsync(request);

				var contentResponse = await responseZipCode.Content.ReadAsStreamAsync();

				var objectResponse = JsonSerializer.Deserialize<ZipCodeResponse>(contentResponse);

				if (responseZipCode.IsSuccessStatusCode)
				{
					response.StatusCode = responseZipCode.StatusCode;

					response.DataReturn = objectResponse;
				}
				else
				{
					response.StatusCode = responseZipCode.StatusCode;

					response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
				}
			}

			return response;
		}
	}
}
