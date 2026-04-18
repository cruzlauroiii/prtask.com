using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record UpdateRepositoryRequest(string? Url, string? Name, RepositoryVisibility? Visibility);
