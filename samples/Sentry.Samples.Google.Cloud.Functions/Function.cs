﻿using System;
using Google.Cloud.Functions.Framework;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Google.Cloud.Functions.Hosting;
using Microsoft.Extensions.Logging;

[assembly: FunctionsStartup(typeof(SentryStartup))]

public class Function : IHttpFunction
{
    private readonly ILogger<Function> _logger;
    public Function(ILogger<Function> logger) => _logger = logger;

    public Task HandleAsync(HttpContext context)
    {
        _logger.LogInformation("Useful info that is added to the breadcrumb list.");
        throw new Exception("Bad function");
    }
}
