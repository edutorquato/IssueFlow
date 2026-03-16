using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

public class JiraService
{
	private readonly HttpClient _http;

	private const string BASE_URL = "https://eduardotorquato2013.atlassian.net";
	private const string EMAIL = "eduardotorquato2013@gmail.com";
	private const string TOKEN = Environment.GetEnvironmentVariable("JIRA_API_TOKEN") ?? "";

	public JiraService(HttpClient http)
	{
		_http = http;

		var auth = Convert.ToBase64String(
			Encoding.ASCII.GetBytes($"{EMAIL}:{TOKEN}")
			);

		_http.DefaultRequestHeaders.Authorization =
		new AuthenticationHeaderValue("Basic", auth);
	}

	public async Task<List<IssueDto>> GetIssues()
	{
		var url = $"{BASE_URL}/rest/api/3/search/jql";

		var payload = new {
			jql = "project=SCRUM",
			maxResults = 50,
			fields = new[] { "summary" }
		};

		var content = new StringContent(
			JsonSerializer.Serialize(payload),
			Encoding.UTF8,
			"application/json"
			);

		var response = await _http.PostAsync(url, content);

		response.EnsureSuccessStatusCode();

		var json = await response.Content.ReadAsStringAsync();

		Console.WriteLine(json);

		var doc = JsonDocument.Parse(json);

		var issues = new List<IssueDto>();

		foreach (var issue in doc.RootElement
			.GetProperty("issues")
			.EnumerateArray())
		{
			issues.Add(new IssueDto
			{
				Id = issue.GetProperty("key").GetString(),
				Title = issue.GetProperty("fields")
				.GetProperty("summary")
				.GetString()
			});
		}

		return issues;
	}
}

public class IssueDto
{
	public string Id { get; set; }
	public string Title { get; set; }
}