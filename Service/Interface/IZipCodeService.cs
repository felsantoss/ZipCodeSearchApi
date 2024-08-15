using Service.Dtos;
using Service.Model;

namespace Service.Interface
{
	public interface IZipCodeService
	{
		Task<GenericResponse<ZipCodeResponse>> GetAddress(string zipCode);
	}
}
