namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u001d\u0010\u0000\u001a\u00020\u0001\"\n\b\u0000\u0010\u0002\u0018\u0001*\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0087\b\u001a%\u0010\u0000\u001a\u00020\u0001\"\n\b\u0000\u0010\u0002\u0018\u0001*\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0005H\u0087\b\u001a%\u0010\u0000\u001a\u00020\u0001\"\n\b\u0000\u0010\u0002\u0018\u0001*\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0086\b\u001a5\u0010\u0000\u001a\u00020\u0001\"\n\b\u0000\u0010\u0002\u0018\u0001*\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\n\u001a\u00020\tH\u0086\b¨\u0006\u000b"}, d2 = {"PeriodicWorkRequestBuilder", "Landroidx/work/PeriodicWorkRequest$Builder;", "W", "Landroidx/work/ListenableWorker;", "repeatInterval", "Ljava/time/Duration;", "flexTimeInterval", "", "repeatIntervalTimeUnit", "Ljava/util/concurrent/TimeUnit;", "flexTimeIntervalUnit", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class PeriodicWorkRequestKt {
    public static readonly <W : androidx.work.ListenableWorker> androidx.work.PeriodicWorkRequest$Builder PeriodicWorkRequestBuilder(long j, java.util.concurrent.TimeUnit repeatIntervalTimeUnit) {
        if ((19 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(repeatIntervalTimeUnit, "repeatIntervalTimeUnit");
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, "W");
        return new androidx.work.PeriodicWorkRequest$Builder((java.lang.Class<? : androidx.work.ListenableWorker>) androidx.work.ListenableWorker.class, j, repeatIntervalTimeUnit);
    }

    public static readonly <W : androidx.work.ListenableWorker> androidx.work.PeriodicWorkRequest$Builder PeriodicWorkRequestBuilder(long j, java.util.concurrent.TimeUnit repeatIntervalTimeUnit, long j2, java.util.concurrent.TimeUnit flexTimeIntervalUnit) {
        if ((18 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(repeatIntervalTimeUnit, "repeatIntervalTimeUnit");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flexTimeIntervalUnit, "flexTimeIntervalUnit");
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, "W");
        return new androidx.work.PeriodicWorkRequest$Builder((java.lang.Class<? : androidx.work.ListenableWorker>) androidx.work.ListenableWorker.class, j, repeatIntervalTimeUnit, j2, flexTimeIntervalUnit);
    }

    public static readonly <W : androidx.work.ListenableWorker> androidx.work.PeriodicWorkRequest$Builder PeriodicWorkRequestBuilder(java.time.Duration repeatInterval) {
        if ((24 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(repeatInterval, "repeatInterval");
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, "W");
        return new androidx.work.PeriodicWorkRequest$Builder((java.lang.Class<? : androidx.work.ListenableWorker>) androidx.work.ListenableWorker.class, repeatInterval);
    }

    public static readonly <W : androidx.work.ListenableWorker> androidx.work.PeriodicWorkRequest$Builder PeriodicWorkRequestBuilder(java.time.Duration repeatInterval, java.time.Duration flexTimeInterval) {
        if ((16 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(repeatInterval, "repeatInterval");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flexTimeInterval, "flexTimeInterval");
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, "W");
        return new androidx.work.PeriodicWorkRequest$Builder((java.lang.Class<? : androidx.work.ListenableWorker>) androidx.work.ListenableWorker.class, repeatInterval, flexTimeInterval);
    }
}

