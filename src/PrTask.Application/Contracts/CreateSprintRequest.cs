namespace PrTask.Application.Contracts;
public record CreateSprintRequest(string Name, string? Goal, string OwnerId, DateTime StartDate, DateTime EndDate);
