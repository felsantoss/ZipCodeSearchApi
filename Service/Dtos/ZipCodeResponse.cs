using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Service.Dtos
{
	public class ZipCodeResponse
	{
		public string Cep { get; set; } = string.Empty;

		public string State { get; set; } = string.Empty;

		public string City { get; set; } = string.Empty;

		public string Neighborhood { get; set; } = string.Empty;

		public string Street { get; set; } = string.Empty;

		[JsonIgnore]
		public string Service { get; set; } = string.Empty;
	}
}
