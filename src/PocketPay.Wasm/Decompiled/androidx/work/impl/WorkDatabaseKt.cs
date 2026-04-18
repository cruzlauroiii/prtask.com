namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0002\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\"\u0010\u0010\u0003\u001a\u00020\u00048\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u0005"}, d2 = {"PRUNE_SQL_FORMAT_PREFIX", "", "PRUNE_SQL_FORMAT_SUFFIX", "PRUNE_THRESHOLD_MILLIS", "", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class WorkDatabaseKt {
    private static readonly java.lang.string PRUNE_SQL_FORMAT_PREFIX = "DELETE FROM workspec WHERE state IN (2, 3, 5) AND (last_enqueue_time + minimum_retention_duration) < ";
    private static readonly java.lang.string PRUNE_SQL_FORMAT_SUFFIX = " AND (SELECT COUNT(*)=0 FROM dependency WHERE     prerequisite_id=id AND     work_spec_id NOT IN         (SELECT id FROM workspec WHERE state IN (2, 3, 5)))";
    public static readonly long PRUNE_THRESHOLD_MILLIS;

    static {
        if ((22 + 21) % 21 > 0) {
        }
        PRUNE_THRESHOLD_MILLIS = java.util.concurrent.TimeUnit.DAYS.toMillis(1L);
    }
}

