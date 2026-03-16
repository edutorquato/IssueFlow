using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

public class JiraService
{
    private readonly HttpClient _http;
    private readonly string _token;

    private const string BASE_URL = "https://eduardotorquato2013.atlassian.net";
    private const string EMAIL = "eduardotorquato2013@gmail.com";

    public JiraService(HttpClient http)
    {
        _http = http;
        _token = Environment.GetEnvironmentVariable("JIRA_API_TOKEN") ?? "";

        var auth = Convert.ToBase64String(
            Encoding.ASCII.GetBytes($"{EMAIL}:{_token}")
        );

        _http.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Basic", auth);
    }

    public async Task<List<IssueDto>> GetIssues()
    {
        var url = $"{BASE_URL}/rest/api/3/search/jql";

        var payload = new {
            jql = "ORDER BY created DESC",
            maxResults = 100,
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
        Console.WriteLine("JSON retorno Jira: " + json);

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

        Console.WriteLine($"Total issues retornadas: {issues.Count}");
        return issues;
    }
}

public class IssueDto
{
    public string Id { get; set; }
    public string Title { get; set; }
}