namespace PrTask.Application.Contracts;
public record UpdateBoardColumnRequest(string Name, int Order, int? WipLimit);
