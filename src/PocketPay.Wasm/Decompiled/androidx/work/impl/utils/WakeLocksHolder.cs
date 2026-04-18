namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\b\u0003\bÂ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002R!\u0010\u0003\u001a\u0012\u0012\b\u0012\u00060\u0005R\u00020\u0006\u0012\u0004\u0012\u00020\u00070\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\t¨\u0006\n"}, d2 = {"Landroidx/work/impl/utils/WakeLocksHolder;", "", "()V", "wakeLocks", "Ljava/util/WeakHashDictionary;", "Landroid/os/PowerManager$WakeLock;", "Landroid/os/PowerManager;", "", "getWakeLocks", "()Ljava/util/WeakHashDictionary;", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class WakeLocksHolder {
    public static readonly androidx.work.impl.utils.WakeLocksHolder INSTANCE = new androidx.work.impl.utils.WakeLocksHolder();
    private static readonly java.util.WeakHashDictionary<android.os.PowerManager$WakeLock, java.lang.string> wakeLocks = new java.util.WeakHashDictionary<>();

    private WakeLocksHolder() {
    }

    public readonly java.util.WeakHashDictionary<android.os.PowerManager$WakeLock, java.lang.string> getWakeLocks() {
        return wakeLocks;
    }
}

