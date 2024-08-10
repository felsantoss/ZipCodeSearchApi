using AutoMapper;
using Models.ZipCode;
using Service.Dtos;

namespace Service.Mapping
{
	public class ZipCodeMapping : Profile
	{
		public ZipCodeMapping()
		{
			CreateMap(typeof(GenericResponse<>), typeof(GenericResponse<>));
			CreateMap<ZipCode, ZipCodeResponse>();
		}
	}
}
