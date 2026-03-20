using IPB2.OnlineBusSystem.WebApi.Common;
using IPB2.OnlineBusSystem.WebApi.Features.Admin.Bus;
using IPB2.OnlineBusSystem.WebApi.Features.Admin.Route;
using IPB2.OnlineScheduleSystem.WebApi.Features.Admin.Schedule;
using IPB2.OnlineBusSystem.WebApi.Features.Report;
using IPB2.OnlineBusSystem.WebApi.Features.User;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register Services
builder.Services.AddScoped<BusService>();
builder.Services.AddScoped<RouteService>();
builder.Services.AddScoped<ScheduleService>();
builder.Services.AddScoped<BookingReportService>();
builder.Services.AddScoped<BookingService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

#region Bus Endpoints
var busApi = app.MapGroup("/api/bus").WithTags("Bus");

busApi.MapGet("/", async (int pageNo, int pageSize, BusService service) =>
{
    var response = await service.GetBusAsync(pageNo, pageSize);
    return Results.Ok(response);
});

busApi.MapGet("/search", async (string str, BusService service) =>
{
    var response = await service.GetBusesBySearchAsync(str);
    return response == null 
        ? Results.NotFound(new ResponseBaseModel { IsSuccess = false, Message = "Bus not found." }) 
        : Results.Ok(response);
});

busApi.MapGet("/{id}", async (string id, BusService service) =>
{
    var response = await service.GetBusByIdAsync(id);
    return response == null 
        ? Results.NotFound(new ResponseBaseModel { IsSuccess = false, Message = "Bus not found." }) 
        : Results.Ok(response);
});

busApi.MapPost("/", async (UpsertBusRequest request, BusService service) =>
{
    var validationRes = ValidateBus(request);
    if (!validationRes.IsSuccess) return Results.BadRequest(validationRes);

    var response = await service.CreateAsync(request);
    return Results.Ok(response);
});

busApi.MapPut("/{id}", async (string id, UpsertBusRequest request, BusService service) =>
{
    var validationRes = ValidateBus(request);
    if (!validationRes.IsSuccess) return Results.BadRequest(validationRes);

    var response = await service.UpsertAsync(request, id);
    return Results.Ok(response);
});

busApi.MapPatch("/{id}", async (string id, UpdateBusRequest request, BusService service) =>
{
    var response = await service.UpdateAsync(request, id);
    return Results.Ok(response);
});

busApi.MapDelete("/{id}", async (string id, BusService service) =>
{
    var response = await service.DeleteAsync(id);
    return Results.Ok(response);
});

ResponseBaseModel ValidateBus(UpsertBusRequest request)
{
    if (string.IsNullOrWhiteSpace(request.BusName)) return new ResponseBaseModel { IsSuccess = false, Message = "BusName is required." };
    if (string.IsNullOrWhiteSpace(request.BusNo)) return new ResponseBaseModel { IsSuccess = false, Message = "BusNo is required." };
    if (string.IsNullOrWhiteSpace(request.BusType)) return new ResponseBaseModel { IsSuccess = false, Message = "BusType is required." };
    if (request.TotalSeat < 20) return new ResponseBaseModel { IsSuccess = false, Message = "Total Seat must be at leave 20 seats." };
    return new ResponseBaseModel { IsSuccess = true };
}
#endregion

#region Route Endpoints
var routeApi = app.MapGroup("/api/routes").WithTags("Route");

routeApi.MapGet("/", async (int pageNo, int pageSize, RouteService service) =>
{
    var response = await service.GetRoutesAsync(pageNo, pageSize);
    return Results.Ok(response);
});

routeApi.MapGet("/{id}", async (string id, RouteService service) =>
{
    var response = await service.GetRouteByIdAsync(id);
    return response == null 
        ? Results.NotFound(new ResponseBaseModel { IsSuccess = false, Message = "Route not found." }) 
        : Results.Ok(response);
});

routeApi.MapPost("/", async (UpsertRouteRequest request, RouteService service) =>
{
    var validationRes = ValidateRoute(request);
    if (!validationRes.IsSuccess) return Results.BadRequest(validationRes);

    var response = await service.CreateAsync(request);
    return Results.Ok(response);
});

routeApi.MapPut("/{id}", async (string id, UpsertRouteRequest request, RouteService service) =>
{
    var validationRes = ValidateRoute(request);
    if (!validationRes.IsSuccess) return Results.BadRequest(validationRes);

    var response = await service.UpsertAsync(request, id);
    return Results.Ok(response);
});

routeApi.MapPatch("/{id}", async (string id, UpdateRouteRequest request, RouteService service) =>
{
    var response = await service.UpdateAsync(request, id);
    return Results.Ok(response);
});

routeApi.MapDelete("/{id}", async (string id, RouteService service) =>
{
    var response = await service.DeleteAsync(id);
    return Results.Ok(response);
});

ResponseBaseModel ValidateRoute(UpsertRouteRequest request)
{
    if (string.IsNullOrWhiteSpace(request.RouteName)) return new ResponseBaseModel { IsSuccess = false, Message = "Route name is required." };
    if (string.IsNullOrWhiteSpace(request.Origin)) return new ResponseBaseModel { IsSuccess = false, Message = "Origin no is required." };
    if (string.IsNullOrWhiteSpace(request.Destination)) return new ResponseBaseModel { IsSuccess = false, Message = "Destination is required." };
    return new ResponseBaseModel { IsSuccess = true };
}
#endregion

#region Schedule Endpoints
var scheduleApi = app.MapGroup("/api/schedules").WithTags("Schedule");

scheduleApi.MapGet("/", async (int pageNo, int pageSize, ScheduleService service) =>
{
    var response = await service.GetScheduleAsync(pageNo, pageSize);
    return Results.Ok(response);
});

scheduleApi.MapGet("/{id}", async (string id, ScheduleService service) =>
{
    var response = await service.GetScheduleByIdAsync(id);
    return response == null 
        ? Results.NotFound(new ResponseBaseModel { IsSuccess = false, Message = "Schedule not found." }) 
        : Results.Ok(response);
});

scheduleApi.MapPost("/", async (UpsertScheduleRequest request, ScheduleService service) =>
{
    var validationRes = ValidateSchedule(request);
    if (!validationRes.IsSuccess) return Results.BadRequest(validationRes);

    var response = await service.CreateAsync(request);
    return Results.Ok(response);
});

scheduleApi.MapPut("/{id}", async (string id, UpsertScheduleRequest request, ScheduleService service) =>
{
    var validationRes = ValidateSchedule(request);
    if (!validationRes.IsSuccess) return Results.BadRequest(validationRes);

    var response = await service.UpsertAsync(request, id);
    return Results.Ok(response);
});

scheduleApi.MapPatch("/{id}", async (string id, UpdateScheduleRequest request, ScheduleService service) =>
{
    var response = await service.UpdateAsync(request, id);
    return Results.Ok(response);
});

scheduleApi.MapDelete("/{id}", async (string id, ScheduleService service) =>
{
    var response = await service.DeleteAsync(id);
    return Results.Ok(response);
});

ResponseBaseModel ValidateSchedule(UpsertScheduleRequest request)
{
    if (string.IsNullOrWhiteSpace(request.BusId)) return new ResponseBaseModel { IsSuccess = false, Message = "BusId is required." };
    if (request.Fare == 0) return new ResponseBaseModel { IsSuccess = false, Message = "Fare is required." };
    if (string.IsNullOrWhiteSpace(request.ArrivalTime)) return new ResponseBaseModel { IsSuccess = false, Message = "ArrivalTime is required." };
    if (string.IsNullOrWhiteSpace(request.DepartureTime)) return new ResponseBaseModel { IsSuccess = false, Message = "DepartureTime is required." };
    if (string.IsNullOrWhiteSpace(request.RouteId)) return new ResponseBaseModel { IsSuccess = false, Message = "RouteId is required." };
    return new ResponseBaseModel { IsSuccess = true };
}
#endregion

#region Booking Endpoints
app.MapGet("/api/booking", async (BookingReportService service) =>
{
    var response = await service.GetBookingDetailAsync("");
    return Results.Ok(response);
}).WithTags("Booking Report");

app.MapPost("/search", async (SearchBusRequest request, BookingService service) =>
{
    if (string.IsNullOrWhiteSpace(request.Origin)) return Results.BadRequest(new ResponseBaseModel { IsSuccess = false, Message = "Origin is required." });
    if (string.IsNullOrWhiteSpace(request.Destination)) return Results.BadRequest(new ResponseBaseModel { IsSuccess = false, Message = "Destination is required." });

    var response = await service.SearchBus(request);
    return Results.Ok(response);
}).WithTags("User Booking");

app.MapPost("/book", async (BookRequest request, BookingService service) =>
{
    if (string.IsNullOrWhiteSpace(request.ScheduleId)) return Results.BadRequest(new ResponseBaseModel { IsSuccess = false, Message = "Schedule Id is required." });
    if (request.Passengers == null || !request.Passengers.Any()) return Results.BadRequest(new ResponseBaseModel { IsSuccess = false, Message = "No passengers provided." });
    if (request.Passengers.Any(p => p.SeatNo <= 0 || string.IsNullOrWhiteSpace(p.Username) || string.IsNullOrWhiteSpace(p.Phoneno)))
        return Results.BadRequest(new ResponseBaseModel { IsSuccess = false, Message = "Passenger details (Seat, Name, Phone) are required." });

    var response = await service.CreateAsync(request);
    return Results.Ok(response);
}).WithTags("User Booking");
#endregion

app.Run();

