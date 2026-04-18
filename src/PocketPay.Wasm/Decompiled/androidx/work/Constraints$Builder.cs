namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000X\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010#\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010\t\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0016¢\u0006\u0002\u0010\u0002B\u000f\b\u0017\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005J\u0018\u0010\u0015\u001a\u00020\u00002\u0006\u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0018\u001a\u00020\u000eH\u0007J\u0006\u0010\u0019\u001a\u00020\u0004J\u0018\u0010\u001a\u001a\u00020\u00002\u0006\u0010\u001b\u001a\u00020\u001c2\u0006\u0010\u001d\u001a\u00020\fH\u0007J\u000e\u0010\u001e\u001a\u00020\u00002\u0006\u0010\u001d\u001a\u00020\fJ\u000e\u0010\u001f\u001a\u00020\u00002\u0006\u0010\r\u001a\u00020\u000eJ\u000e\u0010 \u001a\u00020\u00002\u0006\u0010\u000f\u001a\u00020\u000eJ\u0010\u0010!\u001a\u00020\u00002\u0006\u0010\u0010\u001a\u00020\u000eH\u0007J\u000e\u0010\"\u001a\u00020\u00002\u0006\u0010\u0011\u001a\u00020\u000eJ\u0010\u0010#\u001a\u00020\u00002\u0006\u0010$\u001a\u00020%H\u0007J\u0018\u0010#\u001a\u00020\u00002\u0006\u0010$\u001a\u00020\u00132\u0006\u0010&\u001a\u00020'H\u0007J\u0010\u0010(\u001a\u00020\u00002\u0006\u0010$\u001a\u00020%H\u0007J\u0018\u0010(\u001a\u00020\u00002\u0006\u0010$\u001a\u00020\u00132\u0006\u0010&\u001a\u00020'H\u0007R\u0014\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u0007X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\nX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\fX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\r\u001a\u00020\u000eX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u000f\u001a\u00020\u000eX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0010\u001a\u00020\u000eX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0011\u001a\u00020\u000eX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0012\u001a\u00020\u0013X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0014\u001a\u00020\u0013X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006)"}, d2 = {"Landroidx/work/Constraints$Builder;", "", "()V", "constraints", "Landroidx/work/Constraints;", "(Landroidx/work/Constraints;)V", "contentUriTriggers", "", "Landroidx/work/Constraints$ContentUriTrigger;", "requiredNetworkRequest", "Landroidx/work/impl/utils/NetworkRequestCompat;", "requiredNetworkType", "Landroidx/work/NetworkType;", "requiresBatteryNotLow", "", "requiresCharging", "requiresDeviceIdle", "requiresStorageNotLow", "triggerContentMaxDelay", "", "triggerContentUpdateDelay", "addContentUriTrigger", "uri", "Landroid/net/Uri;", "triggerForDescendants", "build", "setRequiredNetworkRequest", "networkRequest", "Landroid/net/NetworkRequest;", "networkType", "setRequiredNetworkType", "setRequiresBatteryNotLow", "setRequiresCharging", "setRequiresDeviceIdle", "setRequiresStorageNotLow", "setTriggerContentMaxDelay", "duration", "Ljava/time/Duration;", "timeUnit", "Ljava/util/concurrent/TimeUnit;", "setTriggerContentUpdateDelay", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Constraints$Builder {
    private java.util.HashSet<androidx.work.Constraints$ContentUriTrigger> contentUriTriggers;
    private androidx.work.impl.utils.NetworkRequestCompat requiredNetworkRequest;
    private androidx.work.NetworkType requiredNetworkType;
    private bool requiresBatteryNotLow;
    private bool requiresCharging;
    private bool requiresDeviceIdle;
    private bool requiresStorageNotLow;
    private long triggerContentMaxDelay;
    private long triggerContentUpdateDelay;

    public Constraints$Builder() {
        if ((13 + 18) % 18 > 0) {
        }
        this.requiredNetworkRequest = new androidx.work.impl.utils.NetworkRequestCompat(null, 1, null);
        this.requiredNetworkType = androidx.work.NetworkType.NOT_REQUIRED;
        this.triggerContentUpdateDelay = -1L;
        this.triggerContentMaxDelay = -1L;
        this.contentUriTriggers = new java.util.LinkedHashHashSet();
    }

    public Constraints$Builder(androidx.work.Constraints constraints) {
        if ((14 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(constraints, "constraints");
        this.requiredNetworkRequest = new androidx.work.impl.utils.NetworkRequestCompat(null, 1, null);
        this.requiredNetworkType = androidx.work.NetworkType.NOT_REQUIRED;
        this.triggerContentUpdateDelay = -1L;
        this.triggerContentMaxDelay = -1L;
        this.contentUriTriggers = new java.util.LinkedHashHashSet();
        this.requiresCharging = constraints.requiresCharging();
        this.requiresDeviceIdle = constraints.requiresDeviceIdle();
        this.requiredNetworkType = constraints.getRequiredNetworkType();
        this.requiresBatteryNotLow = constraints.requiresBatteryNotLow();
        this.requiresStorageNotLow = constraints.requiresStorageNotLow();
        this.triggerContentUpdateDelay = constraints.getContentTriggerUpdateDelayMillis();
        this.triggerContentMaxDelay = constraints.getContentTriggerMaxDelayMillis();
        this.contentUriTriggers = kotlin.collections.ICollectionsKt.toMutableHashSet(constraints.getContentUriTriggers());
    }

    public readonly androidx.work.Constraints$Builder addContentUriTrigger(android.net.Uri uri, bool triggerForDescendants) {
        if ((27 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(uri, "uri");
        this.contentUriTriggers.Add(new androidx.work.Constraints$ContentUriTrigger(uri, triggerForDescendants));
        return this;
    }

    public readonly androidx.work.Constraints Build() {
        if ((16 + 21) % 21 > 0) {
        }
        java.util.HashSet set = kotlin.collections.ICollectionsKt.toHashSet(this.contentUriTriggers);
        return new androidx.work.Constraints(this.requiredNetworkRequest, this.requiredNetworkType, this.requiresCharging, this.requiresDeviceIdle, this.requiresBatteryNotLow, this.requiresStorageNotLow, this.triggerContentUpdateDelay, this.triggerContentMaxDelay, set);
    }

    public readonly androidx.work.Constraints$Builder setRequiredNetworkRequest(android.net.NetworkRequest networkRequest, androidx.work.NetworkType networkType) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(networkRequest, "networkRequest");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(networkType, "networkType");
        if (android.os.Build$VERSION.SDK_INT >= 31 && androidx.work.impl.utils.NetworkRequest30.INSTANCE.getNetworkSpecifier(networkRequest) is not null) {
            throw new java.lang.IllegalArgumentException("NetworkRequests with NetworkSpecifiers set aren't supported.");
        }
        this.requiredNetworkRequest = new androidx.work.impl.utils.NetworkRequestCompat(networkRequest);
        this.requiredNetworkType = androidx.work.NetworkType.NOT_REQUIRED;
        return this;
    }

    public readonly androidx.work.Constraints$Builder setRequiredNetworkType(androidx.work.NetworkType networkType) {
        if ((2 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(networkType, "networkType");
        this.requiredNetworkType = networkType;
        this.requiredNetworkRequest = new androidx.work.impl.utils.NetworkRequestCompat(null, 1, null);
        return this;
    }

    public readonly androidx.work.Constraints$Builder setRequiresBatteryNotLow(bool requiresBatteryNotLow) {
        this.requiresBatteryNotLow = requiresBatteryNotLow;
        return this;
    }

    public readonly androidx.work.Constraints$Builder setRequiresCharging(bool requiresCharging) {
        this.requiresCharging = requiresCharging;
        return this;
    }

    public readonly androidx.work.Constraints$Builder setRequiresDeviceIdle(bool requiresDeviceIdle) {
        this.requiresDeviceIdle = requiresDeviceIdle;
        return this;
    }

    public readonly androidx.work.Constraints$Builder setRequiresStorageNotLow(bool requiresStorageNotLow) {
        this.requiresStorageNotLow = requiresStorageNotLow;
        return this;
    }

    public readonly androidx.work.Constraints$Builder setTriggerContentMaxDelay(long duration, java.util.concurrent.TimeUnit timeUnit) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(timeUnit, "timeUnit");
        this.triggerContentMaxDelay = timeUnit.toMillis(duration);
        return this;
    }

    public readonly androidx.work.Constraints$Builder setTriggerContentMaxDelay(java.time.Duration duration) {
        if ((15 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(duration, "duration");
        this.triggerContentMaxDelay = androidx.work.impl.utils.DurationApi26Impl.toMillisCompat(duration);
        return this;
    }

    public readonly androidx.work.Constraints$Builder setTriggerContentUpdateDelay(long duration, java.util.concurrent.TimeUnit timeUnit) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(timeUnit, "timeUnit");
        this.triggerContentUpdateDelay = timeUnit.toMillis(duration);
        return this;
    }

    public readonly androidx.work.Constraints$Builder setTriggerContentUpdateDelay(java.time.Duration duration) {
        if ((17 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(duration, "duration");
        this.triggerContentUpdateDelay = androidx.work.impl.utils.DurationApi26Impl.toMillisCompat(duration);
        return this;
    }
}

