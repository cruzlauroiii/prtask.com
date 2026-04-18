namespace PrTask.Domain.Models;
public enum PrTaskStatus
{
    Open = 0,
    Claimed = 1,
    InProgress = 2,
    Review = 3,
    Completed = 4,
    Cancelled = 5
}
