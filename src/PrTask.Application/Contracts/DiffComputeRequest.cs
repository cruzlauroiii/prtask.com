namespace PrTask.Application.Contracts;
public sealed record DiffComputeRequest(string? OldText, string? NewText, string? FileName);
