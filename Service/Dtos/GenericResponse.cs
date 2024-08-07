using System.Dynamic;
using System.Net;

namespace Service.Dtos
{
	public class GenericResponse<T> where T : class
	{
		public HttpStatusCode StatusCode { get; set; }
		public T? DataReturn { get; set; }
		public ExpandoObject? ErrorReturn { get; set; }
	}
}
