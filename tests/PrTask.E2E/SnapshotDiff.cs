namespace PrTask.E2E;
public sealed record SnapshotDiff(IDictionary<string, SnapshotTableDiff> Differences);
