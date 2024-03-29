using API.Contracts.Views;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class BaseController : ControllerBase
{
    public ObjectResult ToWithStatus<T>(T? result) where T : BaseResponseView
    {
        return StatusCode((int)result!.StatusCode, result);
    }
}