using System.Text.Json;
namespace PrTask.Domain.Models;
public class DataSnapshot
{
    public JsonElement[] Users { get; set; } = [];
    public JsonElement[] Tasks { get; set; } = [];
    public JsonElement[] PullRequests { get; set; } = [];
    public JsonElement[] Payments { get; set; } = [];
    public JsonElement[] Achievements { get; set; } = [];
    public JsonElement[] Leaderboard { get; set; } = [];
    public JsonElement[] AuditLog { get; set; } = [];
    public string GeneratedAt { get; set; } = string.Empty;
}
