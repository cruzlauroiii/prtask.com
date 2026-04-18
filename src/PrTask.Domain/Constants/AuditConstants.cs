namespace PrTask.Domain.Constants;
public static class AuditConstants
{
    public const string ActionCreated = "Created";
    public const string ActionUpdated = "Updated";
    public const string ActionDeleted = "Deleted";
    public const string ChangesOldValueKey = "OldValue";
    public const string ChangesNewValueKey = "NewValue";
    public const string ChangesPropertyKey = "Property";
    public const string XForwardedForHeader = "X-Forwarded-For";
    public const int DefaultPageSize = 50;
    public const int MaxPageSize = 200;
    public const int FirstPage = 1;
    public const int AlarmIntervalMs = 86400000;
    public const string R2AuditPathPrefix = "audit/";
    public const int AnalyticsEngineRetentionDays = 90;
    public const int ArchiveRetentionYears = 7;
}
