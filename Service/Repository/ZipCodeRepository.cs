using Service.Dtos;
using Service.Interface;
using Service.Model;
using System.Dynamic;
using System.Runtime.ConstrainedExecution;
using System.Text.Json;

namespace Service.Repository
{
	public class ZipCodeRepository : IZipCodeRepository
	{
		public async Task<GenericResponse<ZipCode>> GetAddressByZipCode(string zipCode)
		{
			var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{zipCode}");

			var response = new GenericResponse<ZipCode>();

			using (var client = new HttpClient())
			{
				var responseZipCode = await client.SendAsync(request);

				var contentResponse = await responseZipCode.Content.ReadAsStringAsync();

				var objectResponse = JsonSerializer.Deserialize<ZipCode>(contentResponse);

				if (responseZipCode.IsSuccessStatusCode)
				{
					response.StatusCode = responseZipCode.StatusCode;

					response.Value = objectResponse;
				}
				else
				{
					response.StatusCode = responseZipCode.StatusCode;

					response.ReturnError = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
				}
			}
			return response;
		}
	}
}
