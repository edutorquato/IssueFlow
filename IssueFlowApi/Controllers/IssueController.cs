using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class IssueController : ControllerBase
{
    private readonly JiraService _jira;

    public IssueController(JiraService jira)
    {
        _jira = jira;
    }

    [HttpGet]
    public async Task<IActionResult> List()
    {
        var issues = await _jira.GetIssues();
        return Ok(issues);
    }

    [HttpGet("test")]
    [AllowAnonymous]
    public async Task<IActionResult> Test()
    {
        var issues = await _jira.GetIssues();
        return Ok(issues);
    }
}