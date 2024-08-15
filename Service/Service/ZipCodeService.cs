using AutoMapper;
using Service.Dtos;
using Service.Interface;

namespace Service.Service
{
	public class ZipCodeService : IZipCodeService
	{
		private readonly IMapper _mapper;
		private readonly IZipCodeRepository _zipCodeRepository;

		public ZipCodeService(IMapper mapper, IZipCodeRepository zipCodeRepository)
		{
			_mapper = mapper;
			_zipCodeRepository = zipCodeRepository;
		}

		public async Task<GenericResponse<ZipCodeResponse>> GetAddress(string zipCode)
		{
			var address = await _zipCodeRepository.GetAddressByZipCode(zipCode);

			return _mapper.Map<GenericResponse<ZipCodeResponse>>(address);
		}
	}
}
