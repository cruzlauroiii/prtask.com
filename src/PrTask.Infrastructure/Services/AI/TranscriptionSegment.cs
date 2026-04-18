namespace PrTask.Infrastructure.Services.AI;
public sealed record TranscriptionSegment(TimeSpan Start, TimeSpan End, string Text);
