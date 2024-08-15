using Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
	public interface IZipCodeRepository
	{
		Task<GenericResponse<ZipCodeResponse>> GetAddressByZipCode(string zipCode);
	}
}
