﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Gateway.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SandwichController : ControllerBase
  {
    readonly Services.ISandwichRequestor _requestor;

    public SandwichController(Services.ISandwichRequestor requestor)
    {
      _requestor = requestor;
    }

    [HttpGet]
    public string OnGet()
    {
      return "I am running; use PUT to make a sandwich";
    }

    [HttpPut]
    public async Task<Messages.SandwichResponse> OnPut(Messages.SandwichRequest request)
    {
      return await _requestor.RequestSandwich(request);
    }
  }
}