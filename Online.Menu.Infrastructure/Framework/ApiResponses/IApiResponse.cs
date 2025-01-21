using Microsoft.AspNetCore.Mvc;

namespace Online.Menu.InfraStructure.Framework.ApiResponses;

public interface IApiResponse : IActionResult
{
    List<string> Errors { get; }
    bool IsSuccess { get; set; }
    string Message { get; set; }
    int StatusCode { get; set; }
}

public interface IApiResponse<out T> : IApiResponse
{
    T Data { get; }
}
