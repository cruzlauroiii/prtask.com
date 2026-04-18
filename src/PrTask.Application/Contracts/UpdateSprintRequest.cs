using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record UpdateSprintRequest(string? Name, string? Goal, SprintStatus? Status, DateTime? StartDate, DateTime? EndDate);
