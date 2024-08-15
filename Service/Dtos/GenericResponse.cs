using System.Dynamic;
using System.Net;

namespace Service.Dtos
{
	public class GenericResponse<T> where T : class
	{
		public HttpStatusCode StatusCode { get; set; }
		public T? Value { get; set; }
		public ExpandoObject? ReturnError { get; set; }
	}
}
