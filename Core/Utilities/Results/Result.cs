using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success)
        {
            Success = success;
        }
        // normalde kullanım tarafında metodlar overload edilir ve diğer metodlar kullanılmaz
        //ama burada this içerisinde bulunduğumuz classı temsil eder burada 2 parametreli metoda this dediğimizde
        //bu diğer metodları işaret eder ve buraya geçilen succcessi oraya da gönder dedik yani artık her türlü 
        // diğer leri de set edilecektir.
        public Result(bool success, string message) : this(success)
        {
            Message = message;
            Success = success;
        }
        

        public bool Success { get; }

        public string Message { get; }
    }
}
