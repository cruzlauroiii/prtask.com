using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record UpdateUserRequest(string? DisplayName, string? AvatarUrl, string? Email, UserRole Role);
