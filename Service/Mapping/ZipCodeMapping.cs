using AutoMapper;
using Service.Dtos;
using Service.Model;

namespace Service.Mapping
{
	public class ZipCodeMapping : Profile
	{
        public ZipCodeMapping()
        {
            CreateMap(typeof(GenericResponse<>), typeof(GenericResponse<>));
            CreateMap<ZipCodeResponse, ZipCode>();
            CreateMap<ZipCode, ZipCodeResponse>();
        }
    }
}
