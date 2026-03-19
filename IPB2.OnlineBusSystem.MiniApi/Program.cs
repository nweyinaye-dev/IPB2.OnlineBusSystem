using IPB2.OnlineBusSystem.WebApi.Common;
using IPB2.OnlineBusSystem.WebApi.Features.Admin.Bus;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
# region bus controller
var busApi = app.MapGroup("/api/bus").WithTags("Bus Endpoints");

// GET: /api/teachers/{pageNo}/{pageSize}
//busApi.MapGet("/{pageNo:int}/{pageSize:int}", async (int pageNo, int pageSize,BusService _busService) =>
//{
//    if (pageNo < 0) return Results.BadRequest(new ResponseBaseModel { IsSuccess = false, Message = "Invalid page number." });
//    if (pageSize < 0) return Results.BadRequest(new ResponseBaseModel { IsSuccess = false, Message = "Invalid page size." });

//    var result = await _busService.GetBusAsync(pageNo, pageSize);
//    string message = result.Buss.Count > 0 ? "Get all Bus successfully." : "No data.";

//    return Results.Ok(new GetAllTeacherResponse
//    {
//        IsSuccess = true,
//        Message = message,
//        data = result
//    });
//});
# endregion

app.Run();

