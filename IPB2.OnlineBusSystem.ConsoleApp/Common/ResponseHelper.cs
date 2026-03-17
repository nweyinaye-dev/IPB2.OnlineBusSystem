

namespace IPB2.OnlineBusSystem.ConsoleApp.Common;

public class ResponseHelper
{
    //public static IActionResult ConvertResponseType(ServiceResponse status)
    //{
    //    switch (status.Status)
    //    {
    //        case ResponseType.NotFound:
    //            return new Microsoft.AspNetCore.Mvc.NotFoundObjectResult(
    //            new ResponseBaseModel { IsSuccess = false, Message = status.Message ?? "Resource not found." });
    //        case ResponseType.AlreadyDeleted:
    //            return new Microsoft.AspNetCore.Mvc.OkObjectResult(
    //             new ResponseBaseModel { IsSuccess = false, Message = status.Message ?? "Resource already deleted." });
    //        case ResponseType.AlreadyExists:
    //            return new Microsoft.AspNetCore.Mvc.ConflictObjectResult(
    //            new ResponseBaseModel { IsSuccess = false, Message = status.Message ?? "Resource already exists." });
    //        case ResponseType.None:
    //            return new Microsoft.AspNetCore.Mvc.OkObjectResult(
    //            new ResponseBaseModel { IsSuccess = false, Message = status.Message ?? "Failed. No rows were affected." });
    //        case ResponseType.Success:
    //            return new Microsoft.AspNetCore.Mvc.OkObjectResult(
    //            new ResponseBaseModel { IsSuccess = true, Message = status.Message ?? "Process done successfully." });
    //        default:
    //            return new Microsoft.AspNetCore.Mvc.ObjectResult(
    //             new ResponseBaseModel { IsSuccess = false, Message = status.Message ?? "Unexpected error." })
    //            {
    //                StatusCode = 500
    //            };
    //    }
    //}
}
