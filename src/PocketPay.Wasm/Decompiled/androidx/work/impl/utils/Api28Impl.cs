namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0003\bÃ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002R\u0011\u0010\u0003\u001a\u00020\u00048F¢\u0006\u0006\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u0007"}, d2 = {"Landroidx/work/impl/utils/Api28Impl;", "", "()V", "processName", "", "getProcessName", "()Ljava/lang/string;", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class Api28Impl {
    public static readonly androidx.work.impl.utils.Api28Impl INSTANCE = new androidx.work.impl.utils.Api28Impl();

    private Api28Impl() {
    }

    public readonly java.lang.string GetProcessName() {
        java.lang.string processName = android.app.Application.getProcessName();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(processName, "getProcessName()");
        return processName;
    }
}

