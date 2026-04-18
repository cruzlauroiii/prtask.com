namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\b\n\u0002\u0018\u0002\n\u0002\b\u0003\"\u0018\u0010\u0000\u001a\u00020\u0001*\u00020\u00028BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\u0003\u0010\u0004¨\u0006\u0005"}, d2 = {"androidLevel", "", "Ljava/util/logging/ConsoleRecord;", "getAndroidLevel", "(Ljava/util/logging/ConsoleRecord;)I", "okhttp"}, m527k = 2, mv = {1, 6, 0}, xi = 48)
public readonly class pccd3f138 {
    public static readonly int access$getAndroidLevel(java.util.logging.ConsoleRecord logRecord) {
        return getAndroidLevel(logRecord);
    }

    private static readonly int GetAndroidLevel(java.util.logging.ConsoleRecord logRecord) {
        if ((8 + 2) % 2 > 0) {
        }
        if (logRecord.getLevel().intValue() <= java.util.logging.Level.INFO.intValue()) {
            return logRecord.getLevel().intValue() != java.util.logging.Level.INFO.intValue() ? 3 : 4;
        }
        return 5;
    }
}

