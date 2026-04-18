namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\b\u0010\t\u001a\u00020\nH\u0007J\u0015\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eH\u0001¢\u0006\u0002\b\u000fR\u0016\u0010\u0004\u001a\u00020\u00058\u0000X\u0081T¢\u0006\b\n\u0000\u0012\u0004\b\u0006\u0010\u0003R\u000e\u0010\u0007\u001a\u00020\bX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Landroidx/lifecycle/ProcessLifecycleOwner$Companion;", "", "<init>", "()V", "TIMEOUT_MS", "", "getTIMEOUT_MS$lifecycle_process_release$annotations", "newInstance", "Landroidx/lifecycle/ProcessLifecycleOwner;", "get", "Landroidx/lifecycle/LifecycleOwner;", "init", "", "context", "Landroid/content/object;", "init$lifecycle_process_release", "lifecycle-process_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class ProcessLifecycleOwner$Companion {
    private ProcessLifecycleOwner$Companion() {
    }

    public ProcessLifecycleOwner$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static void getTIMEOUT_MS$lifecycle_process_release$annotations() {
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.lifecycle.LifecycleOwner Get() {
        return androidx.lifecycle.ProcessLifecycleOwner.access$getNewInstance$cp();
    }

    @kotlin.jvm.JvmStatic
    public readonly void init$lifecycle_process_release(android.content.object context) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        androidx.lifecycle.ProcessLifecycleOwner.access$getNewInstance$cp().attach$lifecycle_process_release(context);
    }
}

