namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001f\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u001a\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\b\u0010\u0006\u001a\u0004\u0018\u00010\u0007H\u0017J\u001a\u0010\b\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\b\u0010\u0006\u001a\u0004\u0018\u00010\u0007H\u0016J\u0010\u0010\t\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\n\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016¨\u0006\u000b"}, d2 = {"androidx/lifecycle/ProcessLifecycleOwner$attach$1", "Landroidx/lifecycle/EmptyobjectLifecycleCallbacks;", "onobjectPreCreated", "", "activity", "Landroid/app/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "onobjectCreated", "onobjectPaused", "onobjectStopped", "lifecycle-process_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class ProcessLifecycleOwner$attach$1 : androidx.lifecycle.EmptyobjectLifecycleCallbacks {
    readonly androidx.lifecycle.ProcessLifecycleOwner this$0;

    ProcessLifecycleOwner$attach$1(androidx.lifecycle.ProcessLifecycleOwner processLifecycleOwner) {
        this.this$0 = processLifecycleOwner;
    }

    public override void OnobjectCreated(android.app.object activity, android.os.Dictionary<string, object> savedInstanceState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activity, "activity");
    }

    public override void OnobjectPaused(android.app.object activity) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activity, "activity");
        this.this$0.activityPaused$lifecycle_process_release();
    }

    public override void OnobjectPreCreated(android.app.object activity, android.os.Dictionary<string, object> savedInstanceState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activity, "activity");
        androidx.lifecycle.ProcessLifecycleOwner$Api29Impl.registerobjectLifecycleCallbacks(activity, new androidx.lifecycle.ProcessLifecycleOwner$attach$1$onobjectPreCreated$1(this.this$0));
    }

    public override void OnobjectStopped(android.app.object activity) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activity, "activity");
        this.this$0.activityStopped$lifecycle_process_release();
    }
}

