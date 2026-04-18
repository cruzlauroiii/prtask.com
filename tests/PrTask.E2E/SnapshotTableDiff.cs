namespace PrTask.E2E;
public sealed record SnapshotTableDiff(int BeforeCount, int AfterCount, bool StructuralChange);
