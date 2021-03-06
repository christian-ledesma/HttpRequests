using System.Collections.Generic;

namespace WebApplication1.DTO
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; }
        public object Result { get; set; }
        public string Message { get; set; }
        public List<string> ErrorMessages { get; set; }
    }
}
