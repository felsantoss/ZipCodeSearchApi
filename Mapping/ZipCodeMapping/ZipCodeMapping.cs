using AutoMapper;
using Models.ZipCode;
using Service.Dtos;

namespace Mapping.ZipCodeMapping
{
	public class ZipCodeMapping : Profile
	{
		public ZipCodeMapping() 
		{
			CreateMap(typeof(GenericResponse<>), typeof(GenericResponse<>));
			CreateMap<ZipCodeResponse, ZipCode>();
		}
	}
}
