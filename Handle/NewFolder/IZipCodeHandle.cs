using Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handle.NewFolder
{
	public interface IZipCodeHandle
	{
		Task<GenericResponse<ZipCodeResponse>> GetAddress(string zipCode);
	}
}
