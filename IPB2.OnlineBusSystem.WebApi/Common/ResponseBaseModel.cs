namespace IPB2.OnlineBusSystem.WebApi.Common;

public class ResponseBaseModel
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; } = null!;
}
