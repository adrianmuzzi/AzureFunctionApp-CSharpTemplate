using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace AzureFunctionApp_CSharpTemplate;

public class HttpTrigger_Prototype
{
    private readonly ILogger<HttpTrigger_Prototype> _logger;

    public HttpTrigger_Prototype(ILogger<HttpTrigger_Prototype> logger)
    {
        _logger = logger;
    }

    [Function("HttpTrigger_Prototype")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Admin, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}