using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Staj.Core.Dtos
{
    public class CustomResponceDto<T>
    {
        public T Data { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }

        public List<String> Errors { get; set; }

        public static CustomResponceDto<T> Success(int statusCode,T data)
        {
            return new CustomResponceDto<T> { StatusCode = statusCode, Data = data};
        }
        
        public static CustomResponceDto<T> Success(int statusCode)
        {
            return new CustomResponceDto<T> { StatusCode = statusCode};
        }
        
        public static CustomResponceDto<T> Fail(int statusCode, List<string> errors)
        {
            return new CustomResponceDto<T> { StatusCode = statusCode, Errors = errors};
        }

        public static CustomResponceDto<T> Fail(int statusCode, string errors)
        {
            return new CustomResponceDto<T> { StatusCode = statusCode, Errors = new List<string> { errors } };
        }

    }
}
