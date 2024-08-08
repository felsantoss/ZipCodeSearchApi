using Models.ZipCode;
using Service.Dtos;

namespace Service.Interface
{
	public interface IZipCodeService
	{
		Task<GenericResponse<ZipCodeResponse>> GetAddress(string zipCode);
	}
}
