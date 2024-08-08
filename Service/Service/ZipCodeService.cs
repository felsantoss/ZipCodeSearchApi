using AutoMapper;
using Models.ZipCode;
using Service.Dtos;
using Service.Interface;

namespace Service.Service
{
	public class ZipCodeService : IZipCodeService
	{
		private readonly IMapper _mapper;
		private readonly IZipCodeService _zipCodeService;

		public ZipCodeService(IMapper mapper, IZipCodeService zipCodeService)
		{
			_mapper = mapper;
			_zipCodeService = zipCodeService;
		}

		public async Task<GenericResponse<ZipCodeResponse>> GetAddress(string zipCode)
		{
			var address = await _zipCodeService.GetAddress(zipCode);

			return _mapper.Map<GenericResponse<ZipCodeResponse>>(address);
		}
	}
}
