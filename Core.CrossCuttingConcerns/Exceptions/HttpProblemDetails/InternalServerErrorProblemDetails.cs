﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;

public class InternalServerErrorProblemDetails : ProblemDetails
{
    public InternalServerErrorProblemDetails(string details)
    {
        Title = "Internal Error";
        Detail = "Internal Error";
        Status = StatusCodes.Status400BadRequest;
        Type = "https://example.com/probs/business";
    }
}

