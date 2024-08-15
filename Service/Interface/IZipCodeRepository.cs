using Service.Dtos;
using Service.Model;

namespace Service.Interface
{
	public interface IZipCodeRepository
	{
		Task<GenericResponse<ZipCode>> GetAddressByZipCode(string zipCode);
	}
}
