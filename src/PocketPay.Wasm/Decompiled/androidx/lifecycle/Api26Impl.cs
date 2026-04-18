namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0000\bÁ\u0002\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u000e\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007¨\u0006\b"}, d2 = {"Landroidx/lifecycle/Api26Impl;", "", "<init>", "()V", "toMillis", "", "timeout", "Ljava/time/Duration;", "lifecycle-livedata_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class Api26Impl {
    public static readonly androidx.lifecycle.Api26Impl INSTANCE = new androidx.lifecycle.Api26Impl();

    private Api26Impl() {
    }

    public readonly long ToMillis(java.time.Duration timeout) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(timeout, "timeout");
        return timeout.toMillis();
    }
}

