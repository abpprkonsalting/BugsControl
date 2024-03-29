using System.Net;

namespace API.Contracts.Views;

/// <summary>
/// Basic data response sent by server to the client
/// </summary>
public class BaseResponseView
{
    /// <summary>
    /// creates a fail response with some message
    /// </summary>
    /// <param name="msg"></param>
    /// <returns></returns>
    public static T Fail<T>(string msg) where T : BaseResponseView, new()
    {
        return new T
        {
            Success = false,
            Message = msg
        };
    }

    /// <summary>
    /// creates a fail response from some exception data
    /// </summary>
    /// <param name="e"></param>
    /// <returns></returns>
    public static T Fail<T>(Exception e)  where T : BaseResponseView, new() =>
        Fail<T>(e.Message);

    /// <summary>
    /// creates a fail response with some message, it returns any previous data
    /// set in the response
    /// </summary>
    /// <param name="msg"></param>
    /// <returns></returns>
    public T ToFail<T>(string msg, 
                        HttpStatusCode statusCode = HttpStatusCode.InternalServerError) where T : BaseResponseView, new()
    {
        Success = false;
        Message = msg;
        Errors.Add(msg);
        StatusCode = statusCode;
        return new T
        {
            Success = false,
            Message = msg,
            Errors = Errors,
            StatusCode = statusCode
        };
    }

    /// <summary>
    /// creates a fail response from some exception data, it returns any previous data
    /// set in the response
    /// </summary>
    /// <param name="e"></param>
    /// <returns></returns>
    public T ToFail<T>(Exception e, 
                        HttpStatusCode statusCode = HttpStatusCode.InternalServerError) where T: BaseResponseView, new() =>
        ToFail<T>(e.Message,statusCode);
    
    /// <summary>
    /// get/set the request status
    /// </summary>
    public bool Success { get; set; } = true;

    /// <summary>
    /// <see cref="HttpStatusCode"/> of the result of the operation to add some
    /// descriptive data in cases that the request execution went wrong
    /// </summary>
    public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;

    /// <summary>
    /// message sent from server, in some cases it could be used to confirm an operation
    /// or as a simple notification message
    /// </summary>
    public string Message { get; set; } = "";

    /// <summary>
    /// List of error messages in the execution if any
    /// </summary>
    public List<string> Errors { get; set; } = new();
}