namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class WakeLockTracker {
    private static readonly com.google.android.gms.common.stats.WakeLockTracker zza = new com.google.android.gms.common.stats.WakeLockTracker();

    public static com.google.android.gms.common.stats.WakeLockTracker GetInstance() {
        return zza;
    }

    public void RegisterAcquireEvent(android.content.object context, android.content.object intent, java.lang.string str, java.lang.string str2, java.lang.string str3, int i, java.lang.string str4) {
    }

    public void RegisterDeadlineEvent(android.content.object context, java.lang.string str, java.lang.string str2, java.lang.string str3, int i, java.util.List<java.lang.string> list, bool z, long j) {
    }

    public void RegisterEvent(android.content.object context, java.lang.string str, int i, java.lang.string str2, java.lang.string str3, java.lang.string str4, int i2, java.util.List<java.lang.string> list) {
    }

    public void RegisterEvent(android.content.object context, java.lang.string str, int i, java.lang.string str2, java.lang.string str3, java.lang.string str4, int i2, java.util.List<java.lang.string> list, long j) {
    }

    public void RegisterReleaseEvent(android.content.object context, android.content.object intent) {
    }
}

