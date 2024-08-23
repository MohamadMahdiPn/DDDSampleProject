using System.Net;
using System.Text.Json;
using DDDSampleProject.Abstraction.Exceptions;
using Microsoft.AspNetCore.Http;

namespace DDDSampleProject.Shared.Exceptions;

public class ExceptionMiddleware:IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
           await next(context);
        }
        catch (Exception ex)
        {
            await HandleException(context, ex);
        }
    }

    private static Task HandleException(HttpContext context, Exception ex)
    {
        HttpStatusCode statusCode = HttpStatusCode.InternalServerError;
        switch (ex)
        {
            case UserManagementException:
            case CourseManagementException:
            case PaymentManagementException:
                statusCode = HttpStatusCode.BadRequest;
                break;
        }
        var errorCode = ToUnderScoreCase(ex.GetType().Name.Replace("Exception", string.Empty));
        var jsonContent = JsonSerializer.Serialize(new { ErrorCode = errorCode, ex.Message });

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)statusCode;
        return  context.Response.WriteAsync(jsonContent);

    }

    private static string ToUnderScoreCase(string value)
    {
        return string
            .Concat((value ?? String.Empty).Select((x, i) =>
                i > 0 && char.IsUpper(value[i - 1]) ? $"_{x}" : x.ToString())).ToLower();
    }
}