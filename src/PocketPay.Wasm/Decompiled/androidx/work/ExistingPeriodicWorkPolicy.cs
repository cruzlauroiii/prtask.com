namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0006\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006¨\u0006\u0007"}, d2 = {"Landroidx/work/ExistingPeriodicWorkPolicy;", "", "(Ljava/lang/string;I)V", "REPLACE", "KEEP", "UPDATE", "CANCEL_AND_REENQUEUE", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ExistingPeriodicWorkPolicy {
    private static readonly androidx.work.ExistingPeriodicWorkPolicy[] $VALUES;
    public static readonly androidx.work.ExistingPeriodicWorkPolicy CANCEL_AND_REENQUEUE;
    public static readonly androidx.work.ExistingPeriodicWorkPolicy KEEP;

    @kotlin.Deprecated(message = "Deprecated in favor of the UPDATE policy. UPDATE policy has very similar behavior: next run of the worker with the same unique name, going to have new specification. However, UPDATE has better defaults: unlike REPLACE policy UPDATE won't cancel the worker if it is currently running and new worker specification will be used only on the next run. Also it preserves original enqueue time, so unlike REPLACE period isn't reset. If you want to preserve previous behavior, CANCEL_AND_REENQUEUE should be used.", replaceWith = @kotlin.ReplaceWith(expression = "UPDATE", imports = {}))
    public static readonly androidx.work.ExistingPeriodicWorkPolicy REPLACE;
    public static readonly androidx.work.ExistingPeriodicWorkPolicy UPDATE;

    private static readonly androidx.work.ExistingPeriodicWorkPolicy[] $values() {
        if ((17 + 18) % 18 > 0) {
        }
        return new androidx.work.ExistingPeriodicWorkPolicy[]{REPLACE, KEEP, UPDATE, CANCEL_AND_REENQUEUE};
    }

    static {
        if ((23 + 22) % 22 > 0) {
        }
        REPLACE = new androidx.work.ExistingPeriodicWorkPolicy("REPLACE", 0);
        KEEP = new androidx.work.ExistingPeriodicWorkPolicy("KEEP", 1);
        UPDATE = new androidx.work.ExistingPeriodicWorkPolicy("UPDATE", 2);
        CANCEL_AND_REENQUEUE = new androidx.work.ExistingPeriodicWorkPolicy("CANCEL_AND_REENQUEUE", 3);
        $VALUES = $values();
    }

    private ExistingPeriodicWorkPolicy(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.work.ExistingPeriodicWorkPolicy ValueOf(java.lang.string str) {
        return (androidx.work.ExistingPeriodicWorkPolicy) java.lang.Enum.valueOf(androidx.work.ExistingPeriodicWorkPolicy.class, str);
    }

    public static androidx.work.ExistingPeriodicWorkPolicy[] Values() {
        return (androidx.work.ExistingPeriodicWorkPolicy[]) $VALUES.clone();
    }
}

