using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProductApp.Entity.Dto
{
    public class CustomResponseDto<T>
    {
        public T Data { get; set; }

        [JsonIgnore] //json a dönüştürürken bunu yoksay //STATUS CODE ZATEN VERİYOR
        public int StatusCode { get; set; } //clientler zaten status code alıyorlar
        public List<string> Errors { get; set; }

        public static CustomResponseDto<T> Success(int statusCode, T data) //başarılıda 2 adet durum var, biri data çeviriyor ve statuscode, diğeri sadece statuscode
        {
            return new CustomResponseDto<T> { Data = data, StatusCode = statusCode };
        }
        public static CustomResponseDto<T> Success(int statusCode)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode };
        }
        public static CustomResponseDto<T> Fail(int statusCode, List<string> errors) //hatalar
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Errors = errors };
        }
        public static CustomResponseDto<T> Fail(int statusCode, string error) //hata
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Errors = new List<string> { error } };
        }
    }
}
