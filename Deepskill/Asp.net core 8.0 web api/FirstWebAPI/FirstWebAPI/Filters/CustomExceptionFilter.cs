using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FirstWebAPI.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "errorlog.txt");

            string errorMessage = $"Time: {DateTime.Now}\nError: {context.Exception.Message}\n\n";

            File.AppendAllText(filePath, errorMessage);

            context.Result = new ObjectResult("Internal Server Error occurred. Please check errorlog.txt")
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };

            context.ExceptionHandled = true;
        }
    }
}