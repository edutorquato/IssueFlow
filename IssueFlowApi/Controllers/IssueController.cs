using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IssueFlowApi.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class IssueController : ControllerBase
{
    [HttpGet]
    public IActionResult List()
    {
        return Ok(new[]
        {
            new { Id = 1, Title = "Bug login" },
            new { Id = 2, Title = "Erro pagamento" }
        });
    }
}