using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace IssueFlowApi.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
	private readonly IConfiguration _config;

	public AuthController(IConfiguration config)
	{
		_config = config;
	}

	[HttpPost("login")]
	public IActionResult Login([FromBody] LoginRequest request)
	{

		if (request.Email != "admin@issueflow.com" || request.Password != "123456"){
			return Unauthorized();
		}

		var token = GenerateToken(request.Email);

		return Ok(new { token });

	}

	[HttpPost("logout")]
	public IActionResult Logout()
	{
		return Ok(new { message = "Logout realizado" });
	}

	private string GenerateToken(string email)
	{
		var key = Encoding.ASCII.GetBytes(_config["Jwt:Key"]!);

		var claims = new[]
		{
			new Claim(ClaimTypes.Email, email)
		};

		var token = new JwtSecurityToken(
			issuer: _config["Jwt:Issuer"],
			audience: _config["Jwt:Audience"],
			claims: claims,
			expires: DateTime.UtcNow.AddHours(2),
			signingCredentials: new SigningCredentials(
				new SymmetricSecurityKey(key),
				SecurityAlgorithms.HmacSha256Signature
				)
			);

		return new JwtSecurityTokenHandler().WriteToken(token);
	}
}

public class LoginRequest
{
	public string Email { get; set; } = string.Empty;
	public string Password { get; set; } = string.Empty;
}