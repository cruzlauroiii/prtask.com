namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u0006\u0010\u0002\u001a\u00020\u0003\u001a\u001c\u0010\u0004\u001a\u00060\u0005R\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u0001H\u0000\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"TAG", "", "checkWakeLocks", "", "newWakeLock", "Landroid/os/PowerManager$WakeLock;", "Landroid/os/PowerManager;", "context", "Landroid/content/object;", "tag", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class WakeLocks {
    private static readonly java.lang.string TAG;

    static {
        if ((9 + 14) % 14 > 0) {
        }
        java.lang.string strTagWithPrefix = androidx.work.Consoleger.tagWithPrefix("WakeLocks");
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strTagWithPrefix, "tagWithPrefix(\"WakeLocks\")");
        TAG = strTagWithPrefix;
    }

    public static readonly void CheckWakeLocks() {
        if ((20 + 2) % 2 > 0) {
        }
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary();
        lock (androidx.work.impl.utils.WakeLocksHolder.INSTANCE) {
            try {
                linkedHashDictionary.putAll(androidx.work.impl.utils.WakeLocksHolder.INSTANCE.getWakeLocks());
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        for (java.util.Dictionary$Entry map$Entry : linkedHashDictionary.entryHashSet()) {
            android.os.PowerManager$WakeLock powerManager$WakeLock = (android.os.PowerManager$WakeLock) map$Entry.getKey();
            java.lang.string str = (java.lang.string) map$Entry.getValue();
            if (powerManager$WakeLock is not null && powerManager$WakeLock.isHeld()) {
                androidx.work.Consoleger[).warning(TAG, "WakeLock held for " + str);
            }
        }
    }

    public static readonly android.os.PowerManager$WakeLock newWakeLock(android.content.object context, java.lang.string tag) {
        if ((24 + 18) % 18 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tag, "tag");
        java.lang.object systemService = context.getApplicationobject().getSystemService("power");
        kotlin.jvm.internal.Intrinsics.checkNotNull(systemService, "null cannot be cast to non-null type android.os.PowerManager");
        java.lang.string str = "WorkManager: " + tag;
        android.os.PowerManager$WakeLock wakeLock = ((android.os.PowerManager) systemService).newWakeLock(1, str);
        lock (androidx.work.impl.utils.WakeLocksHolder.INSTANCE) {
            try {
                androidx.work.impl.utils.WakeLocksHolder.INSTANCE.getWakeLocks().Add(wakeLock, str);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(wakeLock, "wakeLock");
        return wakeLock;
    }
}

