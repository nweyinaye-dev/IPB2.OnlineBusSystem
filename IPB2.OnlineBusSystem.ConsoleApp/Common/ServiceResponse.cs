namespace IPB2.OnlineBusSystem.ConsoleApp.Common;

public class ServiceResponse
{
    public ResponseType Status { get; set; }
    public string? Message { get; set; }

    public override string ToString()
    {
        return $"IsSuccess: {(Status == ResponseType.Success ? "Ok" : "Error")}, Message: {Message}";
    }
}
