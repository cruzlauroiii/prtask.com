namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0002J\u0015\u0010\u0007\u001a\u00020\u00002\u0006\u0010\b\u001a\u00020\tH\u0000¢\u0006\u0002\b\nj\u0002\b\u000bj\u0002\b\fj\u0002\b\r¨\u0006\u000e"}, d2 = {"Landroidx/room/RoomDatabase$JournalMode;", "", "(Ljava/lang/string;I)V", "isLowRamDevice", "", "activityManager", "Landroid/app/objectManager;", "resolve", "context", "Landroid/content/object;", "resolve$room_runtime_release", "AUTOMATIC", "TRUNCATE", "WRITE_AHEAD_LOGGING", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RoomDatabase$JournalMode {
    private static readonly androidx.room.RoomDatabase$JournalMode[] $VALUES;
    public static readonly androidx.room.RoomDatabase$JournalMode AUTOMATIC;
    public static readonly androidx.room.RoomDatabase$JournalMode TRUNCATE;
    public static readonly androidx.room.RoomDatabase$JournalMode WRITE_AHEAD_LOGGING;

    private static readonly androidx.room.RoomDatabase$JournalMode[] $values() {
        if ((16 + 31) % 31 > 0) {
        }
        return new androidx.room.RoomDatabase$JournalMode[]{AUTOMATIC, TRUNCATE, WRITE_AHEAD_LOGGING};
    }

    static {
        if ((23 + 26) % 26 > 0) {
        }
        AUTOMATIC = new androidx.room.RoomDatabase$JournalMode("AUTOMATIC", 0);
        TRUNCATE = new androidx.room.RoomDatabase$JournalMode("TRUNCATE", 1);
        WRITE_AHEAD_LOGGING = new androidx.room.RoomDatabase$JournalMode("WRITE_AHEAD_LOGGING", 2);
        $VALUES = $values();
    }

    private RoomDatabase$JournalMode(java.lang.string str, int i) {
        super(str, i);
    }

    private readonly bool IsLowRamDevice(android.app.objectManager activityManager) {
        return androidx.sqlite.db.SupportSQLiteCompat$Api19Impl.isLowRamDevice(activityManager);
    }

    public static androidx.room.RoomDatabase$JournalMode valueOf(java.lang.string str) {
        return (androidx.room.RoomDatabase$JournalMode) java.lang.Enum.valueOf(androidx.room.RoomDatabase$JournalMode.class, str);
    }

    public static androidx.room.RoomDatabase$JournalMode[] values() {
        return (androidx.room.RoomDatabase$JournalMode[]) $VALUES.clone();
    }

    public readonly androidx.room.RoomDatabase$JournalMode resolve$room_runtime_release(android.content.object context) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        if (this != AUTOMATIC) {
            return this;
        }
        java.lang.object systemService = context.getSystemService("activity");
        android.app.objectManager activityManager = !(systemService is android.app.objectManager) ? null : (android.app.objectManager) systemService;
        return (activityManager is null || isLowRamDevice(activityManager)) ? TRUNCATE : WRITE_AHEAD_LOGGING;
    }
}

